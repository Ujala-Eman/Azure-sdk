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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class OpenAuthenticationAccessPolicy : IUtf8JsonSerializable, IJsonModel<OpenAuthenticationAccessPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OpenAuthenticationAccessPolicy>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<OpenAuthenticationAccessPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ProviderType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProviderType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Claims))
            {
                writer.WritePropertyName("claims"u8);
                writer.WriteStartArray();
                foreach (var item in Claims)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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

        OpenAuthenticationAccessPolicy IJsonModel<OpenAuthenticationAccessPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOpenAuthenticationAccessPolicy(document.RootElement, options);
        }

        internal static OpenAuthenticationAccessPolicy DeserializeOpenAuthenticationAccessPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OpenAuthenticationProviderType? type = default;
            IList<OpenAuthenticationPolicyClaim> claims = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new OpenAuthenticationProviderType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("claims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<OpenAuthenticationPolicyClaim> array = new List<OpenAuthenticationPolicyClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OpenAuthenticationPolicyClaim.DeserializeOpenAuthenticationPolicyClaim(item, options));
                    }
                    claims = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new OpenAuthenticationAccessPolicy(type, claims ?? new ChangeTrackingList<OpenAuthenticationPolicyClaim>(), serializedAdditionalRawData);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProviderType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  type: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProviderType))
                {
                    builder.Append("  type: ");
                    builder.AppendLine($"'{ProviderType.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Claims), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  claims: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Claims))
                {
                    if (Claims.Any())
                    {
                        builder.Append("  claims: ");
                        builder.AppendLine("[");
                        foreach (var item in Claims)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  claims: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<OpenAuthenticationAccessPolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support writing '{options.Format}' format.");
            }
        }

        OpenAuthenticationAccessPolicy IPersistableModel<OpenAuthenticationAccessPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OpenAuthenticationAccessPolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOpenAuthenticationAccessPolicy(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OpenAuthenticationAccessPolicy)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<OpenAuthenticationAccessPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
