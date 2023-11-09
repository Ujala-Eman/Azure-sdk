// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> The AnalyzeTextPiiEntitiesRecognitionInput. </summary>
    internal partial class AnalyzeTextPiiEntitiesRecognitionInput : AnalyzeTextTask
    {
        /// <summary> Initializes a new instance of <see cref="AnalyzeTextPiiEntitiesRecognitionInput"/>. </summary>
        public AnalyzeTextPiiEntitiesRecognitionInput()
        {
            Kind = AnalyzeTextTaskKind.PiiEntityRecognition;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeTextPiiEntitiesRecognitionInput"/>. </summary>
        /// <param name="kind"> Enumeration of supported Text Analysis tasks. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="analysisInput"></param>
        /// <param name="parameters"> Supported parameters for a PII Entities Recognition task. </param>
        internal AnalyzeTextPiiEntitiesRecognitionInput(AnalyzeTextTaskKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, MultiLanguageAnalysisInput analysisInput, PiiTaskParameters parameters) : base(kind, serializedAdditionalRawData)
        {
            AnalysisInput = analysisInput;
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Gets or sets the analysis input. </summary>
        public MultiLanguageAnalysisInput AnalysisInput { get; set; }
        /// <summary> Supported parameters for a PII Entities Recognition task. </summary>
        public PiiTaskParameters Parameters { get; set; }
    }
}
