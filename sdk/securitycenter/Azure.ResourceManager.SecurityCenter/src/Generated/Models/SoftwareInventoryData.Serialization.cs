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
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class SoftwareInventoryData : IUtf8JsonSerializable, IJsonModel<SoftwareInventoryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SoftwareInventoryData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SoftwareInventoryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SoftwareInventoryData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SoftwareInventoryData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DeviceId))
            {
                writer.WritePropertyName("deviceId"u8);
                writer.WriteStringValue(DeviceId);
            }
            if (Optional.IsDefined(OSPlatform))
            {
                writer.WritePropertyName("osPlatform"u8);
                writer.WriteStringValue(OSPlatform);
            }
            if (Optional.IsDefined(Vendor))
            {
                writer.WritePropertyName("vendor"u8);
                writer.WriteStringValue(Vendor);
            }
            if (Optional.IsDefined(SoftwareName))
            {
                writer.WritePropertyName("softwareName"u8);
                writer.WriteStringValue(SoftwareName);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(EndOfSupportStatus))
            {
                writer.WritePropertyName("endOfSupportStatus"u8);
                writer.WriteStringValue(EndOfSupportStatus.Value.ToString());
            }
            if (Optional.IsDefined(EndOfSupportDate))
            {
                writer.WritePropertyName("endOfSupportDate"u8);
                writer.WriteStringValue(EndOfSupportDate);
            }
            if (Optional.IsDefined(NumberOfKnownVulnerabilities))
            {
                writer.WritePropertyName("numberOfKnownVulnerabilities"u8);
                writer.WriteNumberValue(NumberOfKnownVulnerabilities.Value);
            }
            if (Optional.IsDefined(FirstSeenOn))
            {
                writer.WritePropertyName("firstSeenAt"u8);
                writer.WriteStringValue(FirstSeenOn.Value, "O");
            }
            writer.WriteEndObject();
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

        SoftwareInventoryData IJsonModel<SoftwareInventoryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareInventoryData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSoftwareInventoryData(document.RootElement, options);
        }

        internal static SoftwareInventoryData DeserializeSoftwareInventoryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> deviceId = default;
            Optional<string> osPlatform = default;
            Optional<string> vendor = default;
            Optional<string> softwareName = default;
            Optional<string> version = default;
            Optional<EndOfSupportStatus> endOfSupportStatus = default;
            Optional<string> endOfSupportDate = default;
            Optional<int> numberOfKnownVulnerabilities = default;
            Optional<DateTimeOffset> firstSeenAt = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
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
                        if (property0.NameEquals("deviceId"u8))
                        {
                            deviceId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("osPlatform"u8))
                        {
                            osPlatform = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("vendor"u8))
                        {
                            vendor = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("softwareName"u8))
                        {
                            softwareName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            version = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endOfSupportStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endOfSupportStatus = new EndOfSupportStatus(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("endOfSupportDate"u8))
                        {
                            endOfSupportDate = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("numberOfKnownVulnerabilities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            numberOfKnownVulnerabilities = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("firstSeenAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            firstSeenAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SoftwareInventoryData(id, name, type, systemData.Value, deviceId.Value, osPlatform.Value, vendor.Value, softwareName.Value, version.Value, Optional.ToNullable(endOfSupportStatus), endOfSupportDate.Value, Optional.ToNullable(numberOfKnownVulnerabilities), Optional.ToNullable(firstSeenAt), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SoftwareInventoryData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareInventoryData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SoftwareInventoryData IPersistableModel<SoftwareInventoryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SoftwareInventoryData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSoftwareInventoryData(document.RootElement, options);
        }

        string IPersistableModel<SoftwareInventoryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
