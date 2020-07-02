// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.KeyVault.Administration.Models
{
    public partial class SelectiveKeyRestoreDetails
    {
        internal static SelectiveKeyRestoreDetails DeserializeSelectiveKeyRestoreDetails(JsonElement element)
        {
            Optional<string> status = default;
            Optional<string> statusDetails = default;
            Optional<KeyVaultServiceError> error = default;
            Optional<string> jobId = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<DateTimeOffset> endTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("status"))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusDetails"))
                {
                    statusDetails = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("error"))
                {
                    error = KeyVaultServiceError.DeserializeKeyVaultServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("jobId"))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("startTime"))
                {
                    startTime = property.Value.GetDateTimeOffset("U");
                    continue;
                }
                if (property.NameEquals("endTime"))
                {
                    endTime = property.Value.GetDateTimeOffset("U");
                    continue;
                }
            }
            return new SelectiveKeyRestoreDetails(status.HasValue ? status.Value : null, statusDetails.HasValue ? statusDetails.Value : null, error.HasValue ? error.Value : null, jobId.HasValue ? jobId.Value : null, startTime.HasValue ? startTime.Value : (DateTimeOffset?)null, endTime.HasValue ? endTime.Value : (DateTimeOffset?)null);
        }
    }
}
