// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Authorization;
using Azure.Provisioning.Expressions;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using Azure.Provisioning.Roles;
using System;
using System.ComponentModel;

namespace Azure.Provisioning.CosmosDB;

/// <summary>
/// CosmosDBAccount.
/// </summary>
public partial class CosmosDBAccount : ProvisionableResource
{
    /// <summary>
    /// Cosmos DB database account name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets or sets the Location.
    /// </summary>
    public BicepValue<AzureLocation> Location 
    {
        get { Initialize(); return _location!; }
        set { Initialize(); _location!.Assign(value); }
    }
    private BicepValue<AzureLocation>? _location;

    /// <summary>
    /// An array that contains the georeplication locations enabled for the
    /// Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> Locations 
    {
        get { Initialize(); return _locations!; }
        set { Initialize(); _locations!.Assign(value); }
    }
    private BicepList<CosmosDBAccountLocation>? _locations;

    /// <summary>
    /// Describes the types of schema for analytical storage.
    /// </summary>
    public BicepValue<AnalyticalStorageSchemaType> AnalyticalStorageSchemaType 
    {
        get { Initialize(); return _analyticalStorageSchemaType!; }
        set { Initialize(); _analyticalStorageSchemaType!.Assign(value); }
    }
    private BicepValue<AnalyticalStorageSchemaType>? _analyticalStorageSchemaType;

    /// <summary>
    /// Describes the ServerVersion of an a MongoDB account.
    /// </summary>
    public BicepValue<CosmosDBServerVersion> ApiServerVersion 
    {
        get { Initialize(); return _apiServerVersion!; }
        set { Initialize(); _apiServerVersion!.Assign(value); }
    }
    private BicepValue<CosmosDBServerVersion>? _apiServerVersion;

    /// <summary>
    /// The object representing the policy for taking backups on an account.
    /// Please note
    /// Azure.ResourceManager.CosmosDB.Models.CosmosDBAccountBackupPolicy is
    /// the base class. According to the scenario, a derived class of the base
    /// class might need to be assigned here, or this property needs to be
    /// casted to one of the possible derived classes.             The
    /// available derived classes include
    /// Azure.ResourceManager.CosmosDB.Models.ContinuousModeBackupPolicy and
    /// Azure.ResourceManager.CosmosDB.Models.PeriodicModeBackupPolicy.
    /// </summary>
    public CosmosDBAccountBackupPolicy BackupPolicy 
    {
        get { Initialize(); return _backupPolicy!; }
        set { Initialize(); AssignOrReplace(ref _backupPolicy, value); }
    }
    private CosmosDBAccountBackupPolicy? _backupPolicy;

    /// <summary>
    /// List of Cosmos DB capabilities for the account.
    /// </summary>
    public BicepList<CosmosDBAccountCapability> Capabilities 
    {
        get { Initialize(); return _capabilities!; }
        set { Initialize(); _capabilities!.Assign(value); }
    }
    private BicepList<CosmosDBAccountCapability>? _capabilities;

    /// <summary>
    /// The total throughput limit imposed on the account. A
    /// totalThroughputLimit of 2000 imposes a strict limit of max throughput
    /// that can be provisioned on that account to be 2000. A
    /// totalThroughputLimit of -1 indicates no limits on provisioning of
    /// throughput.
    /// </summary>
    public BicepValue<int> CapacityTotalThroughputLimit 
    {
        get { Initialize(); return _capacityTotalThroughputLimit!; }
        set { Initialize(); _capacityTotalThroughputLimit!.Assign(value); }
    }
    private BicepValue<int>? _capacityTotalThroughputLimit;

    /// <summary>
    /// The cassandra connector offer type for the Cosmos DB database C*
    /// account.
    /// </summary>
    public BicepValue<ConnectorOffer> ConnectorOffer 
    {
        get { Initialize(); return _connectorOffer!; }
        set { Initialize(); _connectorOffer!.Assign(value); }
    }
    private BicepValue<ConnectorOffer>? _connectorOffer;

    /// <summary>
    /// The consistency policy for the Cosmos DB account.
    /// </summary>
    public ConsistencyPolicy ConsistencyPolicy 
    {
        get { Initialize(); return _consistencyPolicy!; }
        set { Initialize(); AssignOrReplace(ref _consistencyPolicy, value); }
    }
    private ConsistencyPolicy? _consistencyPolicy;

