// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    /// <summary>
    /// The provisioning state of the cluster resource.
    /// Serialized Name: ProvisioningState
    /// </summary>
    public readonly partial struct ServiceFabricProvisioningState : IEquatable<ServiceFabricProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ServiceFabricProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ServiceFabricProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary>
        /// Updating
        /// Serialized Name: ProvisioningState.Updating
        /// </summary>
        public static ServiceFabricProvisioningState Updating { get; } = new ServiceFabricProvisioningState(UpdatingValue);
        /// <summary>
        /// Succeeded
        /// Serialized Name: ProvisioningState.Succeeded
        /// </summary>
        public static ServiceFabricProvisioningState Succeeded { get; } = new ServiceFabricProvisioningState(SucceededValue);
        /// <summary>
        /// Failed
        /// Serialized Name: ProvisioningState.Failed
        /// </summary>
        public static ServiceFabricProvisioningState Failed { get; } = new ServiceFabricProvisioningState(FailedValue);
        /// <summary>
        /// Canceled
        /// Serialized Name: ProvisioningState.Canceled
        /// </summary>
        public static ServiceFabricProvisioningState Canceled { get; } = new ServiceFabricProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="ServiceFabricProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ServiceFabricProvisioningState left, ServiceFabricProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ServiceFabricProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ServiceFabricProvisioningState left, ServiceFabricProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ServiceFabricProvisioningState"/>. </summary>
        public static implicit operator ServiceFabricProvisioningState(string value) => new ServiceFabricProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ServiceFabricProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ServiceFabricProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
