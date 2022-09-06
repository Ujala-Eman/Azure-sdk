// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Provisioning state of the Private Endpoint Connection. </summary>
    public readonly partial struct ResourceProvisioningState : IEquatable<ResourceProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ResourceProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ResourceProvisioningState(string value)
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
        public static ResourceProvisioningState Creating { get; } = new ResourceProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ResourceProvisioningState Updating { get; } = new ResourceProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ResourceProvisioningState Deleting { get; } = new ResourceProvisioningState(DeletingValue);
        /// <summary> Succeeded. </summary>
        public static ResourceProvisioningState Succeeded { get; } = new ResourceProvisioningState(SucceededValue);
        /// <summary> Canceled. </summary>
        public static ResourceProvisioningState Canceled { get; } = new ResourceProvisioningState(CanceledValue);
        /// <summary> Failed. </summary>
        public static ResourceProvisioningState Failed { get; } = new ResourceProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="ResourceProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ResourceProvisioningState left, ResourceProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ResourceProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ResourceProvisioningState left, ResourceProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ResourceProvisioningState"/>. </summary>
        public static implicit operator ResourceProvisioningState(string value) => new ResourceProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ResourceProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ResourceProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
