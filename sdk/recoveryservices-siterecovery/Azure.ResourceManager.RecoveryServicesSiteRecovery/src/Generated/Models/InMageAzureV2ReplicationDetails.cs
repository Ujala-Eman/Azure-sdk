// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageAzureV2 provider specific settings. </summary>
    public partial class InMageAzureV2ReplicationDetails : ReplicationProviderSpecificSettings
    {
        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ReplicationDetails"/>. </summary>
        internal InMageAzureV2ReplicationDetails()
        {
            ProtectedDisks = new ChangeTrackingList<InMageAzureV2ProtectedDiskDetails>();
            AzureVmDiskDetails = new ChangeTrackingList<SiteRecoveryVmDiskDetails>();
            VmNics = new ChangeTrackingList<VmNicDetails>();
            Datastores = new ChangeTrackingList<string>();
            ValidationErrors = new ChangeTrackingList<SiteRecoveryHealthError>();
            ProtectedManagedDisks = new ChangeTrackingList<InMageAzureV2ManagedDiskDetails>();
            TargetVmTags = new ChangeTrackingDictionary<string, string>();
            SeedManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetManagedDiskTags = new ChangeTrackingDictionary<string, string>();
            TargetNicTags = new ChangeTrackingDictionary<string, string>();
            SwitchProviderBlockingErrorDetails = new ChangeTrackingList<InMageAzureV2SwitchProviderBlockingErrorDetails>();
            InstanceType = "InMageAzureV2";
        }

        /// <summary> Initializes a new instance of <see cref="InMageAzureV2ReplicationDetails"/>. </summary>
        /// <param name="instanceType"> Gets the Instance type. </param>
        /// <param name="infrastructureVmId"> The infrastructure VM Id. </param>
        /// <param name="vCenterInfrastructureId"> The vCenter infrastructure Id. </param>
        /// <param name="protectionStage"> The protection stage. </param>
        /// <param name="vmId"> The virtual machine Id. </param>
        /// <param name="vmProtectionState"> The protection state for the vm. </param>
        /// <param name="vmProtectionStateDescription"> The protection state description for the vm. </param>
        /// <param name="resyncProgressPercentage"> The resync progress percentage. </param>
        /// <param name="rpoInSeconds"> The RPO in seconds. </param>
        /// <param name="compressedDataRateInMB"> The compressed data change rate in MB. </param>
        /// <param name="uncompressedDataRateInMB"> The uncompressed data change rate in MB. </param>
        /// <param name="ipAddress"> The source IP address. </param>
        /// <param name="agentVersion"> The agent version. </param>
        /// <param name="agentExpireOn"> Agent expiry date. </param>
        /// <param name="isAgentUpdateRequired"> A value indicating whether installed agent needs to be updated. </param>
        /// <param name="isRebootAfterUpdateRequired"> A value indicating whether the source server requires a restart after update. </param>
        /// <param name="lastHeartbeat"> The last heartbeat received from the source server. </param>
        /// <param name="processServerId"> The process server Id. </param>
        /// <param name="processServerName"> The process server name. </param>
        /// <param name="multiVmGroupId"> The multi vm group Id. </param>
        /// <param name="multiVmGroupName"> The multi vm group name. </param>
        /// <param name="multiVmSyncStatus"> A value indicating whether multi vm sync is enabled or disabled. </param>
        /// <param name="protectedDisks"> The list of protected disks. </param>
        /// <param name="diskResized"> A value indicating whether any disk is resized for this VM. </param>
        /// <param name="masterTargetId"> The master target Id. </param>
        /// <param name="sourceVmCpuCount"> The CPU count of the VM on the primary side. </param>
        /// <param name="sourceVmRamSizeInMB"> The RAM size of the VM on the primary side. </param>
        /// <param name="osType"> The type of the OS on the VM. </param>
        /// <param name="vhdName"> The OS disk VHD name. </param>
        /// <param name="osDiskId"> The id of the disk containing the OS. </param>
        /// <param name="azureVmDiskDetails"> Azure VM Disk details. </param>
        /// <param name="recoveryAzureVmName"> Recovery Azure given name. </param>
        /// <param name="recoveryAzureVmSize"> The Recovery Azure VM size. </param>
        /// <param name="recoveryAzureStorageAccount"> The recovery Azure storage account. </param>
        /// <param name="recoveryAzureLogStorageAccountId"> The ARM id of the log storage account used for replication. This will be set to null if no log storage account was provided during enable protection. </param>
        /// <param name="vmNics"> The PE Network details. </param>
        /// <param name="selectedRecoveryAzureNetworkId"> The selected recovery azure network Id. </param>
        /// <param name="selectedTfoAzureNetworkId"> The test failover virtual network. </param>
        /// <param name="selectedSourceNicId"> The selected source nic Id which will be used as the primary nic during failover. </param>
        /// <param name="discoveryType"> A value indicating the discovery type of the machine. Value can be vCenter or physical. </param>
        /// <param name="enableRdpOnTargetOption"> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </param>
        /// <param name="datastores"> The datastores of the on-premise machine. Value can be list of strings that contain datastore names. </param>
        /// <param name="targetVmId"> The ARM Id of the target Azure VM. This value will be null until the VM is failed over. Only after failure it will be populated with the ARM Id of the Azure VM. </param>
        /// <param name="recoveryAzureResourceGroupId"> The target resource group Id. </param>
        /// <param name="recoveryAvailabilitySetId"> The recovery availability set Id. </param>
        /// <param name="targetAvailabilityZone"> The target availability zone. </param>
        /// <param name="targetProximityPlacementGroupId"> The target proximity placement group Id. </param>
        /// <param name="useManagedDisks"> A value indicating whether managed disks should be used during failover. </param>
        /// <param name="licenseType"> License Type of the VM to be used. </param>
        /// <param name="sqlServerLicenseType"> The SQL Server license type. </param>
        /// <param name="validationErrors"> The validation errors of the on-premise machine Value can be list of validation errors. </param>
        /// <param name="lastRpoCalculatedOn"> The last RPO calculated time. </param>
        /// <param name="lastUpdateReceivedOn"> The last update time received from on-prem components. </param>
        /// <param name="replicaId"> The replica id of the protected item. </param>
        /// <param name="osVersion"> The OS Version of the protected item. </param>
        /// <param name="protectedManagedDisks"> The list of protected managed disks. </param>
        /// <param name="lastRecoveryPointReceived"> The last recovery point received time. </param>
        /// <param name="firmwareType"> The firmware type of this protected item. </param>
        /// <param name="azureVmGeneration"> The target generation for this protected item. </param>
        /// <param name="isAdditionalStatsAvailable"> A value indicating whether additional IR stats are available or not. </param>
        /// <param name="totalDataTransferred"> The total transferred data in bytes. </param>
        /// <param name="totalProgressHealth"> The progress health. </param>
        /// <param name="targetVmTags"> The target VM tags. </param>
        /// <param name="seedManagedDiskTags"> The tags for the seed managed disks. </param>
        /// <param name="targetManagedDiskTags"> The tags for the target managed disks. </param>
        /// <param name="targetNicTags"> The tags for the target NICs. </param>
        /// <param name="switchProviderBlockingErrorDetails"> The switch provider blocking error information. </param>
        /// <param name="switchProviderDetails"> The switch provider blocking error information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageAzureV2ReplicationDetails(string instanceType, string infrastructureVmId, string vCenterInfrastructureId, string protectionStage, string vmId, string vmProtectionState, string vmProtectionStateDescription, int? resyncProgressPercentage, long? rpoInSeconds, double? compressedDataRateInMB, double? uncompressedDataRateInMB, IPAddress ipAddress, string agentVersion, DateTimeOffset? agentExpireOn, string isAgentUpdateRequired, string isRebootAfterUpdateRequired, DateTimeOffset? lastHeartbeat, Guid? processServerId, string processServerName, string multiVmGroupId, string multiVmGroupName, string multiVmSyncStatus, IReadOnlyList<InMageAzureV2ProtectedDiskDetails> protectedDisks, string diskResized, string masterTargetId, int? sourceVmCpuCount, int? sourceVmRamSizeInMB, string osType, string vhdName, string osDiskId, IReadOnlyList<SiteRecoveryVmDiskDetails> azureVmDiskDetails, string recoveryAzureVmName, string recoveryAzureVmSize, string recoveryAzureStorageAccount, ResourceIdentifier recoveryAzureLogStorageAccountId, IReadOnlyList<VmNicDetails> vmNics, ResourceIdentifier selectedRecoveryAzureNetworkId, ResourceIdentifier selectedTfoAzureNetworkId, string selectedSourceNicId, string discoveryType, string enableRdpOnTargetOption, IReadOnlyList<string> datastores, string targetVmId, ResourceIdentifier recoveryAzureResourceGroupId, ResourceIdentifier recoveryAvailabilitySetId, string targetAvailabilityZone, ResourceIdentifier targetProximityPlacementGroupId, string useManagedDisks, string licenseType, string sqlServerLicenseType, IReadOnlyList<SiteRecoveryHealthError> validationErrors, DateTimeOffset? lastRpoCalculatedOn, DateTimeOffset? lastUpdateReceivedOn, string replicaId, string osVersion, IReadOnlyList<InMageAzureV2ManagedDiskDetails> protectedManagedDisks, DateTimeOffset? lastRecoveryPointReceived, string firmwareType, string azureVmGeneration, bool? isAdditionalStatsAvailable, long? totalDataTransferred, string totalProgressHealth, IReadOnlyDictionary<string, string> targetVmTags, IReadOnlyDictionary<string, string> seedManagedDiskTags, IReadOnlyDictionary<string, string> targetManagedDiskTags, IReadOnlyDictionary<string, string> targetNicTags, IReadOnlyList<InMageAzureV2SwitchProviderBlockingErrorDetails> switchProviderBlockingErrorDetails, InMageAzureV2SwitchProviderDetails switchProviderDetails, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            InfrastructureVmId = infrastructureVmId;
            VCenterInfrastructureId = vCenterInfrastructureId;
            ProtectionStage = protectionStage;
            VmId = vmId;
            VmProtectionState = vmProtectionState;
            VmProtectionStateDescription = vmProtectionStateDescription;
            ResyncProgressPercentage = resyncProgressPercentage;
            RpoInSeconds = rpoInSeconds;
            CompressedDataRateInMB = compressedDataRateInMB;
            UncompressedDataRateInMB = uncompressedDataRateInMB;
            IPAddress = ipAddress;
            AgentVersion = agentVersion;
            AgentExpireOn = agentExpireOn;
            IsAgentUpdateRequired = isAgentUpdateRequired;
            IsRebootAfterUpdateRequired = isRebootAfterUpdateRequired;
            LastHeartbeat = lastHeartbeat;
            ProcessServerId = processServerId;
            ProcessServerName = processServerName;
            MultiVmGroupId = multiVmGroupId;
            MultiVmGroupName = multiVmGroupName;
            MultiVmSyncStatus = multiVmSyncStatus;
            ProtectedDisks = protectedDisks;
            DiskResized = diskResized;
            MasterTargetId = masterTargetId;
            SourceVmCpuCount = sourceVmCpuCount;
            SourceVmRamSizeInMB = sourceVmRamSizeInMB;
            OSType = osType;
            VhdName = vhdName;
            OSDiskId = osDiskId;
            AzureVmDiskDetails = azureVmDiskDetails;
            RecoveryAzureVmName = recoveryAzureVmName;
            RecoveryAzureVmSize = recoveryAzureVmSize;
            RecoveryAzureStorageAccount = recoveryAzureStorageAccount;
            RecoveryAzureLogStorageAccountId = recoveryAzureLogStorageAccountId;
            VmNics = vmNics;
            SelectedRecoveryAzureNetworkId = selectedRecoveryAzureNetworkId;
            SelectedTfoAzureNetworkId = selectedTfoAzureNetworkId;
            SelectedSourceNicId = selectedSourceNicId;
            DiscoveryType = discoveryType;
            EnableRdpOnTargetOption = enableRdpOnTargetOption;
            Datastores = datastores;
            TargetVmId = targetVmId;
            RecoveryAzureResourceGroupId = recoveryAzureResourceGroupId;
            RecoveryAvailabilitySetId = recoveryAvailabilitySetId;
            TargetAvailabilityZone = targetAvailabilityZone;
            TargetProximityPlacementGroupId = targetProximityPlacementGroupId;
            UseManagedDisks = useManagedDisks;
            LicenseType = licenseType;
            SqlServerLicenseType = sqlServerLicenseType;
            ValidationErrors = validationErrors;
            LastRpoCalculatedOn = lastRpoCalculatedOn;
            LastUpdateReceivedOn = lastUpdateReceivedOn;
            ReplicaId = replicaId;
            OSVersion = osVersion;
            ProtectedManagedDisks = protectedManagedDisks;
            LastRecoveryPointReceived = lastRecoveryPointReceived;
            FirmwareType = firmwareType;
            AzureVmGeneration = azureVmGeneration;
            IsAdditionalStatsAvailable = isAdditionalStatsAvailable;
            TotalDataTransferred = totalDataTransferred;
            TotalProgressHealth = totalProgressHealth;
            TargetVmTags = targetVmTags;
            SeedManagedDiskTags = seedManagedDiskTags;
            TargetManagedDiskTags = targetManagedDiskTags;
            TargetNicTags = targetNicTags;
            SwitchProviderBlockingErrorDetails = switchProviderBlockingErrorDetails;
            SwitchProviderDetails = switchProviderDetails;
            InstanceType = instanceType ?? "InMageAzureV2";
        }

        /// <summary> The infrastructure VM Id. </summary>
        public string InfrastructureVmId { get; }
        /// <summary> The vCenter infrastructure Id. </summary>
        public string VCenterInfrastructureId { get; }
        /// <summary> The protection stage. </summary>
        public string ProtectionStage { get; }
        /// <summary> The virtual machine Id. </summary>
        public string VmId { get; }
        /// <summary> The protection state for the vm. </summary>
        public string VmProtectionState { get; }
        /// <summary> The protection state description for the vm. </summary>
        public string VmProtectionStateDescription { get; }
        /// <summary> The resync progress percentage. </summary>
        public int? ResyncProgressPercentage { get; }
        /// <summary> The RPO in seconds. </summary>
        public long? RpoInSeconds { get; }
        /// <summary> The compressed data change rate in MB. </summary>
        public double? CompressedDataRateInMB { get; }
        /// <summary> The uncompressed data change rate in MB. </summary>
        public double? UncompressedDataRateInMB { get; }
        /// <summary> The source IP address. </summary>
        public IPAddress IPAddress { get; }
        /// <summary> The agent version. </summary>
        public string AgentVersion { get; }
        /// <summary> Agent expiry date. </summary>
        public DateTimeOffset? AgentExpireOn { get; }
        /// <summary> A value indicating whether installed agent needs to be updated. </summary>
        public string IsAgentUpdateRequired { get; }
        /// <summary> A value indicating whether the source server requires a restart after update. </summary>
        public string IsRebootAfterUpdateRequired { get; }
        /// <summary> The last heartbeat received from the source server. </summary>
        public DateTimeOffset? LastHeartbeat { get; }
        /// <summary> The process server Id. </summary>
        public Guid? ProcessServerId { get; }
        /// <summary> The process server name. </summary>
        public string ProcessServerName { get; }
        /// <summary> The multi vm group Id. </summary>
        public string MultiVmGroupId { get; }
        /// <summary> The multi vm group name. </summary>
        public string MultiVmGroupName { get; }
        /// <summary> A value indicating whether multi vm sync is enabled or disabled. </summary>
        public string MultiVmSyncStatus { get; }
        /// <summary> The list of protected disks. </summary>
        public IReadOnlyList<InMageAzureV2ProtectedDiskDetails> ProtectedDisks { get; }
        /// <summary> A value indicating whether any disk is resized for this VM. </summary>
        public string DiskResized { get; }
        /// <summary> The master target Id. </summary>
        public string MasterTargetId { get; }
        /// <summary> The CPU count of the VM on the primary side. </summary>
        public int? SourceVmCpuCount { get; }
        /// <summary> The RAM size of the VM on the primary side. </summary>
        public int? SourceVmRamSizeInMB { get; }
        /// <summary> The type of the OS on the VM. </summary>
        public string OSType { get; }
        /// <summary> The OS disk VHD name. </summary>
        public string VhdName { get; }
        /// <summary> The id of the disk containing the OS. </summary>
        public string OSDiskId { get; }
        /// <summary> Azure VM Disk details. </summary>
        public IReadOnlyList<SiteRecoveryVmDiskDetails> AzureVmDiskDetails { get; }
        /// <summary> Recovery Azure given name. </summary>
        public string RecoveryAzureVmName { get; }
        /// <summary> The Recovery Azure VM size. </summary>
        public string RecoveryAzureVmSize { get; }
        /// <summary> The recovery Azure storage account. </summary>
        public string RecoveryAzureStorageAccount { get; }
        /// <summary> The ARM id of the log storage account used for replication. This will be set to null if no log storage account was provided during enable protection. </summary>
        public ResourceIdentifier RecoveryAzureLogStorageAccountId { get; }
        /// <summary> The PE Network details. </summary>
        public IReadOnlyList<VmNicDetails> VmNics { get; }
        /// <summary> The selected recovery azure network Id. </summary>
        public ResourceIdentifier SelectedRecoveryAzureNetworkId { get; }
        /// <summary> The test failover virtual network. </summary>
        public ResourceIdentifier SelectedTfoAzureNetworkId { get; }
        /// <summary> The selected source nic Id which will be used as the primary nic during failover. </summary>
        public string SelectedSourceNicId { get; }
        /// <summary> A value indicating the discovery type of the machine. Value can be vCenter or physical. </summary>
        public string DiscoveryType { get; }
        /// <summary> The selected option to enable RDP\SSH on target vm after failover. String value of SrsDataContract.EnableRDPOnTargetOption enum. </summary>
        public string EnableRdpOnTargetOption { get; }
        /// <summary> The datastores of the on-premise machine. Value can be list of strings that contain datastore names. </summary>
        public IReadOnlyList<string> Datastores { get; }
        /// <summary> The ARM Id of the target Azure VM. This value will be null until the VM is failed over. Only after failure it will be populated with the ARM Id of the Azure VM. </summary>
        public string TargetVmId { get; }
        /// <summary> The target resource group Id. </summary>
        public ResourceIdentifier RecoveryAzureResourceGroupId { get; }
        /// <summary> The recovery availability set Id. </summary>
        public ResourceIdentifier RecoveryAvailabilitySetId { get; }
        /// <summary> The target availability zone. </summary>
        public string TargetAvailabilityZone { get; }
        /// <summary> The target proximity placement group Id. </summary>
        public ResourceIdentifier TargetProximityPlacementGroupId { get; }
        /// <summary> A value indicating whether managed disks should be used during failover. </summary>
        public string UseManagedDisks { get; }
        /// <summary> License Type of the VM to be used. </summary>
        public string LicenseType { get; }
        /// <summary> The SQL Server license type. </summary>
        public string SqlServerLicenseType { get; }
        /// <summary> The validation errors of the on-premise machine Value can be list of validation errors. </summary>
        public IReadOnlyList<SiteRecoveryHealthError> ValidationErrors { get; }
        /// <summary> The last RPO calculated time. </summary>
        public DateTimeOffset? LastRpoCalculatedOn { get; }
        /// <summary> The last update time received from on-prem components. </summary>
        public DateTimeOffset? LastUpdateReceivedOn { get; }
        /// <summary> The replica id of the protected item. </summary>
        public string ReplicaId { get; }
        /// <summary> The OS Version of the protected item. </summary>
        public string OSVersion { get; }
        /// <summary> The list of protected managed disks. </summary>
        public IReadOnlyList<InMageAzureV2ManagedDiskDetails> ProtectedManagedDisks { get; }
        /// <summary> The last recovery point received time. </summary>
        public DateTimeOffset? LastRecoveryPointReceived { get; }
        /// <summary> The firmware type of this protected item. </summary>
        public string FirmwareType { get; }
        /// <summary> The target generation for this protected item. </summary>
        public string AzureVmGeneration { get; }
        /// <summary> A value indicating whether additional IR stats are available or not. </summary>
        public bool? IsAdditionalStatsAvailable { get; }
        /// <summary> The total transferred data in bytes. </summary>
        public long? TotalDataTransferred { get; }
        /// <summary> The progress health. </summary>
        public string TotalProgressHealth { get; }
        /// <summary> The target VM tags. </summary>
        public IReadOnlyDictionary<string, string> TargetVmTags { get; }
        /// <summary> The tags for the seed managed disks. </summary>
        public IReadOnlyDictionary<string, string> SeedManagedDiskTags { get; }
        /// <summary> The tags for the target managed disks. </summary>
        public IReadOnlyDictionary<string, string> TargetManagedDiskTags { get; }
        /// <summary> The tags for the target NICs. </summary>
        public IReadOnlyDictionary<string, string> TargetNicTags { get; }
        /// <summary> The switch provider blocking error information. </summary>
        public IReadOnlyList<InMageAzureV2SwitchProviderBlockingErrorDetails> SwitchProviderBlockingErrorDetails { get; }
        /// <summary> The switch provider blocking error information. </summary>
        public InMageAzureV2SwitchProviderDetails SwitchProviderDetails { get; }
    }
}
