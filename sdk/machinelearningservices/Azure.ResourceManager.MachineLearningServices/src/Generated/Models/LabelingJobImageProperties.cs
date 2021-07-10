// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary> Properties of a labeling job for image data. </summary>
    public partial class LabelingJobImageProperties : LabelingJobMediaProperties
    {
        /// <summary> Initializes a new instance of LabelingJobImageProperties. </summary>
        public LabelingJobImageProperties()
        {
            MediaType = MediaType.Image;
        }

        /// <summary> Initializes a new instance of LabelingJobImageProperties. </summary>
        /// <param name="mediaType"> Media type of the job. </param>
        /// <param name="annotationType"> Annotation type of image labeling job. </param>
        internal LabelingJobImageProperties(MediaType mediaType, ImageAnnotationType? annotationType) : base(mediaType)
        {
            AnnotationType = annotationType;
            MediaType = mediaType;
        }

        /// <summary> Annotation type of image labeling job. </summary>
        public ImageAnnotationType? AnnotationType { get; set; }
    }
}
