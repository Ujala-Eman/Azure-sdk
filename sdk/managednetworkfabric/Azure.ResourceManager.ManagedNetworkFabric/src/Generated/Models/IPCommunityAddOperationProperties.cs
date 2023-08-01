// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    /// <summary> IP Community add operation properties. </summary>
    public partial class IPCommunityAddOperationProperties
    {
        /// <summary> Initializes a new instance of IPCommunityAddOperationProperties. </summary>
        public IPCommunityAddOperationProperties()
        {
        }

        /// <summary> Initializes a new instance of IPCommunityAddOperationProperties. </summary>
        /// <param name="add"> List of IP Community IDs. </param>
        internal IPCommunityAddOperationProperties(IPCommunityIdList @add)
        {
            Add = @add;
        }

        /// <summary> List of IP Community IDs. </summary>
        internal IPCommunityIdList Add { get; set; }
        /// <summary> List of IP Community resource IDs. </summary>
        public IList<ResourceIdentifier> AddIPCommunityIds
        {
            get
            {
                if (Add is null)
                    Add = new IPCommunityIdList();
                return Add.IPCommunityIds;
            }
        }
    }
}
