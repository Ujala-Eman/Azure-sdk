// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class BlobRestoreStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Status != null)
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (FailureReason != null)
            {
                writer.WritePropertyName("failureReason");
                writer.WriteStringValue(FailureReason);
            }
            if (RestoreId != null)
            {
                writer.WritePropertyName("restoreId");
                writer.WriteStringValue(RestoreId);
            }
            if (Parameters != null)
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static BlobRestoreStatus DeserializeBlobRestoreStatus(JsonElement element)
        {
            BlobRestoreStatus result = new BlobRestoreStatus();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Status = new BlobRestoreProgressStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.FailureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.RestoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.Parameters = BlobRestoreParameters.DeserializeBlobRestoreParameters(property.Value);
                    continue;
                }
            }
            return result;
        }
    }
}
