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

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ArmRollingUpgradeMonitoringPolicy : IUtf8JsonSerializable, IModelJsonSerializable<ArmRollingUpgradeMonitoringPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ArmRollingUpgradeMonitoringPolicy>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ArmRollingUpgradeMonitoringPolicy>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FailureAction))
            {
                writer.WritePropertyName("failureAction"u8);
                writer.WriteStringValue(FailureAction.Value.ToString());
            }
            if (Optional.IsDefined(HealthCheckWaitDuration))
            {
                writer.WritePropertyName("healthCheckWaitDuration"u8);
                writer.WriteStringValue(HealthCheckWaitDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckStableDuration))
            {
                writer.WritePropertyName("healthCheckStableDuration"u8);
                writer.WriteStringValue(HealthCheckStableDuration.Value, "c");
            }
            if (Optional.IsDefined(HealthCheckRetryTimeout))
            {
                writer.WritePropertyName("healthCheckRetryTimeout"u8);
                writer.WriteStringValue(HealthCheckRetryTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeTimeout))
            {
                writer.WritePropertyName("upgradeTimeout"u8);
                writer.WriteStringValue(UpgradeTimeout.Value, "c");
            }
            if (Optional.IsDefined(UpgradeDomainTimeout))
            {
                writer.WritePropertyName("upgradeDomainTimeout"u8);
                writer.WriteStringValue(UpgradeDomainTimeout.Value, "c");
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

        internal static ArmRollingUpgradeMonitoringPolicy DeserializeArmRollingUpgradeMonitoringPolicy(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ArmUpgradeFailureAction> failureAction = default;
            Optional<TimeSpan> healthCheckWaitDuration = default;
            Optional<TimeSpan> healthCheckStableDuration = default;
            Optional<TimeSpan> healthCheckRetryTimeout = default;
            Optional<TimeSpan> upgradeTimeout = default;
            Optional<TimeSpan> upgradeDomainTimeout = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("failureAction"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failureAction = new ArmUpgradeFailureAction(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("healthCheckWaitDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckWaitDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckStableDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckStableDuration = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("healthCheckRetryTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    healthCheckRetryTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("upgradeDomainTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeDomainTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ArmRollingUpgradeMonitoringPolicy(Optional.ToNullable(failureAction), Optional.ToNullable(healthCheckWaitDuration), Optional.ToNullable(healthCheckStableDuration), Optional.ToNullable(healthCheckRetryTimeout), Optional.ToNullable(upgradeTimeout), Optional.ToNullable(upgradeDomainTimeout), rawData);
        }

        ArmRollingUpgradeMonitoringPolicy IModelJsonSerializable<ArmRollingUpgradeMonitoringPolicy>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeArmRollingUpgradeMonitoringPolicy(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ArmRollingUpgradeMonitoringPolicy>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ArmRollingUpgradeMonitoringPolicy IModelSerializable<ArmRollingUpgradeMonitoringPolicy>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeArmRollingUpgradeMonitoringPolicy(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ArmRollingUpgradeMonitoringPolicy"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ArmRollingUpgradeMonitoringPolicy"/> to convert. </param>
        public static implicit operator RequestContent(ArmRollingUpgradeMonitoringPolicy model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ArmRollingUpgradeMonitoringPolicy"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ArmRollingUpgradeMonitoringPolicy(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeArmRollingUpgradeMonitoringPolicy(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
