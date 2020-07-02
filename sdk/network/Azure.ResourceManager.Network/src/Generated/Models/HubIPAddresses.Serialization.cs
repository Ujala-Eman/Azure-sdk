// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class HubIPAddresses : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(PublicIPAddresses))
            {
                writer.WritePropertyName("publicIPAddresses");
                writer.WriteStartArray();
                foreach (var item in PublicIPAddresses)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress");
                writer.WriteStringValue(PrivateIPAddress);
            }
            writer.WriteEndObject();
        }

        internal static HubIPAddresses DeserializeHubIPAddresses(JsonElement element)
        {
            Optional<IList<AzureFirewallPublicIPAddress>> publicIPAddresses = default;
            Optional<string> privateIPAddress = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicIPAddresses"))
                {
                    List<AzureFirewallPublicIPAddress> array = new List<AzureFirewallPublicIPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(AzureFirewallPublicIPAddress.DeserializeAzureFirewallPublicIPAddress(item));
                        }
                    }
                    publicIPAddresses = array;
                    continue;
                }
                if (property.NameEquals("privateIPAddress"))
                {
                    privateIPAddress = property.Value.GetString();
                    continue;
                }
            }
            return new HubIPAddresses(new ChangeTrackingList<AzureFirewallPublicIPAddress>(publicIPAddresses), privateIPAddress.HasValue ? privateIPAddress.Value : null);
        }
    }
}
