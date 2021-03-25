// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Enumeration that specifies the sensitivity of the motion detection processor. </summary>
    public readonly partial struct MotionDetectionSensitivity : IEquatable<MotionDetectionSensitivity>
    {
        private readonly string _value;

        /// <summary> Determines if two <see cref="MotionDetectionSensitivity"/> values are the same. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public MotionDetectionSensitivity(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string LowValue = "low";
        private const string MediumValue = "medium";
        private const string HighValue = "high";

        /// <summary> Low Sensitivity. </summary>
        public static MotionDetectionSensitivity Low { get; } = new MotionDetectionSensitivity(LowValue);
        /// <summary> Medium Sensitivity. </summary>
        public static MotionDetectionSensitivity Medium { get; } = new MotionDetectionSensitivity(MediumValue);
        /// <summary> High Sensitivity. </summary>
        public static MotionDetectionSensitivity High { get; } = new MotionDetectionSensitivity(HighValue);
        /// <summary> Determines if two <see cref="MotionDetectionSensitivity"/> values are the same. </summary>
        public static bool operator ==(MotionDetectionSensitivity left, MotionDetectionSensitivity right) => left.Equals(right);
        /// <summary> Determines if two <see cref="MotionDetectionSensitivity"/> values are not the same. </summary>
        public static bool operator !=(MotionDetectionSensitivity left, MotionDetectionSensitivity right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="MotionDetectionSensitivity"/>. </summary>
        public static implicit operator MotionDetectionSensitivity(string value) => new MotionDetectionSensitivity(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is MotionDetectionSensitivity other && Equals(other);
        /// <inheritdoc />
        public bool Equals(MotionDetectionSensitivity other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
