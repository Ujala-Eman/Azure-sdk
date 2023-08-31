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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class VmWorkloadSapHanaSystemWorkloadItem : IUtf8JsonSerializable, IModelJsonSerializable<VmWorkloadSapHanaSystemWorkloadItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<VmWorkloadSapHanaSystemWorkloadItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<VmWorkloadSapHanaSystemWorkloadItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSapHanaSystemWorkloadItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ParentName))
            {
                writer.WritePropertyName("parentName"u8);
                writer.WriteStringValue(ParentName);
            }
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(IsAutoProtectable))
            {
                writer.WritePropertyName("isAutoProtectable"u8);
                writer.WriteBooleanValue(IsAutoProtectable.Value);
            }
            if (Optional.IsDefined(SubInquiredItemCount))
            {
                writer.WritePropertyName("subinquireditemcount"u8);
                writer.WriteNumberValue(SubInquiredItemCount.Value);
            }
            if (Optional.IsDefined(SubWorkloadItemCount))
            {
                writer.WritePropertyName("subWorkloadItemCount"u8);
                writer.WriteNumberValue(SubWorkloadItemCount.Value);
            }
            if (Optional.IsDefined(BackupManagementType))
            {
                writer.WritePropertyName("backupManagementType"u8);
                writer.WriteStringValue(BackupManagementType);
            }
            if (Optional.IsDefined(WorkloadType))
            {
                writer.WritePropertyName("workloadType"u8);
                writer.WriteStringValue(WorkloadType);
            }
            writer.WritePropertyName("workloadItemType"u8);
            writer.WriteStringValue(WorkloadItemType);
            if (Optional.IsDefined(FriendlyName))
            {
                writer.WritePropertyName("friendlyName"u8);
                writer.WriteStringValue(FriendlyName);
            }
            if (Optional.IsDefined(ProtectionState))
            {
                writer.WritePropertyName("protectionState"u8);
                writer.WriteStringValue(ProtectionState.Value.ToString());
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

        internal static VmWorkloadSapHanaSystemWorkloadItem DeserializeVmWorkloadSapHanaSystemWorkloadItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> parentName = default;
            Optional<string> serverName = default;
            Optional<bool> isAutoProtectable = default;
            Optional<int> subinquireditemcount = default;
            Optional<int> subWorkloadItemCount = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string workloadItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("parentName"u8))
                {
                    parentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAutoProtectable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAutoProtectable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("subinquireditemcount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subinquireditemcount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("subWorkloadItemCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    subWorkloadItemCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("backupManagementType"u8))
                {
                    backupManagementType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadType"u8))
                {
                    workloadType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("workloadItemType"u8))
                {
                    workloadItemType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("friendlyName"u8))
                {
                    friendlyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("protectionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    protectionState = new BackupProtectionStatus(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new VmWorkloadSapHanaSystemWorkloadItem(backupManagementType.Value, workloadType.Value, workloadItemType, friendlyName.Value, Optional.ToNullable(protectionState), parentName.Value, serverName.Value, Optional.ToNullable(isAutoProtectable), Optional.ToNullable(subinquireditemcount), Optional.ToNullable(subWorkloadItemCount), rawData);
        }

        VmWorkloadSapHanaSystemWorkloadItem IModelJsonSerializable<VmWorkloadSapHanaSystemWorkloadItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSapHanaSystemWorkloadItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeVmWorkloadSapHanaSystemWorkloadItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<VmWorkloadSapHanaSystemWorkloadItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSapHanaSystemWorkloadItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        VmWorkloadSapHanaSystemWorkloadItem IModelSerializable<VmWorkloadSapHanaSystemWorkloadItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<VmWorkloadSapHanaSystemWorkloadItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeVmWorkloadSapHanaSystemWorkloadItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="VmWorkloadSapHanaSystemWorkloadItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="VmWorkloadSapHanaSystemWorkloadItem"/> to convert. </param>
        public static implicit operator RequestContent(VmWorkloadSapHanaSystemWorkloadItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="VmWorkloadSapHanaSystemWorkloadItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator VmWorkloadSapHanaSystemWorkloadItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeVmWorkloadSapHanaSystemWorkloadItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
