// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(RedisScalingCompletedEventDataConverter))]
    public partial class RedisScalingCompletedEventData
    {
        internal static RedisScalingCompletedEventData DeserializeRedisScalingCompletedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            DateTimeOffset? timestamp = default;
            string name = default;
            string status = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("timestamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
            }
            return new RedisScalingCompletedEventData(timestamp, name, status);
        }

        internal partial class RedisScalingCompletedEventDataConverter : JsonConverter<RedisScalingCompletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, RedisScalingCompletedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override RedisScalingCompletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRedisScalingCompletedEventData(document.RootElement);
            }
        }
    }
}
