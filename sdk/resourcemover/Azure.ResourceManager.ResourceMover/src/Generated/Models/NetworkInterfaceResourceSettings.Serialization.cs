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

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class NetworkInterfaceResourceSettings : IUtf8JsonSerializable, IJsonModel<NetworkInterfaceResourceSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NetworkInterfaceResourceSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NetworkInterfaceResourceSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NetworkInterfaceResourceSettings>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NetworkInterfaceResourceSettings>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Tags))
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
            if (Optional.IsCollectionDefined(IPConfigurations))
            {
                writer.WritePropertyName("ipConfigurations"u8);
                writer.WriteStartArray();
                foreach (var item in IPConfigurations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(EnableAcceleratedNetworking))
            {
                if (EnableAcceleratedNetworking != null)
                {
                    writer.WritePropertyName("enableAcceleratedNetworking"u8);
                    writer.WriteBooleanValue(EnableAcceleratedNetworking.Value);
                }
                else
                {
                    writer.WriteNull("enableAcceleratedNetworking");
                }
            }
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
            if (Optional.IsDefined(TargetResourceName))
            {
                writer.WritePropertyName("targetResourceName"u8);
                writer.WriteStringValue(TargetResourceName);
            }
            if (Optional.IsDefined(TargetResourceGroupName))
            {
                writer.WritePropertyName("targetResourceGroupName"u8);
                writer.WriteStringValue(TargetResourceGroupName);
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

        NetworkInterfaceResourceSettings IJsonModel<NetworkInterfaceResourceSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNetworkInterfaceResourceSettings(document.RootElement, options);
        }

        internal static NetworkInterfaceResourceSettings DeserializeNetworkInterfaceResourceSettings(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, string>> tags = default;
            Optional<IList<NicIPConfigurationResourceSettings>> ipConfigurations = default;
            Optional<bool?> enableAcceleratedNetworking = default;
            string resourceType = default;
            Optional<string> targetResourceName = default;
            Optional<string> targetResourceGroupName = default;
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
                if (property.NameEquals("ipConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NicIPConfigurationResourceSettings> array = new List<NicIPConfigurationResourceSettings>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NicIPConfigurationResourceSettings.DeserializeNicIPConfigurationResourceSettings(item));
                    }
                    ipConfigurations = array;
                    continue;
                }
                if (property.NameEquals("enableAcceleratedNetworking"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        enableAcceleratedNetworking = null;
                        continue;
                    }
                    enableAcceleratedNetworking = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceName"u8))
                {
                    targetResourceName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("targetResourceGroupName"u8))
                {
                    targetResourceGroupName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NetworkInterfaceResourceSettings(resourceType, targetResourceName.Value, targetResourceGroupName.Value, serializedAdditionalRawData, Optional.ToDictionary(tags), Optional.ToList(ipConfigurations), Optional.ToNullable(enableAcceleratedNetworking));
        }

        BinaryData IPersistableModel<NetworkInterfaceResourceSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NetworkInterfaceResourceSettings IPersistableModel<NetworkInterfaceResourceSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NetworkInterfaceResourceSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNetworkInterfaceResourceSettings(document.RootElement, options);
        }

        string IPersistableModel<NetworkInterfaceResourceSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
