// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class BatchEndpoint : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(AuthMode))
            {
                writer.WritePropertyName("authMode");
                writer.WriteStringValue(AuthMode.Value.ToString());
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(Keys))
            {
                writer.WritePropertyName("keys");
                writer.WriteObjectValue(Keys);
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Traffic))
            {
                writer.WritePropertyName("traffic");
                writer.WriteStartObject();
                foreach (var item in Traffic)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteNumberValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static BatchEndpoint DeserializeBatchEndpoint(JsonElement element)
        {
            Optional<EndpointAuthMode> authMode = default;
            Optional<string> description = default;
            Optional<EndpointAuthKeys> keys = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<string> scoringUri = default;
            Optional<string> swaggerUri = default;
            Optional<IDictionary<string, int>> traffic = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    authMode = new EndpointAuthMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("keys"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    keys = EndpointAuthKeys.DeserializeEndpointAuthKeys(property.Value);
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("scoringUri"))
                {
                    scoringUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("swaggerUri"))
                {
                    swaggerUri = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("traffic"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    traffic = dictionary;
                    continue;
                }
            }
            return new BatchEndpoint(Optional.ToNullable(authMode), description.Value, keys.Value, Optional.ToDictionary(properties), scoringUri.Value, swaggerUri.Value, Optional.ToDictionary(traffic));
        }
    }
}
