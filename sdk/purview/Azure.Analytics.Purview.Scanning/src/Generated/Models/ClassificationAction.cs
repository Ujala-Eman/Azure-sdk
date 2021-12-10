// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ClassificationAction. </summary>
    public readonly partial struct ClassificationAction : IEquatable<ClassificationAction>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ClassificationAction"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ClassificationAction(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string KeepValue = "Keep";
        private const string DeleteValue = "Delete";

        /// <summary> Keep. </summary>
        public static ClassificationAction Keep { get; } = new ClassificationAction(KeepValue);
        /// <summary> Delete. </summary>
        public static ClassificationAction Delete { get; } = new ClassificationAction(DeleteValue);
        /// <summary> Determines if two <see cref="ClassificationAction"/> values are the same. </summary>
        public static bool operator ==(ClassificationAction left, ClassificationAction right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ClassificationAction"/> values are not the same. </summary>
        public static bool operator !=(ClassificationAction left, ClassificationAction right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ClassificationAction"/>. </summary>
        public static implicit operator ClassificationAction(string value) => new ClassificationAction(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ClassificationAction other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ClassificationAction other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
