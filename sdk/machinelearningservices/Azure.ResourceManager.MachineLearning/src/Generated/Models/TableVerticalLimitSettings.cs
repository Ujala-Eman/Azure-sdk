// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job execution constraints. </summary>
    public partial class TableVerticalLimitSettings
    {
        /// <summary> Initializes a new instance of <see cref="TableVerticalLimitSettings"/>. </summary>
        public TableVerticalLimitSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TableVerticalLimitSettings"/>. </summary>
        /// <param name="enableEarlyTermination"> Enable early termination, determines whether or not if AutoMLJob will terminate early if there is no score improvement in last 20 iterations. </param>
        /// <param name="exitScore"> Exit score for the AutoML job. </param>
        /// <param name="maxConcurrentTrials"> Maximum Concurrent iterations. </param>
        /// <param name="maxCoresPerTrial"> Max cores per iteration. </param>
        /// <param name="maxTrials"> Number of iterations. </param>
        /// <param name="timeout"> AutoML job timeout. </param>
        /// <param name="trialTimeout"> Iteration timeout. </param>
        internal TableVerticalLimitSettings(bool? enableEarlyTermination, double? exitScore, int? maxConcurrentTrials, int? maxCoresPerTrial, int? maxTrials, TimeSpan? timeout, TimeSpan? trialTimeout)
        {
            EnableEarlyTermination = enableEarlyTermination;
            ExitScore = exitScore;
            MaxConcurrentTrials = maxConcurrentTrials;
            MaxCoresPerTrial = maxCoresPerTrial;
            MaxTrials = maxTrials;
            Timeout = timeout;
            TrialTimeout = trialTimeout;
        }

        /// <summary> Enable early termination, determines whether or not if AutoMLJob will terminate early if there is no score improvement in last 20 iterations. </summary>
        public bool? EnableEarlyTermination { get; set; }
        /// <summary> Exit score for the AutoML job. </summary>
        public double? ExitScore { get; set; }
        /// <summary> Maximum Concurrent iterations. </summary>
        public int? MaxConcurrentTrials { get; set; }
        /// <summary> Max cores per iteration. </summary>
        public int? MaxCoresPerTrial { get; set; }
        /// <summary> Number of iterations. </summary>
        public int? MaxTrials { get; set; }
        /// <summary> AutoML job timeout. </summary>
        public TimeSpan? Timeout { get; set; }
        /// <summary> Iteration timeout. </summary>
        public TimeSpan? TrialTimeout { get; set; }
    }
}
