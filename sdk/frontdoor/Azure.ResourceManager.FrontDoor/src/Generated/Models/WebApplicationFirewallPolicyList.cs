// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.FrontDoor;

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines a list of WebApplicationFirewallPolicies. It contains a list of WebApplicationFirewallPolicy objects and a URL link to get the next set of results. </summary>
    internal partial class WebApplicationFirewallPolicyList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallPolicyList"/>. </summary>
        internal WebApplicationFirewallPolicyList()
        {
            Value = new ChangeTrackingList<FrontDoorWebApplicationFirewallPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallPolicyList"/>. </summary>
        /// <param name="value"> List of WebApplicationFirewallPolicies within a resource group. </param>
        /// <param name="nextLink"> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal WebApplicationFirewallPolicyList(IReadOnlyList<FrontDoorWebApplicationFirewallPolicyData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of WebApplicationFirewallPolicies within a resource group. </summary>
        public IReadOnlyList<FrontDoorWebApplicationFirewallPolicyData> Value { get; }
        /// <summary> URL to get the next set of WebApplicationFirewallPolicy objects if there are any. </summary>
        public string NextLink { get; }
    }
}
