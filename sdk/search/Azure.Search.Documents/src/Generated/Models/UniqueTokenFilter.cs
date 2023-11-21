// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Filters out tokens with same text as the previous token. This token filter is implemented using Apache Lucene. </summary>
    public partial class UniqueTokenFilter : TokenFilter
    {
        /// <summary> Initializes a new instance of <see cref="UniqueTokenFilter"/>. </summary>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public UniqueTokenFilter(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            ODataType = "#Microsoft.Azure.Search.UniqueTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="UniqueTokenFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of token filter. </param>
        /// <param name="name"> The name of the token filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="onlyOnSamePosition"> A value indicating whether to remove duplicates only at the same position. Default is false. </param>
        internal UniqueTokenFilter(string oDataType, string name, IDictionary<string, BinaryData> serializedAdditionalRawData, bool? onlyOnSamePosition) : base(oDataType, name, serializedAdditionalRawData)
        {
            OnlyOnSamePosition = onlyOnSamePosition;
            ODataType = oDataType ?? "#Microsoft.Azure.Search.UniqueTokenFilter";
        }

        /// <summary> Initializes a new instance of <see cref="UniqueTokenFilter"/> for deserialization. </summary>
        internal UniqueTokenFilter()
        {
        }

        /// <summary> A value indicating whether to remove duplicates only at the same position. Default is false. </summary>
        public bool? OnlyOnSamePosition { get; set; }
    }
}
