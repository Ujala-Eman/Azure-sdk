// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Billing.Models
{
    /// <summary> Reason for the specified invoice section status. </summary>
    public readonly partial struct InvoiceSectionStateReasonCode : IEquatable<InvoiceSectionStateReasonCode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="InvoiceSectionStateReasonCode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public InvoiceSectionStateReasonCode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OtherValue = "Other";
        private const string PastDueValue = "PastDue";
        private const string UnusualActivityValue = "UnusualActivity";
        private const string SpendingLimitReachedValue = "SpendingLimitReached";
        private const string SpendingLimitExpiredValue = "SpendingLimitExpired";

        /// <summary> Other. </summary>
        public static InvoiceSectionStateReasonCode Other { get; } = new InvoiceSectionStateReasonCode(OtherValue);
        /// <summary> PastDue. </summary>
        public static InvoiceSectionStateReasonCode PastDue { get; } = new InvoiceSectionStateReasonCode(PastDueValue);
        /// <summary> UnusualActivity. </summary>
        public static InvoiceSectionStateReasonCode UnusualActivity { get; } = new InvoiceSectionStateReasonCode(UnusualActivityValue);
        /// <summary> SpendingLimitReached. </summary>
        public static InvoiceSectionStateReasonCode SpendingLimitReached { get; } = new InvoiceSectionStateReasonCode(SpendingLimitReachedValue);
        /// <summary> SpendingLimitExpired. </summary>
        public static InvoiceSectionStateReasonCode SpendingLimitExpired { get; } = new InvoiceSectionStateReasonCode(SpendingLimitExpiredValue);
        /// <summary> Determines if two <see cref="InvoiceSectionStateReasonCode"/> values are the same. </summary>
        public static bool operator ==(InvoiceSectionStateReasonCode left, InvoiceSectionStateReasonCode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="InvoiceSectionStateReasonCode"/> values are not the same. </summary>
        public static bool operator !=(InvoiceSectionStateReasonCode left, InvoiceSectionStateReasonCode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="InvoiceSectionStateReasonCode"/>. </summary>
        public static implicit operator InvoiceSectionStateReasonCode(string value) => new InvoiceSectionStateReasonCode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is InvoiceSectionStateReasonCode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(InvoiceSectionStateReasonCode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
