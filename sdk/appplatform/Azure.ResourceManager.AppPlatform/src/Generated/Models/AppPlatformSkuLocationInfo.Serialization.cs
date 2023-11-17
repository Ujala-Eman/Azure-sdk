// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformSkuLocationInfo : IUtf8JsonSerializable, IJsonModel<AppPlatformSkuLocationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformSkuLocationInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppPlatformSkuLocationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppPlatformSkuLocationInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppPlatformSkuLocationInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Optional.IsCollectionDefined(Zones))
            {
                writer.WritePropertyName("zones"u8);
                writer.WriteStartArray();
                foreach (var item in Zones)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ZoneDetails))
            {
                writer.WritePropertyName("zoneDetails"u8);
                writer.WriteStartArray();
                foreach (var item in ZoneDetails)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        AppPlatformSkuLocationInfo IJsonModel<AppPlatformSkuLocationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuLocationInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformSkuLocationInfo(document.RootElement, options);
        }

        internal static AppPlatformSkuLocationInfo DeserializeAppPlatformSkuLocationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<IReadOnlyList<string>> zones = default;
            Optional<IReadOnlyList<AppPlatformSkuZoneDetails>> zoneDetails = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("zones"u8))
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
                    zones = array;
                    continue;
                }
                if (property.NameEquals("zoneDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformSkuZoneDetails> array = new List<AppPlatformSkuZoneDetails>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformSkuZoneDetails.DeserializeAppPlatformSkuZoneDetails(item));
                    }
                    zoneDetails = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformSkuLocationInfo(Optional.ToNullable(location), Optional.ToList(zones), Optional.ToList(zoneDetails), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformSkuLocationInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuLocationInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppPlatformSkuLocationInfo IPersistableModel<AppPlatformSkuLocationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformSkuLocationInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppPlatformSkuLocationInfo(document.RootElement, options);
        }

        string IPersistableModel<AppPlatformSkuLocationInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
