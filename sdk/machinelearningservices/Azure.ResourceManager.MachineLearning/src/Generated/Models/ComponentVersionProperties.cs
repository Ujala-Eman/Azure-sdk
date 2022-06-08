// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Definition of a component version: defines resources that span component types. </summary>
    public partial class ComponentVersionProperties : AssetBase
    {
        /// <summary> Initializes a new instance of <see cref="ComponentVersionProperties"/>. </summary>
        public ComponentVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ComponentVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="componentSpec">
        /// Defines Component definition details.
        /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command&quot; /&gt;
        /// </param>
        internal ComponentVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isAnonymous, bool? isArchived, BinaryData componentSpec) : base(description, properties, tags, isAnonymous, isArchived)
        {
            ComponentSpec = componentSpec;
        }

        /// <summary>
        /// Defines Component definition details.
        /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/reference-yaml-component-command&quot; /&gt;
        /// </summary>
        public BinaryData ComponentSpec { get; set; }
    }
}
