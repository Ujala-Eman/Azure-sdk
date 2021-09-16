// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(KeyVaultKeyNewVersionCreatedEventDataConverter))]
    public partial class KeyVaultKeyNewVersionCreatedEventData
    {
        internal static KeyVaultKeyNewVersionCreatedEventData DeserializeKeyVaultKeyNewVersionCreatedEventData(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> vaultName = default;
            Optional<string> objectType = default;
            Optional<string> objectName = default;
            Optional<string> version = default;
            Optional<float> nBF = default;
            Optional<float> eXP = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("Id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("VaultName"))
                {
                    vaultName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectType"))
                {
                    objectType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ObjectName"))
                {
                    objectName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("Version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("NBF"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    nBF = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("EXP"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    eXP = property.Value.GetSingle();
                    continue;
                }
            }
            return new KeyVaultKeyNewVersionCreatedEventData(id.Value, vaultName.Value, objectType.Value, objectName.Value, version.Value, Optional.ToNullable(nBF), Optional.ToNullable(eXP));
        }

        internal partial class KeyVaultKeyNewVersionCreatedEventDataConverter : JsonConverter<KeyVaultKeyNewVersionCreatedEventData>
        {
            public override void Write(Utf8JsonWriter writer, KeyVaultKeyNewVersionCreatedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override KeyVaultKeyNewVersionCreatedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeKeyVaultKeyNewVersionCreatedEventData(document.RootElement);
            }
        }
    }
}
