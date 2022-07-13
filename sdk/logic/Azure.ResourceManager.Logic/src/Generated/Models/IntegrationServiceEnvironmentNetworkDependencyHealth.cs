// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The integration service environment subnet network health. </summary>
    public partial class IntegrationServiceEnvironmentNetworkDependencyHealth
    {
        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkDependencyHealth. </summary>
        internal IntegrationServiceEnvironmentNetworkDependencyHealth()
        {
        }

        /// <summary> Initializes a new instance of IntegrationServiceEnvironmentNetworkDependencyHealth. </summary>
        /// <param name="error"> The error if any occurred during the operation. </param>
        /// <param name="state"> The network dependency health state. </param>
        internal IntegrationServiceEnvironmentNetworkDependencyHealth(ExtendedErrorInfo error, IntegrationServiceEnvironmentNetworkDependencyHealthState? state)
        {
            Error = error;
            State = state;
        }

        /// <summary> The error if any occurred during the operation. </summary>
        public ExtendedErrorInfo Error { get; }
        /// <summary> The network dependency health state. </summary>
        public IntegrationServiceEnvironmentNetworkDependencyHealthState? State { get; }
    }
}
