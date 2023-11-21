// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Search.Documents.Indexes.Models;

namespace Azure.Search.Documents.Models
{
    /// <summary> The UnknownTokenFilter. </summary>
    internal partial class UnknownTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="UnknownTokenFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownTokenFilter(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(oDataType, name, serializedAdditionalRawData)
        {
            ODataType = oDataType ?? "Unknown";
        }

        /// <summary> Initializes a new instance of <see cref="UnknownTokenFilter"/> for deserialization. </summary>
        internal UnknownTokenFilter()
        {
        }
    }
}
