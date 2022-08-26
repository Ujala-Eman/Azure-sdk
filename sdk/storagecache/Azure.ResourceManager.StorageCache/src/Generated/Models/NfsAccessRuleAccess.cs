// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StorageCache.Models
{
    /// <summary> Access allowed by this rule. </summary>
    public readonly partial struct NfsAccessRuleAccess : IEquatable<NfsAccessRuleAccess>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="NfsAccessRuleAccess"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public NfsAccessRuleAccess(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string NoValue = "no";
        private const string RoValue = "ro";
        private const string RwValue = "rw";

        /// <summary> no. </summary>
        public static NfsAccessRuleAccess No { get; } = new NfsAccessRuleAccess(NoValue);
        /// <summary> ro. </summary>
        public static NfsAccessRuleAccess Ro { get; } = new NfsAccessRuleAccess(RoValue);
        /// <summary> rw. </summary>
        public static NfsAccessRuleAccess Rw { get; } = new NfsAccessRuleAccess(RwValue);
        /// <summary> Determines if two <see cref="NfsAccessRuleAccess"/> values are the same. </summary>
        public static bool operator ==(NfsAccessRuleAccess left, NfsAccessRuleAccess right) => left.Equals(right);
        /// <summary> Determines if two <see cref="NfsAccessRuleAccess"/> values are not the same. </summary>
        public static bool operator !=(NfsAccessRuleAccess left, NfsAccessRuleAccess right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="NfsAccessRuleAccess"/>. </summary>
        public static implicit operator NfsAccessRuleAccess(string value) => new NfsAccessRuleAccess(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is NfsAccessRuleAccess other && Equals(other);
        /// <inheritdoc />
        public bool Equals(NfsAccessRuleAccess other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
