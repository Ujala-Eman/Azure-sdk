// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ClusterNodeTypeDescription : IUtf8JsonSerializable, IJsonModel<ClusterNodeTypeDescription>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterNodeTypeDescription>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ClusterNodeTypeDescription>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ClusterNodeTypeDescription>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ClusterNodeTypeDescription>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            if (Optional.IsCollectionDefined(PlacementProperties))
            {
                writer.WritePropertyName("placementProperties"u8);
                writer.WriteStartObject();
                foreach (var item in PlacementProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(Capacities))
            {
                writer.WritePropertyName("capacities"u8);
                writer.WriteStartObject();
                foreach (var item in Capacities)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("clientConnectionEndpointPort"u8);
            writer.WriteNumberValue(ClientConnectionEndpointPort);
            writer.WritePropertyName("httpGatewayEndpointPort"u8);
            writer.WriteNumberValue(HttpGatewayEndpointPort);
            if (Optional.IsDefined(DurabilityLevel))
            {
                writer.WritePropertyName("durabilityLevel"u8);
                writer.WriteStringValue(DurabilityLevel.Value.ToString());
            }
            if (Optional.IsDefined(ApplicationPorts))
            {
                writer.WritePropertyName("applicationPorts"u8);
                writer.WriteObjectValue(ApplicationPorts);
            }
            if (Optional.IsDefined(EphemeralPorts))
            {
                writer.WritePropertyName("ephemeralPorts"u8);
                writer.WriteObjectValue(EphemeralPorts);
            }
            writer.WritePropertyName("isPrimary"u8);
            writer.WriteBooleanValue(IsPrimary);
            writer.WritePropertyName("vmInstanceCount"u8);
            writer.WriteNumberValue(VmInstanceCount);
            if (Optional.IsDefined(ReverseProxyEndpointPort))
            {
                writer.WritePropertyName("reverseProxyEndpointPort"u8);
                writer.WriteNumberValue(ReverseProxyEndpointPort.Value);
            }
            if (Optional.IsDefined(IsStateless))
            {
                writer.WritePropertyName("isStateless"u8);
                writer.WriteBooleanValue(IsStateless.Value);
            }
            if (Optional.IsDefined(IsMultipleAvailabilityZonesSupported))
            {
                writer.WritePropertyName("multipleAvailabilityZones"u8);
                writer.WriteBooleanValue(IsMultipleAvailabilityZonesSupported.Value);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        ClusterNodeTypeDescription IJsonModel<ClusterNodeTypeDescription>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterNodeTypeDescription)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterNodeTypeDescription(document.RootElement, options);
        }

        internal static ClusterNodeTypeDescription DeserializeClusterNodeTypeDescription(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            Optional<IDictionary<string, string>> placementProperties = default;
            Optional<IDictionary<string, string>> capacities = default;
            int clientConnectionEndpointPort = default;
            int httpGatewayEndpointPort = default;
            Optional<ClusterDurabilityLevel> durabilityLevel = default;
            Optional<ClusterEndpointRangeDescription> applicationPorts = default;
            Optional<ClusterEndpointRangeDescription> ephemeralPorts = default;
            bool isPrimary = default;
            int vmInstanceCount = default;
            Optional<int> reverseProxyEndpointPort = default;
            Optional<bool> isStateless = default;
            Optional<bool> multipleAvailabilityZones = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("placementProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    placementProperties = dictionary;
                    continue;
                }
                if (property.NameEquals("capacities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    capacities = dictionary;
                    continue;
                }
                if (property.NameEquals("clientConnectionEndpointPort"u8))
                {
                    clientConnectionEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("httpGatewayEndpointPort"u8))
                {
                    httpGatewayEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("durabilityLevel"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    durabilityLevel = new ClusterDurabilityLevel(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("applicationPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    applicationPorts = ClusterEndpointRangeDescription.DeserializeClusterEndpointRangeDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("ephemeralPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ephemeralPorts = ClusterEndpointRangeDescription.DeserializeClusterEndpointRangeDescription(property.Value);
                    continue;
                }
                if (property.NameEquals("isPrimary"u8))
                {
                    isPrimary = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("vmInstanceCount"u8))
                {
                    vmInstanceCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("reverseProxyEndpointPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reverseProxyEndpointPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("isStateless"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isStateless = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("multipleAvailabilityZones"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    multipleAvailabilityZones = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ClusterNodeTypeDescription(name, Optional.ToDictionary(placementProperties), Optional.ToDictionary(capacities), clientConnectionEndpointPort, httpGatewayEndpointPort, Optional.ToNullable(durabilityLevel), applicationPorts.Value, ephemeralPorts.Value, isPrimary, vmInstanceCount, Optional.ToNullable(reverseProxyEndpointPort), Optional.ToNullable(isStateless), Optional.ToNullable(multipleAvailabilityZones), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ClusterNodeTypeDescription>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterNodeTypeDescription)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ClusterNodeTypeDescription IPersistableModel<ClusterNodeTypeDescription>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ClusterNodeTypeDescription)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeClusterNodeTypeDescription(document.RootElement, options);
        }

        string IPersistableModel<ClusterNodeTypeDescription>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
