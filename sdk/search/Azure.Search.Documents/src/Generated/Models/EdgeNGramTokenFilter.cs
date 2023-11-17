// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Generates n-grams of the given size(s) starting from the front or the back of an input token. This token filter is implemented using Apache Lucene. </summary>
    public partial class EdgeNGramTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="EdgeNGramTokenFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="minGram"> The minimum n-gram length. Default is 1. Maximum is 300. Must be less than the value of maxGram. </param>
        /// <param name="maxGram"> The maximum n-gram length. Default is 2. Maximum is 300. </param>
        /// <param name="side"> Specifies which side of the input the n-gram should be generated from. Default is "front". </param>
        internal EdgeNGramTokenFilter(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, int? minGram, int? maxGram, EdgeNGramTokenFilterSide? side) : base(oDataType, name, serializedAdditionalRawData)
        {
            MinGram = minGram;
            MaxGram = maxGram;
            Side = side;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.EdgeNGramTokenFilterV2";
        }

        /// <summary> Initializes a new instance of <see cref="EdgeNGramTokenFilter"/> for deserialization. </summary>
        internal EdgeNGramTokenFilter()
        {
        }
    }
}
