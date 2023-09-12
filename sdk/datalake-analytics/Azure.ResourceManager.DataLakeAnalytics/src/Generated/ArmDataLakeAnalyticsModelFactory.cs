// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Azure.Core;
using Azure.ResourceManager.DataLakeAnalytics;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataLakeAnalytics.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmDataLakeAnalyticsModelFactory
    {
        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountBasic. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accountId">
        /// The unique identifier associated with this Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.accountId
        /// </param>
        /// <param name="provisioningState">
        /// The provisioning status of the Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.provisioningState
        /// </param>
        /// <param name="state">
        /// The state of the Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.state
        /// </param>
        /// <param name="createdOn">
        /// The account creation time.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.creationTime
        /// </param>
        /// <param name="lastModifiedOn">
        /// The account last modified time.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.lastModifiedTime
        /// </param>
        /// <param name="endpoint">
        /// The full CName endpoint for this account.
        /// Serialized Name: DataLakeAnalyticsAccountBasic.properties.endpoint
        /// </param>
        /// <param name="location">
        /// The resource location.
        /// Serialized Name: Resource.location
        /// </param>
        /// <param name="tags">
        /// The resource tags.
        /// Serialized Name: Resource.tags
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsAccountBasic"/> instance for mocking. </returns>
        public static DataLakeAnalyticsAccountBasic DataLakeAnalyticsAccountBasic(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? accountId = null, DataLakeAnalyticsAccountStatus? provisioningState = null, DataLakeAnalyticsAccountState? state = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string endpoint = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new DataLakeAnalyticsAccountBasic(id, name, resourceType, systemData, accountId, provisioningState, state, createdOn, lastModifiedOn, endpoint, location, tags);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="accountId">
        /// The unique identifier associated with this Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.accountId
        /// </param>
        /// <param name="provisioningState">
        /// The provisioning status of the Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.provisioningState
        /// </param>
        /// <param name="state">
        /// The state of the Data Lake Analytics account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.state
        /// </param>
        /// <param name="createdOn">
        /// The account creation time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.creationTime
        /// </param>
        /// <param name="lastModifiedOn">
        /// The account last modified time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.lastModifiedTime
        /// </param>
        /// <param name="endpoint">
        /// The full CName endpoint for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.endpoint
        /// </param>
        /// <param name="defaultDataLakeStoreAccount">
        /// The default Data Lake Store account associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.defaultDataLakeStoreAccount
        /// </param>
        /// <param name="dataLakeStoreAccounts">
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.dataLakeStoreAccounts
        /// </param>
        /// <param name="publicDataLakeStoreAccounts">
        /// The list of Data Lake Store accounts associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.publicDataLakeStoreAccounts
        /// </param>
        /// <param name="storageAccounts">
        /// The list of Azure Blob Storage accounts associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.storageAccounts
        /// </param>
        /// <param name="computePolicies">
        /// The list of compute policies associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.computePolicies
        /// </param>
        /// <param name="hiveMetastores">
        /// The list of hiveMetastores associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.hiveMetastores
        /// </param>
        /// <param name="virtualNetworkRules">
        /// The list of virtualNetwork rules associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.virtualNetworkRules
        /// </param>
        /// <param name="firewallRules">
        /// The list of firewall rules associated with this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.firewallRules
        /// </param>
        /// <param name="firewallState">
        /// The current state of the IP address firewall for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.firewallState
        /// </param>
        /// <param name="firewallAllowAzureIPs">
        /// The current state of allowing or disallowing IPs originating within Azure through the firewall. If the firewall is disabled, this is not enforced.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.firewallAllowAzureIps
        /// </param>
        /// <param name="newTier">
        /// The commitment tier for the next month.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.newTier
        /// </param>
        /// <param name="currentTier">
        /// The commitment tier in use for the current month.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.currentTier
        /// </param>
        /// <param name="maxJobCount">
        /// The maximum supported jobs running under the account at the same time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxJobCount
        /// </param>
        /// <param name="maxActiveJobCountPerUser">
        /// The maximum supported active jobs under the account at the same time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxActiveJobCountPerUser
        /// </param>
        /// <param name="maxQueuedJobCountPerUser">
        /// The maximum supported jobs queued under the account at the same time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxQueuedJobCountPerUser
        /// </param>
        /// <param name="maxJobRunningTimeInMin">
        /// The maximum supported active jobs under the account at the same time.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxJobRunningTimeInMin
        /// </param>
        /// <param name="systemMaxJobCount">
        /// The system defined maximum supported jobs running under the account at the same time, which restricts the maximum number of running jobs the user can set for the account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.systemMaxJobCount
        /// </param>
        /// <param name="maxDegreeOfParallelism">
        /// The maximum supported degree of parallelism for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxDegreeOfParallelism
        /// </param>
        /// <param name="systemMaxDegreeOfParallelism">
        /// The system defined maximum supported degree of parallelism for this account, which restricts the maximum value of parallelism the user can set for the account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.systemMaxDegreeOfParallelism
        /// </param>
        /// <param name="maxDegreeOfParallelismPerJob">
        /// The maximum supported degree of parallelism per job for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.maxDegreeOfParallelismPerJob
        /// </param>
        /// <param name="minPriorityPerJob">
        /// The minimum supported priority per job for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.minPriorityPerJob
        /// </param>
        /// <param name="queryStoreRetention">
        /// The number of days that job metadata is retained.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.queryStoreRetention
        /// </param>
        /// <param name="debugDataAccessLevel">
        /// The current state of the DebugDataAccessLevel for this account.
        /// Serialized Name: DataLakeAnalyticsAccount.properties.debugDataAccessLevel
        /// </param>
        /// <param name="location">
        /// The resource location.
        /// Serialized Name: Resource.location
        /// </param>
        /// <param name="tags">
        /// The resource tags.
        /// Serialized Name: Resource.tags
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeAnalyticsAccountData"/> instance for mocking. </returns>
        public static DataLakeAnalyticsAccountData DataLakeAnalyticsAccountData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? accountId = null, DataLakeAnalyticsAccountStatus? provisioningState = null, DataLakeAnalyticsAccountState? state = null, DateTimeOffset? createdOn = null, DateTimeOffset? lastModifiedOn = null, string endpoint = null, string defaultDataLakeStoreAccount = null, IEnumerable<DataLakeStoreAccountInformationData> dataLakeStoreAccounts = null, IEnumerable<DataLakeStoreAccountInformationData> publicDataLakeStoreAccounts = null, IEnumerable<DataLakeAnalyticsStorageAccountInformationData> storageAccounts = null, IEnumerable<DataLakeAnalyticsComputePolicyData> computePolicies = null, IEnumerable<DataLakeAnalyticsHiveMetastore> hiveMetastores = null, IEnumerable<DataLakeAnalyticsVirtualNetworkRule> virtualNetworkRules = null, IEnumerable<DataLakeAnalyticsFirewallRuleData> firewallRules = null, DataLakeAnalyticsFirewallState? firewallState = null, FirewallAllowAzureIPsState? firewallAllowAzureIPs = null, DataLakeAnalyticsCommitmentTierType? newTier = null, DataLakeAnalyticsCommitmentTierType? currentTier = null, int? maxJobCount = null, int? maxActiveJobCountPerUser = null, int? maxQueuedJobCountPerUser = null, int? maxJobRunningTimeInMin = null, int? systemMaxJobCount = null, int? maxDegreeOfParallelism = null, int? systemMaxDegreeOfParallelism = null, int? maxDegreeOfParallelismPerJob = null, int? minPriorityPerJob = null, int? queryStoreRetention = null, DebugDataAccessLevel? debugDataAccessLevel = null, AzureLocation? location = null, IReadOnlyDictionary<string, string> tags = null)
        {
            dataLakeStoreAccounts ??= new List<DataLakeStoreAccountInformationData>();
            publicDataLakeStoreAccounts ??= new List<DataLakeStoreAccountInformationData>();
            storageAccounts ??= new List<DataLakeAnalyticsStorageAccountInformationData>();
            computePolicies ??= new List<DataLakeAnalyticsComputePolicyData>();
            hiveMetastores ??= new List<DataLakeAnalyticsHiveMetastore>();
            virtualNetworkRules ??= new List<DataLakeAnalyticsVirtualNetworkRule>();
            firewallRules ??= new List<DataLakeAnalyticsFirewallRuleData>();
            tags ??= new Dictionary<string, string>();

            return new DataLakeAnalyticsAccountData(id, name, resourceType, systemData, accountId, provisioningState, state, createdOn, lastModifiedOn, endpoint, defaultDataLakeStoreAccount, dataLakeStoreAccounts?.ToList(), publicDataLakeStoreAccounts?.ToList(), storageAccounts?.ToList(), computePolicies?.ToList(), hiveMetastores?.ToList(), virtualNetworkRules?.ToList(), firewallRules?.ToList(), firewallState, firewallAllowAzureIPs, newTier, currentTier, maxJobCount, maxActiveJobCountPerUser, maxQueuedJobCountPerUser, maxJobRunningTimeInMin, systemMaxJobCount, maxDegreeOfParallelism, systemMaxDegreeOfParallelism, maxDegreeOfParallelismPerJob, minPriorityPerJob, queryStoreRetention, debugDataAccessLevel, location, tags);
        }

        /// <summary> Initializes a new instance of DataLakeStoreAccountInformationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suffix">
        /// The optional suffix for the Data Lake Store account.
        /// Serialized Name: DataLakeStoreAccountInformation.properties.suffix
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeStoreAccountInformationData"/> instance for mocking. </returns>
        public static DataLakeStoreAccountInformationData DataLakeStoreAccountInformationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string suffix = null)
        {
            return new DataLakeStoreAccountInformationData(id, name, resourceType, systemData, suffix);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsStorageAccountInformationData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="suffix">
        /// The optional suffix for the storage account.
        /// Serialized Name: StorageAccountInformation.properties.suffix
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeAnalyticsStorageAccountInformationData"/> instance for mocking. </returns>
        public static DataLakeAnalyticsStorageAccountInformationData DataLakeAnalyticsStorageAccountInformationData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string suffix = null)
        {
            return new DataLakeAnalyticsStorageAccountInformationData(id, name, resourceType, systemData, suffix);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsComputePolicyData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="objectId">
        /// The AAD object identifier for the entity to create a policy for.
        /// Serialized Name: ComputePolicy.properties.objectId
        /// </param>
        /// <param name="objectType">
        /// The type of AAD object the object identifier refers to.
        /// Serialized Name: ComputePolicy.properties.objectType
        /// </param>
        /// <param name="maxDegreeOfParallelismPerJob">
        /// The maximum degree of parallelism per job this user can use to submit jobs.
        /// Serialized Name: ComputePolicy.properties.maxDegreeOfParallelismPerJob
        /// </param>
        /// <param name="minPriorityPerJob">
        /// The minimum priority per job this user can use to submit jobs.
        /// Serialized Name: ComputePolicy.properties.minPriorityPerJob
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeAnalyticsComputePolicyData"/> instance for mocking. </returns>
        public static DataLakeAnalyticsComputePolicyData DataLakeAnalyticsComputePolicyData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Guid? objectId = null, AadObjectIdentifierType? objectType = null, int? maxDegreeOfParallelismPerJob = null, int? minPriorityPerJob = null)
        {
            return new DataLakeAnalyticsComputePolicyData(id, name, resourceType, systemData, objectId, objectType, maxDegreeOfParallelismPerJob, minPriorityPerJob);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsHiveMetastore. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="serverUri">
        /// The serverUri for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.serverUri
        /// </param>
        /// <param name="databaseName">
        /// The databaseName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.databaseName
        /// </param>
        /// <param name="runtimeVersion">
        /// The runtimeVersion for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.runtimeVersion
        /// </param>
        /// <param name="userName">
        /// The userName for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.userName
        /// </param>
        /// <param name="password">
        /// The password for the Hive MetaStore
        /// Serialized Name: HiveMetastore.properties.password
        /// </param>
        /// <param name="nestedResourceProvisioningState">
        /// The current state of the NestedResource
        /// Serialized Name: HiveMetastore.properties.nestedResourceProvisioningState
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsHiveMetastore"/> instance for mocking. </returns>
        public static DataLakeAnalyticsHiveMetastore DataLakeAnalyticsHiveMetastore(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, Uri serverUri = null, string databaseName = null, string runtimeVersion = null, string userName = null, string password = null, NestedResourceProvisioningState? nestedResourceProvisioningState = null)
        {
            return new DataLakeAnalyticsHiveMetastore(id, name, resourceType, systemData, serverUri, databaseName, runtimeVersion, userName, password, nestedResourceProvisioningState);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsVirtualNetworkRule. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="subnetId">
        /// The resource identifier for the subnet
        /// Serialized Name: VirtualNetworkRule.properties.subnetId
        /// </param>
        /// <param name="virtualNetworkRuleState">
        /// The current state of the VirtualNetwork Rule
        /// Serialized Name: VirtualNetworkRule.properties.virtualNetworkRuleState
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsVirtualNetworkRule"/> instance for mocking. </returns>
        public static DataLakeAnalyticsVirtualNetworkRule DataLakeAnalyticsVirtualNetworkRule(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, ResourceIdentifier subnetId = null, DataLakeAnalyticsVirtualNetworkRuleState? virtualNetworkRuleState = null)
        {
            return new DataLakeAnalyticsVirtualNetworkRule(id, name, resourceType, systemData, subnetId, virtualNetworkRuleState);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsFirewallRuleData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="startIPAddress">
        /// The start IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: FirewallRule.properties.startIpAddress
        /// </param>
        /// <param name="endIPAddress">
        /// The end IP address for the firewall rule. This can be either ipv4 or ipv6. Start and End should be in the same protocol.
        /// Serialized Name: FirewallRule.properties.endIpAddress
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeAnalyticsFirewallRuleData"/> instance for mocking. </returns>
        public static DataLakeAnalyticsFirewallRuleData DataLakeAnalyticsFirewallRuleData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IPAddress startIPAddress = null, IPAddress endIPAddress = null)
        {
            return new DataLakeAnalyticsFirewallRuleData(id, name, resourceType, systemData, startIPAddress, endIPAddress);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsStorageContainerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="lastModifiedOn">
        /// The last modified time of the blob container.
        /// Serialized Name: StorageContainer.properties.lastModifiedTime
        /// </param>
        /// <returns> A new <see cref="DataLakeAnalytics.DataLakeAnalyticsStorageContainerData"/> instance for mocking. </returns>
        public static DataLakeAnalyticsStorageContainerData DataLakeAnalyticsStorageContainerData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, DateTimeOffset? lastModifiedOn = null)
        {
            return new DataLakeAnalyticsStorageContainerData(id, name, resourceType, systemData, lastModifiedOn);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsSasTokenInformation. </summary>
        /// <param name="accessToken">
        /// The access token for the associated Azure Storage Container.
        /// Serialized Name: SasTokenInformation.accessToken
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsSasTokenInformation"/> instance for mocking. </returns>
        public static DataLakeAnalyticsSasTokenInformation DataLakeAnalyticsSasTokenInformation(string accessToken = null)
        {
            return new DataLakeAnalyticsSasTokenInformation(accessToken);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsCapabilityInformation. </summary>
        /// <param name="subscriptionId">
        /// The subscription credentials that uniquely identifies the subscription.
        /// Serialized Name: CapabilityInformation.subscriptionId
        /// </param>
        /// <param name="state">
        /// The subscription state.
        /// Serialized Name: CapabilityInformation.state
        /// </param>
        /// <param name="maxAccountCount">
        /// The maximum supported number of accounts under this subscription.
        /// Serialized Name: CapabilityInformation.maxAccountCount
        /// </param>
        /// <param name="accountCount">
        /// The current number of accounts under this subscription.
        /// Serialized Name: CapabilityInformation.accountCount
        /// </param>
        /// <param name="isUnderMigrationState">
        /// The Boolean value of true or false to indicate the maintenance state.
        /// Serialized Name: CapabilityInformation.migrationState
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsCapabilityInformation"/> instance for mocking. </returns>
        public static DataLakeAnalyticsCapabilityInformation DataLakeAnalyticsCapabilityInformation(Guid? subscriptionId = null, DataLakeAnalyticsSubscriptionState? state = null, int? maxAccountCount = null, int? accountCount = null, bool? isUnderMigrationState = null)
        {
            return new DataLakeAnalyticsCapabilityInformation(subscriptionId, state, maxAccountCount, accountCount, isUnderMigrationState);
        }

        /// <summary> Initializes a new instance of DataLakeAnalyticsAccountNameAvailabilityResult. </summary>
        /// <param name="isNameAvailable">
        /// The Boolean value of true or false to indicate whether the Data Lake Analytics account name is available or not.
        /// Serialized Name: NameAvailabilityInformation.nameAvailable
        /// </param>
        /// <param name="reason">
        /// The reason why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.reason
        /// </param>
        /// <param name="message">
        /// The message describing why the Data Lake Analytics account name is not available, if nameAvailable is false.
        /// Serialized Name: NameAvailabilityInformation.message
        /// </param>
        /// <returns> A new <see cref="Models.DataLakeAnalyticsAccountNameAvailabilityResult"/> instance for mocking. </returns>
        public static DataLakeAnalyticsAccountNameAvailabilityResult DataLakeAnalyticsAccountNameAvailabilityResult(bool? isNameAvailable = null, string reason = null, string message = null)
        {
            return new DataLakeAnalyticsAccountNameAvailabilityResult(isNameAvailable, reason, message);
        }
    }
}
