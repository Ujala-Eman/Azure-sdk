// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> Parameters for patching Azure Cosmos DB database account properties. </summary>
    public partial class CosmosDBAccountPatch
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountPatch"/>. </summary>
        public CosmosDBAccountPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Locations = new ChangeTrackingList<CosmosDBAccountLocation>();
            IPRules = new ChangeTrackingList<CosmosDBIPAddressOrRange>();
            Capabilities = new ChangeTrackingList<CosmosDBAccountCapability>();
            VirtualNetworkRules = new ChangeTrackingList<CosmosDBVirtualNetworkRule>();
            Cors = new ChangeTrackingList<CosmosDBAccountCorsPolicy>();
            NetworkAclBypassResourceIds = new ChangeTrackingList<ResourceIdentifier>();
        }

        /// <summary> Initializes a new instance of <see cref="CosmosDBAccountPatch"/>. </summary>
        /// <param name="tags"> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB". </param>
        /// <param name="location"> The location of the resource group to which the resource belongs. </param>
        /// <param name="identity"> Identity for the resource. </param>
        /// <param name="consistencyPolicy"> The consistency policy for the Cosmos DB account. </param>
        /// <param name="locations"> An array that contains the georeplication locations enabled for the Cosmos DB account. </param>
        /// <param name="ipRules"> List of IpRules. </param>
        /// <param name="isVirtualNetworkFilterEnabled"> Flag to indicate whether to enable/disable Virtual Network ACL rules. </param>
        /// <param name="enableAutomaticFailover"> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </param>
        /// <param name="capabilities"> List of Cosmos DB capabilities for the account. </param>
        /// <param name="virtualNetworkRules"> List of Virtual Network ACL rules configured for the Cosmos DB account. </param>
        /// <param name="enableMultipleWriteLocations"> Enables the account to write in multiple locations. </param>
        /// <param name="enableCassandraConnector"> Enables the cassandra connector on the Cosmos DB C* account. </param>
        /// <param name="connectorOffer"> The cassandra connector offer type for the Cosmos DB database C* account. </param>
        /// <param name="disableKeyBasedMetadataWriteAccess"> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </param>
        /// <param name="keyVaultKeyUri"> The URI of the key vault. </param>
        /// <param name="defaultIdentity"> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be "FirstPartyIdentity", "SystemAssignedIdentity" and more. </param>
        /// <param name="publicNetworkAccess"> Whether requests from Public Network are allowed. </param>
        /// <param name="isFreeTierEnabled"> Flag to indicate whether Free Tier is enabled. </param>
        /// <param name="apiProperties"> API specific properties. Currently, supported only for MongoDB API. </param>
        /// <param name="isAnalyticalStorageEnabled"> Flag to indicate whether to enable storage analytics. </param>
        /// <param name="analyticalStorageConfiguration"> Analytical storage specific properties. </param>
        /// <param name="backupPolicy">
        /// The object representing the policy for taking backups on an account.
        /// Please note <see cref="CosmosDBAccountBackupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContinuousModeBackupPolicy"/> and <see cref="PeriodicModeBackupPolicy"/>.
        /// </param>
        /// <param name="cors"> The CORS policy for the Cosmos DB database account. </param>
        /// <param name="networkAclBypass"> Indicates what services are allowed to bypass firewall checks. </param>
        /// <param name="networkAclBypassResourceIds"> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </param>
        /// <param name="diagnosticLogSettings"> The Object representing the different Diagnostic log settings for the Cosmos DB Account. </param>
        /// <param name="disableLocalAuth"> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </param>
        /// <param name="capacity"> The object that represents all properties related to capacity enforcement on an account. </param>
        /// <param name="capacityMode"> Indicates the capacityMode of the Cosmos DB account. </param>
        /// <param name="enableMaterializedViews"> Flag to indicate whether to enable MaterializedViews on the Cosmos DB account. </param>
        /// <param name="keysMetadata"> This property is ignored during the update operation, as the metadata is read-only. The object represents the metadata for the Account Keys of the Cosmos DB account. </param>
        /// <param name="enablePartitionMerge"> Flag to indicate enabling/disabling of Partition Merge feature on the account. </param>
        /// <param name="enableBurstCapacity"> Flag to indicate enabling/disabling of Burst Capacity Preview feature on the account. </param>
        /// <param name="minimalTlsVersion"> Indicates the minimum allowed Tls version. The default is Tls 1.0, except for Cassandra and Mongo API's, which only work with Tls 1.2. </param>
        /// <param name="customerManagedKeyStatus"> Indicates the status of the Customer Managed Key feature on the account. In case there are errors, the property provides troubleshooting guidance. </param>
        /// <param name="enablePriorityBasedExecution"> Flag to indicate enabling/disabling of Priority Based Execution Preview feature on the account. </param>
        /// <param name="defaultPriorityLevel"> Enum to indicate default Priority Level of request for Priority Based Execution. </param>
        /// <param name="enablePerRegionPerPartitionAutoscale"> Flag to indicate enabling/disabling of Per-Region Per-partition autoscale Preview feature on the account. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal CosmosDBAccountPatch(IDictionary<string, string> tags, AzureLocation? location, ManagedServiceIdentity identity, ConsistencyPolicy consistencyPolicy, IList<CosmosDBAccountLocation> locations, IList<CosmosDBIPAddressOrRange> ipRules, bool? isVirtualNetworkFilterEnabled, bool? enableAutomaticFailover, IList<CosmosDBAccountCapability> capabilities, IList<CosmosDBVirtualNetworkRule> virtualNetworkRules, bool? enableMultipleWriteLocations, bool? enableCassandraConnector, ConnectorOffer? connectorOffer, bool? disableKeyBasedMetadataWriteAccess, Uri keyVaultKeyUri, string defaultIdentity, CosmosDBPublicNetworkAccess? publicNetworkAccess, bool? isFreeTierEnabled, ApiProperties apiProperties, bool? isAnalyticalStorageEnabled, AnalyticalStorageConfiguration analyticalStorageConfiguration, CosmosDBAccountBackupPolicy backupPolicy, IList<CosmosDBAccountCorsPolicy> cors, NetworkAclBypass? networkAclBypass, IList<ResourceIdentifier> networkAclBypassResourceIds, DiagnosticLogSettings diagnosticLogSettings, bool? disableLocalAuth, CosmosDBAccountCapacity capacity, CapacityMode? capacityMode, bool? enableMaterializedViews, DatabaseAccountKeysMetadata keysMetadata, bool? enablePartitionMerge, bool? enableBurstCapacity, CosmosDBMinimalTlsVersion? minimalTlsVersion, string customerManagedKeyStatus, bool? enablePriorityBasedExecution, DefaultPriorityLevel? defaultPriorityLevel, bool? enablePerRegionPerPartitionAutoscale, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Tags = tags;
            Location = location;
            Identity = identity;
            ConsistencyPolicy = consistencyPolicy;
            Locations = locations;
            IPRules = ipRules;
            IsVirtualNetworkFilterEnabled = isVirtualNetworkFilterEnabled;
            EnableAutomaticFailover = enableAutomaticFailover;
            Capabilities = capabilities;
            VirtualNetworkRules = virtualNetworkRules;
            EnableMultipleWriteLocations = enableMultipleWriteLocations;
            EnableCassandraConnector = enableCassandraConnector;
            ConnectorOffer = connectorOffer;
            DisableKeyBasedMetadataWriteAccess = disableKeyBasedMetadataWriteAccess;
            KeyVaultKeyUri = keyVaultKeyUri;
            DefaultIdentity = defaultIdentity;
            PublicNetworkAccess = publicNetworkAccess;
            IsFreeTierEnabled = isFreeTierEnabled;
            ApiProperties = apiProperties;
            IsAnalyticalStorageEnabled = isAnalyticalStorageEnabled;
            AnalyticalStorageConfiguration = analyticalStorageConfiguration;
            BackupPolicy = backupPolicy;
            Cors = cors;
            NetworkAclBypass = networkAclBypass;
            NetworkAclBypassResourceIds = networkAclBypassResourceIds;
            DiagnosticLogSettings = diagnosticLogSettings;
            DisableLocalAuth = disableLocalAuth;
            Capacity = capacity;
            CapacityMode = capacityMode;
            EnableMaterializedViews = enableMaterializedViews;
            KeysMetadata = keysMetadata;
            EnablePartitionMerge = enablePartitionMerge;
            EnableBurstCapacity = enableBurstCapacity;
            MinimalTlsVersion = minimalTlsVersion;
            CustomerManagedKeyStatus = customerManagedKeyStatus;
            EnablePriorityBasedExecution = enablePriorityBasedExecution;
            DefaultPriorityLevel = defaultPriorityLevel;
            EnablePerRegionPerPartitionAutoscale = enablePerRegionPerPartitionAutoscale;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Tags are a list of key-value pairs that describe the resource. These tags can be used in viewing and grouping this resource (across resource groups). A maximum of 15 tags can be provided for a resource. Each tag must have a key no greater than 128 characters and value no greater than 256 characters. For example, the default experience for a template type is set with "defaultExperience": "Cassandra". Current "defaultExperience" values also include "Table", "Graph", "DocumentDB", and "MongoDB". </summary>
        [WirePath("tags")]
        public IDictionary<string, string> Tags { get; }
        /// <summary> The location of the resource group to which the resource belongs. </summary>
        [WirePath("location")]
        public AzureLocation? Location { get; set; }
        /// <summary> Identity for the resource. </summary>
        [WirePath("identity")]
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The consistency policy for the Cosmos DB account. </summary>
        [WirePath("properties.consistencyPolicy")]
        public ConsistencyPolicy ConsistencyPolicy { get; set; }
        /// <summary> An array that contains the georeplication locations enabled for the Cosmos DB account. </summary>
        [WirePath("properties.locations")]
        public IList<CosmosDBAccountLocation> Locations { get; }
        /// <summary> List of IpRules. </summary>
        [WirePath("properties.ipRules")]
        public IList<CosmosDBIPAddressOrRange> IPRules { get; }
        /// <summary> Flag to indicate whether to enable/disable Virtual Network ACL rules. </summary>
        [WirePath("properties.isVirtualNetworkFilterEnabled")]
        public bool? IsVirtualNetworkFilterEnabled { get; set; }
        /// <summary> Enables automatic failover of the write region in the rare event that the region is unavailable due to an outage. Automatic failover will result in a new write region for the account and is chosen based on the failover priorities configured for the account. </summary>
        [WirePath("properties.enableAutomaticFailover")]
        public bool? EnableAutomaticFailover { get; set; }
        /// <summary> List of Cosmos DB capabilities for the account. </summary>
        [WirePath("properties.capabilities")]
        public IList<CosmosDBAccountCapability> Capabilities { get; }
        /// <summary> List of Virtual Network ACL rules configured for the Cosmos DB account. </summary>
        [WirePath("properties.virtualNetworkRules")]
        public IList<CosmosDBVirtualNetworkRule> VirtualNetworkRules { get; }
        /// <summary> Enables the account to write in multiple locations. </summary>
        [WirePath("properties.enableMultipleWriteLocations")]
        public bool? EnableMultipleWriteLocations { get; set; }
        /// <summary> Enables the cassandra connector on the Cosmos DB C* account. </summary>
        [WirePath("properties.enableCassandraConnector")]
        public bool? EnableCassandraConnector { get; set; }
        /// <summary> The cassandra connector offer type for the Cosmos DB database C* account. </summary>
        [WirePath("properties.connectorOffer")]
        public ConnectorOffer? ConnectorOffer { get; set; }
        /// <summary> Disable write operations on metadata resources (databases, containers, throughput) via account keys. </summary>
        [WirePath("properties.disableKeyBasedMetadataWriteAccess")]
        public bool? DisableKeyBasedMetadataWriteAccess { get; set; }
        /// <summary> The URI of the key vault. </summary>
        [WirePath("properties.keyVaultKeyUri")]
        public Uri KeyVaultKeyUri { get; set; }
        /// <summary> The default identity for accessing key vault used in features like customer managed keys. The default identity needs to be explicitly set by the users. It can be "FirstPartyIdentity", "SystemAssignedIdentity" and more. </summary>
        [WirePath("properties.defaultIdentity")]
        public string DefaultIdentity { get; set; }
        /// <summary> Whether requests from Public Network are allowed. </summary>
        [WirePath("properties.publicNetworkAccess")]
        public CosmosDBPublicNetworkAccess? PublicNetworkAccess { get; set; }
        /// <summary> Flag to indicate whether Free Tier is enabled. </summary>
        [WirePath("properties.enableFreeTier")]
        public bool? IsFreeTierEnabled { get; set; }
        /// <summary> API specific properties. Currently, supported only for MongoDB API. </summary>
        internal ApiProperties ApiProperties { get; set; }
        /// <summary> Describes the version of the MongoDB account. </summary>
        [WirePath("properties.apiProperties.serverVersion")]
        public CosmosDBServerVersion? ApiServerVersion
        {
            get => ApiProperties is null ? default : ApiProperties.ServerVersion;
            set
            {
                if (ApiProperties is null)
                    ApiProperties = new ApiProperties();
                ApiProperties.ServerVersion = value;
            }
        }

        /// <summary> Flag to indicate whether to enable storage analytics. </summary>
        [WirePath("properties.enableAnalyticalStorage")]
        public bool? IsAnalyticalStorageEnabled { get; set; }
        /// <summary> Analytical storage specific properties. </summary>
        internal AnalyticalStorageConfiguration AnalyticalStorageConfiguration { get; set; }
        /// <summary> Describes the types of schema for analytical storage. </summary>
        [WirePath("properties.analyticalStorageConfiguration.schemaType")]
        public AnalyticalStorageSchemaType? AnalyticalStorageSchemaType
        {
            get => AnalyticalStorageConfiguration is null ? default : AnalyticalStorageConfiguration.SchemaType;
            set
            {
                if (AnalyticalStorageConfiguration is null)
                    AnalyticalStorageConfiguration = new AnalyticalStorageConfiguration();
                AnalyticalStorageConfiguration.SchemaType = value;
            }
        }

        /// <summary>
        /// The object representing the policy for taking backups on an account.
        /// Please note <see cref="CosmosDBAccountBackupPolicy"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ContinuousModeBackupPolicy"/> and <see cref="PeriodicModeBackupPolicy"/>.
        /// </summary>
        [WirePath("properties.backupPolicy")]
        public CosmosDBAccountBackupPolicy BackupPolicy { get; set; }
        /// <summary> The CORS policy for the Cosmos DB database account. </summary>
        [WirePath("properties.cors")]
        public IList<CosmosDBAccountCorsPolicy> Cors { get; }
        /// <summary> Indicates what services are allowed to bypass firewall checks. </summary>
        [WirePath("properties.networkAclBypass")]
        public NetworkAclBypass? NetworkAclBypass { get; set; }
        /// <summary> An array that contains the Resource Ids for Network Acl Bypass for the Cosmos DB account. </summary>
        [WirePath("properties.networkAclBypassResourceIds")]
        public IList<ResourceIdentifier> NetworkAclBypassResourceIds { get; }
        /// <summary> The Object representing the different Diagnostic log settings for the Cosmos DB Account. </summary>
        internal DiagnosticLogSettings DiagnosticLogSettings { get; set; }
        /// <summary> Describe the level of detail with which queries are to be logged. </summary>
        [WirePath("properties.diagnosticLogSettings.enableFullTextQuery")]
        public EnableFullTextQuery? DiagnosticLogEnableFullTextQuery
        {
            get => DiagnosticLogSettings is null ? default : DiagnosticLogSettings.EnableFullTextQuery;
            set
            {
                if (DiagnosticLogSettings is null)
                    DiagnosticLogSettings = new DiagnosticLogSettings();
                DiagnosticLogSettings.EnableFullTextQuery = value;
            }
        }

        /// <summary> Opt-out of local authentication and ensure only MSI and AAD can be used exclusively for authentication. </summary>
        [WirePath("properties.disableLocalAuth")]
        public bool? DisableLocalAuth { get; set; }
        /// <summary> The object that represents all properties related to capacity enforcement on an account. </summary>
        internal CosmosDBAccountCapacity Capacity { get; set; }
        /// <summary> The total throughput limit imposed on the account. A totalThroughputLimit of 2000 imposes a strict limit of max throughput that can be provisioned on that account to be 2000. A totalThroughputLimit of -1 indicates no limits on provisioning of throughput. </summary>
        [WirePath("properties.capacity.totalThroughputLimit")]
        public int? CapacityTotalThroughputLimit
        {
            get => Capacity is null ? default : Capacity.TotalThroughputLimit;
            set
            {
                if (Capacity is null)
                    Capacity = new CosmosDBAccountCapacity();
                Capacity.TotalThroughputLimit = value;
            }
        }

        /// <summary> Indicates the capacityMode of the Cosmos DB account. </summary>
        [WirePath("properties.capacityMode")]
        public CapacityMode? CapacityMode { get; set; }
        /// <summary> Flag to indicate whether to enable MaterializedViews on the Cosmos DB account. </summary>
        [WirePath("properties.enableMaterializedViews")]
        public bool? EnableMaterializedViews { get; set; }
        /// <summary> This property is ignored during the update operation, as the metadata is read-only. The object represents the metadata for the Account Keys of the Cosmos DB account. </summary>
        [WirePath("properties.keysMetadata")]
        public DatabaseAccountKeysMetadata KeysMetadata { get; }
        /// <summary> Flag to indicate enabling/disabling of Partition Merge feature on the account. </summary>
        [WirePath("properties.enablePartitionMerge")]
        public bool? EnablePartitionMerge { get; set; }
        /// <summary> Flag to indicate enabling/disabling of Burst Capacity Preview feature on the account. </summary>
        [WirePath("properties.enableBurstCapacity")]
        public bool? EnableBurstCapacity { get; set; }
        /// <summary> Indicates the minimum allowed Tls version. The default is Tls 1.0, except for Cassandra and Mongo API's, which only work with Tls 1.2. </summary>
        [WirePath("properties.minimalTlsVersion")]
        public CosmosDBMinimalTlsVersion? MinimalTlsVersion { get; set; }
        /// <summary> Indicates the status of the Customer Managed Key feature on the account. In case there are errors, the property provides troubleshooting guidance. </summary>
        [WirePath("properties.customerManagedKeyStatus")]
        public string CustomerManagedKeyStatus { get; set; }
        /// <summary> Flag to indicate enabling/disabling of Priority Based Execution Preview feature on the account. </summary>
        [WirePath("properties.enablePriorityBasedExecution")]
        public bool? EnablePriorityBasedExecution { get; set; }
        /// <summary> Enum to indicate default Priority Level of request for Priority Based Execution. </summary>
        [WirePath("properties.defaultPriorityLevel")]
        public DefaultPriorityLevel? DefaultPriorityLevel { get; set; }
        /// <summary> Flag to indicate enabling/disabling of Per-Region Per-partition autoscale Preview feature on the account. </summary>
        [WirePath("properties.enablePerRegionPerPartitionAutoscale")]
        public bool? EnablePerRegionPerPartitionAutoscale { get; set; }
    }
}
