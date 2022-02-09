// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> The operation state. </summary>
    public readonly partial struct ManagementOperationState : IEquatable<ManagementOperationState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ManagementOperationState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ManagementOperationState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PendingValue = "Pending";
        private const string InProgressValue = "InProgress";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CancelInProgressValue = "CancelInProgress";
        private const string CancelledValue = "Cancelled";

        /// <summary> Pending. </summary>
        public static ManagementOperationState Pending { get; } = new ManagementOperationState(PendingValue);
        /// <summary> InProgress. </summary>
        public static ManagementOperationState InProgress { get; } = new ManagementOperationState(InProgressValue);
        /// <summary> Succeeded. </summary>
        public static ManagementOperationState Succeeded { get; } = new ManagementOperationState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ManagementOperationState Failed { get; } = new ManagementOperationState(FailedValue);
        /// <summary> CancelInProgress. </summary>
        public static ManagementOperationState CancelInProgress { get; } = new ManagementOperationState(CancelInProgressValue);
        /// <summary> Cancelled. </summary>
        public static ManagementOperationState Cancelled { get; } = new ManagementOperationState(CancelledValue);
        /// <summary> Determines if two <see cref="ManagementOperationState"/> values are the same. </summary>
        public static bool operator ==(ManagementOperationState left, ManagementOperationState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ManagementOperationState"/> values are not the same. </summary>
        public static bool operator !=(ManagementOperationState left, ManagementOperationState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ManagementOperationState"/>. </summary>
        public static implicit operator ManagementOperationState(string value) => new ManagementOperationState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ManagementOperationState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ManagementOperationState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
