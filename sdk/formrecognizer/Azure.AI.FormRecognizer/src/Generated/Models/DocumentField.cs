// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.AI.FormRecognizer;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> An object representing the content and location of a field value. </summary>
    public partial class DocumentField
    {
        /// <summary> Field content. </summary>
        public string Content { get; }
        /// <summary> Bounding regions covering the field. </summary>
        public IReadOnlyList<BoundingRegion> BoundingRegions { get; }
        /// <summary> Location of the field in the reading order concatenated content. </summary>
        public IReadOnlyList<DocumentSpan> Spans { get; }
        /// <summary> Confidence of correctly extracting the field. </summary>
        public float? Confidence { get; }
    }
}
