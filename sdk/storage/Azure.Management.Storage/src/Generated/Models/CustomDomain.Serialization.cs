// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Storage.Models
{
    public partial class CustomDomain : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (UseSubDomainName != null)
            {
                writer.WritePropertyName("useSubDomainName");
                writer.WriteBooleanValue(UseSubDomainName.Value);
            }
            writer.WriteEndObject();
        }

        internal static CustomDomain DeserializeCustomDomain(JsonElement element)
        {
            CustomDomain result = new CustomDomain();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    result.Name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("useSubDomainName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    result.UseSubDomainName = property.Value.GetBoolean();
                    continue;
                }
            }
            return result;
        }
    }
}
