// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;

namespace Azure.AI.FormRecognizer.DocumentAnalysis
{
    /// <summary> List document models response object. </summary>
    internal partial class GetDocumentModelsResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GetDocumentModelsResponse"/>. </summary>
        /// <param name="value"> List of document models. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        internal GetDocumentModelsResponse(IEnumerable<DocumentModelSummary> value)
        {
            Argument.AssertNotNull(value, nameof(value));

            Value = value.ToList();
        }

        /// <summary> Initializes a new instance of <see cref="GetDocumentModelsResponse"/>. </summary>
        /// <param name="value"> List of document models. </param>
        /// <param name="nextLink"> Link to the next page of document models. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GetDocumentModelsResponse(IReadOnlyList<DocumentModelSummary> value, Uri nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GetDocumentModelsResponse"/> for deserialization. </summary>
        internal GetDocumentModelsResponse()
        {
        }

        /// <summary> List of document models. </summary>
        public IReadOnlyList<DocumentModelSummary> Value { get; }
        /// <summary> Link to the next page of document models. </summary>
        public Uri NextLink { get; }
    }
}
