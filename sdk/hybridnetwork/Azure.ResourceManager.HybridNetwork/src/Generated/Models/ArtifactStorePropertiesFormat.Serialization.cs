// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class ArtifactStorePropertiesFormat : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(StoreType))
            {
                writer.WritePropertyName("storeType"u8);
                writer.WriteStringValue(StoreType.Value.ToString());
            }
            if (Optional.IsDefined(ReplicationStrategy))
            {
                writer.WritePropertyName("replicationStrategy"u8);
                writer.WriteStringValue(ReplicationStrategy.Value.ToString());
            }
            if (Optional.IsDefined(ManagedResourceGroupConfiguration))
            {
                writer.WritePropertyName("managedResourceGroupConfiguration"u8);
                writer.WriteObjectValue(ManagedResourceGroupConfiguration);
            }
            writer.WriteEndObject();
        }

        internal static ArtifactStorePropertiesFormat DeserializeArtifactStorePropertiesFormat(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<ArtifactStoreType> storeType = default;
            Optional<ArtifactReplicationStrategy> replicationStrategy = default;
            Optional<ArtifactStorePropertiesFormatManagedResourceGroupConfiguration> managedResourceGroupConfiguration = default;
            Optional<string> storageResourceId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("storeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storeType = new ArtifactStoreType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("replicationStrategy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    replicationStrategy = new ArtifactReplicationStrategy(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("managedResourceGroupConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    managedResourceGroupConfiguration = ArtifactStorePropertiesFormatManagedResourceGroupConfiguration.DeserializeArtifactStorePropertiesFormatManagedResourceGroupConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("storageResourceId"u8))
                {
                    storageResourceId = property.Value.GetString();
                    continue;
                }
            }
            return new ArtifactStorePropertiesFormat(Optional.ToNullable(provisioningState), Optional.ToNullable(storeType), Optional.ToNullable(replicationStrategy), managedResourceGroupConfiguration.Value, storageResourceId.Value);
        }
    }
}
