// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Policy for controlling export on the disk. </summary>
    public readonly partial struct PublicNetworkAccess : IEquatable<PublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> You can generate a SAS URI to access the underlying data of the disk publicly on the internet when NetworkAccessPolicy is set to AllowAll. You can access the data via the SAS URI only from your trusted Azure VNET when NetworkAccessPolicy is set to AllowPrivate. </summary>
        public static PublicNetworkAccess Enabled { get; } = new PublicNetworkAccess(EnabledValue);
        /// <summary> You cannot access the underlying data of the disk publicly on the internet even when NetworkAccessPolicy is set to AllowAll. You can access the data via the SAS URI only from your trusted Azure VNET when NetworkAccessPolicy is set to AllowPrivate. </summary>
        public static PublicNetworkAccess Disabled { get; } = new PublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="PublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(PublicNetworkAccess left, PublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(PublicNetworkAccess left, PublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PublicNetworkAccess"/>. </summary>
        public static implicit operator PublicNetworkAccess(string value) => new PublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
