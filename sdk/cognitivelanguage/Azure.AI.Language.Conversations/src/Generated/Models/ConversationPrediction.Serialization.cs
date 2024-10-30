// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Models
{
    public partial class ConversationPrediction : IUtf8JsonSerializable, IJsonModel<ConversationPrediction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ConversationPrediction>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ConversationPrediction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationPrediction)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("intents"u8);
            writer.WriteStartArray();
            foreach (var item in Intents)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("entities"u8);
            writer.WriteStartArray();
            foreach (var item in Entities)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
        }

        ConversationPrediction IJsonModel<ConversationPrediction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationPrediction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ConversationPrediction)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeConversationPrediction(document.RootElement, options);
        }

        internal static ConversationPrediction DeserializeConversationPrediction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<ConversationIntent> intents = default;
            IReadOnlyList<ConversationEntity> entities = default;
            ProjectKind projectKind = default;
            string topIntent = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("intents"u8))
                {
                    List<ConversationIntent> array = new List<ConversationIntent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationIntent.DeserializeConversationIntent(item, options));
                    }
                    intents = array;
                    continue;
                }
                if (property.NameEquals("entities"u8))
                {
                    List<ConversationEntity> array = new List<ConversationEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ConversationEntity.DeserializeConversationEntity(item, options));
                    }
                    entities = array;
                    continue;
                }
                if (property.NameEquals("projectKind"u8))
                {
                    projectKind = new ProjectKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("topIntent"u8))
                {
                    topIntent = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ConversationPrediction(projectKind, topIntent, serializedAdditionalRawData, intents, entities);
        }

        BinaryData IPersistableModel<ConversationPrediction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationPrediction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ConversationPrediction)} does not support writing '{options.Format}' format.");
            }
        }

        ConversationPrediction IPersistableModel<ConversationPrediction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ConversationPrediction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeConversationPrediction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ConversationPrediction)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ConversationPrediction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static new ConversationPrediction FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeConversationPrediction(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal override RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
