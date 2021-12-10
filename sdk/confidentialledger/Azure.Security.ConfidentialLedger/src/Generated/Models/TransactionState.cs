// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Security.ConfidentialLedger.Models
{
    /// <summary> Represents the state of the transaction. </summary>
    public readonly partial struct TransactionState : IEquatable<TransactionState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="TransactionState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public TransactionState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CommittedValue = "Committed";
        private const string PendingValue = "Pending";

        /// <summary> Committed. </summary>
        public static TransactionState Committed { get; } = new TransactionState(CommittedValue);
        /// <summary> Pending. </summary>
        public static TransactionState Pending { get; } = new TransactionState(PendingValue);
        /// <summary> Determines if two <see cref="TransactionState"/> values are the same. </summary>
        public static bool operator ==(TransactionState left, TransactionState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="TransactionState"/> values are not the same. </summary>
        public static bool operator !=(TransactionState left, TransactionState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="TransactionState"/>. </summary>
        public static implicit operator TransactionState(string value) => new TransactionState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is TransactionState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(TransactionState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
