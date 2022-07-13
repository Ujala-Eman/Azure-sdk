// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Redis.Models
{
    public partial class RedisRebootContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(RebootType))
            {
                writer.WritePropertyName("rebootType");
                writer.WriteStringValue(RebootType.Value.ToString());
            }
            if (Optional.IsDefined(ShardId))
            {
                writer.WritePropertyName("shardId");
                writer.WriteNumberValue(ShardId.Value);
            }
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports");
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteNumberValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
