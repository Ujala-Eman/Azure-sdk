// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ConnectivityIssue
    {
        internal static ConnectivityIssue DeserializeConnectivityIssue(JsonElement element)
        {
            Optional<Origin> origin = default;
            Optional<Severity> severity = default;
            Optional<IssueType> type = default;
            Optional<IReadOnlyList<IDictionary<string, string>>> context = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("origin"))
                {
                    origin = new Origin(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("severity"))
                {
                    severity = new Severity(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new IssueType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("context"))
                {
                    List<IDictionary<string, string>> array = new List<IDictionary<string, string>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property0 in item.EnumerateObject())
                            {
                                if (property0.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property0.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property0.Name, property0.Value.GetString());
                                }
                            }
                            array.Add(dictionary);
                        }
                    }
                    context = array;
                    continue;
                }
            }
            return new ConnectivityIssue(origin.HasValue ? origin.Value : (Origin?)null, severity.HasValue ? severity.Value : (Severity?)null, type.HasValue ? type.Value : (IssueType?)null, new ChangeTrackingList<IDictionary<string, string>>(context));
        }
    }
}
