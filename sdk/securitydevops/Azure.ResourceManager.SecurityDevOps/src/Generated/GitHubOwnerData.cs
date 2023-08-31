// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityDevOps.Models;

namespace Azure.ResourceManager.SecurityDevOps
{
    /// <summary>
    /// A class representing the GitHubOwner data model.
    /// GitHub repo owner Proxy Resource.
    /// </summary>
    public partial class GitHubOwnerData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GitHubOwnerData"/>. </summary>
        public GitHubOwnerData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="GitHubOwnerData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> GitHub Repo Owner properties. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GitHubOwnerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, GitHubOwnerProperties properties, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> GitHub Repo Owner properties. </summary>
        public GitHubOwnerProperties Properties { get; set; }
    }
}
