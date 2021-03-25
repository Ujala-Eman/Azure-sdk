// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Media.Analytics.Edge.Models
{
    /// <summary> Encoding settings for Bmp images. </summary>
    public partial class ImageFormatBmp : ImageFormat
    {
        /// <summary> Initializes a new instance of ImageFormatBmp. </summary>
        public ImageFormatBmp()
        {
            Type = "#Microsoft.VideoAnalyzer.ImageFormatBmp";
        }

        /// <summary> Initializes a new instance of ImageFormatBmp. </summary>
        /// <param name="type"> The discriminator for derived types. </param>
        internal ImageFormatBmp(string type) : base(type)
        {
            Type = type ?? "#Microsoft.VideoAnalyzer.ImageFormatBmp";
        }
    }
}
