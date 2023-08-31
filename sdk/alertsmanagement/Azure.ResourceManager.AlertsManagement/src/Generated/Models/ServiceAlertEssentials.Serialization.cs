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

namespace Azure.ResourceManager.AlertsManagement.Models
{
    public partial class ServiceAlertEssentials : IUtf8JsonSerializable, IModelJsonSerializable<ServiceAlertEssentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ServiceAlertEssentials>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ServiceAlertEssentials>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(TargetResource))
            {
                writer.WritePropertyName("targetResource"u8);
                writer.WriteStringValue(TargetResource);
            }
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroup))
            {
                writer.WritePropertyName("targetResourceGroup"u8);
                writer.WriteStringValue(TargetResourceGroup);
            }
            if (Optional.IsDefined(TargetResourceType))
            {
                writer.WritePropertyName("targetResourceType"u8);
                writer.WriteStringValue(TargetResourceType);
            }
            if (Optional.IsDefined(ActionStatus))
            {
                writer.WritePropertyName("actionStatus"u8);
                writer.WriteObjectValue(ActionStatus);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static ServiceAlertEssentials DeserializeServiceAlertEssentials(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ServiceAlertSeverity> severity = default;
            Optional<ServiceAlertSignalType> signalType = default;
            Optional<ServiceAlertState> alertState = default;
            Optional<MonitorCondition> monitorCondition = default;
            Optional<string> targetResource = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroup = default;
            Optional<string> targetResourceType = default;
            Optional<MonitorServiceSourceForAlert> monitorService = default;
            Optional<string> alertRule = default;
            Optional<string> sourceCreatedId = default;
            Optional<Guid> smartGroupId = default;
            Optional<string> smartGroupingReason = default;
            Optional<DateTimeOffset> startDateTime = default;
            Optional<DateTimeOffset> lastModifiedDateTime = default;
            Optional<DateTimeOffset> monitorConditionResolvedDateTime = default;
            Optional<string> lastModifiedUserName = default;
            Optional<ServiceAlertActionStatus> actionStatus = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("severity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    severity = new ServiceAlertSeverity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("signalType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    signalType = new ServiceAlertSignalType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    alertState = new ServiceAlertState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("monitorCondition"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorCondition = new MonitorCondition(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetResource"u8))
                {
                    targetResource = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroup"u8))
                {
                    targetResourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceType"u8))
                {
                    targetResourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("monitorService"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorService = new MonitorServiceSourceForAlert(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("alertRule"u8))
                {
                    alertRule = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceCreatedId"u8))
                {
                    sourceCreatedId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("smartGroupId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    smartGroupId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("smartGroupingReason"u8))
                {
                    smartGroupingReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    lastModifiedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("monitorConditionResolvedDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitorConditionResolvedDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("lastModifiedUserName"u8))
                {
                    lastModifiedUserName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("actionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    actionStatus = ServiceAlertActionStatus.DeserializeServiceAlertActionStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ServiceAlertEssentials(Optional.ToNullable(severity), Optional.ToNullable(signalType), Optional.ToNullable(alertState), Optional.ToNullable(monitorCondition), targetResource.Value, targetResourceName.Value, targetResourceGroup.Value, targetResourceType.Value, Optional.ToNullable(monitorService), alertRule.Value, sourceCreatedId.Value, Optional.ToNullable(smartGroupId), smartGroupingReason.Value, Optional.ToNullable(startDateTime), Optional.ToNullable(lastModifiedDateTime), Optional.ToNullable(monitorConditionResolvedDateTime), lastModifiedUserName.Value, actionStatus.Value, description.Value, rawData);
        }

        ServiceAlertEssentials IModelJsonSerializable<ServiceAlertEssentials>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceAlertEssentials(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ServiceAlertEssentials>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ServiceAlertEssentials IModelSerializable<ServiceAlertEssentials>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeServiceAlertEssentials(doc.RootElement, options);
        }

        public static implicit operator RequestContent(ServiceAlertEssentials model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator ServiceAlertEssentials(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeServiceAlertEssentials(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
