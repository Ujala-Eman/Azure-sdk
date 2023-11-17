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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ACrossClusterMigrationReplicationDetails : IUtf8JsonSerializable, IJsonModel<A2ACrossClusterMigrationReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<A2ACrossClusterMigrationReplicationDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<A2ACrossClusterMigrationReplicationDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<A2ACrossClusterMigrationReplicationDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<A2ACrossClusterMigrationReplicationDetails>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (Optional.IsDefined(PrimaryFabricLocation))
            {
                writer.WritePropertyName("primaryFabricLocation"u8);
                writer.WriteStringValue(PrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VmProtectionState))
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (Optional.IsDefined(VmProtectionStateDescription))
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (Optional.IsDefined(LifecycleId))
            {
                writer.WritePropertyName("lifecycleId"u8);
                writer.WriteStringValue(LifecycleId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        A2ACrossClusterMigrationReplicationDetails IJsonModel<A2ACrossClusterMigrationReplicationDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACrossClusterMigrationReplicationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ACrossClusterMigrationReplicationDetails(document.RootElement, options);
        }

        internal static A2ACrossClusterMigrationReplicationDetails DeserializeA2ACrossClusterMigrationReplicationDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<AzureLocation> primaryFabricLocation = default;
            Optional<string> osType = default;
            Optional<string> vmProtectionState = default;
            Optional<string> vmProtectionStateDescription = default;
            Optional<string> lifecycleId = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleId"u8))
                {
                    lifecycleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new A2ACrossClusterMigrationReplicationDetails(instanceType, serializedAdditionalRawData, fabricObjectId.Value, Optional.ToNullable(primaryFabricLocation), osType.Value, vmProtectionState.Value, vmProtectionStateDescription.Value, lifecycleId.Value);
        }

        BinaryData IPersistableModel<A2ACrossClusterMigrationReplicationDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACrossClusterMigrationReplicationDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        A2ACrossClusterMigrationReplicationDetails IPersistableModel<A2ACrossClusterMigrationReplicationDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(A2ACrossClusterMigrationReplicationDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeA2ACrossClusterMigrationReplicationDetails(document.RootElement, options);
        }

        string IPersistableModel<A2ACrossClusterMigrationReplicationDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
