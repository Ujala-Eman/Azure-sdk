// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.ArcScVmm;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.ArcScVmm.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmArcScVmmModelFactory
    {
        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmServerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="credentials"> Credentials to connect to VMMServer. </param>
        /// <param name="fqdn"> Fqdn is the hostname/ip of the vmmServer. </param>
        /// <param name="port"> Port is the port on which the vmmServer is listening. </param>
        /// <param name="connectionStatus"> Gets or sets the connection status to the vmmServer. </param>
        /// <param name="errorMessage"> Gets or sets any error message if connection to vmmServer is having any issue. </param>
        /// <param name="uuid"> Unique ID of vmmServer. </param>
        /// <param name="version"> Version is the version of the vmmSever. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmServerData"/> instance for mocking. </returns>
        public static ScVmmServerData ScVmmServerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, VmmServerPropertiesCredentials credentials = null, string fqdn = null, int? port = null, string connectionStatus = null, string errorMessage = null, string uuid = null, string version = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ScVmmServerData(id, name, resourceType, systemData, tags, location, extendedLocation, credentials, fqdn, port, connectionStatus, errorMessage, uuid, version, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmCloudData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="uuid"> Unique ID of the cloud. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="cloudName"> Name of the cloud in VMMServer. </param>
        /// <param name="cloudCapacity"> Capacity of the cloud. </param>
        /// <param name="storageQoSPolicies"> List of QoS policies available for the cloud. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmCloudData"/> instance for mocking. </returns>
        public static ScVmmCloudData ScVmmCloudData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, string inventoryItemId = null, string uuid = null, string vmmServerId = null, string cloudName = null, CloudCapacity cloudCapacity = null, IEnumerable<StorageQoSPolicy> storageQoSPolicies = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            storageQoSPolicies ??= new List<StorageQoSPolicy>();

            return new ScVmmCloudData(id, name, resourceType, systemData, tags, location, extendedLocation, inventoryItemId, uuid, vmmServerId, cloudName, cloudCapacity, storageQoSPolicies?.ToList(), provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.CloudCapacity"/>. </summary>
        /// <param name="cpuCount"> CPUCount specifies the maximum number of CPUs that can be allocated in the cloud. </param>
        /// <param name="memoryMB"> MemoryMB specifies a memory usage limit in megabytes. </param>
        /// <param name="vmCount"> VMCount gives the max number of VMs that can be deployed in the cloud. </param>
        /// <returns> A new <see cref="Models.CloudCapacity"/> instance for mocking. </returns>
        public static CloudCapacity CloudCapacity(long? cpuCount = null, long? memoryMB = null, long? vmCount = null)
        {
            return new CloudCapacity(cpuCount, memoryMB, vmCount, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.StorageQoSPolicy"/>. </summary>
        /// <param name="name"> The name of the policy. </param>
        /// <param name="id"> The ID of the QoS policy. </param>
        /// <param name="iopsMaximum"> The maximum IO operations per second. </param>
        /// <param name="iopsMinimum"> The minimum IO operations per second. </param>
        /// <param name="bandwidthLimit"> The Bandwidth Limit for internet traffic. </param>
        /// <param name="policyId"> The underlying policy. </param>
        /// <returns> A new <see cref="Models.StorageQoSPolicy"/> instance for mocking. </returns>
        public static StorageQoSPolicy StorageQoSPolicy(string name = null, string id = null, long? iopsMaximum = null, long? iopsMinimum = null, long? bandwidthLimit = null, string policyId = null)
        {
            return new StorageQoSPolicy(name, id, iopsMaximum, iopsMinimum, bandwidthLimit, policyId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmVirtualNetworkData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="uuid"> Unique ID of the virtual network. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="networkName"> Name of the virtual network in vmmServer. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmVirtualNetworkData"/> instance for mocking. </returns>
        public static ScVmmVirtualNetworkData ScVmmVirtualNetworkData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, string inventoryItemId = null, string uuid = null, string vmmServerId = null, string networkName = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ScVmmVirtualNetworkData(id, name, resourceType, systemData, tags, location, extendedLocation, inventoryItemId, uuid, vmmServerId, networkName, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmVirtualMachineData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="cloudId"> ARM Id of the cloud resource to use for deploying the vm. </param>
        /// <param name="templateId"> ARM Id of the template resource to use for deploying the vm. </param>
        /// <param name="checkpointType"> Type of checkpoint supported for the vm. </param>
        /// <param name="checkpoints"> Checkpoints in the vm. </param>
        /// <param name="availabilitySets"> Availability Sets in vm. </param>
        /// <param name="osProfile"> OS properties. </param>
        /// <param name="hardwareProfile"> Hardware properties. </param>
        /// <param name="networkInterfaces"> Network properties. </param>
        /// <param name="storageDisks"> Storage properties. </param>
        /// <param name="vmName"> VMName is the name of VM on the SCVMM server. </param>
        /// <param name="uuid"> Unique ID of the virtual machine. </param>
        /// <param name="generation"> Gets or sets the generation for the vm. </param>
        /// <param name="powerState"> Gets the power state of the virtual machine. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmVirtualMachineData"/> instance for mocking. </returns>
        public static ScVmmVirtualMachineData ScVmmVirtualMachineData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, string inventoryItemId = null, string vmmServerId = null, string cloudId = null, string templateId = null, string checkpointType = null, IEnumerable<Checkpoint> checkpoints = null, IEnumerable<AvailabilitySetListItem> availabilitySets = null, OSProfile osProfile = null, HardwareProfile hardwareProfile = null, IEnumerable<NetworkInterfaces> networkInterfaces = null, IEnumerable<VirtualDisk> storageDisks = null, string vmName = null, string uuid = null, int? generation = null, string powerState = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            checkpoints ??= new List<Checkpoint>();
            availabilitySets ??= new List<AvailabilitySetListItem>();
            networkInterfaces ??= new List<NetworkInterfaces>();
            storageDisks ??= new List<VirtualDisk>();

            return new ScVmmVirtualMachineData(id, name, resourceType, systemData, tags, location, extendedLocation, inventoryItemId, vmmServerId, cloudId, templateId, checkpointType, checkpoints?.ToList(), availabilitySets?.ToList(), osProfile, hardwareProfile, networkInterfaces != null ? new NetworkProfile(networkInterfaces?.ToList(), serializedAdditionalRawData: null) : null, storageDisks != null ? new StorageProfile(storageDisks?.ToList(), serializedAdditionalRawData: null) : null, vmName, uuid, generation, powerState, provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.OSProfile"/>. </summary>
        /// <param name="adminPassword"> Admin password of the virtual machine. </param>
        /// <param name="computerName"> Gets or sets computer name. </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osName"> Gets or sets os name. </param>
        /// <returns> A new <see cref="Models.OSProfile"/> instance for mocking. </returns>
        public static OSProfile OSProfile(string adminPassword = null, string computerName = null, OSType? osType = null, string osName = null)
        {
            return new OSProfile(adminPassword, computerName, osType, osName, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.NetworkInterfaces"/>. </summary>
        /// <param name="name"> Gets or sets the name of the network interface. </param>
        /// <param name="displayName"> Gets the display name of the network interface as shown in the vmmServer. This is the fallback label for a NIC when the name is not set. </param>
        /// <param name="ipv4Addresses"> Gets or sets the nic ipv4 addresses. </param>
        /// <param name="ipv6Addresses"> Gets or sets the nic ipv6 addresses. </param>
        /// <param name="macAddress"> Gets or sets the nic MAC address. </param>
        /// <param name="virtualNetworkId"> Gets or sets the ARM Id of the Microsoft.ScVmm/virtualNetwork resource to connect the nic. </param>
        /// <param name="networkName"> Gets or sets the name of the virtual network in vmmServer that the nic is connected to. </param>
        /// <param name="ipv4AddressType"> Gets or sets the ipv4 address type. </param>
        /// <param name="ipv6AddressType"> Gets or sets the ipv6 address type. </param>
        /// <param name="macAddressType"> Gets or sets the mac address type. </param>
        /// <param name="nicId"> Gets or sets the nic id. </param>
        /// <returns> A new <see cref="Models.NetworkInterfaces"/> instance for mocking. </returns>
        public static NetworkInterfaces NetworkInterfaces(string name = null, string displayName = null, IEnumerable<string> ipv4Addresses = null, IEnumerable<string> ipv6Addresses = null, string macAddress = null, string virtualNetworkId = null, string networkName = null, AllocationMethod? ipv4AddressType = null, AllocationMethod? ipv6AddressType = null, AllocationMethod? macAddressType = null, string nicId = null)
        {
            ipv4Addresses ??= new List<string>();
            ipv6Addresses ??= new List<string>();

            return new NetworkInterfaces(name, displayName, ipv4Addresses?.ToList(), ipv6Addresses?.ToList(), macAddress, virtualNetworkId, networkName, ipv4AddressType, ipv6AddressType, macAddressType, nicId, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="Models.VirtualDisk"/>. </summary>
        /// <param name="name"> Gets or sets the name of the disk. </param>
        /// <param name="displayName"> Gets the display name of the virtual disk as shown in the vmmServer. This is the fallback label for a disk when the name is not set. </param>
        /// <param name="diskId"> Gets or sets the disk id. </param>
        /// <param name="diskSizeGB"> Gets or sets the disk total size. </param>
        /// <param name="maxDiskSizeGB"> Gets or sets the max disk size. </param>
        /// <param name="bus"> Gets or sets the disk bus. </param>
        /// <param name="lun"> Gets or sets the disk lun. </param>
        /// <param name="busType"> Gets or sets the disk bus type. </param>
        /// <param name="vhdType"> Gets or sets the disk vhd type. </param>
        /// <param name="volumeType"> Gets or sets the disk volume type. </param>
        /// <param name="vhdFormatType"> Gets the disk vhd format type. </param>
        /// <param name="templateDiskId"> Gets or sets the disk id in the template. </param>
        /// <param name="storageQoSPolicy"> The QoS policy for the disk. </param>
        /// <param name="createDiffDisk"> Gets or sets a value indicating diff disk. </param>
        /// <returns> A new <see cref="Models.VirtualDisk"/> instance for mocking. </returns>
        public static VirtualDisk VirtualDisk(string name = null, string displayName = null, string diskId = null, int? diskSizeGB = null, int? maxDiskSizeGB = null, int? bus = null, int? lun = null, string busType = null, string vhdType = null, string volumeType = null, string vhdFormatType = null, string templateDiskId = null, StorageQoSPolicyDetails storageQoSPolicy = null, CreateDiffDisk? createDiffDisk = null)
        {
            return new VirtualDisk(name, displayName, diskId, diskSizeGB, maxDiskSizeGB, bus, lun, busType, vhdType, volumeType, vhdFormatType, templateDiskId, storageQoSPolicy, createDiffDisk, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmVirtualMachineTemplateData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="inventoryItemId"> Gets or sets the inventory Item ID for the resource. </param>
        /// <param name="uuid"> Unique ID of the virtual machine template. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="osType"> Gets or sets the type of the os. </param>
        /// <param name="osName"> Gets or sets os name. </param>
        /// <param name="computerName"> Gets or sets computer name. </param>
        /// <param name="memoryMB"> MemoryMB is the desired size of a virtual machine's memory, in MB. </param>
        /// <param name="cpuCount"> Gets or sets the desired number of vCPUs for the vm. </param>
        /// <param name="limitCpuForMigration"> Gets or sets a value indicating whether to enable processor compatibility mode for live migration of VMs. </param>
        /// <param name="dynamicMemoryEnabled"> Gets or sets a value indicating whether to enable dynamic memory or not. </param>
        /// <param name="isCustomizable"> Gets or sets a value indicating whether the vm template is customizable or not. </param>
        /// <param name="dynamicMemoryMaxMB"> Gets or sets the max dynamic memory for the vm. </param>
        /// <param name="dynamicMemoryMinMB"> Gets or sets the min dynamic memory for the vm. </param>
        /// <param name="isHighlyAvailable"> Gets highly available property. </param>
        /// <param name="generation"> Gets or sets the generation for the vm. </param>
        /// <param name="networkInterfaces"> Gets or sets the network interfaces of the template. </param>
        /// <param name="disks"> Gets or sets the disks of the template. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmVirtualMachineTemplateData"/> instance for mocking. </returns>
        public static ScVmmVirtualMachineTemplateData ScVmmVirtualMachineTemplateData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, string inventoryItemId = null, string uuid = null, string vmmServerId = null, OSType? osType = null, string osName = null, string computerName = null, int? memoryMB = null, int? cpuCount = null, LimitCpuForMigration? limitCpuForMigration = null, DynamicMemoryEnabled? dynamicMemoryEnabled = null, IsCustomizable? isCustomizable = null, int? dynamicMemoryMaxMB = null, int? dynamicMemoryMinMB = null, string isHighlyAvailable = null, int? generation = null, IEnumerable<NetworkInterfaces> networkInterfaces = null, IEnumerable<VirtualDisk> disks = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();
            networkInterfaces ??= new List<NetworkInterfaces>();
            disks ??= new List<VirtualDisk>();

            return new ScVmmVirtualMachineTemplateData(id, name, resourceType, systemData, tags, location, extendedLocation, inventoryItemId, uuid, vmmServerId, osType, osName, computerName, memoryMB, cpuCount, limitCpuForMigration, dynamicMemoryEnabled, isCustomizable, dynamicMemoryMaxMB, dynamicMemoryMinMB, isHighlyAvailable, generation, networkInterfaces?.ToList(), disks?.ToList(), provisioningState, serializedAdditionalRawData: null);
        }

        /// <summary> Initializes a new instance of <see cref="ArcScVmm.ScVmmAvailabilitySetData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="extendedLocation"> The extended location. </param>
        /// <param name="availabilitySetName"> Name of the availability set. </param>
        /// <param name="vmmServerId"> ARM Id of the vmmServer resource in which this resource resides. </param>
        /// <param name="provisioningState"> Gets or sets the provisioning state. </param>
        /// <returns> A new <see cref="ArcScVmm.ScVmmAvailabilitySetData"/> instance for mocking. </returns>
        public static ScVmmAvailabilitySetData ScVmmAvailabilitySetData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ExtendedLocation extendedLocation = null, string availabilitySetName = null, string vmmServerId = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new ScVmmAvailabilitySetData(id, name, resourceType, systemData, tags, location, extendedLocation, availabilitySetName, vmmServerId, provisioningState, serializedAdditionalRawData: null);
        }
    }
}
