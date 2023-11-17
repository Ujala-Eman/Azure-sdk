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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsIncidentEntitiesMetadata : IUtf8JsonSerializable, IJsonModel<SecurityInsightsIncidentEntitiesMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsIncidentEntitiesMetadata>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsIncidentEntitiesMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityInsightsIncidentEntitiesMetadata>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityInsightsIncidentEntitiesMetadata>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("count"u8);
            writer.WriteNumberValue(Count);
            writer.WritePropertyName("entityKind"u8);
            writer.WriteStringValue(EntityKind.ToString());
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

        SecurityInsightsIncidentEntitiesMetadata IJsonModel<SecurityInsightsIncidentEntitiesMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsIncidentEntitiesMetadata(document.RootElement, options);
        }

        internal static SecurityInsightsIncidentEntitiesMetadata DeserializeSecurityInsightsIncidentEntitiesMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int count = default;
            SecurityInsightsEntityKind entityKind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    count = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("entityKind"u8))
                {
                    entityKind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsIncidentEntitiesMetadata(count, entityKind, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityInsightsIncidentEntitiesMetadata>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesMetadata)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsIncidentEntitiesMetadata IPersistableModel<SecurityInsightsIncidentEntitiesMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsIncidentEntitiesMetadata)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsIncidentEntitiesMetadata(document.RootElement, options);
        }

        string IPersistableModel<SecurityInsightsIncidentEntitiesMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
