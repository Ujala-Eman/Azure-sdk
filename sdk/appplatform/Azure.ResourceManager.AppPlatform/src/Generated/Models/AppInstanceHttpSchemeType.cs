// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary>
    /// Scheme to use for connecting to the host. Defaults to HTTP.
    ///
    /// Possible enum values:
    ///  - `"HTTP"` means that the scheme used will be http://
    ///  - `"HTTPS"` means that the scheme used will be https://
    /// </summary>
    public readonly partial struct AppInstanceHttpSchemeType : IEquatable<AppInstanceHttpSchemeType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="AppInstanceHttpSchemeType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public AppInstanceHttpSchemeType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string HttpValue = "HTTP";
        private const string HttpsValue = "HTTPS";

        /// <summary> HTTP. </summary>
        public static AppInstanceHttpSchemeType Http { get; } = new AppInstanceHttpSchemeType(HttpValue);
        /// <summary> HTTPS. </summary>
        public static AppInstanceHttpSchemeType Https { get; } = new AppInstanceHttpSchemeType(HttpsValue);
        /// <summary> Determines if two <see cref="AppInstanceHttpSchemeType"/> values are the same. </summary>
        public static bool operator ==(AppInstanceHttpSchemeType left, AppInstanceHttpSchemeType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="AppInstanceHttpSchemeType"/> values are not the same. </summary>
        public static bool operator !=(AppInstanceHttpSchemeType left, AppInstanceHttpSchemeType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="AppInstanceHttpSchemeType"/>. </summary>
        public static implicit operator AppInstanceHttpSchemeType(string value) => new AppInstanceHttpSchemeType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is AppInstanceHttpSchemeType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(AppInstanceHttpSchemeType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
