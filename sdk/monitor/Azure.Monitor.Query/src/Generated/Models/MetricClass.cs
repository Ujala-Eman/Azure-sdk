// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Monitor.Query.Models
{
    /// <summary> The class of the metric. </summary>
    public readonly partial struct MetricClass : IEquatable<MetricClass>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="MetricClass"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MetricClass(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string AvailabilityValue = "Availability";
        private const string TransactionsValue = "Transactions";
        private const string ErrorsValue = "Errors";
        private const string LatencyValue = "Latency";
        private const string SaturationValue = "Saturation";

        /// <summary> Availability. </summary>
        public static MetricClass Availability { get; } = new MetricClass(AvailabilityValue);
        /// <summary> Transactions. </summary>
        public static MetricClass Transactions { get; } = new MetricClass(TransactionsValue);
        /// <summary> Errors. </summary>
        public static MetricClass Errors { get; } = new MetricClass(ErrorsValue);
        /// <summary> Latency. </summary>
        public static MetricClass Latency { get; } = new MetricClass(LatencyValue);
        /// <summary> Saturation. </summary>
        public static MetricClass Saturation { get; } = new MetricClass(SaturationValue);
        /// <summary> Determines if two <see cref="MetricClass"/> values are the same. </summary>
        public static bool operator ==(MetricClass left, MetricClass right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MetricClass"/> values are not the same. </summary>
        public static bool operator !=(MetricClass left, MetricClass right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MetricClass"/>. </summary>
        public static implicit operator MetricClass(string value) => new MetricClass(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MetricClass other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MetricClass other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
