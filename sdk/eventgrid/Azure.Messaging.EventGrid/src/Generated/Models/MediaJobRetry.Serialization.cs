// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    internal static class MediaJobRetryExtensions
    {
        public static string ToSerialString(this MediaJobRetry value) => value switch
        {
            MediaJobRetry.DoNotRetry => "DoNotRetry",
            MediaJobRetry.MayRetry => "MayRetry",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaJobRetry value.")
        };

        public static MediaJobRetry ToMediaJobRetry(this string value)
        {
            if (string.Equals(value, "DoNotRetry", StringComparison.InvariantCultureIgnoreCase)) return MediaJobRetry.DoNotRetry;
            if (string.Equals(value, "MayRetry", StringComparison.InvariantCultureIgnoreCase)) return MediaJobRetry.MayRetry;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown MediaJobRetry value.");
        }
    }
}
