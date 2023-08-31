// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Ssh profile for the cluster. </summary>
    public partial class ClusterSshProfile
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ClusterSshProfile"/>. </summary>
        /// <param name="count"> Number of ssh pods per cluster. </param>
        public ClusterSshProfile(int count)
        {
            Count = count;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterSshProfile"/>. </summary>
        /// <param name="count"> Number of ssh pods per cluster. </param>
        /// <param name="podPrefix"> Prefix of the pod names. Pod number will be appended to the prefix. The ingress URLs for the pods will be available at &lt;clusterFqdn&gt;/&lt;sshBasePath&gt;/&lt;prefix&gt;-&lt;number&gt;. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ClusterSshProfile(int count, string podPrefix, Dictionary<string, BinaryData> rawData)
        {
            Count = count;
            PodPrefix = podPrefix;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterSshProfile"/> for deserialization. </summary>
        internal ClusterSshProfile()
        {
        }

        /// <summary> Number of ssh pods per cluster. </summary>
        public int Count { get; set; }
        /// <summary> Prefix of the pod names. Pod number will be appended to the prefix. The ingress URLs for the pods will be available at &lt;clusterFqdn&gt;/&lt;sshBasePath&gt;/&lt;prefix&gt;-&lt;number&gt;. </summary>
        public string PodPrefix { get; }
    }
}
