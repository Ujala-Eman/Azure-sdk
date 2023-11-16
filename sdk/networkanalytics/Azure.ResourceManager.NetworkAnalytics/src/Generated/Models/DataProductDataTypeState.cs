// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The data type state. </summary>
    public readonly partial struct DataProductDataTypeState : IEquatable<DataProductDataTypeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataProductDataTypeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataProductDataTypeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StoppedValue = "Stopped";
        private const string RunningValue = "Running";

        /// <summary> Field to specify stopped state. </summary>
        public static DataProductDataTypeState Stopped { get; } = new DataProductDataTypeState(StoppedValue);
        /// <summary> Field to specify running state. </summary>
        public static DataProductDataTypeState Running { get; } = new DataProductDataTypeState(RunningValue);
        /// <summary> Determines if two <see cref="DataProductDataTypeState"/> values are the same. </summary>
        public static bool operator ==(DataProductDataTypeState left, DataProductDataTypeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataProductDataTypeState"/> values are not the same. </summary>
        public static bool operator !=(DataProductDataTypeState left, DataProductDataTypeState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataProductDataTypeState"/>. </summary>
        public static implicit operator DataProductDataTypeState(string value) => new DataProductDataTypeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataProductDataTypeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataProductDataTypeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
