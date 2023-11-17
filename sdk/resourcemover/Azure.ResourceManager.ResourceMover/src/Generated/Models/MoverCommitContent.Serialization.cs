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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverCommitContent : IUtf8JsonSerializable, IJsonModel<MoverCommitContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverCommitContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverCommitContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MoverCommitContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MoverCommitContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ValidateOnly))
            {
                writer.WritePropertyName("validateOnly"u8);
                writer.WriteBooleanValue(ValidateOnly.Value);
            }
            writer.WritePropertyName("moveResources"u8);
            writer.WriteStartArray();
            foreach (var item in MoverResources)
            {
                if (item == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(MoverResourceInputType))
            {
                writer.WritePropertyName("moveResourceInputType"u8);
                writer.WriteStringValue(MoverResourceInputType.Value.ToString());
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

        MoverCommitContent IJsonModel<MoverCommitContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverCommitContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverCommitContent(document.RootElement, options);
        }

        internal static MoverCommitContent DeserializeMoverCommitContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> validateOnly = default;
            IList<ResourceIdentifier> moveResources = default;
            Optional<MoverResourceInputType> moveResourceInputType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("validateOnly"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateOnly = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("moveResources"u8))
                {
                    List<ResourceIdentifier> array = new List<ResourceIdentifier>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(new ResourceIdentifier(item.GetString()));
                        }
                    }
                    moveResources = array;
                    continue;
                }
                if (property.NameEquals("moveResourceInputType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveResourceInputType = new MoverResourceInputType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverCommitContent(Optional.ToNullable(validateOnly), moveResources, Optional.ToNullable(moveResourceInputType), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverCommitContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverCommitContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MoverCommitContent IPersistableModel<MoverCommitContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverCommitContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMoverCommitContent(document.RootElement, options);
        }

        string IPersistableModel<MoverCommitContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
