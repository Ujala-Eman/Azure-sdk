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

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class CustomEntityLookupSkill : IUtf8JsonSerializable, IJsonModel<CustomEntityLookupSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CustomEntityLookupSkill>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<CustomEntityLookupSkill>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<CustomEntityLookupSkill>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<CustomEntityLookupSkill>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultLanguageCode))
            {
                if (DefaultLanguageCode != null)
                {
                    writer.WritePropertyName("defaultLanguageCode"u8);
                    writer.WriteStringValue(DefaultLanguageCode.Value.ToString());
                }
                else
                {
                    writer.WriteNull("defaultLanguageCode");
                }
            }
            if (Optional.IsDefined(EntitiesDefinitionUri))
            {
                if (EntitiesDefinitionUri != null)
                {
                    writer.WritePropertyName("entitiesDefinitionUri"u8);
                    writer.WriteStringValue(EntitiesDefinitionUri.AbsoluteUri);
                }
                else
                {
                    writer.WriteNull("entitiesDefinitionUri");
                }
            }
            if (Optional.IsCollectionDefined(InlineEntitiesDefinition))
            {
                if (InlineEntitiesDefinition != null)
                {
                    writer.WritePropertyName("inlineEntitiesDefinition"u8);
                    writer.WriteStartArray();
                    foreach (var item in InlineEntitiesDefinition)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("inlineEntitiesDefinition");
                }
            }
            if (Optional.IsDefined(GlobalDefaultCaseSensitive))
            {
                if (GlobalDefaultCaseSensitive != null)
                {
                    writer.WritePropertyName("globalDefaultCaseSensitive"u8);
                    writer.WriteBooleanValue(GlobalDefaultCaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("globalDefaultCaseSensitive");
                }
            }
            if (Optional.IsDefined(GlobalDefaultAccentSensitive))
            {
                if (GlobalDefaultAccentSensitive != null)
                {
                    writer.WritePropertyName("globalDefaultAccentSensitive"u8);
                    writer.WriteBooleanValue(GlobalDefaultAccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("globalDefaultAccentSensitive");
                }
            }
            if (Optional.IsDefined(GlobalDefaultFuzzyEditDistance))
            {
                if (GlobalDefaultFuzzyEditDistance != null)
                {
                    writer.WritePropertyName("globalDefaultFuzzyEditDistance"u8);
                    writer.WriteNumberValue(GlobalDefaultFuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("globalDefaultFuzzyEditDistance");
                }
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(ODataType);
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Context))
            {
                writer.WritePropertyName("context"u8);
                writer.WriteStringValue(Context);
            }
            writer.WritePropertyName("inputs"u8);
            writer.WriteStartArray();
            foreach (var item in Inputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
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

        CustomEntityLookupSkill IJsonModel<CustomEntityLookupSkill>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomEntityLookupSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomEntityLookupSkill(document.RootElement, options);
        }

        internal static CustomEntityLookupSkill DeserializeCustomEntityLookupSkill(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CustomEntityLookupSkillLanguage?> defaultLanguageCode = default;
            Optional<Uri> entitiesDefinitionUri = default;
            Optional<IList<CustomEntity>> inlineEntitiesDefinition = default;
            Optional<bool?> globalDefaultCaseSensitive = default;
            Optional<bool?> globalDefaultAccentSensitive = default;
            Optional<int?> globalDefaultFuzzyEditDistance = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLanguageCode = null;
                        continue;
                    }
                    defaultLanguageCode = new CustomEntityLookupSkillLanguage(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("entitiesDefinitionUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        entitiesDefinitionUri = null;
                        continue;
                    }
                    entitiesDefinitionUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("inlineEntitiesDefinition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inlineEntitiesDefinition = null;
                        continue;
                    }
                    List<CustomEntity> array = new List<CustomEntity>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomEntity.DeserializeCustomEntity(item));
                    }
                    inlineEntitiesDefinition = array;
                    continue;
                }
                if (property.NameEquals("globalDefaultCaseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        globalDefaultCaseSensitive = null;
                        continue;
                    }
                    globalDefaultCaseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("globalDefaultAccentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        globalDefaultAccentSensitive = null;
                        continue;
                    }
                    globalDefaultAccentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("globalDefaultFuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        globalDefaultFuzzyEditDistance = null;
                        continue;
                    }
                    globalDefaultFuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("context"u8))
                {
                    context = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("inputs"u8))
                {
                    List<InputFieldMappingEntry> array = new List<InputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(InputFieldMappingEntry.DeserializeInputFieldMappingEntry(item));
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"u8))
                {
                    List<OutputFieldMappingEntry> array = new List<OutputFieldMappingEntry>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(OutputFieldMappingEntry.DeserializeOutputFieldMappingEntry(item));
                    }
                    outputs = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new CustomEntityLookupSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, serializedAdditionalRawData, Optional.ToNullable(defaultLanguageCode), entitiesDefinitionUri.Value, Optional.ToList(inlineEntitiesDefinition), Optional.ToNullable(globalDefaultCaseSensitive), Optional.ToNullable(globalDefaultAccentSensitive), Optional.ToNullable(globalDefaultFuzzyEditDistance));
        }

        BinaryData IPersistableModel<CustomEntityLookupSkill>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomEntityLookupSkill)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        CustomEntityLookupSkill IPersistableModel<CustomEntityLookupSkill>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(CustomEntityLookupSkill)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeCustomEntityLookupSkill(document.RootElement, options);
        }

        string IPersistableModel<CustomEntityLookupSkill>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
