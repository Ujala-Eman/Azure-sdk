// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Monitor compute identity type enum. </summary>
    internal readonly partial struct MonitorComputeIdentityType : IEquatable<MonitorComputeIdentityType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MonitorComputeIdentityType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MonitorComputeIdentityType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AmlTokenValue = "AmlToken";
        private const string ManagedIdentityValue = "ManagedIdentity";

        /// <summary> Authenticates through user's AML token. </summary>
        public static MonitorComputeIdentityType AmlToken { get; } = new MonitorComputeIdentityType(AmlTokenValue);
        /// <summary> Authenticates through a user-provided managed identity. </summary>
        public static MonitorComputeIdentityType ManagedIdentity { get; } = new MonitorComputeIdentityType(ManagedIdentityValue);
        /// <summary> Determines if two <see cref="MonitorComputeIdentityType"/> values are the same. </summary>
        public static bool operator ==(MonitorComputeIdentityType left, MonitorComputeIdentityType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MonitorComputeIdentityType"/> values are not the same. </summary>
        public static bool operator !=(MonitorComputeIdentityType left, MonitorComputeIdentityType right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="MonitorComputeIdentityType"/>. </summary>
        public static implicit operator MonitorComputeIdentityType(string value) => new MonitorComputeIdentityType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MonitorComputeIdentityType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MonitorComputeIdentityType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
