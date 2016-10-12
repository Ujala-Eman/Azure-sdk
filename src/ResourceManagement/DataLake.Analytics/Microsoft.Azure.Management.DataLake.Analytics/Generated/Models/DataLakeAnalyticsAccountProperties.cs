// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using System.Linq;

    /// <summary>
    /// The account specific properties that are associated with an underlying
    /// Data Lake Analytics account.
    /// </summary>
    public partial class DataLakeAnalyticsAccountProperties
    {
        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountProperties class.
        /// </summary>
        public DataLakeAnalyticsAccountProperties() { }

        /// <summary>
        /// Initializes a new instance of the
        /// DataLakeAnalyticsAccountProperties class.
        /// </summary>
        /// <param name="provisioningState">the provisioning status of the
        /// Data Lake Analytics account. Possible values include: 'Failed',
        /// 'Creating', 'Running', 'Succeeded', 'Patching', 'Suspending',
        /// 'Resuming', 'Deleting', 'Deleted'</param>
        /// <param name="state">the state of the Data Lake Analytics account.
        /// Possible values include: 'active', 'suspended'</param>
        /// <param name="defaultDataLakeStoreAccount">the default data lake
        /// storage account associated with this Data Lake Analytics
        /// account.</param>
        /// <param name="maxDegreeOfParallelism">the maximum supported degree
        /// of parallelism for this account.</param>
        /// <param name="maxJobCount">the maximum supported jobs running under
        /// the account at the same time.</param>
        /// <param name="dataLakeStoreAccounts">the list of Data Lake storage
        /// accounts associated with this account.</param>
        /// <param name="storageAccounts">the list of Azure Blob storage
        /// accounts associated with this account.</param>
        /// <param name="creationTime">the account creation time.</param>
        /// <param name="lastModifiedTime">the account last modified
        /// time.</param>
        /// <param name="endpoint">the full CName endpoint for this
        /// account.</param>
        public DataLakeAnalyticsAccountProperties(DataLakeAnalyticsAccountStatus? provisioningState = default(DataLakeAnalyticsAccountStatus?), DataLakeAnalyticsAccountState? state = default(DataLakeAnalyticsAccountState?), string defaultDataLakeStoreAccount = default(string), int? maxDegreeOfParallelism = default(int?), int? maxJobCount = default(int?), System.Collections.Generic.IList<DataLakeStoreAccountInfo> dataLakeStoreAccounts = default(System.Collections.Generic.IList<DataLakeStoreAccountInfo>), System.Collections.Generic.IList<StorageAccountInfo> storageAccounts = default(System.Collections.Generic.IList<StorageAccountInfo>), System.DateTime? creationTime = default(System.DateTime?), System.DateTime? lastModifiedTime = default(System.DateTime?), string endpoint = default(string))
        {
            ProvisioningState = provisioningState;
            State = state;
            DefaultDataLakeStoreAccount = defaultDataLakeStoreAccount;
            MaxDegreeOfParallelism = maxDegreeOfParallelism;
            MaxJobCount = maxJobCount;
            DataLakeStoreAccounts = dataLakeStoreAccounts;
            StorageAccounts = storageAccounts;
            CreationTime = creationTime;
            LastModifiedTime = lastModifiedTime;
            Endpoint = endpoint;
        }

        /// <summary>
        /// Gets the provisioning status of the Data Lake Analytics account.
        /// Possible values include: 'Failed', 'Creating', 'Running',
        /// 'Succeeded', 'Patching', 'Suspending', 'Resuming', 'Deleting',
        /// 'Deleted'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "provisioningState")]
        public DataLakeAnalyticsAccountStatus? ProvisioningState { get; private set; }

        /// <summary>
        /// Gets the state of the Data Lake Analytics account. Possible values
        /// include: 'active', 'suspended'
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public DataLakeAnalyticsAccountState? State { get; private set; }

        /// <summary>
        /// Gets or sets the default data lake storage account associated with
        /// this Data Lake Analytics account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "defaultDataLakeStoreAccount")]
        public string DefaultDataLakeStoreAccount { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported degree of parallelism for this
        /// account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxDegreeOfParallelism")]
        public int? MaxDegreeOfParallelism { get; set; }

        /// <summary>
        /// Gets or sets the maximum supported jobs running under the account
        /// at the same time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "maxJobCount")]
        public int? MaxJobCount { get; set; }

        /// <summary>
        /// Gets or sets the list of Data Lake storage accounts associated
        /// with this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dataLakeStoreAccounts")]
        public System.Collections.Generic.IList<DataLakeStoreAccountInfo> DataLakeStoreAccounts { get; set; }

        /// <summary>
        /// Gets or sets the list of Azure Blob storage accounts associated
        /// with this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "storageAccounts")]
        public System.Collections.Generic.IList<StorageAccountInfo> StorageAccounts { get; set; }

        /// <summary>
        /// Gets the account creation time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; private set; }

        /// <summary>
        /// Gets the account last modified time.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModifiedTime")]
        public System.DateTime? LastModifiedTime { get; private set; }

        /// <summary>
        /// Gets the full CName endpoint for this account.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "endpoint")]
        public string Endpoint { get; private set; }

    }
}
