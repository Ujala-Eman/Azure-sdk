// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> The last planned failover status. </summary>
    public readonly partial struct PlannedFailoverStatus : IEquatable<PlannedFailoverStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PlannedFailoverStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PlannedFailoverStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelledValue = "Cancelled";
        private const string UnknownValue = "Unknown";

        /// <summary> Succeeded. </summary>
        public static PlannedFailoverStatus Succeeded { get; } = new PlannedFailoverStatus(SucceededValue);
        /// <summary> Failed. </summary>
        public static PlannedFailoverStatus Failed { get; } = new PlannedFailoverStatus(FailedValue);
        /// <summary> Cancelled. </summary>
        public static PlannedFailoverStatus Cancelled { get; } = new PlannedFailoverStatus(CancelledValue);
        /// <summary> Unknown. </summary>
        public static PlannedFailoverStatus Unknown { get; } = new PlannedFailoverStatus(UnknownValue);
        /// <summary> Determines if two <see cref="PlannedFailoverStatus"/> values are the same. </summary>
        public static bool operator ==(PlannedFailoverStatus left, PlannedFailoverStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PlannedFailoverStatus"/> values are not the same. </summary>
        public static bool operator !=(PlannedFailoverStatus left, PlannedFailoverStatus right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="PlannedFailoverStatus"/>. </summary>
        public static implicit operator PlannedFailoverStatus(string value) => new PlannedFailoverStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PlannedFailoverStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PlannedFailoverStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
