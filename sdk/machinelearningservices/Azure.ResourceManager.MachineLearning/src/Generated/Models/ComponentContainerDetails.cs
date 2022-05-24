// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Component container definition.
    /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command&quot; /&gt;
    /// </summary>
    public partial class ComponentContainerDetails : AssetContainer
    {
        /// <summary> Initializes a new instance of ComponentContainerDetails. </summary>
        public ComponentContainerDetails()
        {
        }

        /// <summary> Initializes a new instance of ComponentContainerDetails. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        internal ComponentContainerDetails(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isArchived, string latestVersion, string nextVersion) : base(description, properties, tags, isArchived, latestVersion, nextVersion)
        {
        }
    }
}
