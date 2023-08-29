// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> AzureBackup Job Class. </summary>
    public partial class DataProtectionBackupJobProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupJobProperties"/>. </summary>
        /// <param name="activityId"> Job Activity Id. </param>
        /// <param name="backupInstanceFriendlyName"> Name of the Backup Instance. </param>
        /// <param name="dataSourceId"> ARM ID of the DataSource. </param>
        /// <param name="dataSourceLocation"> Location of the DataSource. </param>
        /// <param name="dataSourceName"> User Friendly Name of the DataSource. </param>
        /// <param name="dataSourceType"> Type of DataSource. </param>
        /// <param name="isUserTriggered"> Indicated that whether the job is adhoc(true) or scheduled(false). </param>
        /// <param name="operation"> It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Tiering:Backup/Archive ; Management:ConfigureProtection/UnConfigure. </param>
        /// <param name="operationCategory"> It indicates the type of Job i.e. Backup/Restore/Tiering/Management. </param>
        /// <param name="isProgressEnabled"> Indicated whether progress is enabled for the job. </param>
        /// <param name="sourceResourceGroup"> Resource Group Name of the Datasource. </param>
        /// <param name="sourceSubscriptionId"> SubscriptionId corresponding to the DataSource. </param>
        /// <param name="startOn"> StartTime of the job(in UTC). </param>
        /// <param name="status"> Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning. </param>
        /// <param name="subscriptionId"> Subscription Id of the corresponding backup vault. </param>
        /// <param name="supportedActions"> List of supported actions. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="activityId"/>, <paramref name="backupInstanceFriendlyName"/>, <paramref name="dataSourceId"/>, <paramref name="dataSourceName"/>, <paramref name="dataSourceType"/>, <paramref name="operation"/>, <paramref name="operationCategory"/>, <paramref name="sourceResourceGroup"/>, <paramref name="sourceSubscriptionId"/>, <paramref name="status"/>, <paramref name="subscriptionId"/>, <paramref name="supportedActions"/> or <paramref name="vaultName"/> is null. </exception>
        public DataProtectionBackupJobProperties(string activityId, string backupInstanceFriendlyName, ResourceIdentifier dataSourceId, AzureLocation dataSourceLocation, string dataSourceName, string dataSourceType, bool isUserTriggered, string operation, string operationCategory, bool isProgressEnabled, string sourceResourceGroup, string sourceSubscriptionId, DateTimeOffset startOn, string status, string subscriptionId, IEnumerable<string> supportedActions, string vaultName)
        {
            Argument.AssertNotNull(activityId, nameof(activityId));
            Argument.AssertNotNull(backupInstanceFriendlyName, nameof(backupInstanceFriendlyName));
            Argument.AssertNotNull(dataSourceId, nameof(dataSourceId));
            Argument.AssertNotNull(dataSourceName, nameof(dataSourceName));
            Argument.AssertNotNull(dataSourceType, nameof(dataSourceType));
            Argument.AssertNotNull(operation, nameof(operation));
            Argument.AssertNotNull(operationCategory, nameof(operationCategory));
            Argument.AssertNotNull(sourceResourceGroup, nameof(sourceResourceGroup));
            Argument.AssertNotNull(sourceSubscriptionId, nameof(sourceSubscriptionId));
            Argument.AssertNotNull(status, nameof(status));
            Argument.AssertNotNull(subscriptionId, nameof(subscriptionId));
            Argument.AssertNotNull(supportedActions, nameof(supportedActions));
            Argument.AssertNotNull(vaultName, nameof(vaultName));

            ActivityId = activityId;
            BackupInstanceFriendlyName = backupInstanceFriendlyName;
            DataSourceId = dataSourceId;
            DataSourceLocation = dataSourceLocation;
            DataSourceName = dataSourceName;
            DataSourceType = dataSourceType;
            ErrorDetails = new ChangeTrackingList<ResponseError>();
            IsUserTriggered = isUserTriggered;
            Operation = operation;
            OperationCategory = operationCategory;
            IsProgressEnabled = isProgressEnabled;
            SourceResourceGroup = sourceResourceGroup;
            SourceSubscriptionId = sourceSubscriptionId;
            StartOn = startOn;
            Status = status;
            SubscriptionId = subscriptionId;
            SupportedActions = supportedActions.ToList();
            VaultName = vaultName;
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupJobProperties"/>. </summary>
        /// <param name="activityId"> Job Activity Id. </param>
        /// <param name="backupInstanceFriendlyName"> Name of the Backup Instance. </param>
        /// <param name="backupInstanceId"> ARM ID of the Backup Instance. </param>
        /// <param name="dataSourceId"> ARM ID of the DataSource. </param>
        /// <param name="dataSourceLocation"> Location of the DataSource. </param>
        /// <param name="dataSourceName"> User Friendly Name of the DataSource. </param>
        /// <param name="dataSourceSetName"> Data Source Set Name of the DataSource. </param>
        /// <param name="dataSourceType"> Type of DataSource. </param>
        /// <param name="duration"> Total run time of the job. ISO 8601 format. </param>
        /// <param name="endOn"> EndTime of the job(in UTC). </param>
        /// <param name="errorDetails"> A List, detailing the errors related to the job. </param>
        /// <param name="extendedInfo"> Extended Information about the job. </param>
        /// <param name="isUserTriggered"> Indicated that whether the job is adhoc(true) or scheduled(false). </param>
        /// <param name="operation"> It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Tiering:Backup/Archive ; Management:ConfigureProtection/UnConfigure. </param>
        /// <param name="operationCategory"> It indicates the type of Job i.e. Backup/Restore/Tiering/Management. </param>
        /// <param name="policyId"> ARM ID of the policy. </param>
        /// <param name="policyName"> Name of the policy. </param>
        /// <param name="isProgressEnabled"> Indicated whether progress is enabled for the job. </param>
        /// <param name="progressUri"> Url which contains job's progress. </param>
        /// <param name="restoreType"> It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR. </param>
        /// <param name="sourceResourceGroup"> Resource Group Name of the Datasource. </param>
        /// <param name="sourceSubscriptionId"> SubscriptionId corresponding to the DataSource. </param>
        /// <param name="startOn"> StartTime of the job(in UTC). </param>
        /// <param name="status"> Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning. </param>
        /// <param name="subscriptionId"> Subscription Id of the corresponding backup vault. </param>
        /// <param name="supportedActions"> List of supported actions. </param>
        /// <param name="vaultName"> Name of the vault. </param>
        /// <param name="eTag"></param>
        /// <param name="sourceDataStoreName"></param>
        /// <param name="destinationDataStoreName"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataProtectionBackupJobProperties(string activityId, string backupInstanceFriendlyName, ResourceIdentifier backupInstanceId, ResourceIdentifier dataSourceId, AzureLocation dataSourceLocation, string dataSourceName, string dataSourceSetName, string dataSourceType, TimeSpan? duration, DateTimeOffset? endOn, IReadOnlyList<ResponseError> errorDetails, BackupJobExtendedInfo extendedInfo, bool isUserTriggered, string operation, string operationCategory, ResourceIdentifier policyId, string policyName, bool isProgressEnabled, Uri progressUri, string restoreType, string sourceResourceGroup, string sourceSubscriptionId, DateTimeOffset startOn, string status, string subscriptionId, IList<string> supportedActions, string vaultName, ETag? eTag, string sourceDataStoreName, string destinationDataStoreName, Dictionary<string, BinaryData> rawData)
        {
            ActivityId = activityId;
            BackupInstanceFriendlyName = backupInstanceFriendlyName;
            BackupInstanceId = backupInstanceId;
            DataSourceId = dataSourceId;
            DataSourceLocation = dataSourceLocation;
            DataSourceName = dataSourceName;
            DataSourceSetName = dataSourceSetName;
            DataSourceType = dataSourceType;
            Duration = duration;
            EndOn = endOn;
            ErrorDetails = errorDetails;
            ExtendedInfo = extendedInfo;
            IsUserTriggered = isUserTriggered;
            Operation = operation;
            OperationCategory = operationCategory;
            PolicyId = policyId;
            PolicyName = policyName;
            IsProgressEnabled = isProgressEnabled;
            ProgressUri = progressUri;
            RestoreType = restoreType;
            SourceResourceGroup = sourceResourceGroup;
            SourceSubscriptionId = sourceSubscriptionId;
            StartOn = startOn;
            Status = status;
            SubscriptionId = subscriptionId;
            SupportedActions = supportedActions;
            VaultName = vaultName;
            ETag = eTag;
            SourceDataStoreName = sourceDataStoreName;
            DestinationDataStoreName = destinationDataStoreName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataProtectionBackupJobProperties"/> for deserialization. </summary>
        internal DataProtectionBackupJobProperties()
        {
        }

        /// <summary> Job Activity Id. </summary>
        public string ActivityId { get; set; }
        /// <summary> Name of the Backup Instance. </summary>
        public string BackupInstanceFriendlyName { get; set; }
        /// <summary> ARM ID of the Backup Instance. </summary>
        public ResourceIdentifier BackupInstanceId { get; }
        /// <summary> ARM ID of the DataSource. </summary>
        public ResourceIdentifier DataSourceId { get; set; }
        /// <summary> Location of the DataSource. </summary>
        public AzureLocation DataSourceLocation { get; set; }
        /// <summary> User Friendly Name of the DataSource. </summary>
        public string DataSourceName { get; set; }
        /// <summary> Data Source Set Name of the DataSource. </summary>
        public string DataSourceSetName { get; set; }
        /// <summary> Type of DataSource. </summary>
        public string DataSourceType { get; set; }
        /// <summary> Total run time of the job. ISO 8601 format. </summary>
        public TimeSpan? Duration { get; set; }
        /// <summary> EndTime of the job(in UTC). </summary>
        public DateTimeOffset? EndOn { get; }
        /// <summary> A List, detailing the errors related to the job. </summary>
        public IReadOnlyList<ResponseError> ErrorDetails { get; }
        /// <summary> Extended Information about the job. </summary>
        public BackupJobExtendedInfo ExtendedInfo { get; }
        /// <summary> Indicated that whether the job is adhoc(true) or scheduled(false). </summary>
        public bool IsUserTriggered { get; set; }
        /// <summary> It indicates the type of Job i.e. Backup:full/log/diff ;Restore:ALR/OLR; Tiering:Backup/Archive ; Management:ConfigureProtection/UnConfigure. </summary>
        public string Operation { get; set; }
        /// <summary> It indicates the type of Job i.e. Backup/Restore/Tiering/Management. </summary>
        public string OperationCategory { get; set; }
        /// <summary> ARM ID of the policy. </summary>
        public ResourceIdentifier PolicyId { get; }
        /// <summary> Name of the policy. </summary>
        public string PolicyName { get; }
        /// <summary> Indicated whether progress is enabled for the job. </summary>
        public bool IsProgressEnabled { get; set; }
        /// <summary> Url which contains job's progress. </summary>
        public Uri ProgressUri { get; }
        /// <summary> It indicates the sub type of operation i.e. in case of Restore it can be ALR/OLR. </summary>
        public string RestoreType { get; }
        /// <summary> Resource Group Name of the Datasource. </summary>
        public string SourceResourceGroup { get; set; }
        /// <summary> SubscriptionId corresponding to the DataSource. </summary>
        public string SourceSubscriptionId { get; set; }
        /// <summary> StartTime of the job(in UTC). </summary>
        public DateTimeOffset StartOn { get; set; }
        /// <summary> Status of the job like InProgress/Success/Failed/Cancelled/SuccessWithWarning. </summary>
        public string Status { get; set; }
        /// <summary> Subscription Id of the corresponding backup vault. </summary>
        public string SubscriptionId { get; set; }
        /// <summary> List of supported actions. </summary>
        public IList<string> SupportedActions { get; }
        /// <summary> Name of the vault. </summary>
        public string VaultName { get; set; }
        /// <summary> Gets or sets the e tag. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Gets or sets the source data store name. </summary>
        public string SourceDataStoreName { get; set; }
        /// <summary> Gets or sets the destination data store name. </summary>
        public string DestinationDataStoreName { get; set; }
    }
}