    /// <summary>
    /// The CORS policy for the Cosmos DB database account.
    /// </summary>
    public BicepList<CosmosDBAccountCorsPolicy> Cors 
    {
        get { Initialize(); return _cors!; }
        set { Initialize(); _cors!.Assign(value); }
    }
    private BicepList<CosmosDBAccountCorsPolicy>? _cors;

    /// <summary>
    /// Enum to indicate the mode of account creation.
    /// </summary>
    public BicepValue<CosmosDBAccountCreateMode> CreateMode 
    {
        get { Initialize(); return _createMode!; }
        set { Initialize(); _createMode!.Assign(value); }
    }
    private BicepValue<CosmosDBAccountCreateMode>? _createMode;

    /// <summary>
    /// Indicates the status of the Customer Managed Key feature on the
    /// account. In case there are errors, the property provides
    /// troubleshooting guidance.
    /// </summary>
    public BicepValue<string> CustomerManagedKeyStatus 
    {
        get { Initialize(); return _customerManagedKeyStatus!; }
        set { Initialize(); _customerManagedKeyStatus!.Assign(value); }
    }
    private BicepValue<string>? _customerManagedKeyStatus;

    /// <summary>
    /// The offer type for the database.
    /// </summary>
    public BicepValue<CosmosDBAccountOfferType> DatabaseAccountOfferType 
    {
        get { Initialize(); return _databaseAccountOfferType!; }
        set { Initialize(); _databaseAccountOfferType!.Assign(value); }
    }
    private BicepValue<CosmosDBAccountOfferType>? _databaseAccountOfferType;

    /// <summary>
    /// The default identity for accessing key vault used in features like
    /// customer managed keys. The default identity needs to be explicitly set
    /// by the users. It can be &quot;FirstPartyIdentity&quot;,
    /// &quot;SystemAssignedIdentity&quot; and more.
    /// </summary>
    public BicepValue<string> DefaultIdentity 
    {
        get { Initialize(); return _defaultIdentity!; }
        set { Initialize(); _defaultIdentity!.Assign(value); }
    }
    private BicepValue<string>? _defaultIdentity;

    /// <summary>
    /// Enum to indicate default Priority Level of request for Priority Based
    /// Execution.
    /// </summary>
    public BicepValue<DefaultPriorityLevel> DefaultPriorityLevel 
    {
        get { Initialize(); return _defaultPriorityLevel!; }
        set { Initialize(); _defaultPriorityLevel!.Assign(value); }
    }
    private BicepValue<DefaultPriorityLevel>? _defaultPriorityLevel;

    /// <summary>
    /// Describe the level of detail with which queries are to be logged.
    /// </summary>
    public BicepValue<EnableFullTextQuery> DiagnosticLogEnableFullTextQuery 
    {
        get { Initialize(); return _diagnosticLogEnableFullTextQuery!; }
        set { Initialize(); _diagnosticLogEnableFullTextQuery!.Assign(value); }
    }
    private BicepValue<EnableFullTextQuery>? _diagnosticLogEnableFullTextQuery;

    /// <summary>
    /// Disable write operations on metadata resources (databases, containers,
    /// throughput) via account keys.
    /// </summary>
    public BicepValue<bool> DisableKeyBasedMetadataWriteAccess 
    {
        get { Initialize(); return _disableKeyBasedMetadataWriteAccess!; }
        set { Initialize(); _disableKeyBasedMetadataWriteAccess!.Assign(value); }
    }
    private BicepValue<bool>? _disableKeyBasedMetadataWriteAccess;

    /// <summary>
    /// Opt-out of local authentication and ensure only MSI and AAD can be used
    /// exclusively for authentication.
    /// </summary>
    public BicepValue<bool> DisableLocalAuth 
    {
        get { Initialize(); return _disableLocalAuth!; }
        set { Initialize(); _disableLocalAuth!.Assign(value); }
    }
    private BicepValue<bool>? _disableLocalAuth;

