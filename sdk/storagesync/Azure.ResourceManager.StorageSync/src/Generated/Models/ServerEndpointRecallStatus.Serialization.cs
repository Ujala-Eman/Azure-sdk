// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class ServerEndpointRecallStatus
    {
        internal static ServerEndpointRecallStatus DeserializeServerEndpointRecallStatus(JsonElement element)
        {
            Optional<DateTimeOffset> lastUpdatedTimestamp = default;
            Optional<long> totalRecallErrorsCount = default;
            Optional<IReadOnlyList<ServerEndpointRecallError>> recallErrors = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("lastUpdatedTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("totalRecallErrorsCount"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    totalRecallErrorsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recallErrors"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ServerEndpointRecallError> array = new List<ServerEndpointRecallError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ServerEndpointRecallError.DeserializeServerEndpointRecallError(item));
                    }
                    recallErrors = array;
                    continue;
                }
            }
            return new ServerEndpointRecallStatus(Optional.ToNullable(lastUpdatedTimestamp), Optional.ToNullable(totalRecallErrorsCount), Optional.ToList(recallErrors));
        }
    }
}
