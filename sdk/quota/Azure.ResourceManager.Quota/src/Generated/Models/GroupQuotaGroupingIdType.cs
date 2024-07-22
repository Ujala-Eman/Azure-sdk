// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Quota.Models
{
    /// <summary> GroupingId type. It is a required property. More types of groupIds can be supported in future. </summary>
    public readonly partial struct GroupQuotaGroupingIdType : IEquatable<GroupQuotaGroupingIdType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="GroupQuotaGroupingIdType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public GroupQuotaGroupingIdType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ServiceTreeIdValue = "ServiceTreeId";
        private const string BillingIdValue = "BillingId";

        /// <summary> ServiceTreeId. </summary>
        public static GroupQuotaGroupingIdType ServiceTreeId { get; } = new GroupQuotaGroupingIdType(ServiceTreeIdValue);
        /// <summary> BillingId. </summary>
        public static GroupQuotaGroupingIdType BillingId { get; } = new GroupQuotaGroupingIdType(BillingIdValue);
        /// <summary> Determines if two <see cref="GroupQuotaGroupingIdType"/> values are the same. </summary>
        public static bool operator ==(GroupQuotaGroupingIdType left, GroupQuotaGroupingIdType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="GroupQuotaGroupingIdType"/> values are not the same. </summary>
        public static bool operator !=(GroupQuotaGroupingIdType left, GroupQuotaGroupingIdType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="GroupQuotaGroupingIdType"/>. </summary>
        public static implicit operator GroupQuotaGroupingIdType(string value) => new GroupQuotaGroupingIdType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is GroupQuotaGroupingIdType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(GroupQuotaGroupingIdType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
