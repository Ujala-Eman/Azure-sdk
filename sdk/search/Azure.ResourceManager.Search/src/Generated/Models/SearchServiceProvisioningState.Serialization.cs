// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Search.Models
{
    internal static partial class SearchServiceProvisioningStateExtensions
    {
        public static string ToSerialString(this SearchServiceProvisioningState value) => value switch
        {
            SearchServiceProvisioningState.Succeeded => "succeeded",
            SearchServiceProvisioningState.Provisioning => "provisioning",
            SearchServiceProvisioningState.Failed => "failed",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchServiceProvisioningState value.")
        };

        public static SearchServiceProvisioningState ToSearchServiceProvisioningState(this string value)
        {
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return SearchServiceProvisioningState.Succeeded;
            if (string.Equals(value, "provisioning", StringComparison.InvariantCultureIgnoreCase)) return SearchServiceProvisioningState.Provisioning;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return SearchServiceProvisioningState.Failed;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown SearchServiceProvisioningState value.");
        }
    }
}
