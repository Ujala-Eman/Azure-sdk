// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> A class representing the ManagedDatabase data model. </summary>
    public partial class ManagedDatabaseData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of ManagedDatabaseData. </summary>
        /// <param name="location"> The location. </param>
        public ManagedDatabaseData(AzureLocation location) : base(location)
        {
        }

        /// <summary> Initializes a new instance of ManagedDatabaseData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="collation"> Collation of the managed database. </param>
        /// <param name="status"> Status of the database. </param>
        /// <param name="createdOn"> Creation date of the database. </param>
        /// <param name="earliestRestorePoint"> Earliest restore point in time for point in time restore. </param>
        /// <param name="restorePointInTime"> Conditional. If createMode is PointInTimeRestore, this value is required. Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. </param>
        /// <param name="defaultSecondaryLocation"> Geo paired region. </param>
        /// <param name="catalogCollation"> Collation of the metadata catalog. </param>
        /// <param name="createMode"> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </param>
        /// <param name="storageContainerUri"> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored. </param>
        /// <param name="sourceDatabaseId"> The resource identifier of the source database associated with create operation of this database. </param>
        /// <param name="restorableDroppedDatabaseId"> The restorable dropped database resource id to restore when creating this database. </param>
        /// <param name="storageContainerSasToken"> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token. </param>
        /// <param name="failoverGroupId"> Instance Failover Group resource identifier that this managed database belongs to. </param>
        /// <param name="recoverableDatabaseId"> The resource identifier of the recoverable database associated with create operation of this database. </param>
        /// <param name="longTermRetentionBackupResourceId"> The name of the Long Term Retention backup to be used for restore of this managed database. </param>
        /// <param name="autoCompleteRestore"> Whether to auto complete restore of this managed database. </param>
        /// <param name="lastBackupName"> Last backup file name for restore of this managed database. </param>
        internal ManagedDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, string collation, ManagedDatabaseStatus? status, DateTimeOffset? createdOn, DateTimeOffset? earliestRestorePoint, DateTimeOffset? restorePointInTime, AzureLocation? defaultSecondaryLocation, CatalogCollationType? catalogCollation, ManagedDatabaseCreateMode? createMode, Uri storageContainerUri, ResourceIdentifier sourceDatabaseId, ResourceIdentifier restorableDroppedDatabaseId, string storageContainerSasToken, string failoverGroupId, ResourceIdentifier recoverableDatabaseId, ResourceIdentifier longTermRetentionBackupResourceId, bool? autoCompleteRestore, string lastBackupName) : base(id, name, resourceType, systemData, tags, location)
        {
            Collation = collation;
            Status = status;
            CreatedOn = createdOn;
            EarliestRestorePoint = earliestRestorePoint;
            RestorePointInTime = restorePointInTime;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            CatalogCollation = catalogCollation;
            CreateMode = createMode;
            StorageContainerUri = storageContainerUri;
            SourceDatabaseId = sourceDatabaseId;
            RestorableDroppedDatabaseId = restorableDroppedDatabaseId;
            StorageContainerSasToken = storageContainerSasToken;
            FailoverGroupId = failoverGroupId;
            RecoverableDatabaseId = recoverableDatabaseId;
            LongTermRetentionBackupResourceId = longTermRetentionBackupResourceId;
            AutoCompleteRestore = autoCompleteRestore;
            LastBackupName = lastBackupName;
        }

        /// <summary> Collation of the managed database. </summary>
        public string Collation { get; set; }
        /// <summary> Status of the database. </summary>
        public ManagedDatabaseStatus? Status { get; }
        /// <summary> Creation date of the database. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Earliest restore point in time for point in time restore. </summary>
        public DateTimeOffset? EarliestRestorePoint { get; }
        /// <summary> Geo paired region. </summary>
        public AzureLocation? DefaultSecondaryLocation { get; }
        /// <summary> Collation of the metadata catalog. </summary>
        public CatalogCollationType? CatalogCollation { get; set; }
        /// <summary> Managed database create mode. PointInTimeRestore: Create a database by restoring a point in time backup of an existing database. SourceDatabaseName, SourceManagedInstanceName and PointInTime must be specified. RestoreExternalBackup: Create a database by restoring from external backup files. Collation, StorageContainerUri and StorageContainerSasToken must be specified. Recovery: Creates a database by restoring a geo-replicated backup. RecoverableDatabaseId must be specified as the recoverable database resource ID to restore. RestoreLongTermRetentionBackup: Create a database by restoring from a long term retention backup (longTermRetentionBackupResourceId required). </summary>
        public ManagedDatabaseCreateMode? CreateMode { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the uri of the storage container where backups for this restore are stored. </summary>
        public Uri StorageContainerUri { get; set; }
        /// <summary> The resource identifier of the source database associated with create operation of this database. </summary>
        public ResourceIdentifier SourceDatabaseId { get; set; }
        /// <summary> The restorable dropped database resource id to restore when creating this database. </summary>
        public ResourceIdentifier RestorableDroppedDatabaseId { get; set; }
        /// <summary> Conditional. If createMode is RestoreExternalBackup, this value is required. Specifies the storage container sas token. </summary>
        public string StorageContainerSasToken { get; set; }
        /// <summary> Instance Failover Group resource identifier that this managed database belongs to. </summary>
        public string FailoverGroupId { get; }
        /// <summary> The resource identifier of the recoverable database associated with create operation of this database. </summary>
        public ResourceIdentifier RecoverableDatabaseId { get; set; }
        /// <summary> The name of the Long Term Retention backup to be used for restore of this managed database. </summary>
        public ResourceIdentifier LongTermRetentionBackupResourceId { get; set; }
        /// <summary> Whether to auto complete restore of this managed database. </summary>
        public bool? AutoCompleteRestore { get; set; }
        /// <summary> Last backup file name for restore of this managed database. </summary>
        public string LastBackupName { get; set; }
    }
}
