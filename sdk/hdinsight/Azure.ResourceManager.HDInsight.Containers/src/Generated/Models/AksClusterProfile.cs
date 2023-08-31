// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Properties of the cluster pool underlying AKS cluster. </summary>
    public partial class AksClusterProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AksClusterProfile"/>. </summary>
        internal AksClusterProfile()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AksClusterProfile"/>. </summary>
        /// <param name="aksClusterResourceId"> ARM Resource ID of the AKS cluster. </param>
        /// <param name="aksClusterAgentPoolIdentityProfile"> Identity properties of the AKS cluster agentpool MSI. </param>
        /// <param name="aksVersion"> AKS control plane and default node pool version of this ClusterPool. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AksClusterProfile(ResourceIdentifier aksClusterResourceId, HDInsightIdentityProfile aksClusterAgentPoolIdentityProfile, string aksVersion, Dictionary<string, BinaryData> rawData)
        {
            AksClusterResourceId = aksClusterResourceId;
            AksClusterAgentPoolIdentityProfile = aksClusterAgentPoolIdentityProfile;
            AksVersion = aksVersion;
            _rawData = rawData;
        }

        /// <summary> ARM Resource ID of the AKS cluster. </summary>
        public ResourceIdentifier AksClusterResourceId { get; }
        /// <summary> Identity properties of the AKS cluster agentpool MSI. </summary>
        public HDInsightIdentityProfile AksClusterAgentPoolIdentityProfile { get; }
        /// <summary> AKS control plane and default node pool version of this ClusterPool. </summary>
        public string AksVersion { get; }
    }
}
