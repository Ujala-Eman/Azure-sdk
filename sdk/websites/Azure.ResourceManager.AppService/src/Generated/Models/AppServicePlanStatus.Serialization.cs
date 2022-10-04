// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.AppService.Models
{
    internal static partial class AppServicePlanStatusExtensions
    {
        public static string ToSerialString(this AppServicePlanStatus value) => value switch
        {
            AppServicePlanStatus.Ready => "Ready",
            AppServicePlanStatus.Pending => "Pending",
            AppServicePlanStatus.Creating => "Creating",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServicePlanStatus value.")
        };

        public static AppServicePlanStatus ToAppServicePlanStatus(this string value)
        {
            if (string.Equals(value, "Ready", StringComparison.InvariantCultureIgnoreCase)) return AppServicePlanStatus.Ready;
            if (string.Equals(value, "Pending", StringComparison.InvariantCultureIgnoreCase)) return AppServicePlanStatus.Pending;
            if (string.Equals(value, "Creating", StringComparison.InvariantCultureIgnoreCase)) return AppServicePlanStatus.Creating;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown AppServicePlanStatus value.");
        }
    }
}
