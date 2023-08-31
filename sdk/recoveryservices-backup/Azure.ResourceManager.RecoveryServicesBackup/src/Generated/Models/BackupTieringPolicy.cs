// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    /// <summary>
    /// Tiering Policy for a target tier.
    /// If the policy is not specified for a given target tier, service retains the existing configured tiering policy for that tier
    /// </summary>
    public partial class BackupTieringPolicy
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BackupTieringPolicy"/>. </summary>
        public BackupTieringPolicy()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BackupTieringPolicy"/>. </summary>
        /// <param name="tieringMode">
        /// Tiering Mode to control automatic tiering of recovery points. Supported values are:
        /// 1. TierRecommended: Tier all recovery points recommended to be tiered
        /// 2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        /// 3. DoNotTier: Do not tier any recovery points
        /// </param>
        /// <param name="durationValue">
        /// Number of days/weeks/months/years to retain backups in current tier before tiering.
        /// Used only if TieringMode is set to TierAfter
        /// </param>
        /// <param name="durationType">
        /// Retention duration type: days/weeks/months/years
        /// Used only if TieringMode is set to TierAfter
        /// </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BackupTieringPolicy(TieringMode? tieringMode, int? durationValue, RetentionDurationType? durationType, Dictionary<string, BinaryData> rawData)
        {
            TieringMode = tieringMode;
            DurationValue = durationValue;
            DurationType = durationType;
            _rawData = rawData;
        }

        /// <summary>
        /// Tiering Mode to control automatic tiering of recovery points. Supported values are:
        /// 1. TierRecommended: Tier all recovery points recommended to be tiered
        /// 2. TierAfter: Tier all recovery points after a fixed period, as specified in duration + durationType below.
        /// 3. DoNotTier: Do not tier any recovery points
        /// </summary>
        public TieringMode? TieringMode { get; set; }
        /// <summary>
        /// Number of days/weeks/months/years to retain backups in current tier before tiering.
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        public int? DurationValue { get; set; }
        /// <summary>
        /// Retention duration type: days/weeks/months/years
        /// Used only if TieringMode is set to TierAfter
        /// </summary>
        public RetentionDurationType? DurationType { get; set; }
    }
}
