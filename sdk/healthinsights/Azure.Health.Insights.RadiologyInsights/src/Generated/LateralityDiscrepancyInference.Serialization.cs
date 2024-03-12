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
    public partial class LateralityDiscrepancyInference : IUtf8JsonSerializable, IJsonModel<LateralityDiscrepancyInference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LateralityDiscrepancyInference>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<LateralityDiscrepancyInference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LateralityDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LateralityDiscrepancyInference)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(LateralityIndication))
            {
                writer.WritePropertyName("lateralityIndication"u8);
                writer.WriteObjectValue(LateralityIndication);
            }
            writer.WritePropertyName("discrepancyType"u8);
            writer.WriteStringValue(DiscrepancyType.ToString());
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind);
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

        LateralityDiscrepancyInference IJsonModel<LateralityDiscrepancyInference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LateralityDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LateralityDiscrepancyInference)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLateralityDiscrepancyInference(document.RootElement, options);
        }

        internal static LateralityDiscrepancyInference DeserializeLateralityDiscrepancyInference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            FhirR4CodeableConcept lateralityIndication = default;
            LateralityDiscrepancyType discrepancyType = default;
            string kind = default;
            IReadOnlyList<FhirR4Extension> extension = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lateralityIndication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lateralityIndication = FhirR4CodeableConcept.DeserializeFhirR4CodeableConcept(property.Value, options);
                    continue;
                }
                if (property.NameEquals("discrepancyType"u8))
                {
                    discrepancyType = new LateralityDiscrepancyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
            return new LateralityDiscrepancyInference(kind, extension ?? new ChangeTrackingList<FhirR4Extension>(), serializedAdditionalRawData, lateralityIndication, discrepancyType);
        }

        BinaryData IPersistableModel<LateralityDiscrepancyInference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LateralityDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LateralityDiscrepancyInference)} does not support '{options.Format}' format.");
            }
        }

        LateralityDiscrepancyInference IPersistableModel<LateralityDiscrepancyInference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LateralityDiscrepancyInference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLateralityDiscrepancyInference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LateralityDiscrepancyInference)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<LateralityDiscrepancyInference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new LateralityDiscrepancyInference FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLateralityDiscrepancyInference(document.RootElement);
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
