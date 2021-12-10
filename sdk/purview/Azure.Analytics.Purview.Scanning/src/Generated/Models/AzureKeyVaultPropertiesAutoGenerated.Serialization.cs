// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    public partial class AzureKeyVaultPropertiesAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(BaseUrl))
            {
                writer.WritePropertyName("baseUrl");
                writer.WriteStringValue(BaseUrl);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WriteEndObject();
        }

        internal static AzureKeyVaultPropertiesAutoGenerated DeserializeAzureKeyVaultPropertiesAutoGenerated(JsonElement element)
        {
            Optional<string> baseUrl = default;
            Optional<string> description = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("baseUrl"))
                {
                    baseUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
            }
            return new AzureKeyVaultPropertiesAutoGenerated(baseUrl.Value, description.Value);
        }
    }
}
