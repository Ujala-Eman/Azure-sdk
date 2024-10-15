// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedNetworkFabric.Models
{
    public partial class RouteTargetInformation : IUtf8JsonSerializable, IJsonModel<RouteTargetInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RouteTargetInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<RouteTargetInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteTargetInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouteTargetInformation)} does not support writing '{format}' format.");
            }

            if (Optional.IsCollectionDefined(ImportIPv4RouteTargets))
            {
                writer.WritePropertyName("importIpv4RouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ImportIPv4RouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ImportIPv6RouteTargets))
            {
                writer.WritePropertyName("importIpv6RouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ImportIPv6RouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExportIPv4RouteTargets))
            {
                writer.WritePropertyName("exportIpv4RouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ExportIPv4RouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ExportIPv6RouteTargets))
            {
                writer.WritePropertyName("exportIpv6RouteTargets"u8);
                writer.WriteStartArray();
                foreach (var item in ExportIPv6RouteTargets)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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
        }

        RouteTargetInformation IJsonModel<RouteTargetInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteTargetInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RouteTargetInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRouteTargetInformation(document.RootElement, options);
        }

        internal static RouteTargetInformation DeserializeRouteTargetInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> importIPv4RouteTargets = default;
            IList<string> importIPv6RouteTargets = default;
            IList<string> exportIPv4RouteTargets = default;
            IList<string> exportIPv6RouteTargets = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("importIpv4RouteTargets"u8))
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
                    importIPv4RouteTargets = array;
                    continue;
                }
                if (property.NameEquals("importIpv6RouteTargets"u8))
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
                    importIPv6RouteTargets = array;
                    continue;
                }
                if (property.NameEquals("exportIpv4RouteTargets"u8))
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
                    exportIPv4RouteTargets = array;
                    continue;
                }
                if (property.NameEquals("exportIpv6RouteTargets"u8))
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
                    exportIPv6RouteTargets = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new RouteTargetInformation(importIPv4RouteTargets ?? new ChangeTrackingList<string>(), importIPv6RouteTargets ?? new ChangeTrackingList<string>(), exportIPv4RouteTargets ?? new ChangeTrackingList<string>(), exportIPv6RouteTargets ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RouteTargetInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteTargetInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RouteTargetInformation)} does not support writing '{options.Format}' format.");
            }
        }

        RouteTargetInformation IPersistableModel<RouteTargetInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RouteTargetInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRouteTargetInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RouteTargetInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<RouteTargetInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
