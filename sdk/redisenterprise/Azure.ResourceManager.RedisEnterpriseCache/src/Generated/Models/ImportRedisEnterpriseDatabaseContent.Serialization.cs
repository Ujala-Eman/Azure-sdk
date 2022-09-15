// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RedisEnterpriseCache.Models
{
    public partial class ImportRedisEnterpriseDatabaseContent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("sasUris");
            writer.WriteStartArray();
            foreach (var item in SasUris)
            {
                writer.WriteStringValue(item.AbsoluteUri);
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }
    }
}
