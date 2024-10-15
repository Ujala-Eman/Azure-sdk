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
    public partial class RedactedTranscriptContent : IUtf8JsonSerializable, IJsonModel<RedactedTranscriptContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedactedTranscriptContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RedactedTranscriptContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedactedTranscriptContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedactedTranscriptContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(InverseTextNormalized))
            {
                writer.WritePropertyName("itn"u8);
                writer.WriteStringValue(InverseTextNormalized);
            }
            if (Optional.IsDefined(MaskedInverseTextNormalized))
            {
                writer.WritePropertyName("maskedItn"u8);
                writer.WriteStringValue(MaskedInverseTextNormalized);
            }
            if (Optional.IsDefined(Text))
            {
                writer.WritePropertyName("text"u8);
                writer.WriteStringValue(Text);
            }
            if (Optional.IsDefined(Lexical))
            {
                writer.WritePropertyName("lexical"u8);
                writer.WriteStringValue(Lexical);
            }
            if (Optional.IsCollectionDefined(AudioTimings))
            {
                writer.WritePropertyName("audioTimings"u8);
                writer.WriteStartArray();
                foreach (var item in AudioTimings)
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
            writer.WriteEndObject();
        }

        RedactedTranscriptContent IJsonModel<RedactedTranscriptContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedactedTranscriptContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RedactedTranscriptContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedactedTranscriptContent(document.RootElement, options);
        }

        internal static RedactedTranscriptContent DeserializeRedactedTranscriptContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string itn = default;
            string maskedItn = default;
            string text = default;
            string lexical = default;
            IReadOnlyList<AudioTiming> audioTimings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("itn"u8))
                {
                    itn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maskedItn"u8))
                {
                    maskedItn = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("text"u8))
                {
                    text = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lexical"u8))
                {
                    lexical = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audioTimings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AudioTiming> array = new List<AudioTiming>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AudioTiming.DeserializeAudioTiming(item, options));
                    }
                    audioTimings = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RedactedTranscriptContent(
                itn,
                maskedItn,
                text,
                lexical,
                audioTimings ?? new ChangeTrackingList<AudioTiming>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedactedTranscriptContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedactedTranscriptContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RedactedTranscriptContent)} does not support writing '{options.Format}' format.");
            }
        }

        RedactedTranscriptContent IPersistableModel<RedactedTranscriptContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RedactedTranscriptContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRedactedTranscriptContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RedactedTranscriptContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RedactedTranscriptContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static RedactedTranscriptContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeRedactedTranscriptContent(document.RootElement);
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
