// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppContainers.Models
{
    internal static partial class WorkflowHealthStateExtensions
    {
        public static string ToSerialString(this WorkflowHealthState value) => value switch
        {
            WorkflowHealthState.Unknown => "Unknown",
            WorkflowHealthState.NotSpecified => "NotSpecified",
            WorkflowHealthState.Healthy => "Healthy",
            WorkflowHealthState.Unhealthy => "Unhealthy",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkflowHealthState value.")
        };

        public static WorkflowHealthState ToWorkflowHealthState(this string value)
        {
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unknown")) return WorkflowHealthState.Unknown;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "NotSpecified")) return WorkflowHealthState.NotSpecified;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Healthy")) return WorkflowHealthState.Healthy;
            if (StringComparer.OrdinalIgnoreCase.Equals(value, "Unhealthy")) return WorkflowHealthState.Unhealthy;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown WorkflowHealthState value.");
        }
    }
}
