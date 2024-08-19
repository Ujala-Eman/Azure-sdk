// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MongoCluster.Models
{
    public partial class MongoClusterProperties : IUtf8JsonSerializable, IJsonModel<MongoClusterProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MongoClusterProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<MongoClusterProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterProperties)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(CreateMode))
            {
                writer.WritePropertyName("createMode"u8);
                writer.WriteStringValue(CreateMode.Value.ToString());
            }
            if (Optional.IsDefined(RestoreParameters))
            {
                writer.WritePropertyName("restoreParameters"u8);
                writer.WriteObjectValue(RestoreParameters, options);
            }
            if (Optional.IsDefined(ReplicaParameters))
            {
                writer.WritePropertyName("replicaParameters"u8);
                writer.WriteObjectValue(ReplicaParameters, options);
            }
            if (Optional.IsDefined(Administrator))
            {
                writer.WritePropertyName("administrator"u8);
                writer.WriteObjectValue(Administrator, options);
            }
            if (Optional.IsDefined(ServerVersion))
            {
                writer.WritePropertyName("serverVersion"u8);
                writer.WriteStringValue(ServerVersion);
            }
            if (options.Format != "W" && Optional.IsDefined(ConnectionString))
            {
                writer.WritePropertyName("connectionString"u8);
                writer.WriteStringValue(ConnectionString);
            }
            if (options.Format != "W" && Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsDefined(ClusterStatus))
            {
                writer.WritePropertyName("clusterStatus"u8);
                writer.WriteStringValue(ClusterStatus.Value.ToString());
            }
            if (Optional.IsDefined(PublicNetworkAccess))
            {
                writer.WritePropertyName("publicNetworkAccess"u8);
                writer.WriteStringValue(PublicNetworkAccess.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailability))
            {
                writer.WritePropertyName("highAvailability"u8);
                writer.WriteObjectValue(HighAvailability, options);
            }
            if (Optional.IsDefined(Storage))
            {
                writer.WritePropertyName("storage"u8);
                writer.WriteObjectValue(Storage, options);
            }
            if (Optional.IsDefined(Sharding))
            {
                writer.WritePropertyName("sharding"u8);
                writer.WriteObjectValue(Sharding, options);
            }
            if (Optional.IsDefined(Compute))
            {
                writer.WritePropertyName("compute"u8);
                writer.WriteObjectValue(Compute, options);
            }
            if (Optional.IsDefined(Backup))
            {
                writer.WritePropertyName("backup"u8);
                writer.WriteObjectValue(Backup, options);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(PrivateEndpointConnections))
            {
                writer.WritePropertyName("privateEndpointConnections"u8);
                writer.WriteStartArray();
                foreach (var item in PrivateEndpointConnections)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(PreviewFeatures))
            {
                writer.WritePropertyName("previewFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in PreviewFeatures)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Replica))
            {
                writer.WritePropertyName("replica"u8);
                writer.WriteObjectValue(Replica, options);
            }
            if (options.Format != "W" && Optional.IsDefined(InfrastructureVersion))
            {
                writer.WritePropertyName("infrastructureVersion"u8);
                writer.WriteStringValue(InfrastructureVersion);
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

        MongoClusterProperties IJsonModel<MongoClusterProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MongoClusterProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMongoClusterProperties(document.RootElement, options);
        }

        internal static MongoClusterProperties DeserializeMongoClusterProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            MongoClusterCreateMode? createMode = default;
            MongoClusterRestoreContent restoreParameters = default;
            MongoClusterReplicaContent replicaParameters = default;
            AdministratorProperties administrator = default;
            string serverVersion = default;
            string connectionString = default;
            MongoClusterProvisioningState? provisioningState = default;
            MongoClusterStatus? clusterStatus = default;
            PublicNetworkAccess? publicNetworkAccess = default;
            HighAvailabilityProperties highAvailability = default;
            StorageProperties storage = default;
            ShardingProperties sharding = default;
            ComputeProperties compute = default;
            BackupProperties backup = default;
            IReadOnlyList<MongoClusterPrivateEndpointConnection> privateEndpointConnections = default;
            IList<MongoClusterPreviewFeature> previewFeatures = default;
            MongoClusterReplicationProperties replica = default;
            string infrastructureVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    createMode = new MongoClusterCreateMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("restoreParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restoreParameters = MongoClusterRestoreContent.DeserializeMongoClusterRestoreContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("replicaParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicaParameters = MongoClusterReplicaContent.DeserializeMongoClusterReplicaContent(property.Value, options);
                    continue;
                }
                if (property.NameEquals("administrator"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    administrator = AdministratorProperties.DeserializeAdministratorProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serverVersion"u8))
                {
                    serverVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectionString"u8))
                {
                    connectionString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new MongoClusterProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("clusterStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clusterStatus = new MongoClusterStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("publicNetworkAccess"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicNetworkAccess = new PublicNetworkAccess(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("highAvailability"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailability = HighAvailabilityProperties.DeserializeHighAvailabilityProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("storage"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storage = StorageProperties.DeserializeStorageProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("sharding"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sharding = ShardingProperties.DeserializeShardingProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("compute"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    compute = ComputeProperties.DeserializeComputeProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("backup"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    backup = BackupProperties.DeserializeBackupProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("privateEndpointConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MongoClusterPrivateEndpointConnection> array = new List<MongoClusterPrivateEndpointConnection>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MongoClusterPrivateEndpointConnection.DeserializeMongoClusterPrivateEndpointConnection(item, options));
                    }
                    privateEndpointConnections = array;
                    continue;
                }
                if (property.NameEquals("previewFeatures"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MongoClusterPreviewFeature> array = new List<MongoClusterPreviewFeature>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new MongoClusterPreviewFeature(item.GetString()));
                    }
                    previewFeatures = array;
                    continue;
                }
                if (property.NameEquals("replica"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replica = MongoClusterReplicationProperties.DeserializeMongoClusterReplicationProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("infrastructureVersion"u8))
                {
                    infrastructureVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new MongoClusterProperties(
                createMode,
                restoreParameters,
                replicaParameters,
                administrator,
                serverVersion,
                connectionString,
                provisioningState,
                clusterStatus,
                publicNetworkAccess,
                highAvailability,
                storage,
                sharding,
                compute,
                backup,
                privateEndpointConnections ?? new ChangeTrackingList<MongoClusterPrivateEndpointConnection>(),
                previewFeatures ?? new ChangeTrackingList<MongoClusterPreviewFeature>(),
                replica,
                infrastructureVersion,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MongoClusterProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MongoClusterProperties)} does not support writing '{options.Format}' format.");
            }
        }

        MongoClusterProperties IPersistableModel<MongoClusterProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MongoClusterProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMongoClusterProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MongoClusterProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<MongoClusterProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
