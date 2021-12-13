// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Account.Models
{
    /// <summary> The FilterType. </summary>
    public readonly partial struct FilterType : IEquatable<FilterType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="FilterType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public FilterType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PatternValue = "Pattern";
        private const string RegexValue = "Regex";

        /// <summary> Pattern. </summary>
        public static FilterType Pattern { get; } = new FilterType(PatternValue);
        /// <summary> Regex. </summary>
        public static FilterType Regex { get; } = new FilterType(RegexValue);
        /// <summary> Determines if two <see cref="FilterType"/> values are the same. </summary>
        public static bool operator ==(FilterType left, FilterType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="FilterType"/> values are not the same. </summary>
        public static bool operator !=(FilterType left, FilterType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="FilterType"/>. </summary>
        public static implicit operator FilterType(string value) => new FilterType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is FilterType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(FilterType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
