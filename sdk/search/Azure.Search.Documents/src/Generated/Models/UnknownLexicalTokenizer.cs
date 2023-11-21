// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownLexicalTokenizer. </summary>
    internal partial class UnknownLexicalTokenizer : LexicalTokenizer
    {
        /// <summary> Initializes a new instance of <see cref="UnknownLexicalTokenizer"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of tokenizer. </param>
        /// <param name="name"> The name of the tokenizer. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownLexicalTokenizer(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(oDataType, name, serializedAdditionalRawData)
        {
            ODataType = oDataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownLexicalTokenizer"/> for deserialization. </summary>
        internal UnknownLexicalTokenizer()
        {
        }
    }
}
