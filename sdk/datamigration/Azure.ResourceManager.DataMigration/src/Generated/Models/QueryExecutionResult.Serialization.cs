// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataMigration.Models
{
    public partial class QueryExecutionResult
    {
        internal static QueryExecutionResult DeserializeQueryExecutionResult(JsonElement element)
        {
            Optional<string> queryText = default;
            Optional<long> statementsInBatch = default;
            Optional<ExecutionStatistics> sourceResult = default;
            Optional<ExecutionStatistics> targetResult = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queryText"))
                {
                    queryText = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statementsInBatch"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    statementsInBatch = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("sourceResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    sourceResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value);
                    continue;
                }
                if (property.NameEquals("targetResult"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    targetResult = ExecutionStatistics.DeserializeExecutionStatistics(property.Value);
                    continue;
                }
            }
            return new QueryExecutionResult(queryText.Value, Optional.ToNullable(statementsInBatch), sourceResult.Value, targetResult.Value);
        }
    }
}
