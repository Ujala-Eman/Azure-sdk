// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Recovery plan creation properties. </summary>
    public partial class CreateRecoveryPlanInputProperties
    {
        /// <summary> Initializes a new instance of CreateRecoveryPlanInputProperties. </summary>
        /// <param name="primaryFabricId"> The primary fabric Id. </param>
        /// <param name="recoveryFabricId"> The recovery fabric Id. </param>
        /// <param name="groups"> The recovery plan groups. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="primaryFabricId"/>, <paramref name="recoveryFabricId"/> or <paramref name="groups"/> is null. </exception>
        public CreateRecoveryPlanInputProperties(string primaryFabricId, string recoveryFabricId, IEnumerable<RecoveryPlanGroup> groups)
        {
            if (primaryFabricId == null)
            {
                throw new ArgumentNullException(nameof(primaryFabricId));
            }
            if (recoveryFabricId == null)
            {
                throw new ArgumentNullException(nameof(recoveryFabricId));
            }
            if (groups == null)
            {
                throw new ArgumentNullException(nameof(groups));
            }

            PrimaryFabricId = primaryFabricId;
            RecoveryFabricId = recoveryFabricId;
            Groups = groups.ToList();
            ProviderSpecificInput = new ChangeTrackingList<RecoveryPlanProviderSpecificInput>();
        }

        /// <summary> The primary fabric Id. </summary>
        public string PrimaryFabricId { get; }
        /// <summary> The recovery fabric Id. </summary>
        public string RecoveryFabricId { get; }
        /// <summary> The failover deployment model. </summary>
        public FailoverDeploymentModel? FailoverDeploymentModel { get; set; }
        /// <summary> The recovery plan groups. </summary>
        public IList<RecoveryPlanGroup> Groups { get; }
        /// <summary>
        /// The provider specific input.
        /// Please note <see cref="RecoveryPlanProviderSpecificInput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="RecoveryPlanA2AInput"/>.
        /// </summary>
        public IList<RecoveryPlanProviderSpecificInput> ProviderSpecificInput { get; }
    }
}
