// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Data.Tables.Models
{
    /// <summary> The ResponseFormat. </summary>
    public readonly partial struct ResponseFormat : IEquatable<ResponseFormat>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="ResponseFormat"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResponseFormat(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ReturnNoContentValue = "return-no-content";
        private const string ReturnContentValue = "return-content";

        /// <summary> return-no-content. </summary>
        public static ResponseFormat ReturnNoContent { get; } = new ResponseFormat(ReturnNoContentValue);
        /// <summary> return-content. </summary>
        public static ResponseFormat ReturnContent { get; } = new ResponseFormat(ReturnContentValue);
        /// <summary> Determines if two <see cref="ResponseFormat"/> values are the same. </summary>
        public static bool operator ==(ResponseFormat left, ResponseFormat right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResponseFormat"/> values are not the same. </summary>
        public static bool operator !=(ResponseFormat left, ResponseFormat right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResponseFormat"/>. </summary>
        public static implicit operator ResponseFormat(string value) => new ResponseFormat(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResponseFormat other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResponseFormat other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
