// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    public partial class ServiceImportConfigurationInfo : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(IntegrationDataStore))
            {
                writer.WritePropertyName("integrationDataStore");
                writer.WriteStringValue(IntegrationDataStore);
            }
            if (Optional.IsDefined(InitialImportMode))
            {
                writer.WritePropertyName("initialImportMode");
                writer.WriteBooleanValue(InitialImportMode.Value);
            }
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            writer.WriteEndObject();
        }

        internal static ServiceImportConfigurationInfo DeserializeServiceImportConfigurationInfo(JsonElement element)
        {
            Optional<string> integrationDataStore = default;
            Optional<bool> initialImportMode = default;
            Optional<bool> enabled = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("integrationDataStore"))
                {
                    integrationDataStore = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("initialImportMode"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    initialImportMode = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("enabled"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
                    continue;
                }
            }
            return new ServiceImportConfigurationInfo(integrationDataStore.Value, Optional.ToNullable(initialImportMode), Optional.ToNullable(enabled));
        }
    }
}
