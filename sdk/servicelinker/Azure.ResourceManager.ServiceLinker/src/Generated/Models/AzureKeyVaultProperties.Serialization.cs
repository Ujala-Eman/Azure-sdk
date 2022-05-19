// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceLinker.Models
{
    public partial class AzureKeyVaultProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ConnectAsKubernetesCsiDriver))
            {
                if (ConnectAsKubernetesCsiDriver != null)
                {
                    writer.WritePropertyName("connectAsKubernetesCsiDriver");
                    writer.WriteBooleanValue(ConnectAsKubernetesCsiDriver.Value);
                }
                else
                {
                    writer.WriteNull("connectAsKubernetesCsiDriver");
                }
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(AzureResourceType.ToString());
            writer.WriteEndObject();
        }

        internal static AzureKeyVaultProperties DeserializeAzureKeyVaultProperties(JsonElement element)
        {
            Optional<bool?> connectAsKubernetesCsiDriver = default;
            AzureResourceType type = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("connectAsKubernetesCsiDriver"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        connectAsKubernetesCsiDriver = null;
                        continue;
                    }
                    connectAsKubernetesCsiDriver = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new AzureResourceType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureKeyVaultProperties(type, Optional.ToNullable(connectAsKubernetesCsiDriver));
        }
    }
}
