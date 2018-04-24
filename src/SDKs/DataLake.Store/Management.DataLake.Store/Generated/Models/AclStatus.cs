// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataLake.Store.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Data Lake Store file or directory Access Control List information.
    /// </summary>
    public partial class AclStatus
    {
        /// <summary>
        /// Initializes a new instance of the AclStatus class.
        /// </summary>
        public AclStatus()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AclStatus class.
        /// </summary>
        /// <param name="entries">the list of ACLSpec entries on a file or
        /// directory.</param>
        /// <param name="group">the group owner, an AAD Object ID.</param>
        /// <param name="owner">the user owner, an AAD Object ID.</param>
        /// <param name="permission">The octal representation of the unnamed
        /// user, mask and other permissions.</param>
        /// <param name="stickyBit">the indicator of whether the sticky bit is
        /// on or off.</param>
        public AclStatus(IList<string> entries = default(IList<string>), string group = default(string), string owner = default(string), string permission = default(string), bool? stickyBit = default(bool?))
        {
            Entries = entries;
            Group = group;
            Owner = owner;
            Permission = permission;
            StickyBit = stickyBit;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

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
        /// Gets or sets the octal representation of the unnamed user, mask and
        /// other permissions.
        /// </summary>
        [JsonProperty(PropertyName = "permission")]
        public string Permission { get; set; }

        /// <summary>
        /// Gets the indicator of whether the sticky bit is on or off.
        /// </summary>
        [JsonProperty(PropertyName = "stickyBit")]
        public bool? StickyBit { get; private set; }

    }
}
