// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.AI.Translation.Text
{
    /// <summary> Alignment information object. </summary>
    public partial class TranslatedTextAlignment
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="TranslatedTextAlignment"/>. </summary>
        /// <param name="proj">
        /// Maps input text to translated text. The alignment information is only provided when the request
        /// parameter includeAlignment is true. Alignment is returned as a string value of the following
        /// format: [[SourceTextStartIndex]:[SourceTextEndIndex]–[TgtTextStartIndex]:[TgtTextEndIndex]].
        /// The colon separates start and end index, the dash separates the languages, and space separates the words.
        /// One word may align with zero, one, or multiple words in the other language, and the aligned words may
        /// be non-contiguous. When no alignment information is available, the alignment element will be empty.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="proj"/> is null. </exception>
        internal TranslatedTextAlignment(string proj)
        {
            Argument.AssertNotNull(proj, nameof(proj));

            Proj = proj;
            _serializedAdditionalRawData = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of <see cref="TranslatedTextAlignment"/>. </summary>
        /// <param name="proj">
        /// Maps input text to translated text. The alignment information is only provided when the request
        /// parameter includeAlignment is true. Alignment is returned as a string value of the following
        /// format: [[SourceTextStartIndex]:[SourceTextEndIndex]–[TgtTextStartIndex]:[TgtTextEndIndex]].
        /// The colon separates start and end index, the dash separates the languages, and space separates the words.
        /// One word may align with zero, one, or multiple words in the other language, and the aligned words may
        /// be non-contiguous. When no alignment information is available, the alignment element will be empty.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TranslatedTextAlignment(string proj, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Proj = proj;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TranslatedTextAlignment"/> for deserialization. </summary>
        internal TranslatedTextAlignment()
        {
        }

        /// <summary>
        /// Maps input text to translated text. The alignment information is only provided when the request
        /// parameter includeAlignment is true. Alignment is returned as a string value of the following
        /// format: [[SourceTextStartIndex]:[SourceTextEndIndex]–[TgtTextStartIndex]:[TgtTextEndIndex]].
        /// The colon separates start and end index, the dash separates the languages, and space separates the words.
        /// One word may align with zero, one, or multiple words in the other language, and the aligned words may
        /// be non-contiguous. When no alignment information is available, the alignment element will be empty.
        /// </summary>
        public string Proj { get; }
    }
}
