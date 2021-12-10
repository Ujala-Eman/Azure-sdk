// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ClassificationRuleType. </summary>
    public readonly partial struct ClassificationRuleType : IEquatable<ClassificationRuleType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClassificationRuleType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClassificationRuleType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemValue = "System";
        private const string CustomValue = "Custom";

        /// <summary> System. </summary>
        public static ClassificationRuleType System { get; } = new ClassificationRuleType(SystemValue);
        /// <summary> Custom. </summary>
        public static ClassificationRuleType Custom { get; } = new ClassificationRuleType(CustomValue);
        /// <summary> Determines if two <see cref="ClassificationRuleType"/> values are the same. </summary>
        public static bool operator ==(ClassificationRuleType left, ClassificationRuleType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClassificationRuleType"/> values are not the same. </summary>
        public static bool operator !=(ClassificationRuleType left, ClassificationRuleType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClassificationRuleType"/>. </summary>
        public static implicit operator ClassificationRuleType(string value) => new ClassificationRuleType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClassificationRuleType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClassificationRuleType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
