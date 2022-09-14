// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary>
    /// This determines if traffic is allowed over public network. By default it is enabled.
    /// You can further restrict to specific IPs by configuring &lt;seealso cref=&quot;P:Microsoft.Azure.Events.ResourceProvider.Common.Contracts.DomainProperties.InboundIpRules&quot; /&gt;
    /// </summary>
    public readonly partial struct EventGridPublicNetworkAccess : IEquatable<EventGridPublicNetworkAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EventGridPublicNetworkAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EventGridPublicNetworkAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EnabledValue = "Enabled";
        private const string DisabledValue = "Disabled";

        /// <summary> Enabled. </summary>
        public static EventGridPublicNetworkAccess Enabled { get; } = new EventGridPublicNetworkAccess(EnabledValue);
        /// <summary> Disabled. </summary>
        public static EventGridPublicNetworkAccess Disabled { get; } = new EventGridPublicNetworkAccess(DisabledValue);
        /// <summary> Determines if two <see cref="EventGridPublicNetworkAccess"/> values are the same. </summary>
        public static bool operator ==(EventGridPublicNetworkAccess left, EventGridPublicNetworkAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EventGridPublicNetworkAccess"/> values are not the same. </summary>
        public static bool operator !=(EventGridPublicNetworkAccess left, EventGridPublicNetworkAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EventGridPublicNetworkAccess"/>. </summary>
        public static implicit operator EventGridPublicNetworkAccess(string value) => new EventGridPublicNetworkAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EventGridPublicNetworkAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EventGridPublicNetworkAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
