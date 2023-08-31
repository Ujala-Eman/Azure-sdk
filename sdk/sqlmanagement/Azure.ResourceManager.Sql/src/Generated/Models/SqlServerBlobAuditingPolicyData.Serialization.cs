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
    public partial class SqlServerBlobAuditingPolicyData : IUtf8JsonSerializable, IModelJsonSerializable<SqlServerBlobAuditingPolicyData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SqlServerBlobAuditingPolicyData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SqlServerBlobAuditingPolicyData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(IsDevopsAuditEnabled))
            {
                writer.WritePropertyName("isDevopsAuditEnabled"u8);
                writer.WriteBooleanValue(IsDevopsAuditEnabled.Value);
            }
            if (Optional.IsDefined(RetentionDays))
            {
                writer.WritePropertyName("retentionDays"u8);
                writer.WriteNumberValue(RetentionDays.Value);
            }
            if (Optional.IsCollectionDefined(AuditActionsAndGroups))
            {
                writer.WritePropertyName("auditActionsAndGroups"u8);
                writer.WriteStartArray();
                foreach (var item in AuditActionsAndGroups)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsStorageSecondaryKeyInUse))
            {
                writer.WritePropertyName("isStorageSecondaryKeyInUse"u8);
                writer.WriteBooleanValue(IsStorageSecondaryKeyInUse.Value);
            }
            if (Optional.IsDefined(IsAzureMonitorTargetEnabled))
            {
                writer.WritePropertyName("isAzureMonitorTargetEnabled"u8);
                writer.WriteBooleanValue(IsAzureMonitorTargetEnabled.Value);
            }
            if (Optional.IsDefined(QueueDelayMs))
            {
                writer.WritePropertyName("queueDelayMs"u8);
                writer.WriteNumberValue(QueueDelayMs.Value);
            }
            if (Optional.IsDefined(IsManagedIdentityInUse))
            {
                writer.WritePropertyName("isManagedIdentityInUse"u8);
                writer.WriteBooleanValue(IsManagedIdentityInUse.Value);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToSerialString());
            }
            if (Optional.IsDefined(StorageEndpoint))
            {
                writer.WritePropertyName("storageEndpoint"u8);
                writer.WriteStringValue(StorageEndpoint);
            }
            if (Optional.IsDefined(StorageAccountAccessKey))
            {
                writer.WritePropertyName("storageAccountAccessKey"u8);
                writer.WriteStringValue(StorageAccountAccessKey);
            }
            if (Optional.IsDefined(StorageAccountSubscriptionId))
            {
                writer.WritePropertyName("storageAccountSubscriptionId"u8);
                writer.WriteStringValue(StorageAccountSubscriptionId.Value);
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

        internal static SqlServerBlobAuditingPolicyData DeserializeSqlServerBlobAuditingPolicyData(JsonElement element, ModelSerializerOptions options = default)
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
            Optional<bool> isDevopsAuditEnabled = default;
            Optional<int> retentionDays = default;
            Optional<IList<string>> auditActionsAndGroups = default;
            Optional<bool> isStorageSecondaryKeyInUse = default;
            Optional<bool> isAzureMonitorTargetEnabled = default;
            Optional<int> queueDelayMs = default;
            Optional<bool> isManagedIdentityInUse = default;
            Optional<BlobAuditingPolicyState> state = default;
            Optional<string> storageEndpoint = default;
            Optional<string> storageAccountAccessKey = default;
            Optional<Guid> storageAccountSubscriptionId = default;
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
                        if (property0.NameEquals("isDevopsAuditEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDevopsAuditEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("retentionDays"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            retentionDays = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("auditActionsAndGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            auditActionsAndGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("isStorageSecondaryKeyInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isStorageSecondaryKeyInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("isAzureMonitorTargetEnabled"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isAzureMonitorTargetEnabled = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("queueDelayMs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queueDelayMs = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isManagedIdentityInUse"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isManagedIdentityInUse = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = property0.Value.GetString().ToBlobAuditingPolicyState();
                            continue;
                        }
                        if (property0.NameEquals("storageEndpoint"u8))
                        {
                            storageEndpoint = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountAccessKey"u8))
                        {
                            storageAccountAccessKey = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("storageAccountSubscriptionId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            storageAccountSubscriptionId = property0.Value.GetGuid();
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
            return new SqlServerBlobAuditingPolicyData(id, name, type, systemData.Value, Optional.ToNullable(isDevopsAuditEnabled), Optional.ToNullable(retentionDays), Optional.ToList(auditActionsAndGroups), Optional.ToNullable(isStorageSecondaryKeyInUse), Optional.ToNullable(isAzureMonitorTargetEnabled), Optional.ToNullable(queueDelayMs), Optional.ToNullable(isManagedIdentityInUse), Optional.ToNullable(state), storageEndpoint.Value, storageAccountAccessKey.Value, Optional.ToNullable(storageAccountSubscriptionId), rawData);
        }

        SqlServerBlobAuditingPolicyData IModelJsonSerializable<SqlServerBlobAuditingPolicyData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServerBlobAuditingPolicyData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SqlServerBlobAuditingPolicyData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SqlServerBlobAuditingPolicyData IModelSerializable<SqlServerBlobAuditingPolicyData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSqlServerBlobAuditingPolicyData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SqlServerBlobAuditingPolicyData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SqlServerBlobAuditingPolicyData"/> to convert. </param>
        public static implicit operator RequestContent(SqlServerBlobAuditingPolicyData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SqlServerBlobAuditingPolicyData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SqlServerBlobAuditingPolicyData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSqlServerBlobAuditingPolicyData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
