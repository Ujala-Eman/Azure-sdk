// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.ConnectedVMwarevSphere.Models;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ConnectedVMwarevSphere
{
    /// <summary> A class representing the VirtualMachineTemplate data model. </summary>
    public partial class VirtualMachineTemplateData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of VirtualMachineTemplateData. </summary>
        /// <param name="location"> The location. </param>
        public VirtualMachineTemplateData(AzureLocation location) : base(location)
        {
            NetworkInterfaces = new ChangeTrackingList<NetworkInterface>();
            Disks = new ChangeTrackingList<VirtualDisk>();
            Statuses = new ChangeTrackingList<ResourceStatus>();
        }

        /// <summary> Initializes a new instance of VirtualMachineTemplateData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> Gets or sets the extended location. </param>
        /// <param name="kind"> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </param>
        /// <param name="uuid"> Gets or sets a unique identifier for this resource. </param>
        /// <param name="vCenterId"> Gets or sets the ARM Id of the vCenter resource in which this template resides. </param>
        /// <param name="moRefId">
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual machine
        /// template.
        /// </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the virtual machine template. </param>
        /// <param name="moName"> Gets or sets the vCenter Managed Object name for the virtual machine template. </param>
        /// <param name="memorySizeMB"> Gets or sets memory size in MBs for the template. </param>
        /// <param name="numCpus"> Gets or sets the number of vCPUs for the template. </param>
        /// <param name="numCoresPerSocket">
        /// Gets or sets the number of cores per socket for the template.
        /// Defaults to 1 if unspecified.
        /// </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osName"> Gets or sets os name. </param>
        /// <param name="folderPath"> Gets or sets the folder path of the template. </param>
        /// <param name="networkInterfaces"> Gets or sets the network interfaces of the template. </param>
        /// <param name="disks"> Gets or sets the disks the template. </param>
        /// <param name="customResourceName"> Gets the name of the corresponding resource in Kubernetes. </param>
        /// <param name="toolsVersionStatus"> Gets or sets the current version status of VMware Tools installed in the guest operating system. </param>
        /// <param name="toolsVersion"> Gets or sets the current version of VMware Tools. </param>
        /// <param name="firmwareType"> Firmware type. </param>
        /// <param name="statuses"> The resource status information. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        internal VirtualMachineTemplateData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ExtendedLocation extendedLocation, string kind, string uuid, string vCenterId, string moRefId, string inventoryItemId, string moName, int? memorySizeMB, int? numCpus, int? numCoresPerSocket, OSType? osType, string osName, string folderPath, IReadOnlyList<NetworkInterface> networkInterfaces, IReadOnlyList<VirtualDisk> disks, string customResourceName, string toolsVersionStatus, string toolsVersion, FirmwareType? firmwareType, IReadOnlyList<ResourceStatus> statuses, string provisioningState) : base(id, name, resourceType, systemData, tags, location)
        {
            ExtendedLocation = extendedLocation;
            Kind = kind;
            Uuid = uuid;
            VCenterId = vCenterId;
            MoRefId = moRefId;
            InventoryItemId = inventoryItemId;
            MoName = moName;
            MemorySizeMB = memorySizeMB;
            NumCpus = numCpus;
            NumCoresPerSocket = numCoresPerSocket;
            OSType = osType;
            OSName = osName;
            FolderPath = folderPath;
            NetworkInterfaces = networkInterfaces;
            Disks = disks;
            CustomResourceName = customResourceName;
            ToolsVersionStatus = toolsVersionStatus;
            ToolsVersion = toolsVersion;
            FirmwareType = firmwareType;
            Statuses = statuses;
            ProvisioningState = provisioningState;
        }

        /// <summary> Gets or sets the extended location. </summary>
        public ExtendedLocation ExtendedLocation { get; set; }
        /// <summary> Metadata used by portal/tooling/etc to render different UX experiences for resources of the same type; e.g. ApiApps are a kind of Microsoft.Web/sites type.  If supported, the resource provider must validate and persist this value. </summary>
        public string Kind { get; set; }
        /// <summary> Gets or sets a unique identifier for this resource. </summary>
        public string Uuid { get; }
        /// <summary> Gets or sets the ARM Id of the vCenter resource in which this template resides. </summary>
        public string VCenterId { get; set; }
        /// <summary>
        /// Gets or sets the vCenter MoRef (Managed Object Reference) ID for the virtual machine
        /// template.
        /// </summary>
        public string MoRefId { get; set; }
        /// <summary> Gets or sets the inventory Item ID for the virtual machine template. </summary>
        public string InventoryItemId { get; set; }
        /// <summary> Gets or sets the vCenter Managed Object name for the virtual machine template. </summary>
        public string MoName { get; }
        /// <summary> Gets or sets memory size in MBs for the template. </summary>
        public int? MemorySizeMB { get; }
        /// <summary> Gets or sets the number of vCPUs for the template. </summary>
        public int? NumCpus { get; }
        /// <summary>
        /// Gets or sets the number of cores per socket for the template.
        /// Defaults to 1 if unspecified.
        /// </summary>
        public int? NumCoresPerSocket { get; }
        /// <summary> Gets or sets the type of the os. </summary>
        public OSType? OSType { get; }
        /// <summary> Gets or sets os name. </summary>
        public string OSName { get; }
        /// <summary> Gets or sets the folder path of the template. </summary>
        public string FolderPath { get; }
        /// <summary> Gets or sets the network interfaces of the template. </summary>
        public IReadOnlyList<NetworkInterface> NetworkInterfaces { get; }
        /// <summary> Gets or sets the disks the template. </summary>
        public IReadOnlyList<VirtualDisk> Disks { get; }
        /// <summary> Gets the name of the corresponding resource in Kubernetes. </summary>
        public string CustomResourceName { get; }
        /// <summary> Gets or sets the current version status of VMware Tools installed in the guest operating system. </summary>
        public string ToolsVersionStatus { get; }
        /// <summary> Gets or sets the current version of VMware Tools. </summary>
        public string ToolsVersion { get; }
        /// <summary> Firmware type. </summary>
        public FirmwareType? FirmwareType { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<ResourceStatus> Statuses { get; }
        /// <summary> Gets or sets the provisioning state. </summary>
        public string ProvisioningState { get; }
    }
}
