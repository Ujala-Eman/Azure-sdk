// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ApplicationGatewaySslPredefinedPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Name))
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(CipherSuites))
            {
                writer.WritePropertyName("cipherSuites");
                writer.WriteStartArray();
                foreach (var item in CipherSuites)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(MinProtocolVersion))
            {
                writer.WritePropertyName("minProtocolVersion");
                writer.WriteStringValue(MinProtocolVersion.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ApplicationGatewaySslPredefinedPolicy DeserializeApplicationGatewaySslPredefinedPolicy(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<IList<ApplicationGatewaySslCipherSuite>> cipherSuites = default;
            Optional<ApplicationGatewaySslProtocol> minProtocolVersion = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("cipherSuites"))
                        {
                            List<ApplicationGatewaySslCipherSuite> array = new List<ApplicationGatewaySslCipherSuite>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new ApplicationGatewaySslCipherSuite(item.GetString()));
                            }
                            cipherSuites = array;
                            continue;
                        }
                        if (property0.NameEquals("minProtocolVersion"))
                        {
                            minProtocolVersion = new ApplicationGatewaySslProtocol(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ApplicationGatewaySslPredefinedPolicy(id.HasValue ? id.Value : null, name.HasValue ? name.Value : null, new ChangeTrackingList<ApplicationGatewaySslCipherSuite>(cipherSuites), minProtocolVersion.HasValue ? minProtocolVersion.Value : (ApplicationGatewaySslProtocol?)null);
        }
    }
}
