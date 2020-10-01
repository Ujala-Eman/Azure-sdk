// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachine : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan");
                writer.WriteObjectValue(Plan);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones");
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(HardwareProfile))
            {
                writer.WritePropertyName("hardwareProfile");
                writer.WriteObjectValue(HardwareProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
            }
            if (Optional.IsDefined(AdditionalCapabilities))
            {
                writer.WritePropertyName("additionalCapabilities");
                writer.WriteObjectValue(AdditionalCapabilities);
            }
            if (Optional.IsDefined(OsProfile))
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OsProfile);
            }
            if (Optional.IsDefined(NetworkProfile))
            {
                writer.WritePropertyName("networkProfile");
                writer.WriteObjectValue(NetworkProfile);
            }
            if (Optional.IsDefined(DiagnosticsProfile))
            {
                writer.WritePropertyName("diagnosticsProfile");
                writer.WriteObjectValue(DiagnosticsProfile);
            }
            if (Optional.IsDefined(AvailabilitySet))
            {
                writer.WritePropertyName("availabilitySet");
                writer.WriteObjectValue(AvailabilitySet);
            }
            if (Optional.IsDefined(VirtualMachineScaleSet))
            {
                writer.WritePropertyName("virtualMachineScaleSet");
                writer.WriteObjectValue(VirtualMachineScaleSet);
            }
            if (Optional.IsDefined(ProximityPlacementGroup))
            {
                writer.WritePropertyName("proximityPlacementGroup");
                writer.WriteObjectValue(ProximityPlacementGroup);
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteStringValue(Priority.Value.ToString());
            }
            if (Optional.IsDefined(EvictionPolicy))
            {
                writer.WritePropertyName("evictionPolicy");
                writer.WriteStringValue(EvictionPolicy.Value.ToString());
            }
            if (Optional.IsDefined(BillingProfile))
            {
                writer.WritePropertyName("billingProfile");
                writer.WriteObjectValue(BillingProfile);
            }
            if (Optional.IsDefined(Host))
            {
                writer.WritePropertyName("host");
                writer.WriteObjectValue(Host);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachine DeserializeVirtualMachine(JsonElement element)
        {
            Optional<Plan> plan = default;
            Optional<IReadOnlyList<VirtualMachineExtension>> resources = default;
            Optional<VirtualMachineIdentity> identity = default;
            Optional<IList<string>> zones = default;
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<HardwareProfile> hardwareProfile = default;
            Optional<StorageProfile> storageProfile = default;
            Optional<AdditionalCapabilities> additionalCapabilities = default;
            Optional<OSProfile> osProfile = default;
            Optional<NetworkProfile> networkProfile = default;
            Optional<DiagnosticsProfile> diagnosticsProfile = default;
            Optional<SubResource> availabilitySet = default;
            Optional<SubResource> virtualMachineScaleSet = default;
            Optional<SubResource> proximityPlacementGroup = default;
            Optional<VirtualMachinePriorityTypes> priority = default;
            Optional<VirtualMachineEvictionPolicyTypes> evictionPolicy = default;
            Optional<BillingProfile> billingProfile = default;
            Optional<SubResource> host = default;
            Optional<string> provisioningState = default;
            Optional<VirtualMachineInstanceView> instanceView = default;
            Optional<string> licenseType = default;
            Optional<string> vmId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("plan"))
                {
                    plan = Plan.DeserializePlan(property.Value);
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    List<VirtualMachineExtension> array = new List<VirtualMachineExtension>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VirtualMachineExtension.DeserializeVirtualMachineExtension(item));
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    identity = VirtualMachineIdentity.DeserializeVirtualMachineIdentity(property.Value);
                    continue;
                }
                if (property.NameEquals("zones"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    zones = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("hardwareProfile"))
                        {
                            hardwareProfile = HardwareProfile.DeserializeHardwareProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("storageProfile"))
                        {
                            storageProfile = StorageProfile.DeserializeStorageProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("additionalCapabilities"))
                        {
                            additionalCapabilities = AdditionalCapabilities.DeserializeAdditionalCapabilities(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osProfile"))
                        {
                            osProfile = OSProfile.DeserializeOSProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("networkProfile"))
                        {
                            networkProfile = NetworkProfile.DeserializeNetworkProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("diagnosticsProfile"))
                        {
                            diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("availabilitySet"))
                        {
                            availabilitySet = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("virtualMachineScaleSet"))
                        {
                            virtualMachineScaleSet = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("proximityPlacementGroup"))
                        {
                            proximityPlacementGroup = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("priority"))
                        {
                            priority = new VirtualMachinePriorityTypes(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("evictionPolicy"))
                        {
                            evictionPolicy = new VirtualMachineEvictionPolicyTypes(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("billingProfile"))
                        {
                            billingProfile = BillingProfile.DeserializeBillingProfile(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("host"))
                        {
                            host = SubResource.DeserializeSubResource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("instanceView"))
                        {
                            instanceView = VirtualMachineInstanceView.DeserializeVirtualMachineInstanceView(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("licenseType"))
                        {
                            licenseType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vmId"))
                        {
                            vmId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachine(id.Value, name.Value, type.Value, location, Optional.ToDictionary(tags), plan.Value, Optional.ToList(resources), identity.Value, Optional.ToList(zones), hardwareProfile.Value, storageProfile.Value, additionalCapabilities.Value, osProfile.Value, networkProfile.Value, diagnosticsProfile.Value, availabilitySet.Value, virtualMachineScaleSet.Value, proximityPlacementGroup.Value, Optional.ToNullable(priority), Optional.ToNullable(evictionPolicy), billingProfile.Value, host.Value, provisioningState.Value, instanceView.Value, licenseType.Value, vmId.Value);
        }
    }
}
