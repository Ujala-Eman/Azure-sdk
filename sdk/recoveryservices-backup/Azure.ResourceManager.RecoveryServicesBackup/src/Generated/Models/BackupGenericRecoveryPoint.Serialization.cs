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
    public partial class BackupGenericRecoveryPoint : IUtf8JsonSerializable, IModelJsonSerializable<BackupGenericRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<BackupGenericRecoveryPoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<BackupGenericRecoveryPoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
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

        internal static BackupGenericRecoveryPoint DeserializeBackupGenericRecoveryPoint(JsonElement element, ModelSerializerOptions options = default)
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
                    case "AzureFileShareRecoveryPoint": return FileShareRecoveryPoint.DeserializeFileShareRecoveryPoint(element);
                    case "AzureWorkloadPointInTimeRecoveryPoint": return WorkloadPointInTimeRecoveryPoint.DeserializeWorkloadPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadRecoveryPoint": return WorkloadRecoveryPoint.DeserializeWorkloadRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaPointInTimeRecoveryPoint": return WorkloadSapHanaPointInTimeRecoveryPoint.DeserializeWorkloadSapHanaPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSAPHanaRecoveryPoint": return WorkloadSapHanaRecoveryPoint.DeserializeWorkloadSapHanaRecoveryPoint(element);
                    case "AzureWorkloadSQLPointInTimeRecoveryPoint": return WorkloadSqlPointInTimeRecoveryPoint.DeserializeWorkloadSqlPointInTimeRecoveryPoint(element);
                    case "AzureWorkloadSQLRecoveryPoint": return WorkloadSqlRecoveryPoint.DeserializeWorkloadSqlRecoveryPoint(element);
                    case "GenericRecoveryPoint": return GenericRecoveryPoint.DeserializeGenericRecoveryPoint(element);
                    case "IaasVMRecoveryPoint": return IaasVmRecoveryPoint.DeserializeIaasVmRecoveryPoint(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string objectType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
            return new UnknownRecoveryPoint(objectType, rawData);
        }

        BackupGenericRecoveryPoint IModelJsonSerializable<BackupGenericRecoveryPoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupGenericRecoveryPoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<BackupGenericRecoveryPoint>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        BackupGenericRecoveryPoint IModelSerializable<BackupGenericRecoveryPoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeBackupGenericRecoveryPoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="BackupGenericRecoveryPoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="BackupGenericRecoveryPoint"/> to convert. </param>
        public static implicit operator RequestContent(BackupGenericRecoveryPoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="BackupGenericRecoveryPoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator BackupGenericRecoveryPoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeBackupGenericRecoveryPoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