    /// <summary>
    /// Enables automatic failover of the write region in the rare event that
    /// the region is unavailable due to an outage. Automatic failover will
    /// result in a new write region for the account and is chosen based on
    /// the failover priorities configured for the account.
    /// </summary>
    public BicepValue<bool> EnableAutomaticFailover 
    {
        get { Initialize(); return _enableAutomaticFailover!; }
        set { Initialize(); _enableAutomaticFailover!.Assign(value); }
    }
    private BicepValue<bool>? _enableAutomaticFailover;

    /// <summary>
    /// Flag to indicate enabling/disabling of Burst Capacity Preview feature
    /// on the account.
    /// </summary>
    public BicepValue<bool> EnableBurstCapacity 
    {
        get { Initialize(); return _enableBurstCapacity!; }
        set { Initialize(); _enableBurstCapacity!.Assign(value); }
    }
    private BicepValue<bool>? _enableBurstCapacity;

    /// <summary>
    /// Enables the cassandra connector on the Cosmos DB C* account.
    /// </summary>
    public BicepValue<bool> EnableCassandraConnector 
    {
        get { Initialize(); return _enableCassandraConnector!; }
        set { Initialize(); _enableCassandraConnector!.Assign(value); }
    }
    private BicepValue<bool>? _enableCassandraConnector;

    /// <summary>
    /// Flag to indicate whether to enable MaterializedViews on the Cosmos DB
    /// account.
    /// </summary>
    public BicepValue<bool> EnableMaterializedViews 
    {
        get { Initialize(); return _enableMaterializedViews!; }
        set { Initialize(); _enableMaterializedViews!.Assign(value); }
    }
    private BicepValue<bool>? _enableMaterializedViews;

    /// <summary>
    /// Enables the account to write in multiple locations.
    /// </summary>
    public BicepValue<bool> EnableMultipleWriteLocations 
    {
        get { Initialize(); return _enableMultipleWriteLocations!; }
        set { Initialize(); _enableMultipleWriteLocations!.Assign(value); }
    }
    private BicepValue<bool>? _enableMultipleWriteLocations;

    /// <summary>
    /// Flag to indicate enabling/disabling of Partition Merge feature on the
    /// account.
    /// </summary>
    public BicepValue<bool> EnablePartitionMerge 
    {
        get { Initialize(); return _enablePartitionMerge!; }
        set { Initialize(); _enablePartitionMerge!.Assign(value); }
    }
    private BicepValue<bool>? _enablePartitionMerge;

    /// <summary>
    /// Flag to indicate enabling/disabling of Per-Region Per-partition
    /// autoscale Preview feature on the account.
    /// </summary>
    public BicepValue<bool> EnablePerRegionPerPartitionAutoscale 
    {
        get { Initialize(); return _enablePerRegionPerPartitionAutoscale!; }
        set { Initialize(); _enablePerRegionPerPartitionAutoscale!.Assign(value); }
    }
    private BicepValue<bool>? _enablePerRegionPerPartitionAutoscale;

    /// <summary>
    /// Flag to indicate enabling/disabling of Priority Based Execution Preview
    /// feature on the account.
    /// </summary>
    public BicepValue<bool> EnablePriorityBasedExecution 
    {
        get { Initialize(); return _enablePriorityBasedExecution!; }
        set { Initialize(); _enablePriorityBasedExecution!.Assign(value); }
    }
    private BicepValue<bool>? _enablePriorityBasedExecution;

    /// <summary>
    /// Identity for the resource.
    /// </summary>
    public ManagedServiceIdentity Identity 
    {
        get { Initialize(); return _identity!; }
        set { Initialize(); AssignOrReplace(ref _identity, value); }
    }
    private ManagedServiceIdentity? _identity;

    /// <summary>
    /// List of IpRules.
    /// </summary>
    public BicepList<CosmosDBIPAddressOrRange> IPRules 
    {
        get { Initialize(); return _iPRules!; }
        set { Initialize(); _iPRules!.Assign(value); }
    }
    private BicepList<CosmosDBIPAddressOrRange>? _iPRules;

