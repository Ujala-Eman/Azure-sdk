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
    public partial class LuisCallingConfig : IUtf8JsonSerializable, IJsonModel<LuisCallingConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LuisCallingConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LuisCallingConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisCallingConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LuisCallingConfig)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Verbose))
            {
                writer.WritePropertyName("verbose"u8);
                writer.WriteBooleanValue(Verbose.Value);
            }
            if (Optional.IsDefined(Log))
            {
                writer.WritePropertyName("log"u8);
                writer.WriteBooleanValue(Log.Value);
            }
            if (Optional.IsDefined(ShowAllIntents))
            {
                writer.WritePropertyName("show-all-intents"u8);
                writer.WriteBooleanValue(ShowAllIntents.Value);
            }
            if (Optional.IsDefined(TimezoneOffset))
            {
                writer.WritePropertyName("timezoneOffset"u8);
                writer.WriteNumberValue(TimezoneOffset.Value);
            }
            if (Optional.IsDefined(SpellCheck))
            {
                writer.WritePropertyName("spellCheck"u8);
                writer.WriteBooleanValue(SpellCheck.Value);
            }
            if (Optional.IsDefined(BingSpellCheckSubscriptionKey))
            {
                writer.WritePropertyName("bing-spell-check-subscription-key"u8);
                writer.WriteStringValue(BingSpellCheckSubscriptionKey);
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

        LuisCallingConfig IJsonModel<LuisCallingConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisCallingConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LuisCallingConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLuisCallingConfig(document.RootElement, options);
        }

        internal static LuisCallingConfig DeserializeLuisCallingConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            bool? verbose = default;
            bool? log = default;
            bool? showAllIntents = default;
            int? timezoneOffset = default;
            bool? spellCheck = default;
            string bingSpellCheckSubscriptionKey = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("verbose"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    verbose = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("log"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    log = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("show-all-intents"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    showAllIntents = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("timezoneOffset"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timezoneOffset = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("spellCheck"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    spellCheck = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("bing-spell-check-subscription-key"u8))
                {
                    bingSpellCheckSubscriptionKey = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LuisCallingConfig(
                verbose,
                log,
                showAllIntents,
                timezoneOffset,
                spellCheck,
                bingSpellCheckSubscriptionKey,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<LuisCallingConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisCallingConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LuisCallingConfig)} does not support writing '{options.Format}' format.");
            }
        }

        LuisCallingConfig IPersistableModel<LuisCallingConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LuisCallingConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLuisCallingConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LuisCallingConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LuisCallingConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static LuisCallingConfig FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeLuisCallingConfig(document.RootElement);
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
