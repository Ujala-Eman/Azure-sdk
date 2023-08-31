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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlAdvisorData : IUtf8JsonSerializable, IModelJsonSerializable<SqlAdvisorData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlAdvisorData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlAdvisorData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AutoExecuteStatus))
            {
                writer.WritePropertyName("autoExecuteStatus"u8);
                writer.WriteStringValue(AutoExecuteStatus.Value.ToSerialString());
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

        internal static SqlAdvisorData DeserializeSqlAdvisorData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> kind = default;
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<SqlAdvisorStatus> advisorStatus = default;
            Optional<AutoExecuteStatus> autoExecuteStatus = default;
            Optional<AutoExecuteStatusInheritedFrom> autoExecuteStatusInheritedFrom = default;
            Optional<string> recommendationsStatus = default;
            Optional<DateTimeOffset> lastChecked = default;
            Optional<IReadOnlyList<RecommendedActionData>> recommendedActions = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("advisorStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            advisorStatus = property0.Value.GetString().ToSqlAdvisorStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatus = property0.Value.GetString().ToAutoExecuteStatus();
                            continue;
                        }
                        if (property0.NameEquals("autoExecuteStatusInheritedFrom"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoExecuteStatusInheritedFrom = property0.Value.GetString().ToAutoExecuteStatusInheritedFrom();
                            continue;
                        }
                        if (property0.NameEquals("recommendationsStatus"u8))
                        {
                            recommendationsStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastChecked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastChecked = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("recommendedActions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<RecommendedActionData> array = new List<RecommendedActionData>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(RecommendedActionData.DeserializeRecommendedActionData(item));
                            }
                            recommendedActions = array;
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
            return new SqlAdvisorData(id, name, type, systemData.Value, kind.Value, Optional.ToNullable(location), Optional.ToNullable(advisorStatus), Optional.ToNullable(autoExecuteStatus), Optional.ToNullable(autoExecuteStatusInheritedFrom), recommendationsStatus.Value, Optional.ToNullable(lastChecked), Optional.ToList(recommendedActions), rawData);
        }

        SqlAdvisorData IModelJsonSerializable<SqlAdvisorData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlAdvisorData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlAdvisorData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlAdvisorData IModelSerializable<SqlAdvisorData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlAdvisorData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlAdvisorData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlAdvisorData"/> to convert. </param>
        public static implicit operator RequestContent(SqlAdvisorData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlAdvisorData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlAdvisorData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlAdvisorData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
