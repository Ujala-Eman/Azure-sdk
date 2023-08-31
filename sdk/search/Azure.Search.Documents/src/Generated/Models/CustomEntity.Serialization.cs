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
    public partial class CustomEntity : IUtf8JsonSerializable, IModelJsonSerializable<CustomEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CustomEntity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CustomEntity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description"u8);
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsDefined(Type))
            {
                if (Type != null)
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(Type);
                }
                else
                {
                    writer.WriteNull("type");
                }
            }
            if (Optional.IsDefined(Subtype))
            {
                if (Subtype != null)
                {
                    writer.WritePropertyName("subtype"u8);
                    writer.WriteStringValue(Subtype);
                }
                else
                {
                    writer.WriteNull("subtype");
                }
            }
            if (Optional.IsDefined(Id))
            {
                if (Id != null)
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
                else
                {
                    writer.WriteNull("id");
                }
            }
            if (Optional.IsDefined(CaseSensitive))
            {
                if (CaseSensitive != null)
                {
                    writer.WritePropertyName("caseSensitive"u8);
                    writer.WriteBooleanValue(CaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("caseSensitive");
                }
            }
            if (Optional.IsDefined(AccentSensitive))
            {
                if (AccentSensitive != null)
                {
                    writer.WritePropertyName("accentSensitive"u8);
                    writer.WriteBooleanValue(AccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("accentSensitive");
                }
            }
            if (Optional.IsDefined(FuzzyEditDistance))
            {
                if (FuzzyEditDistance != null)
                {
                    writer.WritePropertyName("fuzzyEditDistance"u8);
                    writer.WriteNumberValue(FuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("fuzzyEditDistance");
                }
            }
            if (Optional.IsDefined(DefaultCaseSensitive))
            {
                if (DefaultCaseSensitive != null)
                {
                    writer.WritePropertyName("defaultCaseSensitive"u8);
                    writer.WriteBooleanValue(DefaultCaseSensitive.Value);
                }
                else
                {
                    writer.WriteNull("defaultCaseSensitive");
                }
            }
            if (Optional.IsDefined(DefaultAccentSensitive))
            {
                if (DefaultAccentSensitive != null)
                {
                    writer.WritePropertyName("defaultAccentSensitive"u8);
                    writer.WriteBooleanValue(DefaultAccentSensitive.Value);
                }
                else
                {
                    writer.WriteNull("defaultAccentSensitive");
                }
            }
            if (Optional.IsDefined(DefaultFuzzyEditDistance))
            {
                if (DefaultFuzzyEditDistance != null)
                {
                    writer.WritePropertyName("defaultFuzzyEditDistance"u8);
                    writer.WriteNumberValue(DefaultFuzzyEditDistance.Value);
                }
                else
                {
                    writer.WriteNull("defaultFuzzyEditDistance");
                }
            }
            if (Optional.IsCollectionDefined(Aliases))
            {
                if (Aliases != null)
                {
                    writer.WritePropertyName("aliases"u8);
                    writer.WriteStartArray();
                    foreach (var item in Aliases)
                    {
                        if (item is null)
                        {
                            writer.WriteNullValue();
                        }
                        else
                        {
                            ((IModelJsonSerializable<CustomEntityAlias>)item).Serialize(writer, options);
                        }
                    }
                    writer.WriteEndArray();
                }
                else
                {
                    writer.WriteNull("aliases");
                }
            }
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

        internal static CustomEntity DeserializeCustomEntity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<string> description = default;
            Optional<string> type = default;
            Optional<string> subtype = default;
            Optional<string> id = default;
            Optional<bool?> caseSensitive = default;
            Optional<bool?> accentSensitive = default;
            Optional<int?> fuzzyEditDistance = default;
            Optional<bool?> defaultCaseSensitive = default;
            Optional<bool?> defaultAccentSensitive = default;
            Optional<int?> defaultFuzzyEditDistance = default;
            Optional<IList<CustomEntityAlias>> aliases = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        type = null;
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subtype"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        subtype = null;
                        continue;
                    }
                    subtype = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        id = null;
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("caseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        caseSensitive = null;
                        continue;
                    }
                    caseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("accentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        accentSensitive = null;
                        continue;
                    }
                    accentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("fuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        fuzzyEditDistance = null;
                        continue;
                    }
                    fuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("defaultCaseSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultCaseSensitive = null;
                        continue;
                    }
                    defaultCaseSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultAccentSensitive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultAccentSensitive = null;
                        continue;
                    }
                    defaultAccentSensitive = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("defaultFuzzyEditDistance"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        defaultFuzzyEditDistance = null;
                        continue;
                    }
                    defaultFuzzyEditDistance = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("aliases"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        aliases = null;
                        continue;
                    }
                    List<CustomEntityAlias> array = new List<CustomEntityAlias>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CustomEntityAlias.DeserializeCustomEntityAlias(item));
                    }
                    aliases = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CustomEntity(name, description.Value, type.Value, subtype.Value, id.Value, Optional.ToNullable(caseSensitive), Optional.ToNullable(accentSensitive), Optional.ToNullable(fuzzyEditDistance), Optional.ToNullable(defaultCaseSensitive), Optional.ToNullable(defaultAccentSensitive), Optional.ToNullable(defaultFuzzyEditDistance), Optional.ToList(aliases), rawData);
        }

        CustomEntity IModelJsonSerializable<CustomEntity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCustomEntity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CustomEntity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CustomEntity IModelSerializable<CustomEntity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCustomEntity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CustomEntity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CustomEntity"/> to convert. </param>
        public static implicit operator RequestContent(CustomEntity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CustomEntity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CustomEntity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCustomEntity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
