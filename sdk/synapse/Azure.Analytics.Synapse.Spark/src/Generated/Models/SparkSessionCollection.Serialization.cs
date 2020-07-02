// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Spark.Models
{
    public partial class SparkSessionCollection
    {
        internal static SparkSessionCollection DeserializeSparkSessionCollection(JsonElement element)
        {
            int @from = default;
            int total = default;
            Optional<IReadOnlyList<SparkSession>> sessions = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("from"))
                {
                    @from = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("total"))
                {
                    total = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sessions"))
                {
                    List<SparkSession> array = new List<SparkSession>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(SparkSession.DeserializeSparkSession(item));
                        }
                    }
                    sessions = array;
                    continue;
                }
            }
            return new SparkSessionCollection(@from, total, new ChangeTrackingList<SparkSession>(sessions));
        }
    }
}
