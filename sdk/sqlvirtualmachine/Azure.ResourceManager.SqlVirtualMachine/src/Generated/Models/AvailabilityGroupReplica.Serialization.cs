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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class AvailabilityGroupReplica : IUtf8JsonSerializable, IModelJsonSerializable<AvailabilityGroupReplica>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<AvailabilityGroupReplica>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<AvailabilityGroupReplica>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(SqlVmInstanceId))
            {
                writer.WritePropertyName("sqlVirtualMachineInstanceId"u8);
                writer.WriteStringValue(SqlVmInstanceId);
            }
            if (Optional.IsDefined(Role))
            {
                writer.WritePropertyName("role"u8);
                writer.WriteStringValue(Role.Value.ToString());
            }
            if (Optional.IsDefined(Commit))
            {
                writer.WritePropertyName("commit"u8);
                writer.WriteStringValue(Commit.Value.ToString());
            }
            if (Optional.IsDefined(Failover))
            {
                writer.WritePropertyName("failover"u8);
                writer.WriteStringValue(Failover.Value.ToString());
            }
            if (Optional.IsDefined(ReadableSecondary))
            {
                writer.WritePropertyName("readableSecondary"u8);
                writer.WriteStringValue(ReadableSecondary.Value.ToString());
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

        internal static AvailabilityGroupReplica DeserializeAvailabilityGroupReplica(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> sqlVmInstanceId = default;
            Optional<AvailabilityGroupReplicaRole> role = default;
            Optional<AvailabilityGroupReplicaCommitMode> commit = default;
            Optional<AvailabilityGroupReplicaFailoverMode> failover = default;
            Optional<ReadableSecondaryMode> readableSecondary = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sqlVirtualMachineInstanceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sqlVmInstanceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("role"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    role = new AvailabilityGroupReplicaRole(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("commit"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    commit = new AvailabilityGroupReplicaCommitMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failover = new AvailabilityGroupReplicaFailoverMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("readableSecondary"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    readableSecondary = new ReadableSecondaryMode(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new AvailabilityGroupReplica(sqlVmInstanceId.Value, Optional.ToNullable(role), Optional.ToNullable(commit), Optional.ToNullable(failover), Optional.ToNullable(readableSecondary), rawData);
        }

        AvailabilityGroupReplica IModelJsonSerializable<AvailabilityGroupReplica>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeAvailabilityGroupReplica(doc.RootElement, options);
        }

        BinaryData IModelSerializable<AvailabilityGroupReplica>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        AvailabilityGroupReplica IModelSerializable<AvailabilityGroupReplica>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeAvailabilityGroupReplica(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="AvailabilityGroupReplica"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="AvailabilityGroupReplica"/> to convert. </param>
        public static implicit operator RequestContent(AvailabilityGroupReplica model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="AvailabilityGroupReplica"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator AvailabilityGroupReplica(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeAvailabilityGroupReplica(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
