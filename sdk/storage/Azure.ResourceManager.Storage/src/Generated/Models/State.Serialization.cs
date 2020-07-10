// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Storage.Models
{
    internal static class StateExtensions
    {
        public static string ToSerialString(this State value) => value switch
        {
            State.Provisioning => "provisioning",
            State.Deprovisioning => "deprovisioning",
            State.Succeeded => "succeeded",
            State.Failed => "failed",
            State.NetworkSourceDeleted => "networkSourceDeleted",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown State value.")
        };

        public static State ToState(this string value)
        {
            if (string.Equals(value, "provisioning", StringComparison.InvariantCultureIgnoreCase)) return State.Provisioning;
            if (string.Equals(value, "deprovisioning", StringComparison.InvariantCultureIgnoreCase)) return State.Deprovisioning;
            if (string.Equals(value, "succeeded", StringComparison.InvariantCultureIgnoreCase)) return State.Succeeded;
            if (string.Equals(value, "failed", StringComparison.InvariantCultureIgnoreCase)) return State.Failed;
            if (string.Equals(value, "networkSourceDeleted", StringComparison.InvariantCultureIgnoreCase)) return State.NetworkSourceDeleted;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown State value.");
        }
    }
}
