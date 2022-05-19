// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Applications.Containers.Models
{
    public partial class LogAnalyticsConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CustomerId))
            {
                writer.WritePropertyName("customerId");
                writer.WriteStringValue(CustomerId);
            }
            if (Optional.IsDefined(SharedKey))
            {
                writer.WritePropertyName("sharedKey");
                writer.WriteStringValue(SharedKey);
            }
            writer.WriteEndObject();
        }

        internal static LogAnalyticsConfiguration DeserializeLogAnalyticsConfiguration(JsonElement element)
        {
            Optional<string> customerId = default;
            Optional<string> sharedKey = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("customerId"))
                {
                    customerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sharedKey"))
                {
                    sharedKey = property.Value.GetString();
                    continue;
                }
            }
            return new LogAnalyticsConfiguration(customerId.Value, sharedKey.Value);
        }
    }
}
