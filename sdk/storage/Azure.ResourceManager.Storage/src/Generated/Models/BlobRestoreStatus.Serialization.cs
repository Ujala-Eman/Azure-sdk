// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class BlobRestoreStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status");
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(FailureReason))
            {
                writer.WritePropertyName("failureReason");
                writer.WriteStringValue(FailureReason);
            }
            if (Optional.IsDefined(RestoreId))
            {
                writer.WritePropertyName("restoreId");
                writer.WriteStringValue(RestoreId);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            writer.WriteEndObject();
        }

        internal static BlobRestoreStatus DeserializeBlobRestoreStatus(JsonElement element)
        {
            Optional<BlobRestoreProgressStatus> status = default;
            Optional<string> failureReason = default;
            Optional<string> restoreId = default;
            Optional<BlobRestoreParameters> parameters = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = new BlobRestoreProgressStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failureReason"))
                {
                    failureReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreId"))
                {
                    restoreId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    parameters = BlobRestoreParameters.DeserializeBlobRestoreParameters(property.Value);
                    continue;
                }
            }
            return new BlobRestoreStatus(status.HasValue ? status.Value : (BlobRestoreProgressStatus?)null, failureReason.HasValue ? failureReason.Value : null, restoreId.HasValue ? restoreId.Value : null, parameters.HasValue ? parameters.Value : null);
        }
    }
}
