// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataShare.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataShare
{
    /// <summary>
    /// A class representing the DataShareAccount data model.
    /// An account data transfer object.
    /// </summary>
    public partial class DataShareAccountData : TrackedResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DataShareAccountData"/>. </summary>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity Info on the Account. Current supported identity types: SystemAssigned. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="identity"/> is null. </exception>
        public DataShareAccountData(AzureLocation location, ManagedServiceIdentity identity) : base(location)
        {
            Argument.AssertNotNull(identity, nameof(identity));

            Identity = identity;
        }

        /// <summary> Initializes a new instance of <see cref="DataShareAccountData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="identity"> Identity Info on the Account. Current supported identity types: SystemAssigned. </param>
        /// <param name="createdOn"> Time at which the account was created. </param>
        /// <param name="provisioningState"> Provisioning state of the Account. </param>
        /// <param name="userEmail"> Email of the user who created the resource. </param>
        /// <param name="userName"> Name of the user who created the resource. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DataShareAccountData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, ManagedServiceIdentity identity, DateTimeOffset? createdOn, DataShareProvisioningState? provisioningState, string userEmail, string userName, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData, tags, location)
        {
            Identity = identity;
            CreatedOn = createdOn;
            ProvisioningState = provisioningState;
            UserEmail = userEmail;
            UserName = userName;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DataShareAccountData"/> for deserialization. </summary>
        internal DataShareAccountData()
        {
        }

        /// <summary> Identity Info on the Account. Current supported identity types: SystemAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Time at which the account was created. </summary>
        public DateTimeOffset? CreatedOn { get; }
        /// <summary> Provisioning state of the Account. </summary>
        public DataShareProvisioningState? ProvisioningState { get; }
        /// <summary> Email of the user who created the resource. </summary>
        public string UserEmail { get; }
        /// <summary> Name of the user who created the resource. </summary>
        public string UserName { get; }
    }
}
