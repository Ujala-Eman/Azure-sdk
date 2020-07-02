// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class CheckNameAvailabilityResult
    {
        internal static CheckNameAvailabilityResult DeserializeCheckNameAvailabilityResult(JsonElement element)
        {
            Optional<string> message = default;
            Optional<bool> nameAvailable = default;
            Optional<UnavailableReason> reason = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nameAvailable"))
                {
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"))
                {
                    reason = property.Value.GetString().ToUnavailableReason();
                    continue;
                }
            }
            return new CheckNameAvailabilityResult(message.HasValue ? message.Value : null, nameAvailable.HasValue ? nameAvailable.Value : (bool?)null, reason.HasValue ? reason.Value : (UnavailableReason?)null);
        }
    }
}
