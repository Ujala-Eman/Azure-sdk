// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// IaaS VM workload-specific backup item.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureIaaSVMProtectedItem")]
    public partial class AzureIaaSVMProtectedItem : ProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMProtectedItem class.
        /// </summary>
        public AzureIaaSVMProtectedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureIaaSVMProtectedItem class.
        /// </summary>
        /// <param name="backupManagementType">Type of backup management for
        /// the backed up item. Possible values include: 'Invalid',
        /// 'AzureIaasVM', 'MAB', 'DPM', 'AzureBackupServer', 'AzureSql',
        /// 'AzureStorage', 'AzureWorkload', 'DefaultBackup'</param>
        /// <param name="workloadType">Type of workload this item represents.
        /// Possible values include: 'Invalid', 'VM', 'FileFolder',
        /// 'AzureSqlDb', 'SQLDB', 'Exchange', 'Sharepoint', 'VMwareVM',
        /// 'SystemState', 'Client', 'GenericDataSource', 'SQLDataBase',
        /// 'AzureFileShare', 'SAPHanaDatabase', 'SAPAseDatabase'</param>
        /// <param name="containerName">Unique name of container</param>
        /// <param name="sourceResourceId">ARM ID of the resource to be backed
        /// up.</param>
        /// <param name="policyId">ID of the backup policy with which this item
        /// is backed up.</param>
        /// <param name="lastRecoveryPoint">Timestamp when the last (latest)
        /// backup copy was created for this backup item.</param>
        /// <param name="backupSetName">Name of the backup set the backup item
        /// belongs to</param>
        /// <param name="createMode">Create mode to indicate recovery of
        /// existing soft deleted data source or creation of new data source.
        /// Possible values include: 'Invalid', 'Default', 'Recover'</param>
        /// <param name="deferredDeleteTimeInUTC">Time for deferred deletion in
        /// UTC</param>
        /// <param name="isScheduledForDeferredDelete">Flag to identify whether
        /// the DS is scheduled for deferred delete</param>
        /// <param name="deferredDeleteTimeRemaining">Time remaining before the
        /// DS marked for deferred delete is permanently deleted</param>
        /// <param name="isDeferredDeleteScheduleUpcoming">Flag to identify
        /// whether the deferred deleted DS is to be purged soon</param>
        /// <param name="isRehydrate">Flag to identify that deferred deleted DS
        /// is to be moved into Pause state</param>
        /// <param name="friendlyName">Friendly name of the VM represented by
        /// this backup item.</param>
        /// <param name="virtualMachineId">Fully qualified ARM ID of the
        /// virtual machine represented by this item.</param>
        /// <param name="protectionStatus">Backup status of this backup
        /// item.</param>
        /// <param name="protectionState">Backup state of this backup item.
        /// Possible values include: 'Invalid', 'IRPending', 'Protected',
        /// 'ProtectionError', 'ProtectionStopped', 'ProtectionPaused'</param>
        /// <param name="healthStatus">Health status of protected item.
        /// Possible values include: 'Passed', 'ActionRequired',
        /// 'ActionSuggested', 'Invalid'</param>
        /// <param name="healthDetails">Health details on this backup
        /// item.</param>
        /// <param name="kpisHealths">Health details of different KPIs</param>
        /// <param name="lastBackupStatus">Last backup operation
        /// status.</param>
        /// <param name="lastBackupTime">Timestamp of the last backup operation
        /// on this backup item.</param>
        /// <param name="protectedItemDataId">Data ID of the protected
        /// item.</param>
        /// <param name="extendedInfo">Additional information for this backup
        /// item.</param>
        public AzureIaaSVMProtectedItem(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string backupSetName = default(string), string createMode = default(string), System.DateTime? deferredDeleteTimeInUTC = default(System.DateTime?), bool? isScheduledForDeferredDelete = default(bool?), string deferredDeleteTimeRemaining = default(string), bool? isDeferredDeleteScheduleUpcoming = default(bool?), bool? isRehydrate = default(bool?), string friendlyName = default(string), string virtualMachineId = default(string), string protectionStatus = default(string), string protectionState = default(string), string healthStatus = default(string), IList<AzureIaaSVMHealthDetails> healthDetails = default(IList<AzureIaaSVMHealthDetails>), IDictionary<string, KPIResourceHealthDetails> kpisHealths = default(IDictionary<string, KPIResourceHealthDetails>), string lastBackupStatus = default(string), System.DateTime? lastBackupTime = default(System.DateTime?), string protectedItemDataId = default(string), AzureIaaSVMProtectedItemExtendedInfo extendedInfo = default(AzureIaaSVMProtectedItemExtendedInfo), ExtendedProperties extendedProperties = default(ExtendedProperties))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate)
        {
            FriendlyName = friendlyName;
            VirtualMachineId = virtualMachineId;
            ProtectionStatus = protectionStatus;
            ProtectionState = protectionState;
            HealthStatus = healthStatus;
            HealthDetails = healthDetails;
            KpisHealths = kpisHealths;
            LastBackupStatus = lastBackupStatus;
            LastBackupTime = lastBackupTime;
            ProtectedItemDataId = protectedItemDataId;
            ExtendedInfo = extendedInfo;
            ExtendedProperties = extendedProperties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the VM represented by this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets fully qualified ARM ID of the virtual machine
        /// represented by this item.
        /// </summary>
        [JsonProperty(PropertyName = "virtualMachineId")]
        public string VirtualMachineId { get; set; }

        /// <summary>
        /// Gets or sets backup status of this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "protectionStatus")]
        public string ProtectionStatus { get; set; }

        /// <summary>
        /// Gets or sets backup state of this backup item. Possible values
        /// include: 'Invalid', 'IRPending', 'Protected', 'ProtectionError',
        /// 'ProtectionStopped', 'ProtectionPaused'
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets health status of protected item. Possible values
        /// include: 'Passed', 'ActionRequired', 'ActionSuggested', 'Invalid'
        /// </summary>
        [JsonProperty(PropertyName = "healthStatus")]
        public string HealthStatus { get; set; }

        /// <summary>
        /// Gets or sets health details on this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "healthDetails")]
        public IList<AzureIaaSVMHealthDetails> HealthDetails { get; set; }

        /// <summary>
        /// Gets or sets health details of different KPIs
        /// </summary>
        [JsonProperty(PropertyName = "kpisHealths")]
        public IDictionary<string, KPIResourceHealthDetails> KpisHealths { get; set; }

        /// <summary>
        /// Gets or sets last backup operation status.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupStatus")]
        public string LastBackupStatus { get; set; }

        /// <summary>
        /// Gets or sets timestamp of the last backup operation on this backup
        /// item.
        /// </summary>
        [JsonProperty(PropertyName = "lastBackupTime")]
        public System.DateTime? LastBackupTime { get; set; }

        /// <summary>
        /// Gets or sets data ID of the protected item.
        /// </summary>
        [JsonProperty(PropertyName = "protectedItemDataId")]
        public string ProtectedItemDataId { get; set; }

        /// <summary>
        /// Gets or sets additional information for this backup item.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public AzureIaaSVMProtectedItemExtendedInfo ExtendedInfo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extendedProperties")]
        public ExtendedProperties ExtendedProperties { get; set; }

    }
}
