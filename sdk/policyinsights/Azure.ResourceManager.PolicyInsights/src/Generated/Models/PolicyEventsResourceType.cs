// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.PolicyInsights.Models
{
    /// <summary>
    /// The PolicyEventsResourceType.
    /// Serialized Name: PolicyEventsResourceType
    /// </summary>
    public readonly partial struct PolicyEventsResourceType : IEquatable<PolicyEventsResourceType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PolicyEventsResourceType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PolicyEventsResourceType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "default";

        /// <summary>
        /// default
        /// Serialized Name: PolicyEventsResourceType.default
        /// </summary>
        public static PolicyEventsResourceType Default { get; } = new PolicyEventsResourceType(DefaultValue);
        /// <summary> Determines if two <see cref="PolicyEventsResourceType"/> values are the same. </summary>
        public static bool operator ==(PolicyEventsResourceType left, PolicyEventsResourceType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PolicyEventsResourceType"/> values are not the same. </summary>
        public static bool operator !=(PolicyEventsResourceType left, PolicyEventsResourceType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PolicyEventsResourceType"/>. </summary>
        public static implicit operator PolicyEventsResourceType(string value) => new PolicyEventsResourceType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PolicyEventsResourceType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PolicyEventsResourceType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
