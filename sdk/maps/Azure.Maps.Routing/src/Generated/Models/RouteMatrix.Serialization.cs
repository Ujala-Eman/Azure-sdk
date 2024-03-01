// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;

namespace Azure.Maps.Routing.Models
{
    public partial class RouteMatrix
    {
        internal static RouteMatrix DeserializeRouteMatrix(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int? statusCode = default;
            RouteMatrixResultResponse response = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("statusCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusCode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("response"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    response = RouteMatrixResultResponse.DeserializeRouteMatrixResultResponse(property.Value);
                    continue;
                }
            }
            return new RouteMatrix(statusCode, response);
        }
    }
}
