// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Properties of a Synapse link workspaces. </summary>
    public partial class SqlSynapseLinkWorkspaceInfo
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspaceInfo"/>. </summary>
        public SqlSynapseLinkWorkspaceInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SqlSynapseLinkWorkspaceInfo"/>. </summary>
        /// <param name="workspaceId"> Synapse link workspace id. </param>
        /// <param name="linkConnectionName"> Link connection name. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SqlSynapseLinkWorkspaceInfo(ResourceIdentifier workspaceId, string linkConnectionName, Dictionary<string, BinaryData> rawData)
        {
            WorkspaceId = workspaceId;
            LinkConnectionName = linkConnectionName;
            _rawData = rawData;
        }

        /// <summary> Synapse link workspace id. </summary>
        public ResourceIdentifier WorkspaceId { get; set; }
        /// <summary> Link connection name. </summary>
        public string LinkConnectionName { get; set; }
    }
}
