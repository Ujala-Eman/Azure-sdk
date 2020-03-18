// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.AI.FormRecognizer.Models;

namespace Azure.AI.FormRecognizer.Custom
{
    /// <summary> Report for a custom model training document. </summary>
    public partial class TrainingDocumentInfo
    {
        /// <summary> Training document name. </summary>
        public string DocumentName { get; set; }
        /// <summary> List of errors. </summary>
        public IList<FormRecognizerError> Errors { get; set; } = new List<FormRecognizerError>();
        /// <summary> Status of the training operation. </summary>
        public TrainingStatus Status { get; set; }
    }
}
