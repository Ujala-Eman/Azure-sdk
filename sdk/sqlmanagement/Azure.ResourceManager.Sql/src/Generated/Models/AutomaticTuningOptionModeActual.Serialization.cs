// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    internal static partial class AutomaticTuningOptionModeActualExtensions
    {
        public static string ToSerialString(this AutomaticTuningOptionModeActual value) => value switch
        {
            AutomaticTuningOptionModeActual.Off => "Off",
            AutomaticTuningOptionModeActual.On => "On",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningOptionModeActual value.")
        };

        public static AutomaticTuningOptionModeActual ToAutomaticTuningOptionModeActual(this string value)
        {
            if (string.Equals(value, "Off", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningOptionModeActual.Off;
            if (string.Equals(value, "On", StringComparison.InvariantCultureIgnoreCase)) return AutomaticTuningOptionModeActual.On;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AutomaticTuningOptionModeActual value.");
        }
    }
}
