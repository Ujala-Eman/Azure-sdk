// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    public partial class ClientAuthenticationSettings : IUtf8JsonSerializable, IJsonModel<ClientAuthenticationSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClientAuthenticationSettings>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClientAuthenticationSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(AlternativeAuthenticationNameSources))
            {
                writer.WritePropertyName("alternativeAuthenticationNameSources"u8);
                writer.WriteStartArray();
                foreach (var item in AlternativeAuthenticationNameSources)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CustomJwtAuthentication))
            {
                writer.WritePropertyName("customJwtAuthentication"u8);
                writer.WriteObjectValue(CustomJwtAuthentication, options);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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
        }

        ClientAuthenticationSettings IJsonModel<ClientAuthenticationSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClientAuthenticationSettings(document.RootElement, options);
        }

        internal static ClientAuthenticationSettings DeserializeClientAuthenticationSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<AlternativeAuthenticationNameSource> alternativeAuthenticationNameSources = default;
            CustomJwtAuthenticationSettings customJwtAuthentication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("alternativeAuthenticationNameSources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AlternativeAuthenticationNameSource> array = new List<AlternativeAuthenticationNameSource>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AlternativeAuthenticationNameSource(item.GetString()));
                    }
                    alternativeAuthenticationNameSources = array;
                    continue;
                }
                if (property.NameEquals("customJwtAuthentication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    customJwtAuthentication = CustomJwtAuthenticationSettings.DeserializeCustomJwtAuthenticationSettings(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ClientAuthenticationSettings(alternativeAuthenticationNameSources ?? new ChangeTrackingList<AlternativeAuthenticationNameSource>(), customJwtAuthentication, serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AlternativeAuthenticationNameSources), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  alternativeAuthenticationNameSources: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(AlternativeAuthenticationNameSources))
                {
                    if (AlternativeAuthenticationNameSources.Any())
                    {
                        builder.Append("  alternativeAuthenticationNameSources: ");
                        builder.AppendLine("[");
                        foreach (var item in AlternativeAuthenticationNameSources)
                        {
                            builder.AppendLine($"    '{item.ToString()}'");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CustomJwtAuthentication), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  customJwtAuthentication: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CustomJwtAuthentication))
                {
                    builder.Append("  customJwtAuthentication: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CustomJwtAuthentication, options, 2, false, "  customJwtAuthentication: ");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ClientAuthenticationSettings>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support writing '{options.Format}' format.");
            }
        }

        ClientAuthenticationSettings IPersistableModel<ClientAuthenticationSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClientAuthenticationSettings>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClientAuthenticationSettings(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClientAuthenticationSettings)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClientAuthenticationSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
