// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxSkuInformation : IUtf8JsonSerializable, IJsonModel<DataBoxSkuInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxSkuInformation>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DataBoxSkuInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxSkuInformation)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
            if (options.Format != "W" && Optional.IsDefined(IsEnabled))
            {
                writer.WritePropertyName("enabled"u8);
                writer.WriteBooleanValue(IsEnabled.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsCollectionDefined(DataLocationToServiceLocationMap))
            {
                writer.WritePropertyName("dataLocationToServiceLocationMap"u8);
                writer.WriteStartArray();
                foreach (var item in DataLocationToServiceLocationMap)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Capacity))
            {
                writer.WritePropertyName("capacity"u8);
                writer.WriteObjectValue(Capacity);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(Costs))
            {
                writer.WritePropertyName("costs"u8);
                writer.WriteStartArray();
                foreach (var item in Costs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(ApiVersions))
            {
                writer.WritePropertyName("apiVersions"u8);
                writer.WriteStartArray();
                foreach (var item in ApiVersions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(DisabledReason))
            {
                writer.WritePropertyName("disabledReason"u8);
                writer.WriteStringValue(DisabledReason.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(DisabledReasonMessage))
            {
                writer.WritePropertyName("disabledReasonMessage"u8);
                writer.WriteStringValue(DisabledReasonMessage);
            }
            if (options.Format != "W" && Optional.IsDefined(RequiredFeature))
            {
                writer.WritePropertyName("requiredFeature"u8);
                writer.WriteStringValue(RequiredFeature);
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(CountriesWithinCommerceBoundary))
            {
                writer.WritePropertyName("countriesWithinCommerceBoundary"u8);
                writer.WriteStartArray();
                foreach (var item in CountriesWithinCommerceBoundary)
                {
                    writer.WriteStringValue(item);
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

        DataBoxSkuInformation IJsonModel<DataBoxSkuInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSkuInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxSkuInformation)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxSkuInformation(document.RootElement, options);
        }

        internal static DataBoxSkuInformation DeserializeDataBoxSkuInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DataBoxSku> sku = default;
            Optional<bool> enabled = default;
            Optional<IReadOnlyList<DataLocationToServiceLocationMap>> dataLocationToServiceLocationMap = default;
            Optional<DataBoxSkuCapacity> capacity = default;
            Optional<IReadOnlyList<DataBoxSkuCost>> costs = default;
            Optional<IReadOnlyList<string>> apiVersions = default;
            Optional<SkuDisabledReason> disabledReason = default;
            Optional<string> disabledReasonMessage = default;
            Optional<string> requiredFeature = default;
            Optional<IReadOnlyList<string>> countriesWithinCommerceBoundary = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = DataBoxSku.DeserializeDataBoxSku(property.Value, options);
                    continue;
                }
                if (property.NameEquals("enabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enabled = property.Value.GetBoolean();
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
                        if (property0.NameEquals("dataLocationToServiceLocationMap"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataLocationToServiceLocationMap> array = new List<DataLocationToServiceLocationMap>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(Models.DataLocationToServiceLocationMap.DeserializeDataLocationToServiceLocationMap(item, options));
                            }
                            dataLocationToServiceLocationMap = array;
                            continue;
                        }
                        if (property0.NameEquals("capacity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            capacity = DataBoxSkuCapacity.DeserializeDataBoxSkuCapacity(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("costs"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<DataBoxSkuCost> array = new List<DataBoxSkuCost>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataBoxSkuCost.DeserializeDataBoxSkuCost(item, options));
                            }
                            costs = array;
                            continue;
                        }
                        if (property0.NameEquals("apiVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            apiVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("disabledReason"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            disabledReason = property0.Value.GetString().ToSkuDisabledReason();
                            continue;
                        }
                        if (property0.NameEquals("disabledReasonMessage"u8))
                        {
                            disabledReasonMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requiredFeature"u8))
                        {
                            requiredFeature = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("countriesWithinCommerceBoundary"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            countriesWithinCommerceBoundary = array;
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
            return new DataBoxSkuInformation(sku.Value, Optional.ToNullable(enabled), Optional.ToList(dataLocationToServiceLocationMap), capacity.Value, Optional.ToList(costs), Optional.ToList(apiVersions), Optional.ToNullable(disabledReason), disabledReasonMessage.Value, requiredFeature.Value, Optional.ToList(countriesWithinCommerceBoundary), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DataBoxSkuInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxSkuInformation)} does not support '{options.Format}' format.");
            }
        }

        DataBoxSkuInformation IPersistableModel<DataBoxSkuInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxSkuInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxSkuInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxSkuInformation)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxSkuInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
