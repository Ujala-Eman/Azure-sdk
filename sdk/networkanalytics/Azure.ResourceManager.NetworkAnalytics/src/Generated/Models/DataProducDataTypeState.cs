// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.NetworkAnalytics.Models
{
    /// <summary> The data type state. </summary>
    public readonly partial struct DataProducDataTypeState : IEquatable<DataProducDataTypeState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataProducDataTypeState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataProducDataTypeState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string StoppedValue = "Stopped";
        private const string RunningValue = "Running";

        /// <summary> Field to specify stopped state. </summary>
        public static DataProducDataTypeState Stopped { get; } = new DataProducDataTypeState(StoppedValue);
        /// <summary> Field to specify running state. </summary>
        public static DataProducDataTypeState Running { get; } = new DataProducDataTypeState(RunningValue);
        /// <summary> Determines if two <see cref="DataProducDataTypeState"/> values are the same. </summary>
        public static bool operator ==(DataProducDataTypeState left, DataProducDataTypeState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataProducDataTypeState"/> values are not the same. </summary>
        public static bool operator !=(DataProducDataTypeState left, DataProducDataTypeState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataProducDataTypeState"/>. </summary>
        public static implicit operator DataProducDataTypeState(string value) => new DataProducDataTypeState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataProducDataTypeState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataProducDataTypeState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
