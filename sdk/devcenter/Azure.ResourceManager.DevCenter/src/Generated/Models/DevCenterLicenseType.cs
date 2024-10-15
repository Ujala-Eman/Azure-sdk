// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DevCenter.Models
{
    /// <summary> License Types. </summary>
    public readonly partial struct DevCenterLicenseType : IEquatable<DevCenterLicenseType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DevCenterLicenseType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DevCenterLicenseType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WindowsClientValue = "Windows_Client";

        /// <summary> Windows_Client. </summary>
        public static DevCenterLicenseType WindowsClient { get; } = new DevCenterLicenseType(WindowsClientValue);
        /// <summary> Determines if two <see cref="DevCenterLicenseType"/> values are the same. </summary>
        public static bool operator ==(DevCenterLicenseType left, DevCenterLicenseType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DevCenterLicenseType"/> values are not the same. </summary>
        public static bool operator !=(DevCenterLicenseType left, DevCenterLicenseType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DevCenterLicenseType"/>. </summary>
        public static implicit operator DevCenterLicenseType(string value) => new DevCenterLicenseType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DevCenterLicenseType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DevCenterLicenseType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
