// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary> Specifies the move cost for the service. </summary>
    public readonly partial struct ApplicationMoveCost : IEquatable<ApplicationMoveCost>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ApplicationMoveCost"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ApplicationMoveCost(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string ZeroValue = "Zero";
        private const string LowValue = "Low";
        private const string MediumValue = "Medium";
        private const string HighValue = "High";

        /// <summary> Zero move cost. This value is zero. </summary>
        public static ApplicationMoveCost Zero { get; } = new ApplicationMoveCost(ZeroValue);
        /// <summary> Specifies the move cost of the service as Low. The value is 1. </summary>
        public static ApplicationMoveCost Low { get; } = new ApplicationMoveCost(LowValue);
        /// <summary> Specifies the move cost of the service as Medium. The value is 2. </summary>
        public static ApplicationMoveCost Medium { get; } = new ApplicationMoveCost(MediumValue);
        /// <summary> Specifies the move cost of the service as High. The value is 3. </summary>
        public static ApplicationMoveCost High { get; } = new ApplicationMoveCost(HighValue);
        /// <summary> Determines if two <see cref="ApplicationMoveCost"/> values are the same. </summary>
        public static bool operator ==(ApplicationMoveCost left, ApplicationMoveCost right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ApplicationMoveCost"/> values are not the same. </summary>
        public static bool operator !=(ApplicationMoveCost left, ApplicationMoveCost right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ApplicationMoveCost"/>. </summary>
        public static implicit operator ApplicationMoveCost(string value) => new ApplicationMoveCost(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ApplicationMoveCost other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ApplicationMoveCost other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
