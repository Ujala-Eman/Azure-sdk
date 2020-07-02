// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Resources.Models
{
    public partial class ParametersLink : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("uri");
            writer.WriteStringValue(Uri);
            if (Optional.IsDefined(ContentVersion))
            {
                writer.WritePropertyName("contentVersion");
                writer.WriteStringValue(ContentVersion);
            }
            writer.WriteEndObject();
        }

        internal static ParametersLink DeserializeParametersLink(JsonElement element)
        {
            string uri = default;
            Optional<string> contentVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("uri"))
                {
                    uri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentVersion"))
                {
                    contentVersion = property.Value.GetString();
                    continue;
                }
            }
            return new ParametersLink(uri, contentVersion.HasValue ? contentVersion.Value : null);
        }
    }
}
