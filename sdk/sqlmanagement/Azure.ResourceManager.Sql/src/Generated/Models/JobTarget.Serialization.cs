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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class JobTarget : IUtf8JsonSerializable, IModelJsonSerializable<JobTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JobTarget>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JobTarget>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(MembershipType))
            {
                writer.WritePropertyName("membershipType"u8);
                writer.WriteStringValue(MembershipType.Value.ToSerialString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TargetType.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (Optional.IsDefined(ShardMapName))
            {
                writer.WritePropertyName("shardMapName"u8);
                writer.WriteStringValue(ShardMapName);
            }
            if (Optional.IsDefined(RefreshCredential))
            {
                writer.WritePropertyName("refreshCredential"u8);
                writer.WriteStringValue(RefreshCredential);
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

        internal static JobTarget DeserializeJobTarget(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobTargetGroupMembershipType> membershipType = default;
            JobTargetType type = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> elasticPoolName = default;
            Optional<string> shardMapName = default;
            Optional<string> refreshCredential = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("membershipType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    membershipType = property.Value.GetString().ToJobTargetGroupMembershipType();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticPoolName"u8))
                {
                    elasticPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardMapName"u8))
                {
                    shardMapName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshCredential"u8))
                {
                    refreshCredential = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JobTarget(Optional.ToNullable(membershipType), type, serverName.Value, databaseName.Value, elasticPoolName.Value, shardMapName.Value, refreshCredential.Value, rawData);
        }

        JobTarget IModelJsonSerializable<JobTarget>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJobTarget(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JobTarget>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JobTarget IModelSerializable<JobTarget>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJobTarget(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JobTarget"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JobTarget"/> to convert. </param>
        public static implicit operator RequestContent(JobTarget model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JobTarget"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JobTarget(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJobTarget(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
