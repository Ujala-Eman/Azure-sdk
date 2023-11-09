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

namespace Azure.AI.TextAnalytics
{
    public partial struct LinkedEntityMatch : IUtf8JsonSerializable, IJsonModel<LinkedEntityMatch>, IJsonModel<object>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LinkedEntityMatch>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<LinkedEntityMatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("confidenceScore"u8);
            writer.WriteNumberValue(ConfidenceScore);
            writer.WritePropertyName("text"u8);
            writer.WriteStringValue(Text);
            writer.WritePropertyName("offset"u8);
            writer.WriteNumberValue(Offset);
            writer.WritePropertyName("length"u8);
            writer.WriteNumberValue(Length);
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        LinkedEntityMatch IJsonModel<LinkedEntityMatch>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedEntityMatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLinkedEntityMatch(document.RootElement, options);
        }

        void IJsonModel<object>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => ((IJsonModel<LinkedEntityMatch>)this).Write(writer, options);

        object IJsonModel<object>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options) => ((IJsonModel<LinkedEntityMatch>)this).Read(ref reader, options);

        internal static LinkedEntityMatch DeserializeLinkedEntityMatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            double confidenceScore = default;
            string text = default;
            int offset = default;
            int length = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("confidenceScore"u8))
                {
                    confidenceScore = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offset"u8))
                {
                    offset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("length"u8))
                {
                    length = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new LinkedEntityMatch(confidenceScore, text, offset, length, serializedAdditionalRawData);
        }

        BinaryData IModel<LinkedEntityMatch>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedEntityMatch)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        LinkedEntityMatch IModel<LinkedEntityMatch>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(LinkedEntityMatch)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeLinkedEntityMatch(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<LinkedEntityMatch>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        BinaryData IModel<object>.Write(ModelReaderWriterOptions options) => ((IModel<LinkedEntityMatch>)this).Write(options);

        object IModel<object>.Read(BinaryData data, ModelReaderWriterOptions options) => ((IModel<LinkedEntityMatch>)this).Read(data, options);

        ModelReaderWriterFormat IModel<object>.GetWireFormat(ModelReaderWriterOptions options) => ((IModel<LinkedEntityMatch>)this).GetWireFormat(options);
    }
}
