// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    /// <summary> Cluster patch version upgrade history properties. </summary>
    public partial class ClusterPatchVersionUpgradeHistoryProperties : ClusterInPlaceUpgradeHistoryProperties
    {
        /// <summary> Initializes a new instance of <see cref="ClusterPatchVersionUpgradeHistoryProperties"/>. </summary>
        /// <param name="utcTime"> Time when created this upgrade history. </param>
        /// <param name="upgradeResult"> Result of this upgrade. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="utcTime"/> is null. </exception>
        public ClusterPatchVersionUpgradeHistoryProperties(string utcTime, ClusterUpgradeHistoryUpgradeResultType upgradeResult) : base(utcTime, upgradeResult)
        {
            Argument.AssertNotNull(utcTime, nameof(utcTime));

            UpgradeType = ClusterUpgradeHistoryType.PatchVersionUpgrade;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPatchVersionUpgradeHistoryProperties"/>. </summary>
        /// <param name="upgradeType"> Type of upgrade. </param>
        /// <param name="utcTime"> Time when created this upgrade history. </param>
        /// <param name="upgradeResult"> Result of this upgrade. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="sourceClusterVersion"> Version with three part. </param>
        /// <param name="sourceOssVersion"> Version with three part. </param>
        /// <param name="sourceBuildNumber"> Source build number. </param>
        /// <param name="targetClusterVersion"> Version with three part. </param>
        /// <param name="targetOssVersion"> Version with three part. </param>
        /// <param name="targetBuildNumber"> Target build number. </param>
        /// <param name="componentName"> Component name to upgrade. </param>
        /// <param name="severity"> Severity of this upgrade. </param>
        internal ClusterPatchVersionUpgradeHistoryProperties(ClusterUpgradeHistoryType upgradeType, string utcTime, ClusterUpgradeHistoryUpgradeResultType upgradeResult, IDictionary<string, BinaryData> serializedAdditionalRawData, string sourceClusterVersion, string sourceOssVersion, string sourceBuildNumber, string targetClusterVersion, string targetOssVersion, string targetBuildNumber, string componentName, ClusterUpgradeHistorySeverityType? severity) : base(upgradeType, utcTime, upgradeResult, serializedAdditionalRawData, sourceClusterVersion, sourceOssVersion, sourceBuildNumber, targetClusterVersion, targetOssVersion, targetBuildNumber, componentName, severity)
        {
            UpgradeType = upgradeType;
        }

        /// <summary> Initializes a new instance of <see cref="ClusterPatchVersionUpgradeHistoryProperties"/> for deserialization. </summary>
        internal ClusterPatchVersionUpgradeHistoryProperties()
        {
        }
    }
}
