// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> Results for query analysis comparison between the source and target. </summary>
    public partial class QueryAnalysisValidationResult
    {
        /// <summary> Initializes a new instance of QueryAnalysisValidationResult. </summary>
        internal QueryAnalysisValidationResult()
        {
        }

        /// <summary> Initializes a new instance of QueryAnalysisValidationResult. </summary>
        /// <param name="queryResults"> List of queries executed and it's execution results in source and target. </param>
        /// <param name="validationErrors"> Errors that are part of the execution. </param>
        internal QueryAnalysisValidationResult(QueryExecutionResult queryResults, ValidationError validationErrors)
        {
            QueryResults = queryResults;
            ValidationErrors = validationErrors;
        }

        /// <summary> List of queries executed and it's execution results in source and target. </summary>
        public QueryExecutionResult QueryResults { get; }
        /// <summary> Errors that are part of the execution. </summary>
        public ValidationError ValidationErrors { get; }
    }
}
