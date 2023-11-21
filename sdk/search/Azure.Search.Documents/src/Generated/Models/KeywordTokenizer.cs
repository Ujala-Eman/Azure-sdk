// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Emits the entire input as a single token. This tokenizer is implemented using Apache Lucene. </summary>
    public partial class KeywordTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of <see cref="KeywordTokenizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="maxTokenLength"> The maximum token length. Default is 256. Tokens longer than the maximum length are split. The maximum token length that can be used is 300 characters. </param>
        internal KeywordTokenizer(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, int? maxTokenLength) : base(oDataType, name, serializedAdditionalRawData)
        {
            MaxTokenLength = maxTokenLength;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.KeywordTokenizerV2";
        }

        /// <summary> Initializes a new instance of <see cref="KeywordTokenizer"/> for deserialization. </summary>
        internal KeywordTokenizer()
        {
        }
    }
}
