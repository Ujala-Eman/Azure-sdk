// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Batch.Models
{
    internal static partial class InterNodeCommunicationStateExtensions
    {
        public static string ToSerialString(this InterNodeCommunicationState value) => value switch
        {
            InterNodeCommunicationState.Enabled => "Enabled",
            InterNodeCommunicationState.Disabled => "Disabled",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InterNodeCommunicationState value.")
        };

        public static InterNodeCommunicationState ToInterNodeCommunicationState(this string value)
        {
            if (string.Equals(value, "Enabled", StringComparison.InvariantCultureIgnoreCase)) return InterNodeCommunicationState.Enabled;
            if (string.Equals(value, "Disabled", StringComparison.InvariantCultureIgnoreCase)) return InterNodeCommunicationState.Disabled;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown InterNodeCommunicationState value.");
        }
    }
}
