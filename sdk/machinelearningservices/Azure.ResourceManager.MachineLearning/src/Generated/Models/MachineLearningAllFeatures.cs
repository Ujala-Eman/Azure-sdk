// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningAllFeatures. </summary>
    public partial class MachineLearningAllFeatures : MonitoringFeatureFilterBase
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningAllFeatures"/>. </summary>
        public MachineLearningAllFeatures()
        {
            FilterType = MonitoringFeatureFilterType.AllFeatures;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningAllFeatures"/>. </summary>
        /// <param name="filterType"> [Required] Specifies the feature filter to leverage when selecting features to calculate metrics over. </param>
        internal MachineLearningAllFeatures(MonitoringFeatureFilterType filterType) : base(filterType)
        {
            FilterType = filterType;
        }
    }
}
