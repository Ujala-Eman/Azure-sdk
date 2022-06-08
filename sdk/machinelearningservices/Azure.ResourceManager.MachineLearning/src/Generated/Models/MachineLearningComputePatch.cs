// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> AmlCompute update parameters. </summary>
    public partial class MachineLearningComputePatch
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningComputePatch"/>. </summary>
        public MachineLearningComputePatch()
        {
        }

        /// <summary> Properties of ClusterUpdate. </summary>
        internal ScaleSettingsInformation Properties { get; set; }
        /// <summary> scale settings for AML Compute. </summary>
        public ScaleSettings ScaleSettings
        {
            get => Properties is null ? default : Properties.ScaleSettings;
            set
            {
                if (Properties is null)
                    Properties = new ScaleSettingsInformation();
                Properties.ScaleSettings = value;
            }
        }
    }
}
