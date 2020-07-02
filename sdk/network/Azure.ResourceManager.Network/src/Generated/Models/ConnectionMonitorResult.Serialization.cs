// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class ConnectionMonitorResult
    {
        internal static ConnectionMonitorResult DeserializeConnectionMonitorResult(JsonElement element)
        {
            Optional<string> name = default;
            Optional<string> id = default;
            Optional<string> etag = default;
            Optional<string> type = default;
            Optional<string> location = default;
            Optional<IReadOnlyDictionary<string, string>> tags = default;
            Optional<ConnectionMonitorSource> source = default;
            Optional<ConnectionMonitorDestination> destination = default;
            Optional<bool> autoStart = default;
            Optional<int> monitoringIntervalInSeconds = default;
            Optional<IReadOnlyList<ConnectionMonitorEndpoint>> endpoints = default;
            Optional<IReadOnlyList<ConnectionMonitorTestConfiguration>> testConfigurations = default;
            Optional<IReadOnlyList<ConnectionMonitorTestGroup>> testGroups = default;
            Optional<IReadOnlyList<ConnectionMonitorOutput>> outputs = default;
            Optional<string> notes = default;
            Optional<ProvisioningState> provisioningState = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> monitoringStatus = default;
            Optional<ConnectionMonitorType> connectionMonitorType = default;
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
                if (property.NameEquals("etag"))
                {
                    etag = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
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
                        if (property0.NameEquals("source"))
                        {
                            source = ConnectionMonitorSource.DeserializeConnectionMonitorSource(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("destination"))
                        {
                            destination = ConnectionMonitorDestination.DeserializeConnectionMonitorDestination(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("autoStart"))
                        {
                            autoStart = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("monitoringIntervalInSeconds"))
                        {
                            monitoringIntervalInSeconds = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("endpoints"))
                        {
                            List<ConnectionMonitorEndpoint> array = new List<ConnectionMonitorEndpoint>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ConnectionMonitorEndpoint.DeserializeConnectionMonitorEndpoint(item));
                                }
                            }
                            endpoints = array;
                            continue;
                        }
                        if (property0.NameEquals("testConfigurations"))
                        {
                            List<ConnectionMonitorTestConfiguration> array = new List<ConnectionMonitorTestConfiguration>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ConnectionMonitorTestConfiguration.DeserializeConnectionMonitorTestConfiguration(item));
                                }
                            }
                            testConfigurations = array;
                            continue;
                        }
                        if (property0.NameEquals("testGroups"))
                        {
                            List<ConnectionMonitorTestGroup> array = new List<ConnectionMonitorTestGroup>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ConnectionMonitorTestGroup.DeserializeConnectionMonitorTestGroup(item));
                                }
                            }
                            testGroups = array;
                            continue;
                        }
                        if (property0.NameEquals("outputs"))
                        {
                            List<ConnectionMonitorOutput> array = new List<ConnectionMonitorOutput>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(ConnectionMonitorOutput.DeserializeConnectionMonitorOutput(item));
                                }
                            }
                            outputs = array;
                            continue;
                        }
                        if (property0.NameEquals("notes"))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provisioningState"))
                        {
                            provisioningState = new ProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("startTime"))
                        {
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("monitoringStatus"))
                        {
                            monitoringStatus = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("connectionMonitorType"))
                        {
                            connectionMonitorType = new ConnectionMonitorType(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new ConnectionMonitorResult(name.HasValue ? name.Value : null, id.HasValue ? id.Value : null, etag.HasValue ? etag.Value : null, type.HasValue ? type.Value : null, location.HasValue ? location.Value : null, new ChangeTrackingDictionary<string, string>(tags), source.HasValue ? source.Value : null, destination.HasValue ? destination.Value : null, autoStart.HasValue ? autoStart.Value : (bool?)null, monitoringIntervalInSeconds.HasValue ? monitoringIntervalInSeconds.Value : (int?)null, new ChangeTrackingList<ConnectionMonitorEndpoint>(endpoints), new ChangeTrackingList<ConnectionMonitorTestConfiguration>(testConfigurations), new ChangeTrackingList<ConnectionMonitorTestGroup>(testGroups), new ChangeTrackingList<ConnectionMonitorOutput>(outputs), notes.HasValue ? notes.Value : null, provisioningState.HasValue ? provisioningState.Value : (ProvisioningState?)null, startTime.HasValue ? startTime.Value : (DateTimeOffset?)null, monitoringStatus.HasValue ? monitoringStatus.Value : null, connectionMonitorType.HasValue ? connectionMonitorType.Value : (ConnectionMonitorType?)null);
        }
    }
}
