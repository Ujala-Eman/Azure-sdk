// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.AppPlatform;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> Object that includes an array of Spring Cloud Gateway custom domain resources and a possible link for next set. </summary>
    internal partial class GatewayCustomDomainResourceList
    {
        /// <summary> Initializes a new instance of GatewayCustomDomainResourceList. </summary>
        internal GatewayCustomDomainResourceList()
        {
            Value = new ChangeTrackingList<AppPlatformGatewayCustomDomainData>();
        }

        /// <summary> Initializes a new instance of GatewayCustomDomainResourceList. </summary>
        /// <param name="value"> Collection of Spring Cloud Gateway custom domain resources. </param>
        /// <param name="nextLink">
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </param>
        internal GatewayCustomDomainResourceList(IReadOnlyList<AppPlatformGatewayCustomDomainData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Collection of Spring Cloud Gateway custom domain resources. </summary>
        public IReadOnlyList<AppPlatformGatewayCustomDomainData> Value { get; }
        /// <summary>
        /// URL client should use to fetch the next page (per server side paging).
        /// It's null for now, added for future use.
        /// </summary>
        public string NextLink { get; }
    }
}
