// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    /// <summary> The SparkStatementCollection. </summary>
    public partial class SparkStatementCollection
    {
        /// <summary> Initializes a new instance of SparkStatementCollection. </summary>
        /// <param name="total"> . </param>
        internal SparkStatementCollection(int total)
        {
            Total = total;
            Statements = new ChangeTrackingList<SparkStatement>();
        }

        /// <summary> Initializes a new instance of SparkStatementCollection. </summary>
        /// <param name="total"> . </param>
        /// <param name="statements"> . </param>
        internal SparkStatementCollection(int total, IReadOnlyList<SparkStatement> statements)
        {
            Total = total;
            Statements = statements;
        }

        public int Total { get; }
        public IReadOnlyList<SparkStatement> Statements { get; }
    }
}
