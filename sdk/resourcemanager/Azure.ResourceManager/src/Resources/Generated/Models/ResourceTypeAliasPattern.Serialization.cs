// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ResourceTypeAliasPattern : IUtf8JsonSerializable, IJsonModel<ResourceTypeAliasPattern>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ResourceTypeAliasPattern>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ResourceTypeAliasPattern>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ResourceTypeAliasPattern>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ResourceTypeAliasPattern>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Phrase))
            {
                writer.WritePropertyName("phrase"u8);
                writer.WriteStringValue(Phrase);
            }
            if (Optional.IsDefined(Variable))
            {
                writer.WritePropertyName("variable"u8);
                writer.WriteStringValue(Variable);
            }
            if (Optional.IsDefined(PatternType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PatternType.Value.ToSerialString());
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        ResourceTypeAliasPattern IJsonModel<ResourceTypeAliasPattern>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeResourceTypeAliasPattern(document.RootElement, options);
        }

        internal static ResourceTypeAliasPattern DeserializeResourceTypeAliasPattern(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> phrase = default;
            Optional<string> variable = default;
            Optional<ResourceTypeAliasPatternType> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phrase"u8))
                {
                    phrase = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("variable"u8))
                {
                    variable = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString().ToResourceTypeAliasPatternType();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ResourceTypeAliasPattern(phrase.Value, variable.Value, Optional.ToNullable(type), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ResourceTypeAliasPattern>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ResourceTypeAliasPattern IPersistableModel<ResourceTypeAliasPattern>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ResourceTypeAliasPattern)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeResourceTypeAliasPattern(document.RootElement, options);
        }

        string IPersistableModel<ResourceTypeAliasPattern>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
