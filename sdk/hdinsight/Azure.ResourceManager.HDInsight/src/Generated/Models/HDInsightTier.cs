// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster tier. </summary>
    public readonly partial struct HDInsightTier : IEquatable<HDInsightTier>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="HDInsightTier"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public HDInsightTier(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StandardValue = "Standard";
        private const string PremiumValue = "Premium";

        /// <summary> Standard. </summary>
        public static HDInsightTier Standard { get; } = new HDInsightTier(StandardValue);
        /// <summary> Premium. </summary>
        public static HDInsightTier Premium { get; } = new HDInsightTier(PremiumValue);
        /// <summary> Determines if two <see cref="HDInsightTier"/> values are the same. </summary>
        public static bool operator ==(HDInsightTier left, HDInsightTier right) => left.Equals(right);
        /// <summary> Determines if two <see cref="HDInsightTier"/> values are not the same. </summary>
        public static bool operator !=(HDInsightTier left, HDInsightTier right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="HDInsightTier"/>. </summary>
        public static implicit operator HDInsightTier(string value) => new HDInsightTier(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is HDInsightTier other && Equals(other);
        /// <inheritdoc />
        public bool Equals(HDInsightTier other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
