// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a virtual machine scale set virtual machine profile. </summary>
    public partial class VirtualMachineScaleSetVmProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        public VirtualMachineScaleSetVmProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        /// <param name="osProfile"> Specifies the operating system settings for the virtual machines in the scale set. </param>
        /// <param name="storageProfile"> Specifies the storage settings for the virtual machine disks. </param>
        /// <param name="networkProfile"> Specifies properties of the network interfaces of the virtual machines in the scale set. </param>
        /// <param name="securityProfile"> Specifies the Security related profile settings for the virtual machines in the scale set. </param>
        /// <param name="diagnosticsProfile"> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </param>
        /// <param name="extensionProfile"> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="priority"> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </param>
        /// <param name="evictionPolicy"> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </param>
        /// <param name="billingProfile"> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </param>
        /// <param name="scheduledEventsProfile"> Specifies Scheduled Event related configurations. </param>
        /// <param name="userData"> UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </param>
        /// <param name="capacityReservation"> Specifies the capacity reservation related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-04-01. </param>
        /// <param name="applicationProfile"> Specifies the gallery applications that should be made available to the VM/VMSS. </param>
        /// <param name="hardwareProfile"> Specifies the hardware profile related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2022-03-01. </param>
        internal VirtualMachineScaleSetVmProfile(VirtualMachineScaleSetOSProfile osProfile, VirtualMachineScaleSetStorageProfile storageProfile, VirtualMachineScaleSetNetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, VirtualMachineScaleSetExtensionProfile extensionProfile, string licenseType, VirtualMachinePriorityType? priority, VirtualMachineEvictionPolicyType? evictionPolicy, BillingProfile billingProfile, ScheduledEventsProfile scheduledEventsProfile, string userData, CapacityReservationProfile capacityReservation, ApplicationProfile applicationProfile, VirtualMachineScaleSetHardwareProfile hardwareProfile)
        {
            OSProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
            UserData = userData;
            CapacityReservation = capacityReservation;
            ApplicationProfile = applicationProfile;
            HardwareProfile = hardwareProfile;
        }

        /// <summary> Specifies the operating system settings for the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetOSProfile OSProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }
        /// <summary> Specifies properties of the network interfaces of the virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machines in the scale set. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        internal DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;**NOTE**: If storageUri is being specified then ensure that the storage account is in the same region and subscription as the VM. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnostics BootDiagnostics
        {
            get => DiagnosticsProfile is null ? default : DiagnosticsProfile.BootDiagnostics;
            set
            {
                if (DiagnosticsProfile is null)
                    DiagnosticsProfile = new DiagnosticsProfile();
                DiagnosticsProfile.BootDiagnostics = value;
            }
        }

        /// <summary> Specifies a collection of settings for extensions installed on virtual machines in the scale set. </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview. </summary>
        public VirtualMachinePriorityType? Priority { get; set; }
        /// <summary> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </summary>
        public VirtualMachineEvictionPolicyType? EvictionPolicy { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        internal BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS. This price is in US Dollars. &lt;br&gt;&lt;br&gt; This price will be compared with the current Azure Spot price for the VM size. Also, the prices are compared at the time of create/update of Azure Spot VM/VMSS and the operation will only succeed if  the maxPrice is greater than the current Azure Spot price. &lt;br&gt;&lt;br&gt; The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the maxPrice after creation of VM/VMSS. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; - Any decimal value greater than zero. Example: 0.01538 &lt;br&gt;&lt;br&gt; -1 – indicates default price to be up-to on-demand. &lt;br&gt;&lt;br&gt; You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons. Also, the default max price is -1 if it is not provided by you. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public double? BillingMaxPrice
        {
            get => BillingProfile is null ? default : BillingProfile.MaxPrice;
            set
            {
                if (BillingProfile is null)
                    BillingProfile = new BillingProfile();
                BillingProfile.MaxPrice = value;
            }
        }

        /// <summary> Specifies Scheduled Event related configurations. </summary>
        internal ScheduledEventsProfile ScheduledEventsProfile { get; set; }
        /// <summary> Specifies Terminate Scheduled Event related configurations. </summary>
        public TerminateNotificationProfile ScheduledEventsTerminateNotificationProfile
        {
            get => ScheduledEventsProfile is null ? default : ScheduledEventsProfile.TerminateNotificationProfile;
            set
            {
                if (ScheduledEventsProfile is null)
                    ScheduledEventsProfile = new ScheduledEventsProfile();
                ScheduledEventsProfile.TerminateNotificationProfile = value;
            }
        }

        /// <summary> UserData for the virtual machines in the scale set, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </summary>
        public string UserData { get; set; }
        /// <summary> Specifies the capacity reservation related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-04-01. </summary>
        internal CapacityReservationProfile CapacityReservation { get; set; }
        /// <summary> Gets or sets Id. </summary>
        public ResourceIdentifier CapacityReservationGroupId
        {
            get => CapacityReservation is null ? default : CapacityReservation.CapacityReservationGroupId;
            set
            {
                if (CapacityReservation is null)
                    CapacityReservation = new CapacityReservationProfile();
                CapacityReservation.CapacityReservationGroupId = value;
            }
        }

        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        internal ApplicationProfile ApplicationProfile { get; set; }
        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public IList<VmGalleryApplication> GalleryApplications
        {
            get
            {
                if (ApplicationProfile is null)
                    ApplicationProfile = new ApplicationProfile();
                return ApplicationProfile.GalleryApplications;
            }
        }

        /// <summary> Specifies the hardware profile related details of a scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2022-03-01. </summary>
        internal VirtualMachineScaleSetHardwareProfile HardwareProfile { get; set; }
        /// <summary> Specifies the properties for customizing the size of the virtual machine. Minimum api-version: 2022-03-01. &lt;br&gt;&lt;br&gt; Please follow the instructions in [VM Customization](https://aka.ms/vmcustomization) for more details. </summary>
        public VmSizeProperties HardwareVmSizeProperties
        {
            get => HardwareProfile is null ? default : HardwareProfile.VmSizeProperties;
            set
            {
                if (HardwareProfile is null)
                    HardwareProfile = new VirtualMachineScaleSetHardwareProfile();
                HardwareProfile.VmSizeProperties = value;
            }
        }
    }
}
