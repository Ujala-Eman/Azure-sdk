// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class SiteDnsConfig : IUtf8JsonSerializable, IJsonModel<SiteDnsConfig>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteDnsConfig>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SiteDnsConfig>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteDnsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteDnsConfig)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(DnsServers))
            {
                writer.WritePropertyName("dnsServers"u8);
                writer.WriteStartArray();
                foreach (var item in DnsServers)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DnsAltServer))
            {
                writer.WritePropertyName("dnsAltServer"u8);
                writer.WriteStringValue(DnsAltServer);
            }
            if (Optional.IsDefined(DnsRetryAttemptTimeout))
            {
                writer.WritePropertyName("dnsRetryAttemptTimeout"u8);
                writer.WriteNumberValue(DnsRetryAttemptTimeout.Value);
            }
            if (Optional.IsDefined(DnsRetryAttemptCount))
            {
                writer.WritePropertyName("dnsRetryAttemptCount"u8);
                writer.WriteNumberValue(DnsRetryAttemptCount.Value);
            }
            if (Optional.IsDefined(DnsMaxCacheTimeout))
            {
                writer.WritePropertyName("dnsMaxCacheTimeout"u8);
                writer.WriteNumberValue(DnsMaxCacheTimeout.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(DnsLegacySortOrder))
            {
                writer.WritePropertyName("dnsLegacySortOrder"u8);
                writer.WriteBooleanValue(DnsLegacySortOrder.Value);
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

        SiteDnsConfig IJsonModel<SiteDnsConfig>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteDnsConfig>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteDnsConfig)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteDnsConfig(document.RootElement, options);
        }

        internal static SiteDnsConfig DeserializeSiteDnsConfig(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IList<string> dnsServers = default;
            string dnsAltServer = default;
            int? dnsRetryAttemptTimeout = default;
            int? dnsRetryAttemptCount = default;
            int? dnsMaxCacheTimeout = default;
            bool? dnsLegacySortOrder = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dnsServers"u8))
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
                    dnsServers = array;
                    continue;
                }
                if (property.NameEquals("dnsAltServer"u8))
                {
                    dnsAltServer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dnsRetryAttemptTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsRetryAttemptTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnsRetryAttemptCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsRetryAttemptCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnsMaxCacheTimeout"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsMaxCacheTimeout = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("dnsLegacySortOrder"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dnsLegacySortOrder = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SiteDnsConfig(
                dnsServers ?? new ChangeTrackingList<string>(),
                dnsAltServer,
                dnsRetryAttemptTimeout,
                dnsRetryAttemptCount,
                dnsMaxCacheTimeout,
                dnsLegacySortOrder,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsServers), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsServers: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(DnsServers))
                {
                    if (DnsServers.Any())
                    {
                        builder.Append("  dnsServers: ");
                        builder.AppendLine("[");
                        foreach (var item in DnsServers)
                        {
                            if (item == null)
                            {
                                builder.Append("null");
                                continue;
                            }
                            if (item.Contains(Environment.NewLine))
                            {
                                builder.AppendLine("    '''");
                                builder.AppendLine($"{item}'''");
                            }
                            else
                            {
                                builder.AppendLine($"    '{item}'");
                            }
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsAltServer), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsAltServer: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsAltServer))
                {
                    builder.Append("  dnsAltServer: ");
                    if (DnsAltServer.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DnsAltServer}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DnsAltServer}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsRetryAttemptTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsRetryAttemptTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsRetryAttemptTimeout))
                {
                    builder.Append("  dnsRetryAttemptTimeout: ");
                    builder.AppendLine($"{DnsRetryAttemptTimeout.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsRetryAttemptCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsRetryAttemptCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsRetryAttemptCount))
                {
                    builder.Append("  dnsRetryAttemptCount: ");
                    builder.AppendLine($"{DnsRetryAttemptCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsMaxCacheTimeout), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsMaxCacheTimeout: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsMaxCacheTimeout))
                {
                    builder.Append("  dnsMaxCacheTimeout: ");
                    builder.AppendLine($"{DnsMaxCacheTimeout.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DnsLegacySortOrder), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  dnsLegacySortOrder: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DnsLegacySortOrder))
                {
                    builder.Append("  dnsLegacySortOrder: ");
                    var boolValue = DnsLegacySortOrder.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<SiteDnsConfig>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteDnsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(SiteDnsConfig)} does not support writing '{options.Format}' format.");
            }
        }

        SiteDnsConfig IPersistableModel<SiteDnsConfig>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteDnsConfig>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteDnsConfig(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteDnsConfig)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteDnsConfig>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
