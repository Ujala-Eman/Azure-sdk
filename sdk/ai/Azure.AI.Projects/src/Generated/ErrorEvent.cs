// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Projects
{
    /// <summary> Terminal event indicating a server side error while streaming. </summary>
    public readonly partial struct ErrorEvent : IEquatable<ErrorEvent>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ErrorEvent"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ErrorEvent(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ErrorValue = "error";

        /// <summary> Event sent when an error occurs, such as an internal server error or a timeout. </summary>
        public static ErrorEvent Error { get; } = new ErrorEvent(ErrorValue);
        /// <summary> Determines if two <see cref="ErrorEvent"/> values are the same. </summary>
        public static bool operator ==(ErrorEvent left, ErrorEvent right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ErrorEvent"/> values are not the same. </summary>
        public static bool operator !=(ErrorEvent left, ErrorEvent right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="ErrorEvent"/>. </summary>
        public static implicit operator ErrorEvent(string value) => new ErrorEvent(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ErrorEvent other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ErrorEvent other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
