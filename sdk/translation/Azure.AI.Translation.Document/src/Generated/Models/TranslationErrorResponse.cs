// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.AI.Translation.Document;

namespace Azure.AI.Translation.Document.Models
{
    /// <summary>
    /// Contains unified error information used for HTTP responses across any Cognitive Service. Instances
    /// 
    /// can be created either through Microsoft.CloudAI.Containers.HttpStatusExceptionV2 or by returning it directly from
    /// 
    /// a controller.
    /// </summary>
    internal partial class TranslationErrorResponse
    {
        /// <summary> Initializes a new instance of TranslationErrorResponse. </summary>
        internal TranslationErrorResponse()
        {
        }

        /// <summary> Initializes a new instance of TranslationErrorResponse. </summary>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        internal TranslationErrorResponse(DocumentTranslationError error)
        {
            Error = error;
        }

        /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
        public DocumentTranslationError Error { get; }
    }
}
