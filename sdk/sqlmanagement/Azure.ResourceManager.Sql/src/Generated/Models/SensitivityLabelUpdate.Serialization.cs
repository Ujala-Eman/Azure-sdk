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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SensitivityLabelUpdate : IUtf8JsonSerializable, IModelJsonSerializable<SensitivityLabelUpdate>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SensitivityLabelUpdate>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SensitivityLabelUpdate>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Op))
            {
                writer.WritePropertyName("op"u8);
                writer.WriteStringValue(Op.Value.ToSerialString());
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema"u8);
                writer.WriteStringValue(Schema);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table"u8);
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(Column))
            {
                writer.WritePropertyName("column"u8);
                writer.WriteStringValue(Column);
            }
            if (Optional.IsDefined(SensitivityLabel))
            {
                writer.WritePropertyName("sensitivityLabel"u8);
                if (SensitivityLabel is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SensitivityLabelData>)SensitivityLabel).Serialize(writer, options);
                }
            }
            writer.WriteEndObject();
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

        internal static SensitivityLabelUpdate DeserializeSensitivityLabelUpdate(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SensitivityLabelUpdateKind> op = default;
            Optional<string> schema = default;
            Optional<string> table = default;
            Optional<string> column = default;
            Optional<SensitivityLabelData> sensitivityLabel = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("op"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            op = property0.Value.GetString().ToSensitivityLabelUpdateKind();
                            continue;
                        }
                        if (property0.NameEquals("schema"u8))
                        {
                            schema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"u8))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("column"u8))
                        {
                            column = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sensitivityLabel"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sensitivityLabel = SensitivityLabelData.DeserializeSensitivityLabelData(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SensitivityLabelUpdate(id, name, type, systemData.Value, Optional.ToNullable(op), schema.Value, table.Value, column.Value, sensitivityLabel.Value, rawData);
        }

        SensitivityLabelUpdate IModelJsonSerializable<SensitivityLabelUpdate>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSensitivityLabelUpdate(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SensitivityLabelUpdate>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SensitivityLabelUpdate IModelSerializable<SensitivityLabelUpdate>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSensitivityLabelUpdate(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SensitivityLabelUpdate"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SensitivityLabelUpdate"/> to convert. </param>
        public static implicit operator RequestContent(SensitivityLabelUpdate model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SensitivityLabelUpdate"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SensitivityLabelUpdate(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSensitivityLabelUpdate(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
