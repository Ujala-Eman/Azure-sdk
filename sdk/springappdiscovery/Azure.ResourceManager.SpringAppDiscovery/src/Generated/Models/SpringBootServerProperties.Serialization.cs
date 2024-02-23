// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SpringAppDiscovery.Models
{
    public partial class SpringBootServerProperties : IUtf8JsonSerializable, IJsonModel<SpringBootServerProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SpringBootServerProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SpringBootServerProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootServerProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Port.HasValue)
            {
                writer.WritePropertyName("port"u8);
                writer.WriteNumberValue(Port.Value);
            }
            writer.WritePropertyName("server"u8);
            writer.WriteStringValue(Server);
            if (!(FqdnAndIPAddressList is ChangeTrackingList<IPAddress> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("fqdnAndIpAddressList"u8);
                writer.WriteStartArray();
                foreach (var item in FqdnAndIPAddressList)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (MachineArmId != null)
            {
                writer.WritePropertyName("machineArmId"u8);
                writer.WriteStringValue(MachineArmId);
            }
            if (TotalApps.HasValue)
            {
                writer.WritePropertyName("totalApps"u8);
                writer.WriteNumberValue(TotalApps.Value);
            }
            if (SpringBootApps.HasValue)
            {
                writer.WritePropertyName("springBootApps"u8);
                writer.WriteNumberValue(SpringBootApps.Value);
            }
            if (!(Errors is ChangeTrackingList<SpringBootSiteError> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("errors"u8);
                writer.WriteStartArray();
                foreach (var item in Errors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (ProvisioningState.HasValue)
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
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

        SpringBootServerProperties IJsonModel<SpringBootServerProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootServerProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SpringBootServerProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSpringBootServerProperties(document.RootElement, options);
        }

        internal static SpringBootServerProperties DeserializeSpringBootServerProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> port = default;
            string server = default;
            Optional<IList<IPAddress>> fqdnAndIPAddressList = default;
            Optional<ResourceIdentifier> machineArmId = default;
            Optional<int> totalApps = default;
            Optional<int> springBootApps = default;
            Optional<IList<SpringBootSiteError>> errors = default;
            Optional<SpringAppDiscoveryProvisioningState> provisioningState = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("port"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    port = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("server"u8))
                {
                    server = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fqdnAndIpAddressList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<IPAddress> array = new List<IPAddress>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(IPAddress.Parse(item.GetString()));
                        }
                    }
                    fqdnAndIPAddressList = array;
                    continue;
                }
                if (property.NameEquals("machineArmId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    machineArmId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("totalApps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    totalApps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("springBootApps"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    springBootApps = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SpringBootSiteError> array = new List<SpringBootSiteError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(SpringBootSiteError.DeserializeSpringBootSiteError(item, options));
                    }
                    errors = array;
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new SpringAppDiscoveryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SpringBootServerProperties(Optional.ToNullable(port), server, Optional.ToList(fqdnAndIPAddressList), machineArmId.Value, Optional.ToNullable(totalApps), Optional.ToNullable(springBootApps), Optional.ToList(errors), Optional.ToNullable(provisioningState), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SpringBootServerProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SpringBootServerProperties)} does not support '{options.Format}' format.");
            }
        }

        SpringBootServerProperties IPersistableModel<SpringBootServerProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SpringBootServerProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSpringBootServerProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SpringBootServerProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SpringBootServerProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
