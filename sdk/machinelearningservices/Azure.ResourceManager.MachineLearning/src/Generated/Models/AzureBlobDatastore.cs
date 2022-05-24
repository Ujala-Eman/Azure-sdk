// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Azure Blob datastore configuration. </summary>
    public partial class AzureBlobDatastore : DatastoreDetails
    {
        /// <summary> Initializes a new instance of AzureBlobDatastore. </summary>
        /// <param name="credentials"> [Required] Account credentials. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="credentials"/> is null. </exception>
        public AzureBlobDatastore(DatastoreCredentials credentials) : base(credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException(nameof(credentials));
            }

            DatastoreType = DatastoreType.AzureBlob;
        }

        /// <summary> Initializes a new instance of AzureBlobDatastore. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="credentials"> [Required] Account credentials. </param>
        /// <param name="datastoreType"> [Required] Storage type backing the datastore. </param>
        /// <param name="isDefault"> Readonly property to indicate if datastore is the workspace default datastore. </param>
        /// <param name="accountName"> Storage account name. </param>
        /// <param name="containerName"> Storage account container name. </param>
        /// <param name="endpoint"> Azure cloud endpoint for the storage account. </param>
        /// <param name="protocol"> Protocol used to communicate with the storage account. </param>
        /// <param name="serviceDataAccessAuthIdentity"> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </param>
        internal AzureBlobDatastore(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, DatastoreCredentials credentials, DatastoreType datastoreType, bool? isDefault, string accountName, string containerName, string endpoint, string protocol, ServiceDataAccessAuthIdentity? serviceDataAccessAuthIdentity) : base(description, properties, tags, credentials, datastoreType, isDefault)
        {
            AccountName = accountName;
            ContainerName = containerName;
            Endpoint = endpoint;
            Protocol = protocol;
            ServiceDataAccessAuthIdentity = serviceDataAccessAuthIdentity;
            DatastoreType = datastoreType;
        }

        /// <summary> Storage account name. </summary>
        public string AccountName { get; set; }
        /// <summary> Storage account container name. </summary>
        public string ContainerName { get; set; }
        /// <summary> Azure cloud endpoint for the storage account. </summary>
        public string Endpoint { get; set; }
        /// <summary> Protocol used to communicate with the storage account. </summary>
        public string Protocol { get; set; }
        /// <summary> Indicates which identity to use to authenticate service data access to customer&apos;s storage. </summary>
        public ServiceDataAccessAuthIdentity? ServiceDataAccessAuthIdentity { get; set; }
    }
}
