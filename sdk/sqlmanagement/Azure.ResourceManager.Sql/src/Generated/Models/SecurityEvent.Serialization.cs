// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager;

namespace SqlManagementClient.Models
{
    public partial class SecurityEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static SecurityEvent DeserializeSecurityEvent(JsonElement element)
        {
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<DateTimeOffset> eventTime = default;
            Optional<SecurityEventType> securityEventType = default;
            Optional<string> subscription = default;
            Optional<string> server = default;
            Optional<string> database = default;
            Optional<string> clientIp = default;
            Optional<string> applicationName = default;
            Optional<string> principalName = default;
            Optional<SecurityEventSqlInjectionAdditionalProperties> securityEventSqlInjectionAdditionalProperties = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("eventTime"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            eventTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("securityEventType"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityEventType = property0.Value.GetString().ToSecurityEventType();
                            continue;
                        }
                        if (property0.NameEquals("subscription"))
                        {
                            subscription = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("server"))
                        {
                            server = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("database"))
                        {
                            database = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clientIp"))
                        {
                            clientIp = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("applicationName"))
                        {
                            applicationName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("principalName"))
                        {
                            principalName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("securityEventSqlInjectionAdditionalProperties"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            securityEventSqlInjectionAdditionalProperties = SecurityEventSqlInjectionAdditionalProperties.DeserializeSecurityEventSqlInjectionAdditionalProperties(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new SecurityEvent(id, name, type, Optional.ToNullable(eventTime), Optional.ToNullable(securityEventType), subscription.Value, server.Value, database.Value, clientIp.Value, applicationName.Value, principalName.Value, securityEventSqlInjectionAdditionalProperties.Value);
        }
    }
}