    /// <summary>
    /// Flag to indicate whether to enable storage analytics.
    /// </summary>
    public BicepValue<bool> IsAnalyticalStorageEnabled 
    {
        get { Initialize(); return _isAnalyticalStorageEnabled!; }
        set { Initialize(); _isAnalyticalStorageEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isAnalyticalStorageEnabled;

    /// <summary>
    /// Flag to indicate whether Free Tier is enabled.
    /// </summary>
    public BicepValue<bool> IsFreeTierEnabled 
    {
        get { Initialize(); return _isFreeTierEnabled!; }
        set { Initialize(); _isFreeTierEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isFreeTierEnabled;

    /// <summary>
    /// Flag to indicate whether to enable/disable Virtual Network ACL rules.
    /// </summary>
    public BicepValue<bool> IsVirtualNetworkFilterEnabled 
    {
        get { Initialize(); return _isVirtualNetworkFilterEnabled!; }
        set { Initialize(); _isVirtualNetworkFilterEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isVirtualNetworkFilterEnabled;

    /// <summary>
    /// The URI of the key vault.
    /// </summary>
    public BicepValue<Uri> KeyVaultKeyUri 
    {
        get { Initialize(); return _keyVaultKeyUri!; }
        set { Initialize(); _keyVaultKeyUri!.Assign(value); }
    }
    private BicepValue<Uri>? _keyVaultKeyUri;

    /// <summary>
    /// Indicates the type of database account. This can only be set at
    /// database account creation.
    /// </summary>
    public BicepValue<CosmosDBAccountKind> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<CosmosDBAccountKind>? _kind;

    /// <summary>
    /// Indicates the minimum allowed Tls version. The default is Tls 1.0,
    /// except for Cassandra and Mongo API&apos;s, which only work with Tls
    /// 1.2.
    /// </summary>
    public BicepValue<CosmosDBMinimalTlsVersion> MinimalTlsVersion 
    {
        get { Initialize(); return _minimalTlsVersion!; }
        set { Initialize(); _minimalTlsVersion!.Assign(value); }
    }
    private BicepValue<CosmosDBMinimalTlsVersion>? _minimalTlsVersion;

    /// <summary>
    /// Indicates what services are allowed to bypass firewall checks.
    /// </summary>
    public BicepValue<NetworkAclBypass> NetworkAclBypass 
    {
        get { Initialize(); return _networkAclBypass!; }
        set { Initialize(); _networkAclBypass!.Assign(value); }
    }
    private BicepValue<NetworkAclBypass>? _networkAclBypass;

    /// <summary>
    /// An array that contains the Resource Ids for Network Acl Bypass for the
    /// Cosmos DB account.
    /// </summary>
    public BicepList<ResourceIdentifier> NetworkAclBypassResourceIds 
    {
        get { Initialize(); return _networkAclBypassResourceIds!; }
        set { Initialize(); _networkAclBypassResourceIds!.Assign(value); }
    }
    private BicepList<ResourceIdentifier>? _networkAclBypassResourceIds;

    /// <summary>
    /// Whether requests from Public Network are allowed.
    /// </summary>
    public BicepValue<CosmosDBPublicNetworkAccess> PublicNetworkAccess 
    {
        get { Initialize(); return _publicNetworkAccess!; }
        set { Initialize(); _publicNetworkAccess!.Assign(value); }
    }
    private BicepValue<CosmosDBPublicNetworkAccess>? _publicNetworkAccess;

    /// <summary>
    /// Parameters to indicate the information about the restore.
    /// </summary>
    public CosmosDBAccountRestoreParameters RestoreParameters 
    {
        get { Initialize(); return _restoreParameters!; }
        set { Initialize(); AssignOrReplace(ref _restoreParameters, value); }
    }
    private CosmosDBAccountRestoreParameters? _restoreParameters;

    /// <summary>
    /// Gets or sets the Tags.
    /// </summary>
    public BicepDictionary<string> Tags 
    {
        get { Initialize(); return _tags!; }
        set { Initialize(); _tags!.Assign(value); }
    }
    private BicepDictionary<string>? _tags;

    /// <summary>
    /// List of Virtual Network ACL rules configured for the Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBVirtualNetworkRule> VirtualNetworkRules 
    {
        get { Initialize(); return _virtualNetworkRules!; }
        set { Initialize(); _virtualNetworkRules!.Assign(value); }
    }
    private BicepList<CosmosDBVirtualNetworkRule>? _virtualNetworkRules;

    /// <summary>
    /// The connection endpoint for the Cosmos DB database account.
    /// </summary>
    public BicepValue<string> DocumentEndpoint 
    {
        get { Initialize(); return _documentEndpoint!; }
    }
    private BicepValue<string>? _documentEndpoint;

    /// <summary>
    /// An array that contains the regions ordered by their failover priorities.
    /// </summary>
    public BicepList<CosmosDBFailoverPolicy> FailoverPolicies 
    {
        get { Initialize(); return _failoverPolicies!; }
    }
    private BicepList<CosmosDBFailoverPolicy>? _failoverPolicies;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// A unique identifier assigned to the database account.
    /// </summary>
    public BicepValue<Guid> InstanceId 
    {
        get { Initialize(); return _instanceId!; }
    }
    private BicepValue<Guid>? _instanceId;

    /// <summary>
    /// This property is ignored during the update/create operation, as the
    /// metadata is read-only. The object represents the metadata for the
    /// Account Keys of the Cosmos DB account.
    /// </summary>
    public DatabaseAccountKeysMetadata KeysMetadata 
    {
        get { Initialize(); return _keysMetadata!; }
    }
    private DatabaseAccountKeysMetadata? _keysMetadata;

    /// <summary>
    /// List of Private Endpoint Connections configured for the Cosmos DB
    /// account.
    /// </summary>
    public BicepList<CosmosDBPrivateEndpointConnectionData> PrivateEndpointConnections 
    {
        get { Initialize(); return _privateEndpointConnections!; }
    }
    private BicepList<CosmosDBPrivateEndpointConnectionData>? _privateEndpointConnections;

    /// <summary>
    /// The status of the Cosmos DB account at the time the operation was
    /// called. The status can be one of following. &apos;Creating&apos; – the
    /// Cosmos DB account is being created. When an account is in Creating
    /// state, only properties that are specified as input for the Create
    /// Cosmos DB account operation are returned. &apos;Succeeded&apos; – the
    /// Cosmos DB account is active for use. &apos;Updating&apos; – the Cosmos
    /// DB account is being updated. &apos;Deleting&apos; – the Cosmos DB
    /// account is being deleted. &apos;Failed&apos; – the Cosmos DB account
    /// failed creation. &apos;DeletionFailed&apos; – the Cosmos DB account
    /// deletion failed.
    /// </summary>
    public BicepValue<string> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
    }
    private BicepValue<string>? _provisioningState;

    /// <summary>
    /// An array that contains of the read locations enabled for the Cosmos DB
    /// account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> ReadLocations 
    {
        get { Initialize(); return _readLocations!; }
    }
    private BicepList<CosmosDBAccountLocation>? _readLocations;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// An array that contains the write location for the Cosmos DB account.
    /// </summary>
    public BicepList<CosmosDBAccountLocation> WriteLocations 
    {
        get { Initialize(); return _writeLocations!; }
    }
    private BicepList<CosmosDBAccountLocation>? _writeLocations;

    /// <summary>
    /// Creates a new CosmosDBAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBAccount resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBAccount.</param>
    public CosmosDBAccount(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.DocumentDB/databaseAccounts", resourceVersion ?? "2024-08-15")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of CosmosDBAccount.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _location = DefineProperty<AzureLocation>("Location", ["location"], isRequired: true);
        _locations = DefineListProperty<CosmosDBAccountLocation>("Locations", ["properties", "locations"], isRequired: true);
        _analyticalStorageSchemaType = DefineProperty<AnalyticalStorageSchemaType>("AnalyticalStorageSchemaType", ["properties", "analyticalStorageConfiguration", "schemaType"]);
        _apiServerVersion = DefineProperty<CosmosDBServerVersion>("ApiServerVersion", ["properties", "apiProperties", "serverVersion"]);
        _backupPolicy = DefineModelProperty<CosmosDBAccountBackupPolicy>("BackupPolicy", ["properties", "backupPolicy"]);
        _capabilities = DefineListProperty<CosmosDBAccountCapability>("Capabilities", ["properties", "capabilities"]);
        _capacityTotalThroughputLimit = DefineProperty<int>("CapacityTotalThroughputLimit", ["properties", "capacity", "totalThroughputLimit"]);
        _connectorOffer = DefineProperty<ConnectorOffer>("ConnectorOffer", ["properties", "connectorOffer"]);
        _consistencyPolicy = DefineModelProperty<ConsistencyPolicy>("ConsistencyPolicy", ["properties", "consistencyPolicy"]);
        _cors = DefineListProperty<CosmosDBAccountCorsPolicy>("Cors", ["properties", "cors"]);
        _createMode = DefineProperty<CosmosDBAccountCreateMode>("CreateMode", ["properties", "createMode"]);
        _customerManagedKeyStatus = DefineProperty<string>("CustomerManagedKeyStatus", ["properties", "customerManagedKeyStatus"]);
        _databaseAccountOfferType = DefineProperty<CosmosDBAccountOfferType>("DatabaseAccountOfferType", ["properties", "databaseAccountOfferType"]);
        _defaultIdentity = DefineProperty<string>("DefaultIdentity", ["properties", "defaultIdentity"]);
        _defaultPriorityLevel = DefineProperty<DefaultPriorityLevel>("DefaultPriorityLevel", ["properties", "defaultPriorityLevel"]);
        _diagnosticLogEnableFullTextQuery = DefineProperty<EnableFullTextQuery>("DiagnosticLogEnableFullTextQuery", ["properties", "diagnosticLogSettings", "enableFullTextQuery"]);
        _disableKeyBasedMetadataWriteAccess = DefineProperty<bool>("DisableKeyBasedMetadataWriteAccess", ["properties", "disableKeyBasedMetadataWriteAccess"]);
        _disableLocalAuth = DefineProperty<bool>("DisableLocalAuth", ["properties", "disableLocalAuth"]);
        _enableAutomaticFailover = DefineProperty<bool>("EnableAutomaticFailover", ["properties", "enableAutomaticFailover"]);
        _enableBurstCapacity = DefineProperty<bool>("EnableBurstCapacity", ["properties", "enableBurstCapacity"]);
        _enableCassandraConnector = DefineProperty<bool>("EnableCassandraConnector", ["properties", "enableCassandraConnector"]);
        _enableMaterializedViews = DefineProperty<bool>("EnableMaterializedViews", ["properties", "enableMaterializedViews"]);
        _enableMultipleWriteLocations = DefineProperty<bool>("EnableMultipleWriteLocations", ["properties", "enableMultipleWriteLocations"]);
        _enablePartitionMerge = DefineProperty<bool>("EnablePartitionMerge", ["properties", "enablePartitionMerge"]);
        _enablePerRegionPerPartitionAutoscale = DefineProperty<bool>("EnablePerRegionPerPartitionAutoscale", ["properties", "enablePerRegionPerPartitionAutoscale"]);
        _enablePriorityBasedExecution = DefineProperty<bool>("EnablePriorityBasedExecution", ["properties", "enablePriorityBasedExecution"]);
        _identity = DefineModelProperty<ManagedServiceIdentity>("Identity", ["identity"]);
        _iPRules = DefineListProperty<CosmosDBIPAddressOrRange>("IPRules", ["properties", "ipRules"]);
        _isAnalyticalStorageEnabled = DefineProperty<bool>("IsAnalyticalStorageEnabled", ["properties", "enableAnalyticalStorage"]);
        _isFreeTierEnabled = DefineProperty<bool>("IsFreeTierEnabled", ["properties", "enableFreeTier"]);
        _isVirtualNetworkFilterEnabled = DefineProperty<bool>("IsVirtualNetworkFilterEnabled", ["properties", "isVirtualNetworkFilterEnabled"]);
        _keyVaultKeyUri = DefineProperty<Uri>("KeyVaultKeyUri", ["properties", "keyVaultKeyUri"]);
        _kind = DefineProperty<CosmosDBAccountKind>("Kind", ["kind"]);
        _minimalTlsVersion = DefineProperty<CosmosDBMinimalTlsVersion>("MinimalTlsVersion", ["properties", "minimalTlsVersion"]);
        _networkAclBypass = DefineProperty<NetworkAclBypass>("NetworkAclBypass", ["properties", "networkAclBypass"]);
        _networkAclBypassResourceIds = DefineListProperty<ResourceIdentifier>("NetworkAclBypassResourceIds", ["properties", "networkAclBypassResourceIds"]);
        _publicNetworkAccess = DefineProperty<CosmosDBPublicNetworkAccess>("PublicNetworkAccess", ["properties", "publicNetworkAccess"]);
        _restoreParameters = DefineModelProperty<CosmosDBAccountRestoreParameters>("RestoreParameters", ["properties", "restoreParameters"]);
        _tags = DefineDictionaryProperty<string>("Tags", ["tags"]);
        _virtualNetworkRules = DefineListProperty<CosmosDBVirtualNetworkRule>("VirtualNetworkRules", ["properties", "virtualNetworkRules"]);
        _documentEndpoint = DefineProperty<string>("DocumentEndpoint", ["properties", "documentEndpoint"], isOutput: true);
        _failoverPolicies = DefineListProperty<CosmosDBFailoverPolicy>("FailoverPolicies", ["properties", "failoverPolicies"], isOutput: true);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _instanceId = DefineProperty<Guid>("InstanceId", ["properties", "instanceId"], isOutput: true);
        _keysMetadata = DefineModelProperty<DatabaseAccountKeysMetadata>("KeysMetadata", ["properties", "keysMetadata"], isOutput: true);
        _privateEndpointConnections = DefineListProperty<CosmosDBPrivateEndpointConnectionData>("PrivateEndpointConnections", ["properties", "privateEndpointConnections"], isOutput: true);
        _provisioningState = DefineProperty<string>("ProvisioningState", ["properties", "provisioningState"], isOutput: true);
        _readLocations = DefineListProperty<CosmosDBAccountLocation>("ReadLocations", ["properties", "readLocations"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _writeLocations = DefineListProperty<CosmosDBAccountLocation>("WriteLocations", ["properties", "writeLocations"], isOutput: true);
    }

    /// <summary>
    /// Supported CosmosDBAccount resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2024-08-15.
        /// </summary>
        public static readonly string V2024_08_15 = "2024-08-15";

        /// <summary>
        /// 2024-05-15.
        /// </summary>
        public static readonly string V2024_05_15 = "2024-05-15";

        /// <summary>
        /// 2023-11-15.
        /// </summary>
        public static readonly string V2023_11_15 = "2023-11-15";

        /// <summary>
        /// 2023-09-15.
        /// </summary>
        public static readonly string V2023_09_15 = "2023-09-15";

        /// <summary>
        /// 2023-04-15.
        /// </summary>
        public static readonly string V2023_04_15 = "2023-04-15";

        /// <summary>
        /// 2023-03-15.
        /// </summary>
        public static readonly string V2023_03_15 = "2023-03-15";

        /// <summary>
        /// 2022-11-15.
        /// </summary>
        public static readonly string V2022_11_15 = "2022-11-15";

        /// <summary>
        /// 2022-08-15.
        /// </summary>
        public static readonly string V2022_08_15 = "2022-08-15";

        /// <summary>
        /// 2022-05-15.
        /// </summary>
        public static readonly string V2022_05_15 = "2022-05-15";

        /// <summary>
        /// 2021-10-15.
        /// </summary>
        public static readonly string V2021_10_15 = "2021-10-15";

        /// <summary>
        /// 2021-06-15.
        /// </summary>
        public static readonly string V2021_06_15 = "2021-06-15";

        /// <summary>
        /// 2021-05-15.
        /// </summary>
        public static readonly string V2021_05_15 = "2021-05-15";

        /// <summary>
        /// 2021-04-15.
        /// </summary>
        public static readonly string V2021_04_15 = "2021-04-15";

        /// <summary>
        /// 2021-03-15.
        /// </summary>
        public static readonly string V2021_03_15 = "2021-03-15";

        /// <summary>
        /// 2021-01-15.
        /// </summary>
        public static readonly string V2021_01_15 = "2021-01-15";

        /// <summary>
        /// 2020-09-01.
        /// </summary>
        public static readonly string V2020_09_01 = "2020-09-01";

        /// <summary>
        /// 2020-04-01.
        /// </summary>
        public static readonly string V2020_04_01 = "2020-04-01";

        /// <summary>
        /// 2020-03-01.
        /// </summary>
        public static readonly string V2020_03_01 = "2020-03-01";

        /// <summary>
        /// 2019-12-12.
        /// </summary>
        public static readonly string V2019_12_12 = "2019-12-12";

        /// <summary>
        /// 2019-08-01.
        /// </summary>
        public static readonly string V2019_08_01 = "2019-08-01";

        /// <summary>
        /// 2016-03-31.
        /// </summary>
        public static readonly string V2016_03_31 = "2016-03-31";

        /// <summary>
        /// 2016-03-19.
        /// </summary>
        public static readonly string V2016_03_19 = "2016-03-19";

        /// <summary>
        /// 2015-11-06.
        /// </summary>
        public static readonly string V2015_11_06 = "2015-11-06";

        /// <summary>
        /// 2015-04-08.
        /// </summary>
        public static readonly string V2015_04_08 = "2015-04-08";

        /// <summary>
        /// 2014-04-01.
        /// </summary>
        public static readonly string V2014_04_01 = "2014-04-01";
    }

    /// <summary>
    /// Creates a reference to an existing CosmosDBAccount.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the CosmosDBAccount resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the CosmosDBAccount.</param>
    /// <returns>The existing CosmosDBAccount resource.</returns>
    public static CosmosDBAccount FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };

    /// <summary>
    /// Get the requirements for naming this CosmosDBAccount resource.
    /// </summary>
    /// <returns>Naming requirements.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override ResourceNameRequirements GetResourceNameRequirements() =>
        new(minLength: 3, maxLength: 44, validCharacters: ResourceNameCharacters.LowercaseLetters | ResourceNameCharacters.Numbers | ResourceNameCharacters.Hyphen);

    /// <summary>
    /// Get access keys for this CosmosDBAccount resource.
    /// </summary>
    /// <returns>The keys for this CosmosDBAccount resource.</returns>
    public CosmosDBAccountKeyList GetKeys()
    {
        CosmosDBAccountKeyList key = new();
        ((IBicepValue)key).Expression = new FunctionCallExpression(new MemberExpression(new IdentifierExpression(BicepIdentifier), "listKeys"));
        return key;
    }

    /// <summary>
    /// Creates a role assignment for a user-assigned identity that grants
    /// access to this CosmosDBAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="identity">The <see cref="UserAssignedIdentity"/>.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(CosmosDBBuiltInRole role, UserAssignedIdentity identity) =>
        new($"{BicepIdentifier}_{identity.BicepIdentifier}_{CosmosDBBuiltInRole.GetBuiltInRoleName(role)}")
        {
            Name = BicepFunction.CreateGuid(Id, identity.PrincipalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = RoleManagementPrincipalType.ServicePrincipal,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = identity.PrincipalId
        };

    /// <summary>
    /// Creates a role assignment for a principal that grants access to this
    /// CosmosDBAccount.
    /// </summary>
    /// <param name="role">The role to grant.</param>
    /// <param name="principalType">The type of the principal to assign to.</param>
    /// <param name="principalId">The principal to assign to.</param>
    /// <param name="bicepIdentifierSuffix">Optional role assignment identifier name suffix.</param>
    /// <returns>The <see cref="RoleAssignment"/>.</returns>
    public RoleAssignment CreateRoleAssignment(CosmosDBBuiltInRole role, BicepValue<RoleManagementPrincipalType> principalType, BicepValue<Guid> principalId, string? bicepIdentifierSuffix = default) =>
        new($"{BicepIdentifier}_{CosmosDBBuiltInRole.GetBuiltInRoleName(role)}{(bicepIdentifierSuffix is null ? "" : "_")}{bicepIdentifierSuffix}")
        {
            Name = BicepFunction.CreateGuid(Id, principalId, BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString())),
            Scope = new IdentifierExpression(BicepIdentifier),
            PrincipalType = principalType,
            RoleDefinitionId = BicepFunction.GetSubscriptionResourceId("Microsoft.Authorization/roleDefinitions", role.ToString()),
            PrincipalId = principalId
        };
}
