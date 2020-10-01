// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The indexes for the path. </summary>
    public partial class Indexes
    {
        /// <summary> Initializes a new instance of Indexes. </summary>
        public Indexes()
        {
        }

        /// <summary> Initializes a new instance of Indexes. </summary>
        /// <param name="dataType"> The datatype for which the indexing behavior is applied to. </param>
        /// <param name="precision"> The precision of the index. -1 is maximum precision. </param>
        /// <param name="kind"> Indicates the type of index. </param>
        internal Indexes(DataType? dataType, int? precision, IndexKind? kind)
        {
            DataType = dataType;
            Precision = precision;
            Kind = kind;
        }

        /// <summary> The datatype for which the indexing behavior is applied to. </summary>
        public DataType? DataType { get; set; }
        /// <summary> The precision of the index. -1 is maximum precision. </summary>
        public int? Precision { get; set; }
        /// <summary> Indicates the type of index. </summary>
        public IndexKind? Kind { get; set; }
    }
}
