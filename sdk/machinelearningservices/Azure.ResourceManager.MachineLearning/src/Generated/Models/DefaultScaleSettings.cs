// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The DefaultScaleSettings. </summary>
    public partial class DefaultScaleSettings : OnlineScaleSettings
    {
        /// <summary> Initializes a new instance of <see cref="DefaultScaleSettings"/>. </summary>
        public DefaultScaleSettings()
        {
            ScaleType = ScaleType.Default;
        }

        /// <summary> Initializes a new instance of <see cref="DefaultScaleSettings"/>. </summary>
        /// <param name="scaleType"> [Required] Type of deployment scaling algorithm. </param>
        internal DefaultScaleSettings(ScaleType scaleType) : base(scaleType)
        {
            ScaleType = scaleType;
        }
    }
}
