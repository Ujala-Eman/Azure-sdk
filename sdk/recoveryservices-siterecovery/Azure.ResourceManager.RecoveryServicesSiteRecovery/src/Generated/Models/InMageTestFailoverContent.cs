// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Provider specific input for InMage test failover. </summary>
    public partial class InMageTestFailoverContent : TestFailoverProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageTestFailoverContent"/>. </summary>
        public InMageTestFailoverContent()
        {
            InstanceType = "InMage";
        }

        /// <summary> Initializes a new instance of <see cref="InMageTestFailoverContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="recoveryPointType"> The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored. </param>
        /// <param name="recoveryPointId"> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageTestFailoverContent(string instanceType, SiteRecoveryPointType? recoveryPointType, ResourceIdentifier recoveryPointId, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            RecoveryPointType = recoveryPointType;
            RecoveryPointId = recoveryPointId;
            InstanceType = instanceType ?? "InMage";
        }

        /// <summary> The recovery point type. Values from LatestTime, LatestTag or Custom. In the case of custom, the recovery point provided by RecoveryPointId will be used. In the other two cases, recovery point id will be ignored. </summary>
        public SiteRecoveryPointType? RecoveryPointType { get; set; }
        /// <summary> The recovery point id to be passed to test failover to a particular recovery point. In case of latest recovery point, null should be passed. </summary>
        public ResourceIdentifier RecoveryPointId { get; set; }
    }
}
