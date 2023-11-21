// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationUpgradePolicy : IUtf8JsonSerializable, IJsonModel<ApplicationUpgradePolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationUpgradePolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplicationUpgradePolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationUpgradePolicy)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(UpgradeReplicaSetCheckTimeout))
            {
                writer.WritePropertyName("upgradeReplicaSetCheckTimeout"u8);
                writer.WriteStringValue(UpgradeReplicaSetCheckTimeout.Value, "c");
            }
            if (Optional.IsDefined(ForceRestart))
            {
                writer.WritePropertyName("forceRestart"u8);
                writer.WriteBooleanValue(ForceRestart.Value);
            }
            if (Optional.IsDefined(RollingUpgradeMonitoringPolicy))
            {
                writer.WritePropertyName("rollingUpgradeMonitoringPolicy"u8);
                writer.WriteObjectValue(RollingUpgradeMonitoringPolicy);
            }
            if (Optional.IsDefined(ApplicationHealthPolicy))
            {
                writer.WritePropertyName("applicationHealthPolicy"u8);
                writer.WriteObjectValue(ApplicationHealthPolicy);
            }
            if (Optional.IsDefined(UpgradeMode))
            {
                writer.WritePropertyName("upgradeMode"u8);
                writer.WriteStringValue(UpgradeMode.Value.ToString());
            }
            if (Optional.IsDefined(RecreateApplication))
            {
                writer.WritePropertyName("recreateApplication"u8);
                writer.WriteBooleanValue(RecreateApplication.Value);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ApplicationUpgradePolicy IJsonModel<ApplicationUpgradePolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApplicationUpgradePolicy)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationUpgradePolicy(document.RootElement, options);
        }

        internal static ApplicationUpgradePolicy DeserializeApplicationUpgradePolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> upgradeReplicaSetCheckTimeout = default;
            Optional<bool> forceRestart = default;
            Optional<ArmRollingUpgradeMonitoringPolicy> rollingUpgradeMonitoringPolicy = default;
            Optional<ArmApplicationHealthPolicy> applicationHealthPolicy = default;
            Optional<ApplicationRollingUpgradeMode> upgradeMode = default;
            Optional<bool> recreateApplication = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("upgradeReplicaSetCheckTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeReplicaSetCheckTimeout = property.Value.GetTimeSpan("c");
                    continue;
                }
                if (property.NameEquals("forceRestart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    forceRestart = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("rollingUpgradeMonitoringPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rollingUpgradeMonitoringPolicy = ArmRollingUpgradeMonitoringPolicy.DeserializeArmRollingUpgradeMonitoringPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("applicationHealthPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationHealthPolicy = ArmApplicationHealthPolicy.DeserializeArmApplicationHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("upgradeMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradeMode = new ApplicationRollingUpgradeMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("recreateApplication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recreateApplication = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationUpgradePolicy(Optional.ToNullable(upgradeReplicaSetCheckTimeout), Optional.ToNullable(forceRestart), rollingUpgradeMonitoringPolicy.Value, applicationHealthPolicy.Value, Optional.ToNullable(upgradeMode), Optional.ToNullable(recreateApplication), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationUpgradePolicy>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        ApplicationUpgradePolicy IPersistableModel<ApplicationUpgradePolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApplicationUpgradePolicy>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApplicationUpgradePolicy(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApplicationUpgradePolicy)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApplicationUpgradePolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
