// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MobileNetwork.Models
{
    public partial class MobileNetworkServiceDataFlowTemplate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("templateName"u8);
            writer.WriteStringValue(TemplateName);
            writer.WritePropertyName("direction"u8);
            writer.WriteStringValue(Direction.ToString());
            writer.WritePropertyName("protocol"u8);
            writer.WriteStartArray();
            foreach (var item in Protocol)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            writer.WritePropertyName("remoteIpList"u8);
            writer.WriteStartArray();
            foreach (var item in RemoteIPList)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsCollectionDefined(Ports))
            {
                writer.WritePropertyName("ports"u8);
                writer.WriteStartArray();
                foreach (var item in Ports)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static MobileNetworkServiceDataFlowTemplate DeserializeMobileNetworkServiceDataFlowTemplate(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string templateName = default;
            MobileNetworkSdfDirectionS direction = default;
            IList<string> protocol = default;
            IList<string> remoteIPList = default;
            Optional<IList<string>> ports = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("templateName"u8))
                {
                    templateName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("direction"u8))
                {
                    direction = new MobileNetworkSdfDirectionS(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("protocol"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    protocol = array;
                    continue;
                }
                if (property.NameEquals("remoteIpList"u8))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    remoteIPList = array;
                    continue;
                }
                if (property.NameEquals("ports"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ports = array;
                    continue;
                }
            }
            return new MobileNetworkServiceDataFlowTemplate(templateName, direction, protocol, remoteIPList, Optional.ToList(ports));
        }
    }
}
