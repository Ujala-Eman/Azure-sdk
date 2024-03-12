// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.Health.Insights.RadiologyInsights
{
    public partial class FhirR4Narrative : IUtf8JsonSerializable, IJsonModel<FhirR4Narrative>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FhirR4Narrative>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<FhirR4Narrative>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Narrative>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Narrative)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status);
            writer.WritePropertyName("div"u8);
            writer.WriteStringValue(Div);
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(Extension))
            {
                writer.WritePropertyName("extension"u8);
                writer.WriteStartArray();
                foreach (var item in Extension)
                {
                    writer.WriteObjectValue(item);
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
            writer.WriteEndObject();
        }

        FhirR4Narrative IJsonModel<FhirR4Narrative>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Narrative>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(FhirR4Narrative)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFhirR4Narrative(document.RootElement, options);
        }

        internal static FhirR4Narrative DeserializeFhirR4Narrative(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string status = default;
            string div = default;
            string id = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("div"u8))
                {
                    div = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extension"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<FhirR4Extension> array = new List<FhirR4Extension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(FhirR4Extension.DeserializeFhirR4Extension(item, options));
                    }
                    extension = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FhirR4Narrative(id, extension ?? new ChangeTrackingList<FhirR4Extension>(), serializedAdditionalRawData, status, div);
        }

        BinaryData IPersistableModel<FhirR4Narrative>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Narrative>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(FhirR4Narrative)} does not support '{options.Format}' format.");
            }
        }

        FhirR4Narrative IPersistableModel<FhirR4Narrative>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<FhirR4Narrative>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeFhirR4Narrative(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(FhirR4Narrative)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<FhirR4Narrative>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new FhirR4Narrative FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeFhirR4Narrative(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
