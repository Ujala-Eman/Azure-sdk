// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.IotCentral.Models
{
    /// <summary> The provisioning state of the application. </summary>
    public readonly partial struct IotCentralProvisioningState : IEquatable<IotCentralProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="IotCentralProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public IotCentralProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string UpdatingValue = "Updating";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";

        /// <summary> Creating. </summary>
        public static IotCentralProvisioningState Creating { get; } = new IotCentralProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static IotCentralProvisioningState Deleting { get; } = new IotCentralProvisioningState(DeletingValue);
        /// <summary> Updating. </summary>
        public static IotCentralProvisioningState Updating { get; } = new IotCentralProvisioningState(UpdatingValue);
        /// <summary> Succeeded. </summary>
        public static IotCentralProvisioningState Succeeded { get; } = new IotCentralProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static IotCentralProvisioningState Failed { get; } = new IotCentralProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static IotCentralProvisioningState Canceled { get; } = new IotCentralProvisioningState(CanceledValue);
        /// <summary> Determines if two <see cref="IotCentralProvisioningState"/> values are the same. </summary>
        public static bool operator ==(IotCentralProvisioningState left, IotCentralProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="IotCentralProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(IotCentralProvisioningState left, IotCentralProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="IotCentralProvisioningState"/>. </summary>
        public static implicit operator IotCentralProvisioningState(string value) => new IotCentralProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is IotCentralProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(IotCentralProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
