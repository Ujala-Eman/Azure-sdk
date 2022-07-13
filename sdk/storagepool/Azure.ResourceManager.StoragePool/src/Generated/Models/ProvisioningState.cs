// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.StoragePool.Models
{
    /// <summary> Provisioning state of the iSCSI Target. </summary>
    public readonly partial struct ProvisioningState : IEquatable<ProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InvalidValue = "Invalid";
        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string PendingValue = "Pending";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";

        /// <summary> Invalid. </summary>
        public static ProvisioningState Invalid { get; } = new ProvisioningState(InvalidValue);
        /// <summary> Succeeded. </summary>
        public static ProvisioningState Succeeded { get; } = new ProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static ProvisioningState Failed { get; } = new ProvisioningState(FailedValue);
        /// <summary> Canceled. </summary>
        public static ProvisioningState Canceled { get; } = new ProvisioningState(CanceledValue);
        /// <summary> Pending. </summary>
        public static ProvisioningState Pending { get; } = new ProvisioningState(PendingValue);
        /// <summary> Creating. </summary>
        public static ProvisioningState Creating { get; } = new ProvisioningState(CreatingValue);
        /// <summary> Updating. </summary>
        public static ProvisioningState Updating { get; } = new ProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static ProvisioningState Deleting { get; } = new ProvisioningState(DeletingValue);
        /// <summary> Determines if two <see cref="ProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ProvisioningState left, ProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ProvisioningState left, ProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ProvisioningState"/>. </summary>
        public static implicit operator ProvisioningState(string value) => new ProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
