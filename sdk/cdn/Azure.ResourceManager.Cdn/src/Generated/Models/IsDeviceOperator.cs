// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Describes operator to be matched. </summary>
    public readonly partial struct IsDeviceOperator : IEquatable<IsDeviceOperator>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IsDeviceOperator"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IsDeviceOperator(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EqualValue = "Equal";

        /// <summary> Equal. </summary>
        public static IsDeviceOperator Equal { get; } = new IsDeviceOperator(EqualValue);
        /// <summary> Determines if two <see cref="IsDeviceOperator"/> values are the same. </summary>
        public static bool operator ==(IsDeviceOperator left, IsDeviceOperator right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IsDeviceOperator"/> values are not the same. </summary>
        public static bool operator !=(IsDeviceOperator left, IsDeviceOperator right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IsDeviceOperator"/>. </summary>
        public static implicit operator IsDeviceOperator(string value) => new IsDeviceOperator(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IsDeviceOperator other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IsDeviceOperator other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
