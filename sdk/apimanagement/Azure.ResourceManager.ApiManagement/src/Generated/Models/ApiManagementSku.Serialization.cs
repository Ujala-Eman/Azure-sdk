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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiManagementSku : IUtf8JsonSerializable, IJsonModel<ApiManagementSku>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiManagementSku>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApiManagementSku>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApiManagementSku>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApiManagementSku>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceType))
                {
                    writer.WritePropertyName("resourceType"u8);
                    writer.WriteStringValue(ResourceType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Name))
                {
                    writer.WritePropertyName("name"u8);
                    writer.WriteStringValue(Name);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Tier))
                {
                    writer.WritePropertyName("tier"u8);
                    writer.WriteStringValue(Tier);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Size))
                {
                    writer.WritePropertyName("size"u8);
                    writer.WriteStringValue(Size);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Family))
                {
                    writer.WritePropertyName("family"u8);
                    writer.WriteStringValue(Family);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Kind))
                {
                    writer.WritePropertyName("kind"u8);
                    writer.WriteStringValue(Kind);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Capacity))
                {
                    writer.WritePropertyName("capacity"u8);
                    writer.WriteObjectValue(Capacity);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Locations))
                {
                    writer.WritePropertyName("locations"u8);
                    writer.WriteStartArray();
                    foreach (var item in Locations)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(LocationInfo))
                {
                    writer.WritePropertyName("locationInfo"u8);
                    writer.WriteStartArray();
                    foreach (var item in LocationInfo)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(ApiVersions))
                {
                    writer.WritePropertyName("apiVersions"u8);
                    writer.WriteStartArray();
                    foreach (var item in ApiVersions)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Costs))
                {
                    writer.WritePropertyName("costs"u8);
                    writer.WriteStartArray();
                    foreach (var item in Costs)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Capabilities))
                {
                    writer.WritePropertyName("capabilities"u8);
                    writer.WriteStartArray();
                    foreach (var item in Capabilities)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Restrictions))
                {
                    writer.WritePropertyName("restrictions"u8);
                    writer.WriteStartArray();
                    foreach (var item in Restrictions)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
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

        ApiManagementSku IJsonModel<ApiManagementSku>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementSku)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiManagementSku(document.RootElement, options);
        }

        internal static ApiManagementSku DeserializeApiManagementSku(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> resourceType = default;
            Optional<string> name = default;
            Optional<string> tier = default;
            Optional<string> size = default;
            Optional<string> family = default;
            Optional<string> kind = default;
            Optional<ApiManagementSkuCapacity> capacity = default;
            Optional<IReadOnlyList<AzureLocation>> locations = default;
            Optional<IReadOnlyList<ApiManagementSkuLocationInfo>> locationInfo = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<IReadOnlyList<ApiManagementSkuCosts>> costs = default;
            Optional<IReadOnlyList<ApiManagementSkuCapabilities>> capabilities = default;
            Optional<IReadOnlyList<ApiManagementSkuRestrictions>> restrictions = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tier"u8))
                {
                    tier = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("size"u8))
                {
                    size = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("family"u8))
                {
                    family = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("capacity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    capacity = ApiManagementSkuCapacity.DeserializeApiManagementSkuCapacity(property.Value);
                    continue;
                }
                if (property.NameEquals("locations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureLocation> array = new List<AzureLocation>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new AzureLocation(item.GetString()));
                    }
                    locations = array;
                    continue;
                }
                if (property.NameEquals("locationInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementSkuLocationInfo> array = new List<ApiManagementSkuLocationInfo>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSkuLocationInfo.DeserializeApiManagementSkuLocationInfo(item));
                    }
                    locationInfo = array;
                    continue;
                }
                if (property.NameEquals("apiVersions"u8))
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
                    apiVersions = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementSkuCosts> array = new List<ApiManagementSkuCosts>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSkuCosts.DeserializeApiManagementSkuCosts(item));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("capabilities"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementSkuCapabilities> array = new List<ApiManagementSkuCapabilities>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSkuCapabilities.DeserializeApiManagementSkuCapabilities(item));
                    }
                    capabilities = array;
                    continue;
                }
                if (property.NameEquals("restrictions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApiManagementSkuRestrictions> array = new List<ApiManagementSkuRestrictions>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApiManagementSkuRestrictions.DeserializeApiManagementSkuRestrictions(item));
                    }
                    restrictions = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiManagementSku(resourceType.Value, name.Value, tier.Value, size.Value, family.Value, kind.Value, capacity.Value, Optional.ToList(locations), Optional.ToList(locationInfo), Optional.ToList(apiVersions), Optional.ToList(costs), Optional.ToList(capabilities), Optional.ToList(restrictions), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiManagementSku>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementSku)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApiManagementSku IPersistableModel<ApiManagementSku>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApiManagementSku)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApiManagementSku(document.RootElement, options);
        }

        string IPersistableModel<ApiManagementSku>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
