// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Available cluster pool version. </summary>
    public partial class ClusterPoolVersion : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterPoolVersion"/>. </summary>
        public ClusterPoolVersion()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPoolVersion"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clusterPoolVersionValue"> Cluster pool version is a 2-part version. </param>
        /// <param name="aksVersion"> AKS version. </param>
        /// <param name="isPreview"> Indicate if this version is in preview or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterPoolVersion(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string clusterPoolVersionValue, string aksVersion, bool? isPreview, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ClusterPoolVersionValue = clusterPoolVersionValue;
            AksVersion = aksVersion;
            IsPreview = isPreview;
            _rawData = rawData;
        }

        /// <summary> Cluster pool version is a 2-part version. </summary>
        public string ClusterPoolVersionValue { get; set; }
        /// <summary> AKS version. </summary>
        public string AksVersion { get; set; }
        /// <summary> Indicate if this version is in preview or not. </summary>
        public bool? IsPreview { get; set; }
    }
}
