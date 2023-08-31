// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> InMageRcmFailback policy creation input. </summary>
    public partial class InMageRcmFailbackPolicyCreationContent : PolicyProviderSpecificContent
    {
        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPolicyCreationContent"/>. </summary>
        public InMageRcmFailbackPolicyCreationContent()
        {
            InstanceType = "InMageRcmFailback";
        }

        /// <summary> Initializes a new instance of <see cref="InMageRcmFailbackPolicyCreationContent"/>. </summary>
        /// <param name="instanceType"> The class type. </param>
        /// <param name="crashConsistentFrequencyInMinutes"> The crash consistent snapshot frequency (in minutes). </param>
        /// <param name="appConsistentFrequencyInMinutes"> The app consistent snapshot frequency (in minutes). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal InMageRcmFailbackPolicyCreationContent(string instanceType, int? crashConsistentFrequencyInMinutes, int? appConsistentFrequencyInMinutes, Dictionary<string, BinaryData> rawData) : base(instanceType, rawData)
        {
            CrashConsistentFrequencyInMinutes = crashConsistentFrequencyInMinutes;
            AppConsistentFrequencyInMinutes = appConsistentFrequencyInMinutes;
            InstanceType = instanceType ?? "InMageRcmFailback";
        }

        /// <summary> The crash consistent snapshot frequency (in minutes). </summary>
        public int? CrashConsistentFrequencyInMinutes { get; set; }
        /// <summary> The app consistent snapshot frequency (in minutes). </summary>
        public int? AppConsistentFrequencyInMinutes { get; set; }
    }
}
