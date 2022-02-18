// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment script parameters to be updated. </summary>
    public partial class DeploymentScriptUpdateOptions : ResourceData
    {
        /// <summary> Initializes a new instance of DeploymentScriptUpdateOptions. </summary>
        public DeploymentScriptUpdateOptions()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of DeploymentScriptUpdateOptions. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="type"> The type. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> Resource tags to be updated. </param>
        internal DeploymentScriptUpdateOptions(ResourceIdentifier id, string name, ResourceType type, SystemData systemData, IDictionary<string, string> tags) : base(id, name, type, systemData)
        {
            Tags = tags;
        }

        /// <summary> Resource tags to be updated. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
