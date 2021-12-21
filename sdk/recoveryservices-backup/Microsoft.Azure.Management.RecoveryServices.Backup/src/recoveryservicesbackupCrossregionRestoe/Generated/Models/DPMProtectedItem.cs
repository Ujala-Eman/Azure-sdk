// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.CrossRegionRestore.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Additional information on Backup engine specific backup item.
    /// </summary>
    public partial class DPMProtectedItem : ProtectedItem
    {
        /// <summary>
        /// Initializes a new instance of the DPMProtectedItem class.
        /// </summary>
        public DPMProtectedItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DPMProtectedItem class.
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
        /// <param
        /// name="resourceGuardOperationRequests">ResourceGuardOperationRequests
        /// on which LAC check will be performed</param>
        /// <param name="friendlyName">Friendly name of the managed
        /// item</param>
        /// <param name="backupEngineName">Backup Management server protecting
        /// this backup item</param>
        /// <param name="protectionState">Protection state of the backup
        /// engine. Possible values include: 'Invalid', 'IRPending',
        /// 'Protected', 'ProtectionError', 'ProtectionStopped',
        /// 'ProtectionPaused'</param>
        /// <param name="extendedInfo">Extended info of the backup
        /// item.</param>
        public DPMProtectedItem(string backupManagementType = default(string), string workloadType = default(string), string containerName = default(string), string sourceResourceId = default(string), string policyId = default(string), System.DateTime? lastRecoveryPoint = default(System.DateTime?), string backupSetName = default(string), string createMode = default(string), System.DateTime? deferredDeleteTimeInUTC = default(System.DateTime?), bool? isScheduledForDeferredDelete = default(bool?), string deferredDeleteTimeRemaining = default(string), bool? isDeferredDeleteScheduleUpcoming = default(bool?), bool? isRehydrate = default(bool?), IList<string> resourceGuardOperationRequests = default(IList<string>), string friendlyName = default(string), string backupEngineName = default(string), string protectionState = default(string), DPMProtectedItemExtendedInfo extendedInfo = default(DPMProtectedItemExtendedInfo))
            : base(backupManagementType, workloadType, containerName, sourceResourceId, policyId, lastRecoveryPoint, backupSetName, createMode, deferredDeleteTimeInUTC, isScheduledForDeferredDelete, deferredDeleteTimeRemaining, isDeferredDeleteScheduleUpcoming, isRehydrate, resourceGuardOperationRequests)
        {
            FriendlyName = friendlyName;
            BackupEngineName = backupEngineName;
            ProtectionState = protectionState;
            ExtendedInfo = extendedInfo;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets friendly name of the managed item
        /// </summary>
        [JsonProperty(PropertyName = "friendlyName")]
        public string FriendlyName { get; set; }

        /// <summary>
        /// Gets or sets backup Management server protecting this backup item
        /// </summary>
        [JsonProperty(PropertyName = "backupEngineName")]
        public string BackupEngineName { get; set; }

        /// <summary>
        /// Gets or sets protection state of the backup engine. Possible values
        /// include: 'Invalid', 'IRPending', 'Protected', 'ProtectionError',
        /// 'ProtectionStopped', 'ProtectionPaused'
        /// </summary>
        [JsonProperty(PropertyName = "protectionState")]
        public string ProtectionState { get; set; }

        /// <summary>
        /// Gets or sets extended info of the backup item.
        /// </summary>
        [JsonProperty(PropertyName = "extendedInfo")]
        public DPMProtectedItemExtendedInfo ExtendedInfo { get; set; }

    }
}
