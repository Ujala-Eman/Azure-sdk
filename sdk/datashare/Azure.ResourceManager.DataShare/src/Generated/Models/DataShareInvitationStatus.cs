// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DataShare.Models
{
    /// <summary> The status of the invitation. </summary>
    public readonly partial struct DataShareInvitationStatus : IEquatable<DataShareInvitationStatus>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataShareInvitationStatus"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataShareInvitationStatus(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string AcceptedValue = "Accepted";
        private const string RejectedValue = "Rejected";
        private const string WithdrawnValue = "Withdrawn";

        /// <summary> Pending. </summary>
        public static DataShareInvitationStatus Pending { get; } = new DataShareInvitationStatus(PendingValue);
        /// <summary> Accepted. </summary>
        public static DataShareInvitationStatus Accepted { get; } = new DataShareInvitationStatus(AcceptedValue);
        /// <summary> Rejected. </summary>
        public static DataShareInvitationStatus Rejected { get; } = new DataShareInvitationStatus(RejectedValue);
        /// <summary> Withdrawn. </summary>
        public static DataShareInvitationStatus Withdrawn { get; } = new DataShareInvitationStatus(WithdrawnValue);
        /// <summary> Determines if two <see cref="DataShareInvitationStatus"/> values are the same. </summary>
        public static bool operator ==(DataShareInvitationStatus left, DataShareInvitationStatus right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataShareInvitationStatus"/> values are not the same. </summary>
        public static bool operator !=(DataShareInvitationStatus left, DataShareInvitationStatus right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataShareInvitationStatus"/>. </summary>
        public static implicit operator DataShareInvitationStatus(string value) => new DataShareInvitationStatus(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataShareInvitationStatus other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataShareInvitationStatus other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
