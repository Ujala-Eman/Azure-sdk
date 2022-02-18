// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes a Virtual Machine Update. </summary>
    public partial class VirtualMachineUpdateOptions : UpdateResource
    {
        /// <summary> Initializes a new instance of VirtualMachineUpdateOptions. </summary>
        public VirtualMachineUpdateOptions()
        {
            Zones = new ChangeTrackingList<string>();
        }

        /// <summary> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </summary>
        public Plan Plan { get; set; }
        /// <summary> The identity of the virtual machine, if configured. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The virtual machine zones. </summary>
        public IList<string> Zones { get; }
        /// <summary> Specifies the hardware settings for the virtual machine. </summary>
        public HardwareProfile HardwareProfile { get; set; }
        /// <summary> Specifies the storage settings for the virtual machine disks. </summary>
        public StorageProfile StorageProfile { get; set; }
        /// <summary> Specifies additional capabilities enabled or disabled on the virtual machine. </summary>
        public AdditionalCapabilities AdditionalCapabilities { get; set; }
        /// <summary> Specifies the operating system settings used while creating the virtual machine. Some of the settings cannot be changed once VM is provisioned. </summary>
        public OSProfile OSProfile { get; set; }
        /// <summary> Specifies the network interfaces of the virtual machine. </summary>
        public NetworkProfile NetworkProfile { get; set; }
        /// <summary> Specifies the Security related profile settings for the virtual machine. </summary>
        public SecurityProfile SecurityProfile { get; set; }
        /// <summary> Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15. </summary>
        public DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary> Specifies information about the availability set that the virtual machine should be assigned to. Virtual machines specified in the same availability set are allocated to different nodes to maximize availability. For more information about availability sets, see [Availability sets overview](https://docs.microsoft.com/azure/virtual-machines/availability-set-overview). &lt;br&gt;&lt;br&gt; For more information on Azure planned maintenance, see [Maintenance and updates for Virtual Machines in Azure](https://docs.microsoft.com/azure/virtual-machines/maintenance-and-updates) &lt;br&gt;&lt;br&gt; Currently, a VM can only be added to availability set at creation time. The availability set to which the VM is being added should be under the same resource group as the availability set resource. An existing VM cannot be added to an availability set. &lt;br&gt;&lt;br&gt;This property cannot exist along with a non-null properties.virtualMachineScaleSet reference. </summary>
        public WritableSubResource AvailabilitySet { get; set; }
        /// <summary> Specifies information about the virtual machine scale set that the virtual machine should be assigned to. Virtual machines specified in the same virtual machine scale set are allocated to different nodes to maximize availability. Currently, a VM can only be added to virtual machine scale set at creation time. An existing VM cannot be added to a virtual machine scale set. &lt;br&gt;&lt;br&gt;This property cannot exist along with a non-null properties.availabilitySet reference. &lt;br&gt;&lt;br&gt;Minimum api‐version: 2019‐03‐01. </summary>
        public WritableSubResource VirtualMachineScaleSet { get; set; }
        /// <summary> Specifies information about the proximity placement group that the virtual machine should be assigned to. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-04-01. </summary>
        public WritableSubResource ProximityPlacementGroup { get; set; }
        /// <summary> Specifies the priority for the virtual machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public VirtualMachinePriorityTypes? Priority { get; set; }
        /// <summary> Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both &apos;Deallocate&apos; and &apos;Delete&apos; are supported and the minimum api-version is 2017-10-30-preview. </summary>
        public VirtualMachineEvictionPolicyTypes? EvictionPolicy { get; set; }
        /// <summary> Specifies the billing related details of a Azure Spot virtual machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01. </summary>
        public BillingProfile BillingProfile { get; set; }
        /// <summary> Specifies information about the dedicated host that the virtual machine resides in. &lt;br&gt;&lt;br&gt;Minimum api-version: 2018-10-01. </summary>
        public WritableSubResource Host { get; set; }
        /// <summary> Specifies information about the dedicated host group that the virtual machine resides in. &lt;br&gt;&lt;br&gt;Minimum api-version: 2020-06-01. &lt;br&gt;&lt;br&gt;NOTE: User cannot specify both host and hostGroup properties. </summary>
        public WritableSubResource HostGroup { get; set; }
        /// <summary> The provisioning state, which only appears in the response. </summary>
        public string ProvisioningState { get; }
        /// <summary> The virtual machine instance view. </summary>
        public VirtualMachineInstanceView InstanceView { get; }
        /// <summary> Specifies that the image or disk that is being used was licensed on-premises. &lt;br&gt;&lt;br&gt; Possible values for Windows Server operating system are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; Possible values for Linux Server operating system are: &lt;br&gt;&lt;br&gt; RHEL_BYOS (for RHEL) &lt;br&gt;&lt;br&gt; SLES_BYOS (for SUSE) &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/windows/hybrid-use-benefit-licensing) &lt;br&gt;&lt;br&gt; [Azure Hybrid Use Benefit for Linux Server](https://docs.microsoft.com/azure/virtual-machines/linux/azure-hybrid-benefit-linux) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </summary>
        public string LicenseType { get; set; }
        /// <summary> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </summary>
        public string VmId { get; }
        /// <summary> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). &lt;br&gt;&lt;br&gt; Minimum api-version: 2020-06-01. </summary>
        public string ExtensionsTimeBudget { get; set; }
        /// <summary> Specifies the scale set logical fault domain into which the Virtual Machine will be created. By default, the Virtual Machine will by automatically assigned to a fault domain that best maintains balance across available fault domains.&lt;br&gt;&lt;li&gt;This is applicable only if the &apos;virtualMachineScaleSet&apos; property of this Virtual Machine is set.&lt;li&gt;The Virtual Machine Scale Set that is referenced, must have &apos;platformFaultDomainCount&apos; &amp;gt; 1.&lt;li&gt;This property cannot be updated once the Virtual Machine is created.&lt;li&gt;Fault domain assignment can be viewed in the Virtual Machine Instance View.&lt;br&gt;&lt;br&gt;Minimum api‐version: 2020‐12‐01. </summary>
        public int? PlatformFaultDomain { get; set; }
        /// <summary> Specifies Scheduled Event related configurations. </summary>
        public ScheduledEventsProfile ScheduledEventsProfile { get; set; }
        /// <summary> UserData for the VM, which must be base-64 encoded. Customer should not pass any secrets in here. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-03-01. </summary>
        public string UserData { get; set; }
        /// <summary> Specifies information about the capacity reservation that is used to allocate virtual machine. &lt;br&gt;&lt;br&gt;Minimum api-version: 2021-04-01. </summary>
        public CapacityReservationProfile CapacityReservation { get; set; }
        /// <summary> Specifies the gallery applications that should be made available to the VM/VMSS. </summary>
        public ApplicationProfile ApplicationProfile { get; set; }
    }
}
