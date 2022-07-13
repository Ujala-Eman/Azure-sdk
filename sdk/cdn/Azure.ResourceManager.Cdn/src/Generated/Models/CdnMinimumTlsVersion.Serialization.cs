// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.Cdn.Models
{
    internal static partial class CdnMinimumTlsVersionExtensions
    {
        public static string ToSerialString(this CdnMinimumTlsVersion value) => value switch
        {
            CdnMinimumTlsVersion.None => "None",
            CdnMinimumTlsVersion.Tls1_0 => "TLS10",
            CdnMinimumTlsVersion.Tls1_2 => "TLS12",
            _ => throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CdnMinimumTlsVersion value.")
        };

        public static CdnMinimumTlsVersion ToCdnMinimumTlsVersion(this string value)
        {
            if (string.Equals(value, "None", StringComparison.InvariantCultureIgnoreCase)) return CdnMinimumTlsVersion.None;
            if (string.Equals(value, "TLS10", StringComparison.InvariantCultureIgnoreCase)) return CdnMinimumTlsVersion.Tls1_0;
            if (string.Equals(value, "TLS12", StringComparison.InvariantCultureIgnoreCase)) return CdnMinimumTlsVersion.Tls1_2;
            throw new ArgumentOutOfRangeException(nameof(value), value, "Unknown CdnMinimumTlsVersion value.");
        }
    }
}
