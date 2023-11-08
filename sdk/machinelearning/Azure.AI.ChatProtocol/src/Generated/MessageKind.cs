// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.ChatProtocol
{
    /// <summary> Identifies the type of a message. </summary>
    internal readonly partial struct MessageKind : IEquatable<MessageKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MessageKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MessageKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string TextValue = "text";

        /// <summary> The message context is text. </summary>
        public static MessageKind Text { get; } = new MessageKind(TextValue);
        /// <summary> Determines if two <see cref="MessageKind"/> values are the same. </summary>
        public static bool operator ==(MessageKind left, MessageKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MessageKind"/> values are not the same. </summary>
        public static bool operator !=(MessageKind left, MessageKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MessageKind"/>. </summary>
        public static implicit operator MessageKind(string value) => new MessageKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MessageKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MessageKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
