// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.CosmosDBForPostgreSql.Models
{
    /// <summary> The current provisioning state. </summary>
    public readonly partial struct CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState : IEquatable<CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string SucceededValue = "Succeeded";
        private const string CreatingValue = "Creating";
        private const string DeletingValue = "Deleting";
        private const string FailedValue = "Failed";

        /// <summary> Succeeded. </summary>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState Succeeded { get; } = new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(SucceededValue);
        /// <summary> Creating. </summary>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState Creating { get; } = new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(CreatingValue);
        /// <summary> Deleting. </summary>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState Deleting { get; } = new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(DeletingValue);
        /// <summary> Failed. </summary>
        public static CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState Failed { get; } = new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(FailedValue);
        /// <summary> Determines if two <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState"/> values are the same. </summary>
        public static bool operator ==(CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState left, CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState right) => left.Equals(right);
        /// <summary> Determines if two <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState"/> values are not the same. </summary>
        public static bool operator !=(CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState left, CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState"/>. </summary>
        public static implicit operator CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(string value) => new CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState other && Equals(other);
        /// <inheritdoc />
        public bool Equals(CosmosDBForPostgreSqlPrivateEndpointConnectionProvisioningState other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
