// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Online deployment scaling configuration.
    /// Please note <see cref="OnlineScaleSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="DefaultScaleSettings"/> and <see cref="TargetUtilizationScaleSettings"/>.
    /// </summary>
    public partial class OnlineScaleSettings
    {
        /// <summary> Initializes a new instance of <see cref="OnlineScaleSettings"/>. </summary>
        public OnlineScaleSettings()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OnlineScaleSettings"/>. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        internal OnlineScaleSettings(ScaleType scaleType)
        {
            ScaleType = scaleType;
        }

        /// <summary> [Required] Type of deployment scaling algorithm. </summary>
        internal ScaleType ScaleType { get; set; }
    }
}
