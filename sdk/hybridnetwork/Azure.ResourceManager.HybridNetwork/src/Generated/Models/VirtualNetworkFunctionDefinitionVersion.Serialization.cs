// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class VirtualNetworkFunctionDefinitionVersion : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(NetworkFunctionTemplate))
            {
                writer.WritePropertyName("networkFunctionTemplate"u8);
                writer.WriteObjectValue(NetworkFunctionTemplate);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DeployParameters))
            {
                writer.WritePropertyName("deployParameters"u8);
                writer.WriteStringValue(DeployParameters);
            }
            writer.WritePropertyName("networkFunctionType"u8);
            writer.WriteStringValue(NetworkFunctionType.ToString());
            writer.WriteEndObject();
        }

        internal static VirtualNetworkFunctionDefinitionVersion DeserializeVirtualNetworkFunctionDefinitionVersion(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<VirtualNetworkFunctionTemplate> networkFunctionTemplate = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<VersionState> versionState = default;
            Optional<string> description = default;
            Optional<string> deployParameters = default;
            NetworkFunctionType networkFunctionType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("networkFunctionTemplate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkFunctionTemplate = VirtualNetworkFunctionTemplate.DeserializeVirtualNetworkFunctionTemplate(property.Value);
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("versionState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    versionState = new VersionState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("deployParameters"u8))
                {
                    deployParameters = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("networkFunctionType"u8))
                {
                    networkFunctionType = new NetworkFunctionType(property.Value.GetString());
                    continue;
                }
            }
            return new VirtualNetworkFunctionDefinitionVersion(Optional.ToNullable(provisioningState), Optional.ToNullable(versionState), description.Value, deployParameters.Value, networkFunctionType, networkFunctionTemplate.Value);
        }
    }
}
