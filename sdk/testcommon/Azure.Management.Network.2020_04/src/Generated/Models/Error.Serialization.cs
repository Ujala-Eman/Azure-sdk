// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    internal partial class Error
    {
        internal static Error DeserializeError(JsonElement element)
        {
            Optional<string> code = default;
            Optional<string> message = default;
            Optional<string> target = default;
            Optional<IReadOnlyList<ErrorDetails>> details = default;
            Optional<string> innerError = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"))
                {
                    target = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"))
                {
                    List<ErrorDetails> array = new List<ErrorDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ErrorDetails.DeserializeErrorDetails(item));
                        }
                    }
                    details = array;
                    continue;
                }
                if (property.NameEquals("innerError"))
                {
                    innerError = property.Value.GetString();
                    continue;
                }
            }
            return new Error(code.HasValue ? code.Value : null, message.HasValue ? message.Value : null, target.HasValue ? target.Value : null, new ChangeTrackingList<ErrorDetails>(details), innerError.HasValue ? innerError.Value : null);
        }
    }
}
