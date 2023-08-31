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
    public partial class WorkloadSqlRestoreContent : IUtf8JsonSerializable, IModelJsonSerializable<WorkloadSqlRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkloadSqlRestoreContent>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkloadSqlRestoreContent>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRestoreContent>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ShouldUseAlternateTargetLocation))
            {
                writer.WritePropertyName("shouldUseAlternateTargetLocation"u8);
                writer.WriteBooleanValue(ShouldUseAlternateTargetLocation.Value);
            }
            if (Optional.IsDefined(IsNonRecoverable))
            {
                writer.WritePropertyName("isNonRecoverable"u8);
                writer.WriteBooleanValue(IsNonRecoverable.Value);
            }
            if (Optional.IsCollectionDefined(AlternateDirectoryPaths))
            {
                writer.WritePropertyName("alternateDirectoryPaths"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateDirectoryPaths)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<SqlDataDirectoryMapping>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(RecoveryType))
            {
                writer.WritePropertyName("recoveryType"u8);
                writer.WriteStringValue(RecoveryType.Value.ToString());
            }
            if (Optional.IsDefined(SourceResourceId))
            {
                writer.WritePropertyName("sourceResourceId"u8);
                writer.WriteStringValue(SourceResourceId);
            }
            if (Optional.IsCollectionDefined(PropertyBag))
            {
                writer.WritePropertyName("propertyBag"u8);
                writer.WriteStartObject();
                foreach (var item in PropertyBag)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(TargetInfo))
            {
                writer.WritePropertyName("targetInfo"u8);
                if (TargetInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<TargetRestoreInfo>)TargetInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RecoveryMode))
            {
                writer.WritePropertyName("recoveryMode"u8);
                writer.WriteStringValue(RecoveryMode.Value.ToString());
            }
            if (Optional.IsDefined(TargetVirtualMachineId))
            {
                writer.WritePropertyName("targetVirtualMachineId"u8);
                writer.WriteStringValue(TargetVirtualMachineId);
            }
            writer.WritePropertyName("objectType"u8);
            writer.WriteStringValue(ObjectType);
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

        internal static WorkloadSqlRestoreContent DeserializeWorkloadSqlRestoreContent(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("objectType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AzureWorkloadSQLPointInTimeRestoreRequest": return WorkloadSqlPointInTimeRestoreContent.DeserializeWorkloadSqlPointInTimeRestoreContent(element);
                    case "AzureWorkloadSQLPointInTimeRestoreWithRehydrateRequest": return WorkloadSqlPointInTimeRestoreWithRehydrateContent.DeserializeWorkloadSqlPointInTimeRestoreWithRehydrateContent(element);
                    case "AzureWorkloadSQLRestoreWithRehydrateRequest": return WorkloadSqlRestoreWithRehydrateContent.DeserializeWorkloadSqlRestoreWithRehydrateContent(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<bool> shouldUseAlternateTargetLocation = default;
            Optional<bool> isNonRecoverable = default;
            Optional<IList<SqlDataDirectoryMapping>> alternateDirectoryPaths = default;
            Optional<FileShareRecoveryType> recoveryType = default;
            Optional<ResourceIdentifier> sourceResourceId = default;
            Optional<IDictionary<string, string>> propertyBag = default;
            Optional<TargetRestoreInfo> targetInfo = default;
            Optional<RecoveryMode> recoveryMode = default;
            Optional<ResourceIdentifier> targetVirtualMachineId = default;
            string objectType = "AzureWorkloadSQLRestoreRequest";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("shouldUseAlternateTargetLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    shouldUseAlternateTargetLocation = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("isNonRecoverable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isNonRecoverable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("alternateDirectoryPaths"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SqlDataDirectoryMapping> array = new List<SqlDataDirectoryMapping>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SqlDataDirectoryMapping.DeserializeSqlDataDirectoryMapping(item));
                    }
                    alternateDirectoryPaths = array;
                    continue;
                }
                if (property.NameEquals("recoveryType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryType = new FileShareRecoveryType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceResourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyBag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    propertyBag = dictionary;
                    continue;
                }
                if (property.NameEquals("targetInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetInfo = TargetRestoreInfo.DeserializeTargetRestoreInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryMode = new RecoveryMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetVirtualMachineId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetVirtualMachineId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("objectType"u8))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new WorkloadSqlRestoreContent(objectType, Optional.ToNullable(recoveryType), sourceResourceId.Value, Optional.ToDictionary(propertyBag), targetInfo.Value, Optional.ToNullable(recoveryMode), targetVirtualMachineId.Value, Optional.ToNullable(shouldUseAlternateTargetLocation), Optional.ToNullable(isNonRecoverable), Optional.ToList(alternateDirectoryPaths), rawData);
        }

        WorkloadSqlRestoreContent IModelJsonSerializable<WorkloadSqlRestoreContent>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRestoreContent>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlRestoreContent(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkloadSqlRestoreContent>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRestoreContent>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkloadSqlRestoreContent IModelSerializable<WorkloadSqlRestoreContent>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRestoreContent>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkloadSqlRestoreContent(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WorkloadSqlRestoreContent"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WorkloadSqlRestoreContent"/> to convert. </param>
        public static implicit operator RequestContent(WorkloadSqlRestoreContent model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WorkloadSqlRestoreContent"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WorkloadSqlRestoreContent(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWorkloadSqlRestoreContent(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
