// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.AI.DocumentIntelligence
{
    /// <summary> Document splitting mode. </summary>
    public readonly partial struct SplitMode : IEquatable<SplitMode>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SplitMode"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SplitMode(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AutoValue = "auto";
        private const string NoneValue = "none";
        private const string PerPageValue = "perPage";

        /// <summary> Automatically split file into documents. </summary>
        public static SplitMode Auto { get; } = new SplitMode(AutoValue);
        /// <summary> Treat the entire file as a single document. </summary>
        public static SplitMode None { get; } = new SplitMode(NoneValue);
        /// <summary> Treat each page in the file as a separate document. </summary>
        public static SplitMode PerPage { get; } = new SplitMode(PerPageValue);
        /// <summary> Determines if two <see cref="SplitMode"/> values are the same. </summary>
        public static bool operator ==(SplitMode left, SplitMode right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SplitMode"/> values are not the same. </summary>
        public static bool operator !=(SplitMode left, SplitMode right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="SplitMode"/>. </summary>
        public static implicit operator SplitMode(string value) => new SplitMode(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SplitMode other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SplitMode other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
