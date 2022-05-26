// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.ResourceManager.DynaTrace.Models
{
    /// <summary> Request for getting all the linkable environments for a user. </summary>
    public partial class LinkableEnvironmentContent
    {
        /// <summary> Initializes a new instance of LinkableEnvironmentContent. </summary>
        public LinkableEnvironmentContent()
        {
        }

        /// <summary> Tenant Id of the user in which they want to link the environment. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> user principal id of the user. </summary>
        public string UserPrincipal { get; set; }
        /// <summary> Azure region in which we want to link the environment. </summary>
        public AzureLocation? Region { get; set; }
    }
}
