// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class MachineLearningServicesModelRegisteredEventData : IUtf8JsonSerializable, IJsonModel<MachineLearningServicesModelRegisteredEventData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningServicesModelRegisteredEventData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MachineLearningServicesModelRegisteredEventData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesModelRegisteredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesModelRegisteredEventData)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(ModelName))
            {
                writer.WritePropertyName("modelName"u8);
                writer.WriteStringValue(ModelName);
            }
            if (Optional.IsDefined(ModelVersion))
            {
                writer.WritePropertyName("modelVersion"u8);
                writer.WriteStringValue(ModelVersion);
            }
            writer.WritePropertyName("modelTags"u8);
            writer.WriteStartObject();
            foreach (var item in ModelTags)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
            writer.WritePropertyName("modelProperties"u8);
            writer.WriteStartObject();
            foreach (var item in ModelProperties)
            {
                writer.WritePropertyName(item.Key);
                if (item.Value == null)
                {
                    writer.WriteNullValue();
                    continue;
                }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                using (JsonDocument document = JsonDocument.Parse(item.Value))
                {
                    JsonSerializer.Serialize(writer, document.RootElement);
                }
#endif
            }
            writer.WriteEndObject();
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

        MachineLearningServicesModelRegisteredEventData IJsonModel<MachineLearningServicesModelRegisteredEventData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesModelRegisteredEventData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningServicesModelRegisteredEventData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningServicesModelRegisteredEventData(document.RootElement, options);
        }

        internal static MachineLearningServicesModelRegisteredEventData DeserializeMachineLearningServicesModelRegisteredEventData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string modelName = default;
            string modelVersion = default;
            IReadOnlyDictionary<string, BinaryData> modelTags = default;
            IReadOnlyDictionary<string, BinaryData> modelProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("modelName"u8))
                {
                    modelName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    modelVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("modelTags"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    modelTags = dictionary;
                    continue;
                }
                if (property.NameEquals("modelProperties"u8))
                {
                    Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, BinaryData.FromString(property0.Value.GetRawText()));
                        }
                    }
                    modelProperties = dictionary;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MachineLearningServicesModelRegisteredEventData(modelName, modelVersion, modelTags, modelProperties, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MachineLearningServicesModelRegisteredEventData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesModelRegisteredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesModelRegisteredEventData)} does not support writing '{options.Format}' format.");
            }
        }

        MachineLearningServicesModelRegisteredEventData IPersistableModel<MachineLearningServicesModelRegisteredEventData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningServicesModelRegisteredEventData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningServicesModelRegisteredEventData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningServicesModelRegisteredEventData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningServicesModelRegisteredEventData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static MachineLearningServicesModelRegisteredEventData FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeMachineLearningServicesModelRegisteredEventData(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
