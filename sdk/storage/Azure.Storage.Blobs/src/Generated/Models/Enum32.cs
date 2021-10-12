// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The Enum32. </summary>
    public readonly partial struct Enum32 : IEquatable<Enum32>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum32"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum32(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AppendblockValue = "appendblock";

        /// <summary> appendblock. </summary>
        public static Enum32 Appendblock { get; } = new Enum32(AppendblockValue);
        /// <summary> Determines if two <see cref="Enum32"/> values are the same. </summary>
        public static bool operator ==(Enum32 left, Enum32 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum32"/> values are not the same. </summary>
        public static bool operator !=(Enum32 left, Enum32 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum32"/>. </summary>
        public static implicit operator Enum32(string value) => new Enum32(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum32 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum32 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
