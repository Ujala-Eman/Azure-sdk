// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Queues.Models
{
    /// <summary> The Enum1. </summary>
    public readonly partial struct Enum1 : IEquatable<Enum1>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum1"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum1(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string PropertiesValue = "properties";

        /// <summary> properties. </summary>
        public static Enum1 Properties { get; } = new Enum1(PropertiesValue);
        /// <summary> Determines if two <see cref="Enum1"/> values are the same. </summary>
        public static bool operator ==(Enum1 left, Enum1 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum1"/> values are not the same. </summary>
        public static bool operator !=(Enum1 left, Enum1 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum1"/>. </summary>
        public static implicit operator Enum1(string value) => new Enum1(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum1 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum1 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
