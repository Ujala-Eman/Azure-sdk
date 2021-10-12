// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The Enum25. </summary>
    public readonly partial struct Enum25 : IEquatable<Enum25>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="Enum25"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public Enum25(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AbortValue = "abort";

        /// <summary> abort. </summary>
        public static Enum25 Abort { get; } = new Enum25(AbortValue);
        /// <summary> Determines if two <see cref="Enum25"/> values are the same. </summary>
        public static bool operator ==(Enum25 left, Enum25 right) => left.Equals(right);
        /// <summary> Determines if two <see cref="Enum25"/> values are not the same. </summary>
        public static bool operator !=(Enum25 left, Enum25 right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="Enum25"/>. </summary>
        public static implicit operator Enum25(string value) => new Enum25(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is Enum25 other && Equals(other);
        /// <inheritdoc />
        public bool Equals(Enum25 other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
