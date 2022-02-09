// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> The type of the Security policy to create. </summary>
    public readonly partial struct SecurityPolicyType : IEquatable<SecurityPolicyType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SecurityPolicyType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SecurityPolicyType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string WebApplicationFirewallValue = "WebApplicationFirewall";

        /// <summary> WebApplicationFirewall. </summary>
        public static SecurityPolicyType WebApplicationFirewall { get; } = new SecurityPolicyType(WebApplicationFirewallValue);
        /// <summary> Determines if two <see cref="SecurityPolicyType"/> values are the same. </summary>
        public static bool operator ==(SecurityPolicyType left, SecurityPolicyType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SecurityPolicyType"/> values are not the same. </summary>
        public static bool operator !=(SecurityPolicyType left, SecurityPolicyType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SecurityPolicyType"/>. </summary>
        public static implicit operator SecurityPolicyType(string value) => new SecurityPolicyType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SecurityPolicyType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SecurityPolicyType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
