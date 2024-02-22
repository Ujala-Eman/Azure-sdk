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

namespace Azure.Health.Insights.ClinicalMatching
{
    public partial class PatientInfo : IUtf8JsonSerializable, IJsonModel<PatientInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PatientInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PatientInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientInfo)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sex))
            {
                writer.WritePropertyName("sex"u8);
                writer.WriteStringValue(Sex.Value.ToString());
            }
            if (Optional.IsDefined(BirthDate))
            {
                writer.WritePropertyName("birthDate"u8);
                writer.WriteStringValue(BirthDate.Value, "D");
            }
            if (Optional.IsCollectionDefined(ClinicalInfo))
            {
                writer.WritePropertyName("clinicalInfo"u8);
                writer.WriteStartArray();
                foreach (var item in ClinicalInfo)
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

        PatientInfo IJsonModel<PatientInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PatientInfo)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePatientInfo(document.RootElement, options);
        }

        internal static PatientInfo DeserializePatientInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PatientInfoSex> sex = default;
            Optional<DateTimeOffset> birthDate = default;
            Optional<IList<ClinicalCodedElement>> clinicalInfo = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sex"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sex = new PatientInfoSex(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("birthDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    birthDate = property.Value.GetDateTimeOffset("D");
                    continue;
                }
                if (property.NameEquals("clinicalInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ClinicalCodedElement> array = new List<ClinicalCodedElement>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ClinicalCodedElement.DeserializeClinicalCodedElement(item, options));
                    }
                    clinicalInfo = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PatientInfo(Optional.ToNullable(sex), Optional.ToNullable(birthDate), Optional.ToList(clinicalInfo), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PatientInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PatientInfo)} does not support '{options.Format}' format.");
            }
        }

        PatientInfo IPersistableModel<PatientInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PatientInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePatientInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PatientInfo)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PatientInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static PatientInfo FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializePatientInfo(document.RootElement);
        }

        /// <summary> Convert into a Utf8JsonRequestContent. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this);
            return content;
        }
    }
}
