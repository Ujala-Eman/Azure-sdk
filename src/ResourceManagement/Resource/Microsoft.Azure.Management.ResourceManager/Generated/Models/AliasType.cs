// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ResourceManager.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// </summary>
    public partial class AliasType
    {
        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        public AliasType() { }

        /// <summary>
        /// Initializes a new instance of the AliasType class.
        /// </summary>
        public AliasType(string name = default(string), IList<AliasPathType> paths = default(IList<AliasPathType>))
        {
            Name = name;
            Paths = paths;
        }

        /// <summary>
        /// Gets or sets the alias name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the paths for an alias.
        /// </summary>
        [JsonProperty(PropertyName = "paths")]
        public IList<AliasPathType> Paths { get; set; }

    }
}
