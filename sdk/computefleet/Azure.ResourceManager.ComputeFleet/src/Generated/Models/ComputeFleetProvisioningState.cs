// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    /// <summary> The status of the current operation. </summary>
    public readonly partial struct ComputeFleetProvisioningState : IEquatable<ComputeFleetProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="ComputeFleetProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public ComputeFleetProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string CanceledValue = "Canceled";
        private const string CreatingValue = "Creating";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string MigratingValue = "Migrating";

        /// <summary> Resource has been created. </summary>
        public static ComputeFleetProvisioningState Succeeded { get; } = new ComputeFleetProvisioningState(SucceededValue);
        /// <summary> Resource creation failed. </summary>
        public static ComputeFleetProvisioningState Failed { get; } = new ComputeFleetProvisioningState(FailedValue);
        /// <summary> Resource creation was canceled. </summary>
        public static ComputeFleetProvisioningState Canceled { get; } = new ComputeFleetProvisioningState(CanceledValue);
        /// <summary> Initial creation in progress. </summary>
        public static ComputeFleetProvisioningState Creating { get; } = new ComputeFleetProvisioningState(CreatingValue);
        /// <summary> Update in progress. </summary>
        public static ComputeFleetProvisioningState Updating { get; } = new ComputeFleetProvisioningState(UpdatingValue);
        /// <summary> Deletion in progress. </summary>
        public static ComputeFleetProvisioningState Deleting { get; } = new ComputeFleetProvisioningState(DeletingValue);
        /// <summary> Resource is being migrated from one subscription or resource group to another. </summary>
        public static ComputeFleetProvisioningState Migrating { get; } = new ComputeFleetProvisioningState(MigratingValue);
        /// <summary> Determines if two <see cref="ComputeFleetProvisioningState"/> values are the same. </summary>
        public static bool operator ==(ComputeFleetProvisioningState left, ComputeFleetProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="ComputeFleetProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(ComputeFleetProvisioningState left, ComputeFleetProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="ComputeFleetProvisioningState"/>. </summary>
        public static implicit operator ComputeFleetProvisioningState(string value) => new ComputeFleetProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ComputeFleetProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(ComputeFleetProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
