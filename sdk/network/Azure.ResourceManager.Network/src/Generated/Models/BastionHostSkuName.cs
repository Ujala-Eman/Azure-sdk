// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The name of this Bastion Host. </summary>
    public readonly partial struct BastionHostSkuName : IEquatable<BastionHostSkuName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="BastionHostSkuName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public BastionHostSkuName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BasicValue = "Basic";
        private const string StandardValue = "Standard";

        /// <summary> Basic. </summary>
        public static BastionHostSkuName Basic { get; } = new BastionHostSkuName(BasicValue);
        /// <summary> Standard. </summary>
        public static BastionHostSkuName Standard { get; } = new BastionHostSkuName(StandardValue);
        /// <summary> Determines if two <see cref="BastionHostSkuName"/> values are the same. </summary>
        public static bool operator ==(BastionHostSkuName left, BastionHostSkuName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="BastionHostSkuName"/> values are not the same. </summary>
        public static bool operator !=(BastionHostSkuName left, BastionHostSkuName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="BastionHostSkuName"/>. </summary>
        public static implicit operator BastionHostSkuName(string value) => new BastionHostSkuName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is BastionHostSkuName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(BastionHostSkuName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
