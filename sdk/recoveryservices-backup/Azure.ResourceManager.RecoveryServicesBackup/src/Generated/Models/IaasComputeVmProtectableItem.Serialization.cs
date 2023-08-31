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
    public partial class IaasComputeVmProtectableItem : IUtf8JsonSerializable, IModelJsonSerializable<IaasComputeVmProtectableItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IaasComputeVmProtectableItem>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IaasComputeVmProtectableItem>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasComputeVmProtectableItem>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(VirtualMachineId))
            {
                writer.WritePropertyName("virtualMachineId"u8);
                writer.WriteStringValue(VirtualMachineId);
            }
            if (Optional.IsDefined(VirtualMachineVersion))
            {
                writer.WritePropertyName("virtualMachineVersion"u8);
                writer.WriteStringValue(VirtualMachineVersion);
            }
            if (Optional.IsDefined(ResourceGroup))
            {
                writer.WritePropertyName("resourceGroup"u8);
                writer.WriteStringValue(ResourceGroup);
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
            writer.WritePropertyName("protectableItemType"u8);
            writer.WriteStringValue(ProtectableItemType);
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

        internal static IaasComputeVmProtectableItem DeserializeIaasComputeVmProtectableItem(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> virtualMachineId = default;
            Optional<string> virtualMachineVersion = default;
            Optional<string> resourceGroup = default;
            Optional<string> backupManagementType = default;
            Optional<string> workloadType = default;
            string protectableItemType = default;
            Optional<string> friendlyName = default;
            Optional<BackupProtectionStatus> protectionState = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("virtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("virtualMachineVersion"u8))
                {
                    virtualMachineVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
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
                if (property.NameEquals("protectableItemType"u8))
                {
                    protectableItemType = property.Value.GetString();
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
            return new IaasComputeVmProtectableItem(backupManagementType.Value, workloadType.Value, protectableItemType, friendlyName.Value, Optional.ToNullable(protectionState), virtualMachineId.Value, virtualMachineVersion.Value, resourceGroup.Value, rawData);
        }

        IaasComputeVmProtectableItem IModelJsonSerializable<IaasComputeVmProtectableItem>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasComputeVmProtectableItem>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIaasComputeVmProtectableItem(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IaasComputeVmProtectableItem>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasComputeVmProtectableItem>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IaasComputeVmProtectableItem IModelSerializable<IaasComputeVmProtectableItem>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<IaasComputeVmProtectableItem>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIaasComputeVmProtectableItem(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IaasComputeVmProtectableItem"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IaasComputeVmProtectableItem"/> to convert. </param>
        public static implicit operator RequestContent(IaasComputeVmProtectableItem model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IaasComputeVmProtectableItem"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IaasComputeVmProtectableItem(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIaasComputeVmProtectableItem(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
