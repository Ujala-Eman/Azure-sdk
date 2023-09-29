// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class NlpVerticalLimitSettings
    {
        /// <summary> Initializes a new instance of NlpVerticalLimitSettings. </summary>
        public NlpVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of NlpVerticalLimitSettings. </summary>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent AutoML iterations. </param>
        /// <param name="maxNodes"> Maximum nodes to use for the experiment. </param>
        /// <param name="maxTrials"> Number of AutoML iterations. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="trialTimeout"> Timeout for individual HD trials. </param>
        internal NlpVerticalLimitSettings(int? maxConcurrentTrials, int? maxNodes, int? maxTrials, TimeSpan? timeout, TimeSpan? trialTimeout)
        {
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxNodes = maxNodes;
            MaxTrials = maxTrials;
            Timeout = timeout;
            TrialTimeout = trialTimeout;
        }

        /// <summary> Maximum Concurrent AutoML iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Maximum nodes to use for the experiment. </summary>
        public int? MaxNodes { get; set; }
        /// <summary> Number of AutoML iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Timeout for individual HD trials. </summary>
        public TimeSpan? TrialTimeout { get; set; }
    }
}
