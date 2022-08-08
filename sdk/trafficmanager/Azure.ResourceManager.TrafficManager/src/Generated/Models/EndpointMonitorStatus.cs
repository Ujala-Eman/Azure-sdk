// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.TrafficManager.Models
{
    /// <summary> The monitoring status of the endpoint. </summary>
    public readonly partial struct EndpointMonitorStatus : IEquatable<EndpointMonitorStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="EndpointMonitorStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public EndpointMonitorStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CheckingEndpointValue = "CheckingEndpoint";
        private const string OnlineValue = "Online";
        private const string DegradedValue = "Degraded";
        private const string DisabledValue = "Disabled";
        private const string InactiveValue = "Inactive";
        private const string StoppedValue = "Stopped";

        /// <summary> CheckingEndpoint. </summary>
        public static EndpointMonitorStatus CheckingEndpoint { get; } = new EndpointMonitorStatus(CheckingEndpointValue);
        /// <summary> Online. </summary>
        public static EndpointMonitorStatus Online { get; } = new EndpointMonitorStatus(OnlineValue);
        /// <summary> Degraded. </summary>
        public static EndpointMonitorStatus Degraded { get; } = new EndpointMonitorStatus(DegradedValue);
        /// <summary> Disabled. </summary>
        public static EndpointMonitorStatus Disabled { get; } = new EndpointMonitorStatus(DisabledValue);
        /// <summary> Inactive. </summary>
        public static EndpointMonitorStatus Inactive { get; } = new EndpointMonitorStatus(InactiveValue);
        /// <summary> Stopped. </summary>
        public static EndpointMonitorStatus Stopped { get; } = new EndpointMonitorStatus(StoppedValue);
        /// <summary> Determines if two <see cref="EndpointMonitorStatus"/> values are the same. </summary>
        public static bool operator ==(EndpointMonitorStatus left, EndpointMonitorStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="EndpointMonitorStatus"/> values are not the same. </summary>
        public static bool operator !=(EndpointMonitorStatus left, EndpointMonitorStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="EndpointMonitorStatus"/>. </summary>
        public static implicit operator EndpointMonitorStatus(string value) => new EndpointMonitorStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is EndpointMonitorStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(EndpointMonitorStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
