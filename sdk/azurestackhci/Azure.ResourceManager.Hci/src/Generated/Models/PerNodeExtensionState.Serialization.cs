// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Hci.Models
{
    public partial class PerNodeExtensionState : IUtf8JsonSerializable, IJsonModel<PerNodeExtensionState>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PerNodeExtensionState>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PerNodeExtensionState>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PerNodeExtensionState>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PerNodeExtensionState>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Extension))
                {
                    writer.WritePropertyName("extension"u8);
                    writer.WriteStringValue(Extension);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TypeHandlerVersion))
                {
                    writer.WritePropertyName("typeHandlerVersion"u8);
                    writer.WriteStringValue(TypeHandlerVersion);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(State))
                {
                    writer.WritePropertyName("state"u8);
                    writer.WriteStringValue(State.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(InstanceView))
                {
                    writer.WritePropertyName("instanceView"u8);
                    writer.WriteObjectValue(InstanceView);
                }
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PerNodeExtensionState IJsonModel<PerNodeExtensionState>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PerNodeExtensionState)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePerNodeExtensionState(document.RootElement, options);
        }

        internal static PerNodeExtensionState DeserializePerNodeExtensionState(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<string> extension = default;
            Optional<string> typeHandlerVersion = default;
            Optional<NodeExtensionState> state = default;
            Optional<HciExtensionInstanceView> instanceView = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    extension = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("typeHandlerVersion"u8))
                {
                    typeHandlerVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new NodeExtensionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("instanceView"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instanceView = HciExtensionInstanceView.DeserializeHciExtensionInstanceView(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PerNodeExtensionState(name.Value, extension.Value, typeHandlerVersion.Value, Optional.ToNullable(state), instanceView.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PerNodeExtensionState>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PerNodeExtensionState)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PerNodeExtensionState IPersistableModel<PerNodeExtensionState>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PerNodeExtensionState)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePerNodeExtensionState(document.RootElement, options);
        }

        string IPersistableModel<PerNodeExtensionState>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
