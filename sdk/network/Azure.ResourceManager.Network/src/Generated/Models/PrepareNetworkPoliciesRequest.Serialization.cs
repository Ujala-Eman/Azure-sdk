// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class PrepareNetworkPoliciesRequest : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceName))
            {
                writer.WritePropertyName("serviceName");
                writer.WriteStringValue(ServiceName);
            }
            if (Optional.IsDefined(NetworkIntentPolicyConfigurations))
            {
                writer.WritePropertyName("networkIntentPolicyConfigurations");
                writer.WriteStartArray();
                foreach (var item in NetworkIntentPolicyConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }
    }
}
