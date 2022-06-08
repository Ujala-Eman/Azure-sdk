// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The AssetBase. </summary>
    public partial class AssetBase : ResourceBase
    {
        /// <summary> Initializes a new instance of <see cref="AssetBase"/>. </summary>
        public AssetBase()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AssetBase"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        internal AssetBase(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isAnonymous, bool? isArchived) : base(description, properties, tags)
        {
            IsAnonymous = isAnonymous;
            IsArchived = isArchived;
        }

        /// <summary> If the name version are system generated (anonymous registration). </summary>
        public bool? IsAnonymous { get; set; }
        /// <summary> Is the asset archived?. </summary>
        public bool? IsArchived { get; set; }
    }
}
