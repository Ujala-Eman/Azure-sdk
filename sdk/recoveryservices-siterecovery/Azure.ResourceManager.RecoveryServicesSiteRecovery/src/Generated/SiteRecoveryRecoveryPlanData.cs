// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RecoveryServicesSiteRecovery.Models;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery
{
    /// <summary>
    /// A class representing the SiteRecoveryRecoveryPlan data model.
    /// Recovery plan details.
    /// </summary>
    public partial class SiteRecoveryRecoveryPlanData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRecoveryPlanData"/>. </summary>
        internal SiteRecoveryRecoveryPlanData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryRecoveryPlanData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> The custom details. </param>
        /// <param name="location"> Resource Location. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryRecoveryPlanData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, SiteRecoveryRecoveryPlanProperties properties, AzureLocation? location, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
            Location = location;
            _rawData = rawData;
        }

        /// <summary> The custom details. </summary>
        public SiteRecoveryRecoveryPlanProperties Properties { get; }
        /// <summary> Resource Location. </summary>
        public AzureLocation? Location { get; }
    }
}
