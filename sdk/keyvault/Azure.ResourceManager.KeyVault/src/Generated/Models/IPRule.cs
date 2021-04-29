// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.KeyVault.Models
{
    /// <summary> A rule governing the accessibility of a vault from a specific ip address or ip range. </summary>
    public partial class IPRule
    {
        /// <summary> Initializes a new instance of IPRule. </summary>
        /// <param name="value"> An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all addresses that start with 124.56.78). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IPRule(string value)
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }

            Value = value;
        }

        /// <summary> An IPv4 address range in CIDR notation, such as &apos;124.56.78.91&apos; (simple IP address) or &apos;124.56.78.0/24&apos; (all addresses that start with 124.56.78). </summary>
        public string Value { get; set; }
    }
}
