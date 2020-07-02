// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Graph.Rbac.Models
{
    public partial class ADGroup
    {
        internal static ADGroup DeserializeADGroup(JsonElement element)
        {
            Optional<string> displayName = default;
            Optional<bool> mailEnabled = default;
            Optional<string> mailNickname = default;
            Optional<bool> securityEnabled = default;
            Optional<string> mail = default;
            Optional<string> objectId = default;
            Optional<string> objectType = default;
            Optional<DateTimeOffset> deletionTimestamp = default;
            IReadOnlyDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("mailEnabled"))
                {
                    mailEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mailNickname"))
                {
                    mailNickname = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("securityEnabled"))
                {
                    securityEnabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("mail"))
                {
                    mail = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectId"))
                {
                    objectId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("objectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deletionTimestamp"))
                {
                    deletionTimestamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new ADGroup(objectId.HasValue ? objectId.Value : null, objectType.HasValue ? objectType.Value : null, deletionTimestamp.HasValue ? deletionTimestamp.Value : (DateTimeOffset?)null, additionalProperties, displayName.HasValue ? displayName.Value : null, mailEnabled.HasValue ? mailEnabled.Value : (bool?)null, mailNickname.HasValue ? mailNickname.Value : null, securityEnabled.HasValue ? securityEnabled.Value : (bool?)null, mail.HasValue ? mail.Value : null);
        }
    }
}
