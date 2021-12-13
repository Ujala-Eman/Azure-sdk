// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Analytics.Purview.Administration.Models
{
    /// <summary> Identity Type. </summary>
    public readonly partial struct Type : IEquatable<Type>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Type"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Type(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SystemAssignedValue = "SystemAssigned";

        /// <summary> SystemAssigned. </summary>
        public static Type SystemAssigned { get; } = new Type(SystemAssignedValue);
        /// <summary> Determines if two <see cref="Type"/> values are the same. </summary>
        public static bool operator ==(Type left, Type right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Type"/> values are not the same. </summary>
        public static bool operator !=(Type left, Type right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Type"/>. </summary>
        public static implicit operator Type(string value) => new Type(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Type other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Type other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
