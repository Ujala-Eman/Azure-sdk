// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The private link service connection status. </summary>
    public readonly partial struct PrivateLinkServiceConnectionStateStatus : IEquatable<PrivateLinkServiceConnectionStateStatus>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="PrivateLinkServiceConnectionStateStatus"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PrivateLinkServiceConnectionStateStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ApprovedValue = "Approved";
        private const string PendingValue = "Pending";
        private const string RejectedValue = "Rejected";
        private const string DisconnectedValue = "Disconnected";

        /// <summary> Approved. </summary>
        public static PrivateLinkServiceConnectionStateStatus Approved { get; } = new PrivateLinkServiceConnectionStateStatus(ApprovedValue);
        /// <summary> Pending. </summary>
        public static PrivateLinkServiceConnectionStateStatus Pending { get; } = new PrivateLinkServiceConnectionStateStatus(PendingValue);
        /// <summary> Rejected. </summary>
        public static PrivateLinkServiceConnectionStateStatus Rejected { get; } = new PrivateLinkServiceConnectionStateStatus(RejectedValue);
        /// <summary> Disconnected. </summary>
        public static PrivateLinkServiceConnectionStateStatus Disconnected { get; } = new PrivateLinkServiceConnectionStateStatus(DisconnectedValue);
        /// <summary> Determines if two <see cref="PrivateLinkServiceConnectionStateStatus"/> values are the same. </summary>
        public static bool operator ==(PrivateLinkServiceConnectionStateStatus left, PrivateLinkServiceConnectionStateStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PrivateLinkServiceConnectionStateStatus"/> values are not the same. </summary>
        public static bool operator !=(PrivateLinkServiceConnectionStateStatus left, PrivateLinkServiceConnectionStateStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PrivateLinkServiceConnectionStateStatus"/>. </summary>
        public static implicit operator PrivateLinkServiceConnectionStateStatus(string value) => new PrivateLinkServiceConnectionStateStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PrivateLinkServiceConnectionStateStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PrivateLinkServiceConnectionStateStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
