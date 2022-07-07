// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.Language.Conversations
{
    /// <summary> Type of ranker to be used. </summary>
    public readonly partial struct RankerKind : IEquatable<RankerKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RankerKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RankerKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string QuestionOnlyValue = "QuestionOnly";
        private const string DefaultValue = "Default";

        /// <summary> Question only ranker. </summary>
        public static RankerKind QuestionOnly { get; } = new RankerKind(QuestionOnlyValue);
        /// <summary> Default ranker. </summary>
        public static RankerKind Default { get; } = new RankerKind(DefaultValue);
        /// <summary> Determines if two <see cref="RankerKind"/> values are the same. </summary>
        public static bool operator ==(RankerKind left, RankerKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RankerKind"/> values are not the same. </summary>
        public static bool operator !=(RankerKind left, RankerKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RankerKind"/>. </summary>
        public static implicit operator RankerKind(string value) => new RankerKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RankerKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RankerKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
