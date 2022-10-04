// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Replication appliance properties. </summary>
    internal partial class ReplicationApplianceProperties
    {
        /// <summary> Initializes a new instance of ReplicationApplianceProperties. </summary>
        internal ReplicationApplianceProperties()
        {
        }

        /// <summary> Initializes a new instance of ReplicationApplianceProperties. </summary>
        /// <param name="providerSpecificDetails">
        /// Provider specific settings.
        /// Please note <see cref="ApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </param>
        internal ReplicationApplianceProperties(ApplianceSpecificDetails providerSpecificDetails)
        {
            ProviderSpecificDetails = providerSpecificDetails;
        }

        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="ApplianceSpecificDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="InMageRcmApplianceSpecificDetails"/>.
        /// </summary>
        public ApplianceSpecificDetails ProviderSpecificDetails { get; }
    }
}
