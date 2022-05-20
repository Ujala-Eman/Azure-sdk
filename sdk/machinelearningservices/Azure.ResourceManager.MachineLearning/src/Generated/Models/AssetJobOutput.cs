// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Asset output type. </summary>
    internal partial class AssetJobOutput
    {
        /// <summary> Initializes a new instance of AssetJobOutput. </summary>
        public AssetJobOutput()
        {
        }

        /// <summary> Initializes a new instance of AssetJobOutput. </summary>
        /// <param name="mode"> Output Asset Delivery Mode. </param>
        /// <param name="uri"> Output Asset URI. </param>
        internal AssetJobOutput(OutputDeliveryMode? mode, Uri uri)
        {
            Mode = mode;
            Uri = uri;
        }

        /// <summary> Output Asset Delivery Mode. </summary>
        public OutputDeliveryMode? Mode { get; set; }
        /// <summary> Output Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
