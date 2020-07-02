// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.KeyVault.Models
{
    public partial class CheckNameAvailabilityResult
    {
        internal static CheckNameAvailabilityResult DeserializeCheckNameAvailabilityResult(JsonElement element)
        {
            Optional<bool> nameAvailable = default;
            Optional<Reason> reason = default;
            Optional<string> message = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"))
                {
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString().ToReason();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
            }
            return new CheckNameAvailabilityResult(nameAvailable.HasValue ? nameAvailable.Value : (bool?)null, reason.HasValue ? reason.Value : (Reason?)null, message.HasValue ? message.Value : null);
        }
    }
}
