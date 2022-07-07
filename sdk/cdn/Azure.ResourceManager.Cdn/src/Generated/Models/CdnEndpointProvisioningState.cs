// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Provisioning status of the endpoint. </summary>
    public readonly partial struct CdnEndpointProvisioningState : IEquatable<CdnEndpointProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CdnEndpointProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CdnEndpointProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string FailedValue = "Failed";
        private const string UpdatingValue = "Updating";
        private const string DeletingValue = "Deleting";
        private const string CreatingValue = "Creating";

        /// <summary> Succeeded. </summary>
        public static CdnEndpointProvisioningState Succeeded { get; } = new CdnEndpointProvisioningState(SucceededValue);
        /// <summary> Failed. </summary>
        public static CdnEndpointProvisioningState Failed { get; } = new CdnEndpointProvisioningState(FailedValue);
        /// <summary> Updating. </summary>
        public static CdnEndpointProvisioningState Updating { get; } = new CdnEndpointProvisioningState(UpdatingValue);
        /// <summary> Deleting. </summary>
        public static CdnEndpointProvisioningState Deleting { get; } = new CdnEndpointProvisioningState(DeletingValue);
        /// <summary> Creating. </summary>
        public static CdnEndpointProvisioningState Creating { get; } = new CdnEndpointProvisioningState(CreatingValue);
        /// <summary> Determines if two <see cref="CdnEndpointProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CdnEndpointProvisioningState left, CdnEndpointProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CdnEndpointProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CdnEndpointProvisioningState left, CdnEndpointProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CdnEndpointProvisioningState"/>. </summary>
        public static implicit operator CdnEndpointProvisioningState(string value) => new CdnEndpointProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CdnEndpointProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CdnEndpointProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
