// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
// 
// Code generated by Microsoft (R) AutoRest Code Generator 0.14.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Authorization.Models
{
	using System.Collections;
	using System.Collections.Generic;
	using System.Linq;
	using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Authorization;
    using Newtonsoft.Json;

    /// <summary>
    /// Role definition permissions.
    /// </summary>
    public partial class Permission
    {
        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        public Permission()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Permission class.
        /// </summary>
        /// <param name="actions">Allowed actions.</param>
        /// <param name="notActions">Denied actions.</param>
        public Permission(IList<string> actions = default(IList<string>), IList<string> notActions = default(IList<string>))
        {
            Actions = actions;
            NotActions = notActions;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets allowed actions.
        /// </summary>
        [JsonProperty(PropertyName = "actions")]
        public IList<string> Actions { get; set; }

        /// <summary>
        /// Gets or sets denied actions.
        /// </summary>
        [JsonProperty(PropertyName = "notActions")]
        public IList<string> NotActions { get; set; }

    }
}
