// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An object describing face rectangle.
    /// </summary>
    public partial class FaceRectangle
    {
        /// <summary>
        /// Initializes a new instance of the FaceRectangle class.
        /// </summary>
        public FaceRectangle()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FaceRectangle class.
        /// </summary>
        /// <param name="left">X-coordinate of the top left point of the
        /// face.</param>
        /// <param name="top">Y-coordinate of the top left point of the
        /// face.</param>
        /// <param name="width">Width measured from the top-left point of the
        /// face.</param>
        /// <param name="height">Height measured from the top-left point of the
        /// face.</param>
        public FaceRectangle(int? left = default(int?), int? top = default(int?), int? width = default(int?), int? height = default(int?))
        {
            Left = left;
            Top = top;
            Width = width;
            Height = height;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets x-coordinate of the top left point of the face.
        /// </summary>
        [JsonProperty(PropertyName = "left")]
        public int? Left { get; set; }

        /// <summary>
        /// Gets or sets y-coordinate of the top left point of the face.
        /// </summary>
        [JsonProperty(PropertyName = "top")]
        public int? Top { get; set; }

        /// <summary>
        /// Gets or sets width measured from the top-left point of the face.
        /// </summary>
        [JsonProperty(PropertyName = "width")]
        public int? Width { get; set; }

        /// <summary>
        /// Gets or sets height measured from the top-left point of the face.
        /// </summary>
        [JsonProperty(PropertyName = "height")]
        public int? Height { get; set; }

    }
}
