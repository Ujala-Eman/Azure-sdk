// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    public partial class SourceDictionaryLanguage : IUtf8JsonSerializable, IJsonModel<SourceDictionaryLanguage>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceDictionaryLanguage>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SourceDictionaryLanguage>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("nativeName"u8);
            writer.WriteStringValue(NativeName);
            writer.WritePropertyName("dir"u8);
            writer.WriteStringValue(Dir);
            writer.WritePropertyName("translations"u8);
            writer.WriteStartArray();
            foreach (var item in Translations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        SourceDictionaryLanguage IJsonModel<SourceDictionaryLanguage>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceDictionaryLanguage(document.RootElement, options);
        }

        internal static SourceDictionaryLanguage DeserializeSourceDictionaryLanguage(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string nativeName = default;
            string dir = default;
            IReadOnlyList<TargetDictionaryLanguage> translations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nativeName"u8))
                {
                    nativeName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dir"u8))
                {
                    dir = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("translations"u8))
                {
                    List<TargetDictionaryLanguage> array = new List<TargetDictionaryLanguage>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(TargetDictionaryLanguage.DeserializeTargetDictionaryLanguage(item));
                    }
                    translations = array;
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SourceDictionaryLanguage(name, nativeName, dir, translations, serializedAdditionalRawData);
        }

        BinaryData IModel<SourceDictionaryLanguage>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SourceDictionaryLanguage IModel<SourceDictionaryLanguage>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SourceDictionaryLanguage)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSourceDictionaryLanguage(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SourceDictionaryLanguage>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SourceDictionaryLanguage FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSourceDictionaryLanguage(document.RootElement, ModelReaderWriterOptions.DefaultWireOptions);
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
