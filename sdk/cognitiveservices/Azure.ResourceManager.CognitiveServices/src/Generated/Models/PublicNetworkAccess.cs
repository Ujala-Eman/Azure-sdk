// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CognitiveServices.Models
{
    /// <summary> Whether or not public endpoint access is allowed for this account. </summary>
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

        /// <summary> Enabled. </summary>
        public static PublicNetworkAccess Enabled { get; } = new PublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
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
