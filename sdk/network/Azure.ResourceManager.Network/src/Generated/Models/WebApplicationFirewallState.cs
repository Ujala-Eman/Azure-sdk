// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Describes if the custom rule is in enabled or disabled state. Defaults to Enabled if not specified. </summary>
    public readonly partial struct WebApplicationFirewallState : IEquatable<WebApplicationFirewallState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="WebApplicationFirewallState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public WebApplicationFirewallState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DisabledValue = "Disabled";
        private const string EnabledValue = "Enabled";

        /// <summary> Disabled. </summary>
        public static WebApplicationFirewallState Disabled { get; } = new WebApplicationFirewallState(DisabledValue);
        /// <summary> Enabled. </summary>
        public static WebApplicationFirewallState Enabled { get; } = new WebApplicationFirewallState(EnabledValue);
        /// <summary> Determines if two <see cref="WebApplicationFirewallState"/> values are the same. </summary>
        public static bool operator ==(WebApplicationFirewallState left, WebApplicationFirewallState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="WebApplicationFirewallState"/> values are not the same. </summary>
        public static bool operator !=(WebApplicationFirewallState left, WebApplicationFirewallState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="WebApplicationFirewallState"/>. </summary>
        public static implicit operator WebApplicationFirewallState(string value) => new WebApplicationFirewallState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is WebApplicationFirewallState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(WebApplicationFirewallState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
