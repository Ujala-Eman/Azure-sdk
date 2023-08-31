// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> Cluster monitoring extensions. </summary>
    public partial class HDInsightClusterCreateExtensionContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateExtensionContent"/>. </summary>
        public HDInsightClusterCreateExtensionContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="HDInsightClusterCreateExtensionContent"/>. </summary>
        /// <param name="workspaceId"> The workspace ID for the cluster monitoring extension. </param>
        /// <param name="primaryKey"> The certificate for the cluster monitoring extensions. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HDInsightClusterCreateExtensionContent(string workspaceId, string primaryKey, Dictionary<string, BinaryData> rawData)
        {
            WorkspaceId = workspaceId;
            PrimaryKey = primaryKey;
            _rawData = rawData;
        }

        /// <summary> The workspace ID for the cluster monitoring extension. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The certificate for the cluster monitoring extensions. </summary>
        public string PrimaryKey { get; set; }
    }
}
