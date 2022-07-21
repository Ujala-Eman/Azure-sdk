// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> A list of job executions. </summary>
    internal partial class JobExecutionListResult
    {
        /// <summary> Initializes a new instance of JobExecutionListResult. </summary>
        internal JobExecutionListResult()
        {
            Value = new ChangeTrackingList<SqlServerJobExecutionData>();
        }

        /// <summary> Initializes a new instance of JobExecutionListResult. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        internal JobExecutionListResult(IReadOnlyList<SqlServerJobExecutionData> value, string nextLink)
        {
            Value = value;
            NextLink = nextLink;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SqlServerJobExecutionData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
