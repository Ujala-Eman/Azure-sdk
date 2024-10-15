// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The resource provisioning state. This property is READ-ONLY. </summary>
    public readonly partial struct DataCollectionEndpointProvisioningState : IEquatable<DataCollectionEndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="DataCollectionEndpointProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public DataCollectionEndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string SucceededValue = "Succeeded";
        private const string CanceledValue = "Canceled";
        private const string FailedValue = "Failed";

        /// <summary> Creating. </summary>
        public static DataCollectionEndpointProvisioningState Creating { get; } = new DataCollectionEndpointProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static DataCollectionEndpointProvisioningState Updating { get; } = new DataCollectionEndpointProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static DataCollectionEndpointProvisioningState Deleting { get; } = new DataCollectionEndpointProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static DataCollectionEndpointProvisioningState Succeeded { get; } = new DataCollectionEndpointProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static DataCollectionEndpointProvisioningState Canceled { get; } = new DataCollectionEndpointProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static DataCollectionEndpointProvisioningState Failed { get; } = new DataCollectionEndpointProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="DataCollectionEndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(DataCollectionEndpointProvisioningState left, DataCollectionEndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="DataCollectionEndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(DataCollectionEndpointProvisioningState left, DataCollectionEndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a <see cref="string"/> to a <see cref="DataCollectionEndpointProvisioningState"/>. </summary>
        public static implicit operator DataCollectionEndpointProvisioningState(string value) => new DataCollectionEndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is DataCollectionEndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(DataCollectionEndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
