// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Create protection intent input properties. </summary>
    internal partial class SiteRecoveryCreateProtectionIntentProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateProtectionIntentProperties"/>. </summary>
        public SiteRecoveryCreateProtectionIntentProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryCreateProtectionIntentProperties"/>. </summary>
        /// <param name="providerSpecificDetails">
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// Please note <see cref="SiteRecoveryCreateProtectionIntentProviderDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ACreateProtectionIntentContent"/>.
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryCreateProtectionIntentProperties(SiteRecoveryCreateProtectionIntentProviderDetail providerSpecificDetails, Dictionary<string, BinaryData> rawData)
        {
            ProviderSpecificDetails = providerSpecificDetails;
            _rawData = rawData;
        }

        /// <summary>
        /// The ReplicationProviderInput. For A2A provider, it will be A2ACreateProtectionIntentInput object.
        /// Please note <see cref="SiteRecoveryCreateProtectionIntentProviderDetail"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="A2ACreateProtectionIntentContent"/>.
        /// </summary>
        public SiteRecoveryCreateProtectionIntentProviderDetail ProviderSpecificDetails { get; set; }
    }
}
