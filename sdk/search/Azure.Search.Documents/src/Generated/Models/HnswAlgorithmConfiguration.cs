// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Contains configuration options specific to the HNSW approximate nearest neighbors algorithm used during indexing and querying. The HNSW algorithm offers a tunable trade-off between search speed and accuracy. </summary>
    public partial class HnswAlgorithmConfiguration : VectorSearchAlgorithmConfiguration
    {
        /// <summary> Initializes a new instance of <see cref="HnswAlgorithmConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        public HnswAlgorithmConfiguration(string name) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Kind = VectorSearchAlgorithmKind.Hnsw;
        }

        /// <summary> Initializes a new instance of <see cref="HnswAlgorithmConfiguration"/>. </summary>
        /// <param name="name"> The name to associate with this particular configuration. </param>
        /// <param name="kind"> The name of the kind of algorithm being configured for use with vector search. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="parameters"> Contains the parameters specific to HNSW algorithm. </param>
        internal HnswAlgorithmConfiguration(string name, VectorSearchAlgorithmKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, HnswParameters parameters) : base(name, kind, serializedAdditionalRawData)
        {
            Parameters = parameters;
            Kind = kind;
        }

        /// <summary> Initializes a new instance of <see cref="HnswAlgorithmConfiguration"/> for deserialization. </summary>
        internal HnswAlgorithmConfiguration()
        {
        }

        /// <summary> Contains the parameters specific to HNSW algorithm. </summary>
        public HnswParameters Parameters { get; set; }
    }
}
