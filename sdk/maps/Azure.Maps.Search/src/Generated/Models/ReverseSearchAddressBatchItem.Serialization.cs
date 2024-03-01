// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Search.Models
{
    internal partial class ReverseSearchAddressBatchItem
    {
        internal static ReverseSearchAddressBatchItem DeserializeReverseSearchAddressBatchItem(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ReverseSearchAddressBatchItemResponse response = default;
            int? statusCode = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = ReverseSearchAddressBatchItemResponse.DeserializeReverseSearchAddressBatchItemResponse(property.Value);
                    continue;
                }
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
            }
            return new ReverseSearchAddressBatchItem(statusCode, response);
        }
    }
}
