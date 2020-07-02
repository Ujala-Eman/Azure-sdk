// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Storage.Models
{
    public partial class ManagementPolicySnapShot : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Delete))
            {
                writer.WritePropertyName("delete");
                writer.WriteObjectValue(Delete);
            }
            writer.WriteEndObject();
        }

        internal static ManagementPolicySnapShot DeserializeManagementPolicySnapShot(JsonElement element)
        {
            Optional<DateAfterCreation> delete = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("delete"))
                {
                    delete = DateAfterCreation.DeserializeDateAfterCreation(property.Value);
                    continue;
                }
            }
            return new ManagementPolicySnapShot(delete.HasValue ? delete.Value : null);
        }
    }
}
