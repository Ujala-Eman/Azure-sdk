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
    public partial class WorkloadSqlRecoveryPoint : IUtf8JsonSerializable, IModelJsonSerializable<WorkloadSqlRecoveryPoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<WorkloadSqlRecoveryPoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<WorkloadSqlRecoveryPoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRecoveryPoint>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ExtendedInfo))
            {
                writer.WritePropertyName("extendedInfo"u8);
                if (ExtendedInfo is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<WorkloadSqlRecoveryPointExtendedInfo>)ExtendedInfo).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(RecoveryPointCreatedOn))
            {
                writer.WritePropertyName("recoveryPointTimeInUTC"u8);
                writer.WriteStringValue(RecoveryPointCreatedOn.Value, "O");
            }
            if (Optional.IsDefined(RestorePointType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(RestorePointType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(RecoveryPointTierDetails))
            {
                writer.WritePropertyName("recoveryPointTierDetails"u8);
                writer.WriteStartArray();
                foreach (var item in RecoveryPointTierDetails)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPointTierInformationV2>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RecoveryPointMoveReadinessInfo))
            {
                writer.WritePropertyName("recoveryPointMoveReadinessInfo"u8);
                writer.WriteStartObject();
                foreach (var item in RecoveryPointMoveReadinessInfo)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<RecoveryPointMoveReadinessInfo>)item.Value).Serialize(writer, options);
                    }
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(RecoveryPointProperties))
            {
                writer.WritePropertyName("recoveryPointProperties"u8);
                if (RecoveryPointProperties is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<RecoveryPointProperties>)RecoveryPointProperties).Serialize(writer, options);
                }
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

        internal static WorkloadSqlRecoveryPoint DeserializeWorkloadSqlRecoveryPoint(JsonElement element, ModelSerializerOptions options = default)
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
                    case "AzureWorkloadSQLPointInTimeRecoveryPoint": return WorkloadSqlPointInTimeRecoveryPoint.DeserializeWorkloadSqlPointInTimeRecoveryPoint(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            Optional<WorkloadSqlRecoveryPointExtendedInfo> extendedInfo = default;
            Optional<DateTimeOffset> recoveryPointTimeInUTC = default;
            Optional<RestorePointType> type = default;
            Optional<IList<RecoveryPointTierInformationV2>> recoveryPointTierDetails = default;
            Optional<IDictionary<string, RecoveryPointMoveReadinessInfo>> recoveryPointMoveReadinessInfo = default;
            Optional<RecoveryPointProperties> recoveryPointProperties = default;
            string objectType = "AzureWorkloadSQLRecoveryPoint";
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("extendedInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    extendedInfo = WorkloadSqlRecoveryPointExtendedInfo.DeserializeWorkloadSqlRecoveryPointExtendedInfo(property.Value);
                    continue;
                }
                if (property.NameEquals("recoveryPointTimeInUTC"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointTimeInUTC = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new RestorePointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recoveryPointTierDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RecoveryPointTierInformationV2> array = new List<RecoveryPointTierInformationV2>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RecoveryPointTierInformationV2.DeserializeRecoveryPointTierInformationV2(item));
                    }
                    recoveryPointTierDetails = array;
                    continue;
                }
                if (property.NameEquals("recoveryPointMoveReadinessInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, RecoveryPointMoveReadinessInfo> dictionary = new Dictionary<string, RecoveryPointMoveReadinessInfo>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, Models.RecoveryPointMoveReadinessInfo.DeserializeRecoveryPointMoveReadinessInfo(property0.Value));
                    }
                    recoveryPointMoveReadinessInfo = dictionary;
                    continue;
                }
                if (property.NameEquals("recoveryPointProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recoveryPointProperties = RecoveryPointProperties.DeserializeRecoveryPointProperties(property.Value);
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
            return new WorkloadSqlRecoveryPoint(objectType, Optional.ToNullable(recoveryPointTimeInUTC), Optional.ToNullable(type), Optional.ToList(recoveryPointTierDetails), Optional.ToDictionary(recoveryPointMoveReadinessInfo), recoveryPointProperties.Value, extendedInfo.Value, rawData);
        }

        WorkloadSqlRecoveryPoint IModelJsonSerializable<WorkloadSqlRecoveryPoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRecoveryPoint>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeWorkloadSqlRecoveryPoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<WorkloadSqlRecoveryPoint>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRecoveryPoint>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        WorkloadSqlRecoveryPoint IModelSerializable<WorkloadSqlRecoveryPoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<WorkloadSqlRecoveryPoint>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeWorkloadSqlRecoveryPoint(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="WorkloadSqlRecoveryPoint"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="WorkloadSqlRecoveryPoint"/> to convert. </param>
        public static implicit operator RequestContent(WorkloadSqlRecoveryPoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="WorkloadSqlRecoveryPoint"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator WorkloadSqlRecoveryPoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeWorkloadSqlRecoveryPoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
