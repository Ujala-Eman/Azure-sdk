// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Supported parameters for the pre-build Abstractive Summarization task. </summary>
    internal partial class AbstractiveSummarizationTaskParameters : AbstractiveSummarizationTaskParametersBase
    {
        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParameters"/>. </summary>
        public AbstractiveSummarizationTaskParameters()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AbstractiveSummarizationTaskParameters"/>. </summary>
        /// <param name="sentenceCount"> It controls the approximate number of sentences in the output summaries. </param>
        /// <param name="stringIndexType"> Specifies the method used to interpret string offsets.  Defaults to Text Elements (Graphemes) according to Unicode v8.0.0. For additional information see https://aka.ms/text-analytics-offsets. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="modelVersion"></param>
        /// <param name="loggingOptOut"></param>
        internal AbstractiveSummarizationTaskParameters(int? sentenceCount, StringIndexType? stringIndexType, IDictionary<string, BinaryData> serializedAdditionalRawData, string modelVersion, bool? loggingOptOut) : base(sentenceCount, stringIndexType, serializedAdditionalRawData)
        {
            ModelVersion = modelVersion;
            LoggingOptOut = loggingOptOut;
        }

        /// <summary> Gets or sets the model version. </summary>
        public string ModelVersion { get; set; }
        /// <summary> Gets or sets the logging opt out. </summary>
        public bool? LoggingOptOut { get; set; }
    }
}
