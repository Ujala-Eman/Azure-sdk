// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Microsoft.Rest.Azure;

    /// <summary>
    /// Data Lake Store file or directory Access Control List information.
    /// </summary>
    public partial class AclStatus
    {
        /// <summary>
        /// Initializes a new instance of the AclStatus class.
        /// </summary>
        public AclStatus() { }

        /// <summary>
        /// Initializes a new instance of the AclStatus class.
        /// </summary>
        /// <param name="entries">the list of ACLSpec entries on a file or directory.</param>
        /// <param name="group">the group owner, an AAD Object ID.</param>
        /// <param name="owner">the user owner, an AAD Object ID.</param>
        /// <param name="stickyBit">the indicator of whether the sticky bit is on or off.</param>
        public AclStatus(IList<string> entries = default(IList<string>), string group = default(string), string owner = default(string), bool? stickyBit = default(bool?))
        {
            Entries = entries;
            Group = group;
            Owner = owner;
            StickyBit = stickyBit;
        }

        /// <summary>
        /// Gets or sets the list of ACLSpec entries on a file or directory.
        /// </summary>
        [JsonProperty(PropertyName = "entries")]
        public IList<string> Entries { get; set; }

        /// <summary>
        /// Gets or sets the group owner, an AAD Object ID.
        /// </summary>
        [JsonProperty(PropertyName = "group")]
        public string Group { get; set; }

        /// <summary>
        /// Gets or sets the user owner, an AAD Object ID.
        /// </summary>
        [JsonProperty(PropertyName = "owner")]
        public string Owner { get; set; }

        /// <summary>
        /// Gets or sets the indicator of whether the sticky bit is on or off.
        /// </summary>
        [JsonProperty(PropertyName = "stickyBit")]
        public bool? StickyBit { get; set; }

    }
}
