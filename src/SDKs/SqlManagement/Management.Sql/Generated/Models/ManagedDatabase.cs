// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// A managed database resource.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedDatabase : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedDatabase class.
        /// </summary>
        public ManagedDatabase()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedDatabase class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="collation">Collation of the managed database.</param>
        /// <param name="status">Status for the database. Possible values
        /// include: 'Online', 'Offline', 'Shutdown', 'Creating',
        /// 'Inaccessible'</param>
        /// <param name="creationDate">Creation date of the database.</param>
        /// <param name="earliestRestorePoint">Earliest restore point in time
        /// for point in time restore.</param>
        /// <param name="restorePointInTime">Conditional. If createMode is
        /// PointInTimeRestore, this value is required. Specifies the point in
        /// time (ISO8601 format) of the source database that will be restored
        /// to create the new database.</param>
        /// <param name="defaultSecondaryLocation">Geo paired region.</param>
        /// <param name="catalogCollation">Collation of the metadata catalog.
        /// Possible values include: 'DATABASE_DEFAULT',
        /// 'SQL_Latin1_General_CP1_CI_AS'</param>
        /// <param name="createMode">Managed database create mode.
        /// PointInTimeRestore: Create a database by restoring a point in time
        /// backup of an existing database. SourceDatabaseName,
        /// SourceManagedInstanceName and PointInTime must be specified.
        /// RestoreExternalBackup: Create a database by restoring from external
        /// backup files. Collation, StorageContainerUri and
        /// StorageContainerSasToken must be specified. Possible values
        /// include: 'Default', 'RestoreExternalBackup',
        /// 'PointInTimeRestore'</param>
        /// <param name="storageContainerUri">Conditional. If createMode is
        /// RestoreExternalBackup, this value is required. Specifies the uri of
        /// the storage container where backups for this restore are
        /// stored.</param>
        /// <param name="sourceDatabaseId">The resource identifier of the
        /// source database associated with create operation of this
        /// database.</param>
        /// <param name="storageContainerSasToken">Conditional. If createMode
        /// is RestoreExternalBackup, this value is required. Specifies the
        /// storage container sas token.</param>
        /// <param name="failoverGroupId">Instance Failover Group resource
        /// identifier that this managed database belongs to.</param>
        public ManagedDatabase(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string collation = default(string), string status = default(string), System.DateTime? creationDate = default(System.DateTime?), System.DateTime? earliestRestorePoint = default(System.DateTime?), System.DateTime? restorePointInTime = default(System.DateTime?), string defaultSecondaryLocation = default(string), string catalogCollation = default(string), string createMode = default(string), string storageContainerUri = default(string), string sourceDatabaseId = default(string), string storageContainerSasToken = default(string), string failoverGroupId = default(string))
            : base(location, id, name, type, tags)
        {
            Collation = collation;
            Status = status;
            CreationDate = creationDate;
            EarliestRestorePoint = earliestRestorePoint;
            RestorePointInTime = restorePointInTime;
            DefaultSecondaryLocation = defaultSecondaryLocation;
            CatalogCollation = catalogCollation;
            CreateMode = createMode;
            StorageContainerUri = storageContainerUri;
            SourceDatabaseId = sourceDatabaseId;
            StorageContainerSasToken = storageContainerSasToken;
            FailoverGroupId = failoverGroupId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets collation of the managed database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets status for the database. Possible values include: 'Online',
        /// 'Offline', 'Shutdown', 'Creating', 'Inaccessible'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets creation date of the database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.creationDate")]
        public System.DateTime? CreationDate { get; private set; }

        /// <summary>
        /// Gets earliest restore point in time for point in time restore.
        /// </summary>
        [JsonProperty(PropertyName = "properties.earliestRestorePoint")]
        public System.DateTime? EarliestRestorePoint { get; private set; }

        /// <summary>
        /// Gets or sets conditional. If createMode is PointInTimeRestore, this
        /// value is required. Specifies the point in time (ISO8601 format) of
        /// the source database that will be restored to create the new
        /// database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointInTime")]
        public System.DateTime? RestorePointInTime { get; set; }

        /// <summary>
        /// Gets geo paired region.
        /// </summary>
        [JsonProperty(PropertyName = "properties.defaultSecondaryLocation")]
        public string DefaultSecondaryLocation { get; private set; }

        /// <summary>
        /// Gets or sets collation of the metadata catalog. Possible values
        /// include: 'DATABASE_DEFAULT', 'SQL_Latin1_General_CP1_CI_AS'
        /// </summary>
        [JsonProperty(PropertyName = "properties.catalogCollation")]
        public string CatalogCollation { get; set; }

        /// <summary>
        /// Gets or sets managed database create mode. PointInTimeRestore:
        /// Create a database by restoring a point in time backup of an
        /// existing database. SourceDatabaseName, SourceManagedInstanceName
        /// and PointInTime must be specified. RestoreExternalBackup: Create a
        /// database by restoring from external backup files. Collation,
        /// StorageContainerUri and StorageContainerSasToken must be specified.
        /// Possible values include: 'Default', 'RestoreExternalBackup',
        /// 'PointInTimeRestore'
        /// </summary>
        [JsonProperty(PropertyName = "properties.createMode")]
        public string CreateMode { get; set; }

        /// <summary>
        /// Gets or sets conditional. If createMode is RestoreExternalBackup,
        /// this value is required. Specifies the uri of the storage container
        /// where backups for this restore are stored.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageContainerUri")]
        public string StorageContainerUri { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the source database
        /// associated with create operation of this database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceDatabaseId")]
        public string SourceDatabaseId { get; set; }

        /// <summary>
        /// Gets or sets conditional. If createMode is RestoreExternalBackup,
        /// this value is required. Specifies the storage container sas token.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageContainerSasToken")]
        public string StorageContainerSasToken { get; set; }

        /// <summary>
        /// Gets instance Failover Group resource identifier that this managed
        /// database belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.failoverGroupId")]
        public string FailoverGroupId { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
