// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Network.Models
{
    public partial class ExpressRouteCrossConnection : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Etag != null)
            {
                writer.WritePropertyName("etag");
                writer.WriteStringValue(Etag);
            }
            if (Id != null)
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            if (Name != null)
            {
                writer.WritePropertyName("name");
                writer.WriteStringValue(Name);
            }
            if (Type != null)
            {
                writer.WritePropertyName("type");
                writer.WriteStringValue(Type);
            }
            if (Location != null)
            {
                writer.WritePropertyName("location");
                writer.WriteStringValue(Location);
            }
            if (Tags != null)
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (PrimaryAzurePort != null)
            {
                writer.WritePropertyName("primaryAzurePort");
                writer.WriteStringValue(PrimaryAzurePort);
            }
            if (SecondaryAzurePort != null)
            {
                writer.WritePropertyName("secondaryAzurePort");
                writer.WriteStringValue(SecondaryAzurePort);
            }
            if (STag != null)
            {
                writer.WritePropertyName("sTag");
                writer.WriteNumberValue(STag.Value);
            }
            if (PeeringLocation != null)
            {
                writer.WritePropertyName("peeringLocation");
                writer.WriteStringValue(PeeringLocation);
            }
            if (BandwidthInMbps != null)
            {
                writer.WritePropertyName("bandwidthInMbps");
                writer.WriteNumberValue(BandwidthInMbps.Value);
            }
            if (ExpressRouteCircuit != null)
            {
                writer.WritePropertyName("expressRouteCircuit");
                writer.WriteObjectValue(ExpressRouteCircuit);
            }
            if (ServiceProviderProvisioningState != null)
            {
                writer.WritePropertyName("serviceProviderProvisioningState");
                writer.WriteStringValue(ServiceProviderProvisioningState.Value.ToString());
            }
            if (ServiceProviderNotes != null)
            {
                writer.WritePropertyName("serviceProviderNotes");
                writer.WriteStringValue(ServiceProviderNotes);
            }
            if (ProvisioningState != null)
            {
                writer.WritePropertyName("provisioningState");
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Peerings != null)
            {
                writer.WritePropertyName("peerings");
                writer.WriteStartArray();
                foreach (var item in Peerings)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static ExpressRouteCrossConnection DeserializeExpressRouteCrossConnection(JsonElement element)
        {
            string etag = default;
            string id = default;
            string name = default;
            string type = default;
            string location = default;
            IDictionary<string, string> tags = default;
            string primaryAzurePort = default;
            string secondaryAzurePort = default;
            int? sTag = default;
            string peeringLocation = default;
            int? bandwidthInMbps = default;
            ExpressRouteCircuitReference expressRouteCircuit = default;
            ServiceProviderProvisioningState? serviceProviderProvisioningState = default;
            string serviceProviderNotes = default;
            ProvisioningState? provisioningState = default;
            IList<ExpressRouteCrossConnectionPeering> peerings = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("primaryAzurePort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            primaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("secondaryAzurePort"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            secondaryAzurePort = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sTag"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sTag = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("peeringLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            peeringLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("bandwidthInMbps"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            bandwidthInMbps = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("expressRouteCircuit"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            expressRouteCircuit = ExpressRouteCircuitReference.DeserializeExpressRouteCircuitReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderProvisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderProvisioningState = new ServiceProviderProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serviceProviderNotes"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            serviceProviderNotes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("peerings"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ExpressRouteCrossConnectionPeering> array = new List<ExpressRouteCrossConnectionPeering>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ExpressRouteCrossConnectionPeering.DeserializeExpressRouteCrossConnectionPeering(item));
                                }
                            }
                            peerings = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ExpressRouteCrossConnection(id, name, type, location, tags, etag, primaryAzurePort, secondaryAzurePort, sTag, peeringLocation, bandwidthInMbps, expressRouteCircuit, serviceProviderProvisioningState, serviceProviderNotes, provisioningState, peerings);
        }
    }
}
