// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> The SyncRemoteAddressSpace. </summary>
    public readonly partial struct SyncRemoteAddressSpace : IEquatable<SyncRemoteAddressSpace>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SyncRemoteAddressSpace"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SyncRemoteAddressSpace(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TrueValue = "true";

        /// <summary> true. </summary>
        public static SyncRemoteAddressSpace True { get; } = new SyncRemoteAddressSpace(TrueValue);
        /// <summary> Determines if two <see cref="SyncRemoteAddressSpace"/> values are the same. </summary>
        public static bool operator ==(SyncRemoteAddressSpace left, SyncRemoteAddressSpace right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SyncRemoteAddressSpace"/> values are not the same. </summary>
        public static bool operator !=(SyncRemoteAddressSpace left, SyncRemoteAddressSpace right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SyncRemoteAddressSpace"/>. </summary>
        public static implicit operator SyncRemoteAddressSpace(string value) => new SyncRemoteAddressSpace(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SyncRemoteAddressSpace other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SyncRemoteAddressSpace other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
