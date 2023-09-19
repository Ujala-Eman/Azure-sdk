// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DevSpaces.Models
{
    /// <summary> The ControllerConnectionDetails. </summary>
    public partial class ControllerConnectionDetails
    {
        /// <summary> Initializes a new instance of ControllerConnectionDetails. </summary>
        internal ControllerConnectionDetails()
        {
        }

        /// <summary> Initializes a new instance of ControllerConnectionDetails. </summary>
        /// <param name="orchestratorSpecificConnectionDetails">
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="Models.OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </param>
        internal ControllerConnectionDetails(OrchestratorSpecificConnectionDetails orchestratorSpecificConnectionDetails)
        {
            OrchestratorSpecificConnectionDetails = orchestratorSpecificConnectionDetails;
        }

        /// <summary>
        /// Base class for types that supply values used to connect to container orchestrators
        /// Please note <see cref="Models.OrchestratorSpecificConnectionDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="KubernetesConnectionDetails"/>.
        /// </summary>
        public OrchestratorSpecificConnectionDetails OrchestratorSpecificConnectionDetails { get; }
    }
}
