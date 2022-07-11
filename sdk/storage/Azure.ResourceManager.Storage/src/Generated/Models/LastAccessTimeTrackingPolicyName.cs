// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> Name of the policy. The valid value is AccessTimeTracking. This field is currently read only. </summary>
    public readonly partial struct LastAccessTimeTrackingPolicyName : IEquatable<LastAccessTimeTrackingPolicyName>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="LastAccessTimeTrackingPolicyName"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public LastAccessTimeTrackingPolicyName(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AccessTimeTrackingValue = "AccessTimeTracking";

        /// <summary> AccessTimeTracking. </summary>
        public static LastAccessTimeTrackingPolicyName AccessTimeTracking { get; } = new LastAccessTimeTrackingPolicyName(AccessTimeTrackingValue);
        /// <summary> Determines if two <see cref="LastAccessTimeTrackingPolicyName"/> values are the same. </summary>
        public static bool operator ==(LastAccessTimeTrackingPolicyName left, LastAccessTimeTrackingPolicyName right) => left.Equals(right);
        /// <summary> Determines if two <see cref="LastAccessTimeTrackingPolicyName"/> values are not the same. </summary>
        public static bool operator !=(LastAccessTimeTrackingPolicyName left, LastAccessTimeTrackingPolicyName right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="LastAccessTimeTrackingPolicyName"/>. </summary>
        public static implicit operator LastAccessTimeTrackingPolicyName(string value) => new LastAccessTimeTrackingPolicyName(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is LastAccessTimeTrackingPolicyName other && Equals(other);
        /// <inheritdoc />
        public bool Equals(LastAccessTimeTrackingPolicyName other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
