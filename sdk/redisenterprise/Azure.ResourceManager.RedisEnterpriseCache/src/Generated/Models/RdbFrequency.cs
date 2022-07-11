// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    /// <summary> Sets the frequency at which a snapshot of the database is created. </summary>
    public readonly partial struct RdbFrequency : IEquatable<RdbFrequency>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="RdbFrequency"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public RdbFrequency(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string OneHValue = "1h";
        private const string SixHValue = "6h";
        private const string TwelveHValue = "12h";

        /// <summary> 1h. </summary>
        public static RdbFrequency OneH { get; } = new RdbFrequency(OneHValue);
        /// <summary> 6h. </summary>
        public static RdbFrequency SixH { get; } = new RdbFrequency(SixHValue);
        /// <summary> 12h. </summary>
        public static RdbFrequency TwelveH { get; } = new RdbFrequency(TwelveHValue);
        /// <summary> Determines if two <see cref="RdbFrequency"/> values are the same. </summary>
        public static bool operator ==(RdbFrequency left, RdbFrequency right) => left.Equals(right);
        /// <summary> Determines if two <see cref="RdbFrequency"/> values are not the same. </summary>
        public static bool operator !=(RdbFrequency left, RdbFrequency right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="RdbFrequency"/>. </summary>
        public static implicit operator RdbFrequency(string value) => new RdbFrequency(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is RdbFrequency other && Equals(other);
        /// <inheritdoc />
        public bool Equals(RdbFrequency other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
