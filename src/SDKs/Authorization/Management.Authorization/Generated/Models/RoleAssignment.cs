// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
	using System;
	using System.Linq;
	using System.Collections.Generic;
	using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;

    /// <summary>
    /// Role Assignments
    /// </summary>
    public partial class RoleAssignment
    {
        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        public RoleAssignment()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleAssignment class.
        /// </summary>
        /// <param name="id">The role assignment ID.</param>
        /// <param name="name">The role assignment name.</param>
        /// <param name="type">The role assignment type.</param>
        /// <param name="properties">Role assignment properties.</param>
        public RoleAssignment(string id = default(string), string name = default(string), string type = default(string), RoleAssignmentPropertiesWithScope properties = default(RoleAssignmentPropertiesWithScope))
        {
            Id = id;
            Name = name;
            Type = type;
            Properties = properties;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the role assignment ID.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the role assignment name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the role assignment type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets role assignment properties.
        /// </summary>
        [JsonProperty(PropertyName = "properties")]
        public RoleAssignmentPropertiesWithScope Properties { get; set; }

    }
}
