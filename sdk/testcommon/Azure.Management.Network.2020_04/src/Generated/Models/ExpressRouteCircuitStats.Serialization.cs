// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCircuitStats : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PrimarybytesIn))
            {
                writer.WritePropertyName("primarybytesIn");
                writer.WriteNumberValue(PrimarybytesIn.Value);
            }
            if (Optional.IsDefined(PrimarybytesOut))
            {
                writer.WritePropertyName("primarybytesOut");
                writer.WriteNumberValue(PrimarybytesOut.Value);
            }
            if (Optional.IsDefined(SecondarybytesIn))
            {
                writer.WritePropertyName("secondarybytesIn");
                writer.WriteNumberValue(SecondarybytesIn.Value);
            }
            if (Optional.IsDefined(SecondarybytesOut))
            {
                writer.WritePropertyName("secondarybytesOut");
                writer.WriteNumberValue(SecondarybytesOut.Value);
            }
            writer.WriteEndObject();
        }

        internal static ExpressRouteCircuitStats DeserializeExpressRouteCircuitStats(JsonElement element)
        {
            Optional<long> primarybytesIn = default;
            Optional<long> primarybytesOut = default;
            Optional<long> secondarybytesIn = default;
            Optional<long> secondarybytesOut = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("primarybytesIn"))
                {
                    primarybytesIn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("primarybytesOut"))
                {
                    primarybytesOut = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("secondarybytesIn"))
                {
                    secondarybytesIn = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("secondarybytesOut"))
                {
                    secondarybytesOut = property.Value.GetInt64();
                    continue;
                }
            }
            return new ExpressRouteCircuitStats(primarybytesIn.HasValue ? primarybytesIn.Value : (long?)null, primarybytesOut.HasValue ? primarybytesOut.Value : (long?)null, secondarybytesIn.HasValue ? secondarybytesIn.Value : (long?)null, secondarybytesOut.HasValue ? secondarybytesOut.Value : (long?)null);
        }
    }
}
