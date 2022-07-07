// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StreamAnalytics.Models
{
    public partial class QueryCompilationResult
    {
        internal static QueryCompilationResult DeserializeQueryCompilationResult(JsonElement element)
        {
            Optional<IReadOnlyList<QueryCompilationError>> errors = default;
            Optional<IReadOnlyList<string>> warnings = default;
            Optional<IReadOnlyList<string>> inputs = default;
            Optional<IReadOnlyList<string>> outputs = default;
            Optional<IReadOnlyList<string>> functions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("errors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<QueryCompilationError> array = new List<QueryCompilationError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(QueryCompilationError.DeserializeQueryCompilationError(item));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("warnings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    warnings = array;
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    inputs = array;
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("functions"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    functions = array;
                    continue;
                }
            }
            return new QueryCompilationResult(Optional.ToList(errors), Optional.ToList(warnings), Optional.ToList(inputs), Optional.ToList(outputs), Optional.ToList(functions));
        }
    }
}
