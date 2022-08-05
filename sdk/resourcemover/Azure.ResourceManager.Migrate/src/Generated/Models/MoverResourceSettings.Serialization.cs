// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Migrate.Models
{
    public partial class MoverResourceSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("resourceType");
            writer.WriteStringValue(ResourceType);
            writer.WritePropertyName("targetResourceName");
            writer.WriteStringValue(TargetResourceName);
            writer.WriteEndObject();
        }

        internal static MoverResourceSettings DeserializeMoverResourceSettings(JsonElement element)
        {
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Microsoft.Compute/availabilitySets": return MoverAvailabilitySetResourceSettings.DeserializeMoverAvailabilitySetResourceSettings(element);
                    case "Microsoft.Compute/diskEncryptionSets": return DiskEncryptionSetResourceSettings.DeserializeDiskEncryptionSetResourceSettings(element);
                    case "Microsoft.Compute/virtualMachines": return VirtualMachineResourceSettings.DeserializeVirtualMachineResourceSettings(element);
                    case "Microsoft.KeyVault/vaults": return KeyVaultResourceSettings.DeserializeKeyVaultResourceSettings(element);
                    case "Microsoft.Network/loadBalancers": return LoadBalancerResourceSettings.DeserializeLoadBalancerResourceSettings(element);
                    case "Microsoft.Network/networkInterfaces": return NetworkInterfaceResourceSettings.DeserializeNetworkInterfaceResourceSettings(element);
                    case "Microsoft.Network/networkSecurityGroups": return NetworkSecurityGroupResourceSettings.DeserializeNetworkSecurityGroupResourceSettings(element);
                    case "Microsoft.Network/publicIPAddresses": return PublicIPAddressResourceSettings.DeserializePublicIPAddressResourceSettings(element);
                    case "Microsoft.Network/virtualNetworks": return VirtualNetworkResourceSettings.DeserializeVirtualNetworkResourceSettings(element);
                    case "Microsoft.Sql/servers": return SqlServerResourceSettings.DeserializeSqlServerResourceSettings(element);
                    case "Microsoft.Sql/servers/databases": return SqlDatabaseResourceSettings.DeserializeSqlDatabaseResourceSettings(element);
                    case "Microsoft.Sql/servers/elasticPools": return SqlElasticPoolResourceSettings.DeserializeSqlElasticPoolResourceSettings(element);
                    case "resourceGroups": return ResourceGroupResourceSettings.DeserializeResourceGroupResourceSettings(element);
                }
            }
            string resourceType = default;
            string targetResourceName = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
            }
            return new MoverResourceSettings(resourceType, targetResourceName);
        }
    }
}
