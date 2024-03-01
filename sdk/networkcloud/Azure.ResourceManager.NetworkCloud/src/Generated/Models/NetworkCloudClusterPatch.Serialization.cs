// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.NetworkCloud;

namespace Azure.ResourceManager.NetworkCloud.Models
{
    public partial class NetworkCloudClusterPatch : IUtf8JsonSerializable, IJsonModel<NetworkCloudClusterPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkCloudClusterPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkCloudClusterPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudClusterPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (!(Tags is ChangeTrackingDictionary<string, string> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("tags"u8);
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (AggregatorOrSingleRackDefinition != null)
            {
                writer.WritePropertyName("aggregatorOrSingleRackDefinition"u8);
                writer.WriteObjectValue(AggregatorOrSingleRackDefinition);
            }
            if (ClusterLocation != null)
            {
                writer.WritePropertyName("clusterLocation"u8);
                writer.WriteStringValue(ClusterLocation);
            }
            if (ClusterServicePrincipal != null)
            {
                writer.WritePropertyName("clusterServicePrincipal"u8);
                writer.WriteObjectValue(ClusterServicePrincipal);
            }
            if (ComputeDeploymentThreshold != null)
            {
                writer.WritePropertyName("computeDeploymentThreshold"u8);
                writer.WriteObjectValue(ComputeDeploymentThreshold);
            }
            if (!(ComputeRackDefinitions is ChangeTrackingList<NetworkCloudRackDefinition> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("computeRackDefinitions"u8);
                writer.WriteStartArray();
                foreach (var item in ComputeRackDefinitions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        NetworkCloudClusterPatch IJsonModel<NetworkCloudClusterPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NetworkCloudClusterPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkCloudClusterPatch(document.RootElement, options);
        }

        internal static NetworkCloudClusterPatch DeserializeNetworkCloudClusterPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            NetworkCloudRackDefinition aggregatorOrSingleRackDefinition = default;
            string clusterLocation = default;
            ServicePrincipalInformation clusterServicePrincipal = default;
            ValidationThreshold computeDeploymentThreshold = default;
            IList<NetworkCloudRackDefinition> computeRackDefinitions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("tags"u8))
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
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("aggregatorOrSingleRackDefinition"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            aggregatorOrSingleRackDefinition = NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("clusterLocation"u8))
                        {
                            clusterLocation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterServicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterServicePrincipal = ServicePrincipalInformation.DeserializeServicePrincipalInformation(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("computeDeploymentThreshold"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            computeDeploymentThreshold = ValidationThreshold.DeserializeValidationThreshold(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("computeRackDefinitions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<NetworkCloudRackDefinition> array = new List<NetworkCloudRackDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(NetworkCloudRackDefinition.DeserializeNetworkCloudRackDefinition(item, options));
                            }
                            computeRackDefinitions = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkCloudClusterPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                aggregatorOrSingleRackDefinition,
                clusterLocation,
                clusterServicePrincipal,
                computeDeploymentThreshold,
                computeRackDefinitions ?? new ChangeTrackingList<NetworkCloudRackDefinition>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<NetworkCloudClusterPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        NetworkCloudClusterPatch IPersistableModel<NetworkCloudClusterPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NetworkCloudClusterPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNetworkCloudClusterPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NetworkCloudClusterPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<NetworkCloudClusterPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
