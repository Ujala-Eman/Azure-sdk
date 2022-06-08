// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The paths that are included in indexing. </summary>
    public partial class IncludedPath
    {
        /// <summary> Initializes a new instance of <see cref="IncludedPath"/>. </summary>
        public IncludedPath()
        {
            Indexes = new ChangeTrackingList<PathIndexes>();
        }

        /// <summary> Initializes a new instance of <see cref="IncludedPath"/>. </summary>
        /// <param name="path"> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </param>
        /// <param name="indexes"> List of indexes for this path. </param>
        internal IncludedPath(string path, IList<PathIndexes> indexes)
        {
            Path = path;
            Indexes = indexes;
        }

        /// <summary> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </summary>
        public string Path { get; set; }
        /// <summary> List of indexes for this path. </summary>
        public IList<PathIndexes> Indexes { get; }
    }
}
