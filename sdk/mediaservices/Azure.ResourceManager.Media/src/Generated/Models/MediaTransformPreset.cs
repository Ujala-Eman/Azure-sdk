// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary>
    /// Base type for all Presets, which define the recipe or instructions on how the input media files should be processed.
    /// Please note <see cref="MediaTransformPreset"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AudioAnalyzerPreset"/>, <see cref="BuiltInStandardEncoderPreset"/>, <see cref="StandardEncoderPreset"/> and <see cref="VideoAnalyzerPreset"/>.
    /// </summary>
    public abstract partial class MediaTransformPreset
    {
        /// <summary> Initializes a new instance of MediaTransformPreset. </summary>
        protected MediaTransformPreset()
        {
        }

        /// <summary> Initializes a new instance of MediaTransformPreset. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        internal MediaTransformPreset(string odataType)
        {
            OdataType = odataType;
        }

        /// <summary> The discriminator for derived types. </summary>
        internal string OdataType { get; set; }
    }
}
