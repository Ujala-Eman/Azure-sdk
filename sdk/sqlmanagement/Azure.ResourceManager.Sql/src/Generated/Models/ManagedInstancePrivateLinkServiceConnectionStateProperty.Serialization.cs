// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstancePrivateLinkServiceConnectionStateProperty : IUtf8JsonSerializable, IJsonModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("description"u8);
            writer.WriteStringValue(Description);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ActionsRequired))
                {
                    writer.WritePropertyName("actionsRequired"u8);
                    writer.WriteStringValue(ActionsRequired);
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

        ManagedInstancePrivateLinkServiceConnectionStateProperty IJsonModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstancePrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstancePrivateLinkServiceConnectionStateProperty(document.RootElement, options);
        }

        internal static ManagedInstancePrivateLinkServiceConnectionStateProperty DeserializeManagedInstancePrivateLinkServiceConnectionStateProperty(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            string description = default;
            Optional<string> actionsRequired = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionsRequired"u8))
                {
                    actionsRequired = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedInstancePrivateLinkServiceConnectionStateProperty(status, description, actionsRequired.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstancePrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedInstancePrivateLinkServiceConnectionStateProperty IPersistableModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedInstancePrivateLinkServiceConnectionStateProperty)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedInstancePrivateLinkServiceConnectionStateProperty(document.RootElement, options);
        }

        string IPersistableModel<ManagedInstancePrivateLinkServiceConnectionStateProperty>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
