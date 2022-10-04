// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> Kind of the endpoint for the data connection. </summary>
    internal readonly partial struct DataConnectionKind : IEquatable<DataConnectionKind>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataConnectionKind"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataConnectionKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string EventHubValue = "EventHub";
        private const string EventGridValue = "EventGrid";
        private const string IotHubValue = "IotHub";

        /// <summary> EventHub. </summary>
        public static DataConnectionKind EventHub { get; } = new DataConnectionKind(EventHubValue);
        /// <summary> EventGrid. </summary>
        public static DataConnectionKind EventGrid { get; } = new DataConnectionKind(EventGridValue);
        /// <summary> IotHub. </summary>
        public static DataConnectionKind IotHub { get; } = new DataConnectionKind(IotHubValue);
        /// <summary> Determines if two <see cref="DataConnectionKind"/> values are the same. </summary>
        public static bool operator ==(DataConnectionKind left, DataConnectionKind right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataConnectionKind"/> values are not the same. </summary>
        public static bool operator !=(DataConnectionKind left, DataConnectionKind right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="DataConnectionKind"/>. </summary>
        public static implicit operator DataConnectionKind(string value) => new DataConnectionKind(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataConnectionKind other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataConnectionKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
