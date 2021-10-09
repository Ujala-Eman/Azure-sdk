// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Search.Documents.Indexes.Models
{
    public partial class IndexerExecutionResult
    {
        internal static IndexerExecutionResult DeserializeIndexerExecutionResult(JsonElement element)
        {
            IndexerExecutionStatus status = default;
            Optional<IndexerExecutionStatusDetail?> statusDetail = default;
            Optional<IndexerState> currentState = default;
            Optional<string> errorMessage = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset?> endTime = default;
            IReadOnlyList<SearchIndexerError> errors = default;
            IReadOnlyList<SearchIndexerWarning> warnings = default;
            int itemsProcessed = default;
            int itemsFailed = default;
            Optional<string> initialTrackingState = default;
            Optional<string> finalTrackingState = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString().ToIndexerExecutionStatus();
                    continue;
                }
                if (property.NameEquals("statusDetail"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        statusDetail = null;
                        continue;
                    }
                    statusDetail = new IndexerExecutionStatusDetail(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("currentState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currentState = IndexerState.DeserializeIndexerState(property.Value);
                    continue;
                }
                if (property.NameEquals("errorMessage"))
                {
                    errorMessage = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    startTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        endTime = null;
                        continue;
                    }
                    endTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("errors"))
                {
                    List<SearchIndexerError> array = new List<SearchIndexerError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndexerError.DeserializeSearchIndexerError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    List<SearchIndexerWarning> array = new List<SearchIndexerWarning>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SearchIndexerWarning.DeserializeSearchIndexerWarning(item));
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("itemsProcessed"))
                {
                    itemsProcessed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("itemsFailed"))
                {
                    itemsFailed = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("initialTrackingState"))
                {
                    initialTrackingState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("finalTrackingState"))
                {
                    finalTrackingState = property.Value.GetString();
                    continue;
                }
            }
            return new IndexerExecutionResult(status, Optional.ToNullable(statusDetail), currentState.Value, errorMessage.Value, Optional.ToNullable(startTime), Optional.ToNullable(endTime), errors, warnings, itemsProcessed, itemsFailed, initialTrackingState.Value, finalTrackingState.Value);
        }
    }
}
