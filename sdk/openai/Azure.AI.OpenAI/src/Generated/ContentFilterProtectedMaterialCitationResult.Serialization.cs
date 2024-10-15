// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;

namespace Azure.AI.OpenAI
{
    public partial class ContentFilterProtectedMaterialCitationResult : IJsonModel<ContentFilterProtectedMaterialCitationResult>
    {
        void IJsonModel<ContentFilterProtectedMaterialCitationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialCitationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialCitationResult)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (SerializedAdditionalRawData?.ContainsKey("license") != true && Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteStringValue(License);
            }
            if (SerializedAdditionalRawData?.ContainsKey("URL") != true && Optional.IsDefined(Uri))
            {
                writer.WritePropertyName("URL"u8);
                writer.WriteStringValue(Uri.AbsoluteUri);
            }
            if (SerializedAdditionalRawData != null)
            {
                foreach (var item in SerializedAdditionalRawData)
                {
                    if (ModelSerializationExtensions.IsSentinelValue(item.Value))
                    {
                        continue;
                    }
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

        ContentFilterProtectedMaterialCitationResult IJsonModel<ContentFilterProtectedMaterialCitationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialCitationResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialCitationResult)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentFilterProtectedMaterialCitationResult(document.RootElement, options);
        }

        internal static ContentFilterProtectedMaterialCitationResult DeserializeContentFilterProtectedMaterialCitationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string license = default;
            Uri url = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("license"u8))
                {
                    license = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("URL"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    url = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary ??= new Dictionary<string, BinaryData>();
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ContentFilterProtectedMaterialCitationResult(license, url, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ContentFilterProtectedMaterialCitationResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialCitationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialCitationResult)} does not support writing '{options.Format}' format.");
            }
        }

        ContentFilterProtectedMaterialCitationResult IPersistableModel<ContentFilterProtectedMaterialCitationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentFilterProtectedMaterialCitationResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentFilterProtectedMaterialCitationResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentFilterProtectedMaterialCitationResult)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentFilterProtectedMaterialCitationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The result to deserialize the model from. </param>
        internal static ContentFilterProtectedMaterialCitationResult FromResponse(PipelineResponse response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeContentFilterProtectedMaterialCitationResult(document.RootElement);
        }

        /// <summary> Convert into a <see cref="BinaryContent"/>. </summary>
        internal virtual BinaryContent ToBinaryContent()
        {
            return BinaryContent.Create(this, ModelSerializationExtensions.WireOptions);
        }
    }
}
