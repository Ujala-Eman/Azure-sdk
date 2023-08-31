// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Input definition for planned failover input properties. </summary>
    public partial class PlannedFailoverProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="PlannedFailoverProperties"/>. </summary>
        public PlannedFailoverProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PlannedFailoverProperties"/>. </summary>
        /// <param name="failoverDirection"> Failover direction. </param>
        /// <param name="providerSpecificDetails">
        /// Provider specific settings.
        /// Please note <see cref="PlannedFailoverProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVReplicaAzurePlannedFailoverProviderContent"/>, <see cref="HyperVReplicaAzureFailbackProviderContent"/> and <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal PlannedFailoverProperties(string failoverDirection, PlannedFailoverProviderSpecificFailoverContent providerSpecificDetails, Dictionary<string, BinaryData> rawData)
        {
            FailoverDirection = failoverDirection;
            ProviderSpecificDetails = providerSpecificDetails;
            _rawData = rawData;
        }

        /// <summary> Failover direction. </summary>
        public string FailoverDirection { get; set; }
        /// <summary>
        /// Provider specific settings.
        /// Please note <see cref="PlannedFailoverProviderSpecificFailoverContent"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="HyperVReplicaAzurePlannedFailoverProviderContent"/>, <see cref="HyperVReplicaAzureFailbackProviderContent"/> and <see cref="InMageRcmFailbackPlannedFailoverProviderContent"/>.
        /// </summary>
        public PlannedFailoverProviderSpecificFailoverContent ProviderSpecificDetails { get; set; }
    }
}
