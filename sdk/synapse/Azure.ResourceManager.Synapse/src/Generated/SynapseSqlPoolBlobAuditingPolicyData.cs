// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Synapse.Models;

namespace Azure.ResourceManager.Synapse
{
    /// <summary>
    /// A class representing the SynapseSqlPoolBlobAuditingPolicy data model.
    /// A Sql pool blob auditing policy.
    /// </summary>
    public partial class SynapseSqlPoolBlobAuditingPolicyData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolBlobAuditingPolicyData"/>. </summary>
        public SynapseSqlPoolBlobAuditingPolicyData()
        {
            AuditActionsAndGroups = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseSqlPoolBlobAuditingPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Resource kind. </param>
        /// <param name="state"> Specifies the state of the policy. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are required. </param>
        /// <param name="storageEndpoint"> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). If state is Enabled, storageEndpoint is required. </param>
        /// <param name="storageAccountAccessKey"> Specifies the identifier key of the auditing storage account. If state is Enabled and storageEndpoint is specified, storageAccountAccessKey is required. </param>
        /// <param name="retentionDays"> Specifies the number of days to keep in the audit logs in the storage account. </param>
        /// <param name="auditActionsAndGroups">
        /// Specifies the Actions-Groups and Actions to audit.
        ///
        /// The recommended set of action groups to use is the following combination - this will audit all the queries and stored procedures executed against the database, as well as successful and failed logins:
        ///
        /// BATCH_COMPLETED_GROUP,
        /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
        /// FAILED_DATABASE_AUTHENTICATION_GROUP.
        ///
        /// This above combination is also the set that is configured by default when enabling auditing from the Azure portal.
        ///
        /// The supported action groups to audit are (note: choose only specific groups that cover your auditing needs. Using unnecessary groups could lead to very large quantities of audit records):
        ///
        /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
        /// BACKUP_RESTORE_GROUP
        /// DATABASE_LOGOUT_GROUP
        /// DATABASE_OBJECT_CHANGE_GROUP
        /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
        /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
        /// DATABASE_OPERATION_GROUP
        /// DATABASE_PERMISSION_CHANGE_GROUP
        /// DATABASE_PRINCIPAL_CHANGE_GROUP
        /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
        /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
        /// FAILED_DATABASE_AUTHENTICATION_GROUP
        /// SCHEMA_OBJECT_ACCESS_GROUP
        /// SCHEMA_OBJECT_CHANGE_GROUP
        /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
        /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
        /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
        /// USER_CHANGE_PASSWORD_GROUP
        /// BATCH_STARTED_GROUP
        /// BATCH_COMPLETED_GROUP
        ///
        /// These are groups that cover all sql statements and stored procedures executed against the database, and should not be used in combination with other groups as this will result in duplicate audit logs.
        ///
        /// For more information, see [Database-Level Audit Action Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
        ///
        /// For Database auditing policy, specific Actions can also be specified (note that Actions cannot be specified for Server auditing policy). The supported actions to audit are:
        /// SELECT
        /// UPDATE
        /// INSERT
        /// DELETE
        /// EXECUTE
        /// RECEIVE
        /// REFERENCES
        ///
        /// The general form for defining an action to be audited is:
        /// {action} ON {object} BY {principal}
        ///
        /// Note that &lt;object&gt; in the above format can refer to an object like a table, view, or stored procedure, or an entire database or schema. For the latter cases, the forms DATABASE::{db_name} and SCHEMA::{schema_name} are used, respectively.
        ///
        /// For example:
        /// SELECT on dbo.myTable by public
        /// SELECT on DATABASE::myDatabase by public
        /// SELECT on SCHEMA::mySchema by public
        ///
        /// For more information, see [Database-Level Audit Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
        /// </param>
        /// <param name="storageAccountSubscriptionId"> Specifies the blob storage subscription Id. </param>
        /// <param name="isStorageSecondaryKeyInUse"> Specifies whether storageAccountAccessKey value is the storage's secondary key. </param>
        /// <param name="isAzureMonitorTargetEnabled">
        /// Specifies whether audit events are sent to Azure Monitor.
        /// In order to send the events to Azure Monitor, specify 'state' as 'Enabled' and 'isAzureMonitorTargetEnabled' as true.
        ///
        /// When using REST API to configure auditing, Diagnostic Settings with 'SQLSecurityAuditEvents' diagnostic logs category on the database should be also created.
        /// Note that for server level audit you should use the 'master' database as {databaseName}.
        ///
        /// Diagnostic Settings URI format:
        /// PUT https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
        ///
        /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
        /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
        ///
        /// </param>
        internal SynapseSqlPoolBlobAuditingPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, SynapseBlobAuditingPolicyState? state, string storageEndpoint, string storageAccountAccessKey, int? retentionDays, IList<string> auditActionsAndGroups, Guid? storageAccountSubscriptionId, bool? isStorageSecondaryKeyInUse, bool? isAzureMonitorTargetEnabled) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            State = state;
            StorageEndpoint = storageEndpoint;
            StorageAccountAccessKey = storageAccountAccessKey;
            RetentionDays = retentionDays;
            AuditActionsAndGroups = auditActionsAndGroups;
            StorageAccountSubscriptionId = storageAccountSubscriptionId;
            IsStorageSecondaryKeyInUse = isStorageSecondaryKeyInUse;
            IsAzureMonitorTargetEnabled = isAzureMonitorTargetEnabled;
        }

        /// <summary> Resource kind. </summary>
        public string Kind { get; }
        /// <summary> Specifies the state of the policy. If state is Enabled, storageEndpoint or isAzureMonitorTargetEnabled are required. </summary>
        public SynapseBlobAuditingPolicyState? State { get; set; }
        /// <summary> Specifies the blob storage endpoint (e.g. https://MyAccount.blob.core.windows.net). If state is Enabled, storageEndpoint is required. </summary>
        public string StorageEndpoint { get; set; }
        /// <summary> Specifies the identifier key of the auditing storage account. If state is Enabled and storageEndpoint is specified, storageAccountAccessKey is required. </summary>
        public string StorageAccountAccessKey { get; set; }
        /// <summary> Specifies the number of days to keep in the audit logs in the storage account. </summary>
        public int? RetentionDays { get; set; }
        /// <summary>
        /// Specifies the Actions-Groups and Actions to audit.
        ///
        /// The recommended set of action groups to use is the following combination - this will audit all the queries and stored procedures executed against the database, as well as successful and failed logins:
        ///
        /// BATCH_COMPLETED_GROUP,
        /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP,
        /// FAILED_DATABASE_AUTHENTICATION_GROUP.
        ///
        /// This above combination is also the set that is configured by default when enabling auditing from the Azure portal.
        ///
        /// The supported action groups to audit are (note: choose only specific groups that cover your auditing needs. Using unnecessary groups could lead to very large quantities of audit records):
        ///
        /// APPLICATION_ROLE_CHANGE_PASSWORD_GROUP
        /// BACKUP_RESTORE_GROUP
        /// DATABASE_LOGOUT_GROUP
        /// DATABASE_OBJECT_CHANGE_GROUP
        /// DATABASE_OBJECT_OWNERSHIP_CHANGE_GROUP
        /// DATABASE_OBJECT_PERMISSION_CHANGE_GROUP
        /// DATABASE_OPERATION_GROUP
        /// DATABASE_PERMISSION_CHANGE_GROUP
        /// DATABASE_PRINCIPAL_CHANGE_GROUP
        /// DATABASE_PRINCIPAL_IMPERSONATION_GROUP
        /// DATABASE_ROLE_MEMBER_CHANGE_GROUP
        /// FAILED_DATABASE_AUTHENTICATION_GROUP
        /// SCHEMA_OBJECT_ACCESS_GROUP
        /// SCHEMA_OBJECT_CHANGE_GROUP
        /// SCHEMA_OBJECT_OWNERSHIP_CHANGE_GROUP
        /// SCHEMA_OBJECT_PERMISSION_CHANGE_GROUP
        /// SUCCESSFUL_DATABASE_AUTHENTICATION_GROUP
        /// USER_CHANGE_PASSWORD_GROUP
        /// BATCH_STARTED_GROUP
        /// BATCH_COMPLETED_GROUP
        ///
        /// These are groups that cover all sql statements and stored procedures executed against the database, and should not be used in combination with other groups as this will result in duplicate audit logs.
        ///
        /// For more information, see [Database-Level Audit Action Groups](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-action-groups).
        ///
        /// For Database auditing policy, specific Actions can also be specified (note that Actions cannot be specified for Server auditing policy). The supported actions to audit are:
        /// SELECT
        /// UPDATE
        /// INSERT
        /// DELETE
        /// EXECUTE
        /// RECEIVE
        /// REFERENCES
        ///
        /// The general form for defining an action to be audited is:
        /// {action} ON {object} BY {principal}
        ///
        /// Note that &lt;object&gt; in the above format can refer to an object like a table, view, or stored procedure, or an entire database or schema. For the latter cases, the forms DATABASE::{db_name} and SCHEMA::{schema_name} are used, respectively.
        ///
        /// For example:
        /// SELECT on dbo.myTable by public
        /// SELECT on DATABASE::myDatabase by public
        /// SELECT on SCHEMA::mySchema by public
        ///
        /// For more information, see [Database-Level Audit Actions](https://docs.microsoft.com/en-us/sql/relational-databases/security/auditing/sql-server-audit-action-groups-and-actions#database-level-audit-actions)
        /// </summary>
        public IList<string> AuditActionsAndGroups { get; }
        /// <summary> Specifies the blob storage subscription Id. </summary>
        public Guid? StorageAccountSubscriptionId { get; set; }
        /// <summary> Specifies whether storageAccountAccessKey value is the storage's secondary key. </summary>
        public bool? IsStorageSecondaryKeyInUse { get; set; }
        /// <summary>
        /// Specifies whether audit events are sent to Azure Monitor.
        /// In order to send the events to Azure Monitor, specify 'state' as 'Enabled' and 'isAzureMonitorTargetEnabled' as true.
        ///
        /// When using REST API to configure auditing, Diagnostic Settings with 'SQLSecurityAuditEvents' diagnostic logs category on the database should be also created.
        /// Note that for server level audit you should use the 'master' database as {databaseName}.
        ///
        /// Diagnostic Settings URI format:
        /// PUT https://management.azure.com/subscriptions/{subscriptionId}/resourceGroups/{resourceGroup}/providers/Microsoft.Sql/servers/{serverName}/databases/{databaseName}/providers/microsoft.insights/diagnosticSettings/{settingsName}?api-version=2017-05-01-preview
        ///
        /// For more information, see [Diagnostic Settings REST API](https://go.microsoft.com/fwlink/?linkid=2033207)
        /// or [Diagnostic Settings PowerShell](https://go.microsoft.com/fwlink/?linkid=2033043)
        ///
        /// </summary>
        public bool? IsAzureMonitorTargetEnabled { get; set; }
    }
}
