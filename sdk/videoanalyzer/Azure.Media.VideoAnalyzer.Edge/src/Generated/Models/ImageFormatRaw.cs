// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    /// <summary> Raw image formatting. </summary>
    public partial class ImageFormatRaw : ImageFormatProperties
    {
        /// <summary> Initializes a new instance of <see cref="ImageFormatRaw"/>. </summary>
        /// <param name="pixelFormat"> Pixel format to be applied to the raw image. </param>
        public ImageFormatRaw(ImageFormatRawPixelFormat pixelFormat)
        {
            PixelFormat = pixelFormat;
            Type = "#Microsoft.VideoAnalyzer.ImageFormatRaw";
        }

        /// <summary> Initializes a new instance of <see cref="ImageFormatRaw"/>. </summary>
        /// <param name="type"> Type discriminator for the derived types. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="pixelFormat"> Pixel format to be applied to the raw image. </param>
        internal ImageFormatRaw(string type, IDictionary<string, BinaryData> serializedAdditionalRawData, ImageFormatRawPixelFormat pixelFormat) : base(type, serializedAdditionalRawData)
        {
            PixelFormat = pixelFormat;
            Type = type ?? "#Microsoft.VideoAnalyzer.ImageFormatRaw";
        }

        /// <summary> Initializes a new instance of <see cref="ImageFormatRaw"/> for deserialization. </summary>
        internal ImageFormatRaw()
        {
        }

        /// <summary> Pixel format to be applied to the raw image. </summary>
        public ImageFormatRawPixelFormat PixelFormat { get; set; }
    }
}
