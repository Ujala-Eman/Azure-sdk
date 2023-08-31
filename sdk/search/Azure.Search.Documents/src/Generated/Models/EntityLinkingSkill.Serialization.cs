// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class EntityLinkingSkill : IUtf8JsonSerializable, IModelJsonSerializable<EntityLinkingSkill>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<EntityLinkingSkill>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<EntityLinkingSkill>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingSkill>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultLanguageCode))
            {
                if (DefaultLanguageCode != null)
                {
                    writer.WritePropertyName("defaultLanguageCode"u8);
                    writer.WriteStringValue(DefaultLanguageCode);
                }
                else
                {
                    writer.WriteNull("defaultLanguageCode");
                }
            }
            if (Optional.IsDefined(MinimumPrecision))
            {
                if (MinimumPrecision != null)
                {
                    writer.WritePropertyName("minimumPrecision"u8);
                    writer.WriteNumberValue(MinimumPrecision.Value);
                }
                else
                {
                    writer.WriteNull("minimumPrecision");
                }
            }
            if (Optional.IsDefined(ModelVersion))
            {
                if (ModelVersion != null)
                {
                    writer.WritePropertyName("modelVersion"u8);
                    writer.WriteStringValue(ModelVersion);
                }
                else
                {
                    writer.WriteNull("modelVersion");
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
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<InputFieldMappingEntry>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            writer.WritePropertyName("outputs"u8);
            writer.WriteStartArray();
            foreach (var item in Outputs)
            {
                if (item is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<OutputFieldMappingEntry>)item).Serialize(writer, options);
                }
            }
            writer.WriteEndArray();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static EntityLinkingSkill DeserializeEntityLinkingSkill(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> defaultLanguageCode = default;
            Optional<double?> minimumPrecision = default;
            Optional<string> modelVersion = default;
            string odataType = default;
            Optional<string> name = default;
            Optional<string> description = default;
            Optional<string> context = default;
            IList<InputFieldMappingEntry> inputs = default;
            IList<OutputFieldMappingEntry> outputs = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultLanguageCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultLanguageCode = null;
                        continue;
                    }
                    defaultLanguageCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("minimumPrecision"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        minimumPrecision = null;
                        continue;
                    }
                    minimumPrecision = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("modelVersion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        modelVersion = null;
                        continue;
                    }
                    modelVersion = property.Value.GetString();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new EntityLinkingSkill(odataType, name.Value, description.Value, context.Value, inputs, outputs, defaultLanguageCode.Value, Optional.ToNullable(minimumPrecision), modelVersion.Value, rawData);
        }

        EntityLinkingSkill IModelJsonSerializable<EntityLinkingSkill>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingSkill>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityLinkingSkill(doc.RootElement, options);
        }

        BinaryData IModelSerializable<EntityLinkingSkill>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingSkill>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        EntityLinkingSkill IModelSerializable<EntityLinkingSkill>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<EntityLinkingSkill>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeEntityLinkingSkill(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="EntityLinkingSkill"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="EntityLinkingSkill"/> to convert. </param>
        public static implicit operator RequestContent(EntityLinkingSkill model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="EntityLinkingSkill"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator EntityLinkingSkill(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeEntityLinkingSkill(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
