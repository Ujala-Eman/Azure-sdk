// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The rule query details. </summary>
    public partial class QueryCheck
    {
        /// <summary> Initializes a new instance of QueryCheck. </summary>
        public QueryCheck()
        {
            ExpectedResult = new ChangeTrackingList<IList<string>>();
            ColumnNames = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of QueryCheck. </summary>
        /// <param name="query"> The rule query. </param>
        /// <param name="expectedResult"> Expected result. </param>
        /// <param name="columnNames"> Column names of expected result. </param>
        internal QueryCheck(string query, IList<IList<string>> expectedResult, IList<string> columnNames)
        {
            Query = query;
            ExpectedResult = expectedResult;
            ColumnNames = columnNames;
        }

        /// <summary> The rule query. </summary>
        public string Query { get; set; }
        /// <summary> Expected result. </summary>
        public IList<IList<string>> ExpectedResult { get; }
        /// <summary> Column names of expected result. </summary>
        public IList<string> ColumnNames { get; }
    }
}
