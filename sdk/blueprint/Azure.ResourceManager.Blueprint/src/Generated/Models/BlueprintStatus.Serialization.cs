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

namespace Azure.ResourceManager.Blueprint.Models
{
    public partial class BlueprintStatus : IUtf8JsonSerializable, IJsonModel<BlueprintStatus>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BlueprintStatus>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BlueprintStatus>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BlueprintStatus>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BlueprintStatus>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TimeCreated))
                {
                    writer.WritePropertyName("timeCreated"u8);
                    writer.WriteStringValue(TimeCreated.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastModified))
                {
                    writer.WritePropertyName("lastModified"u8);
                    writer.WriteStringValue(LastModified.Value, "O");
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

        BlueprintStatus IJsonModel<BlueprintStatus>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlueprintStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBlueprintStatus(document.RootElement, options);
        }

        internal static BlueprintStatus DeserializeBlueprintStatus(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> timeCreated = default;
            Optional<DateTimeOffset> lastModified = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timeCreated"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeCreated = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModified"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModified = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BlueprintStatus(Optional.ToNullable(timeCreated), Optional.ToNullable(lastModified), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BlueprintStatus>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlueprintStatus)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BlueprintStatus IPersistableModel<BlueprintStatus>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BlueprintStatus)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBlueprintStatus(document.RootElement, options);
        }

        string IPersistableModel<BlueprintStatus>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
