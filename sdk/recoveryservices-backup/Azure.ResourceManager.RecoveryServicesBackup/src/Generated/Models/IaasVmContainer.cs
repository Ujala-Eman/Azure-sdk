// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// IaaS VM workload-specific container.
    /// Please note <see cref="IaasVmContainer"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="IaasClassicComputeVmContainer"/> and <see cref="IaasComputeVmContainer"/>.
    /// </summary>
    public partial class IaasVmContainer : BackupGenericProtectionContainer
    {
        /// <summary> Initializes a new instance of <see cref="IaasVmContainer"/>. </summary>
        public IaasVmContainer()
        {
            ContainerType = ProtectableContainerType.IaasVmContainer;
        }

        /// <summary> Initializes a new instance of <see cref="IaasVmContainer"/>. </summary>
        /// <param name="friendlyName"> Friendly name of the container. </param>
        /// <param name="backupManagementType"> Type of backup management for the container. </param>
        /// <param name="registrationStatus"> Status of registration of the container with the Recovery Services Vault. </param>
        /// <param name="healthStatus"> Status of health of the container. </param>
        /// <param name="containerType">
        /// Type of the container. The value of this property for: 1. Compute Azure VM is Microsoft.Compute/virtualMachines 2.
        /// Classic Compute Azure VM is Microsoft.ClassicCompute/virtualMachines 3. Windows machines (like MAB, DPM etc) is
        /// Windows 4. Azure SQL instance is AzureSqlContainer. 5. Storage containers is StorageContainer. 6. Azure workload
        /// Backup is VMAppContainer
        /// </param>
        /// <param name="protectableObjectType"> Type of the protectable object associated with this container. </param>
        /// <param name="virtualMachineId"> Fully qualified ARM url of the virtual machine represented by this Azure IaaS VM container. </param>
        /// <param name="virtualMachineVersion"> Specifies whether the container represents a Classic or an Azure Resource Manager VM. </param>
        /// <param name="resourceGroup"> Resource group name of Recovery Services Vault. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal IaasVmContainer(string friendlyName, BackupManagementType? backupManagementType, string registrationStatus, string healthStatus, ProtectableContainerType containerType, string protectableObjectType, ResourceIdentifier virtualMachineId, string virtualMachineVersion, string resourceGroup, Dictionary<string, BinaryData> rawData) : base(friendlyName, backupManagementType, registrationStatus, healthStatus, containerType, protectableObjectType, rawData)
        {
            VirtualMachineId = virtualMachineId;
            VirtualMachineVersion = virtualMachineVersion;
            ResourceGroup = resourceGroup;
            ContainerType = containerType;
        }

        /// <summary> Fully qualified ARM url of the virtual machine represented by this Azure IaaS VM container. </summary>
        public ResourceIdentifier VirtualMachineId { get; set; }
        /// <summary> Specifies whether the container represents a Classic or an Azure Resource Manager VM. </summary>
        public string VirtualMachineVersion { get; set; }
        /// <summary> Resource group name of Recovery Services Vault. </summary>
        public string ResourceGroup { get; set; }
    }
}
