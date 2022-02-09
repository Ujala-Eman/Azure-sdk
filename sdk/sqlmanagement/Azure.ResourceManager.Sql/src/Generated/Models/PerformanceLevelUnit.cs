// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Unit type used to measure performance level. </summary>
    public readonly partial struct PerformanceLevelUnit : IEquatable<PerformanceLevelUnit>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="PerformanceLevelUnit"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public PerformanceLevelUnit(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DTUValue = "DTU";
        private const string VCoresValue = "VCores";

        /// <summary> DTU. </summary>
        public static PerformanceLevelUnit DTU { get; } = new PerformanceLevelUnit(DTUValue);
        /// <summary> VCores. </summary>
        public static PerformanceLevelUnit VCores { get; } = new PerformanceLevelUnit(VCoresValue);
        /// <summary> Determines if two <see cref="PerformanceLevelUnit"/> values are the same. </summary>
        public static bool operator ==(PerformanceLevelUnit left, PerformanceLevelUnit right) => left.Equals(right);
        /// <summary> Determines if two <see cref="PerformanceLevelUnit"/> values are not the same. </summary>
        public static bool operator !=(PerformanceLevelUnit left, PerformanceLevelUnit right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="PerformanceLevelUnit"/>. </summary>
        public static implicit operator PerformanceLevelUnit(string value) => new PerformanceLevelUnit(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is PerformanceLevelUnit other && Equals(other);
        /// <inheritdoc />
        public bool Equals(PerformanceLevelUnit other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
