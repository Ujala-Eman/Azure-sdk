// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class VirtualMachineScaleSetVMProfile : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(OsProfile))
            {
                writer.WritePropertyName("osProfile");
                writer.WriteObjectValue(OsProfile);
            }
            if (Optional.IsDefined(StorageProfile))
            {
                writer.WritePropertyName("storageProfile");
                writer.WriteObjectValue(StorageProfile);
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
            if (Optional.IsDefined(ExtensionProfile))
            {
                writer.WritePropertyName("extensionProfile");
                writer.WriteObjectValue(ExtensionProfile);
            }
            if (Optional.IsDefined(LicenseType))
            {
                writer.WritePropertyName("licenseType");
                writer.WriteStringValue(LicenseType);
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
            if (Optional.IsDefined(ScheduledEventsProfile))
            {
                writer.WritePropertyName("scheduledEventsProfile");
                writer.WriteObjectValue(ScheduledEventsProfile);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineScaleSetVMProfile DeserializeVirtualMachineScaleSetVMProfile(JsonElement element)
        {
            Optional<VirtualMachineScaleSetOSProfile> osProfile = default;
            Optional<VirtualMachineScaleSetStorageProfile> storageProfile = default;
            Optional<VirtualMachineScaleSetNetworkProfile> networkProfile = default;
            Optional<DiagnosticsProfile> diagnosticsProfile = default;
            Optional<VirtualMachineScaleSetExtensionProfile> extensionProfile = default;
            Optional<string> licenseType = default;
            Optional<VirtualMachinePriorityTypes> priority = default;
            Optional<VirtualMachineEvictionPolicyTypes> evictionPolicy = default;
            Optional<BillingProfile> billingProfile = default;
            Optional<ScheduledEventsProfile> scheduledEventsProfile = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("osProfile"))
                {
                    osProfile = VirtualMachineScaleSetOSProfile.DeserializeVirtualMachineScaleSetOSProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("storageProfile"))
                {
                    storageProfile = VirtualMachineScaleSetStorageProfile.DeserializeVirtualMachineScaleSetStorageProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("networkProfile"))
                {
                    networkProfile = VirtualMachineScaleSetNetworkProfile.DeserializeVirtualMachineScaleSetNetworkProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("diagnosticsProfile"))
                {
                    diagnosticsProfile = DiagnosticsProfile.DeserializeDiagnosticsProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("extensionProfile"))
                {
                    extensionProfile = VirtualMachineScaleSetExtensionProfile.DeserializeVirtualMachineScaleSetExtensionProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("licenseType"))
                {
                    licenseType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    priority = new VirtualMachinePriorityTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("evictionPolicy"))
                {
                    evictionPolicy = new VirtualMachineEvictionPolicyTypes(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("billingProfile"))
                {
                    billingProfile = BillingProfile.DeserializeBillingProfile(property.Value);
                    continue;
                }
                if (property.NameEquals("scheduledEventsProfile"))
                {
                    scheduledEventsProfile = ScheduledEventsProfile.DeserializeScheduledEventsProfile(property.Value);
                    continue;
                }
            }
            return new VirtualMachineScaleSetVMProfile(osProfile.HasValue ? osProfile.Value : null, storageProfile.HasValue ? storageProfile.Value : null, networkProfile.HasValue ? networkProfile.Value : null, diagnosticsProfile.HasValue ? diagnosticsProfile.Value : null, extensionProfile.HasValue ? extensionProfile.Value : null, licenseType.HasValue ? licenseType.Value : null, priority.HasValue ? priority.Value : (VirtualMachinePriorityTypes?)null, evictionPolicy.HasValue ? evictionPolicy.Value : (VirtualMachineEvictionPolicyTypes?)null, billingProfile.HasValue ? billingProfile.Value : null, scheduledEventsProfile.HasValue ? scheduledEventsProfile.Value : null);
        }
    }
}
