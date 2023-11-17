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

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsMailClusterEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsMailClusterEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsMailClusterEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsMailClusterEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityInsightsMailClusterEntity>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityInsightsMailClusterEntity>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(AdditionalData))
                {
                    writer.WritePropertyName("additionalData"u8);
                    writer.WriteStartObject();
                    foreach (var item in AdditionalData)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FriendlyName))
                {
                    writer.WritePropertyName("friendlyName"u8);
                    writer.WriteStringValue(FriendlyName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(NetworkMessageIds))
                {
                    writer.WritePropertyName("networkMessageIds"u8);
                    writer.WriteStartArray();
                    foreach (var item in NetworkMessageIds)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CountByDeliveryStatus))
                {
                    writer.WritePropertyName("countByDeliveryStatus"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CountByDeliveryStatus);
#else
                    using (JsonDocument document = JsonDocument.Parse(CountByDeliveryStatus))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CountByThreatType))
                {
                    writer.WritePropertyName("countByThreatType"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CountByThreatType);
#else
                    using (JsonDocument document = JsonDocument.Parse(CountByThreatType))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CountByProtectionStatus))
                {
                    writer.WritePropertyName("countByProtectionStatus"u8);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(CountByProtectionStatus);
#else
                    using (JsonDocument document = JsonDocument.Parse(CountByProtectionStatus))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Threats))
                {
                    writer.WritePropertyName("threats"u8);
                    writer.WriteStartArray();
                    foreach (var item in Threats)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Query))
                {
                    writer.WritePropertyName("query"u8);
                    writer.WriteStringValue(Query);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(QueryOn))
                {
                    writer.WritePropertyName("queryTime"u8);
                    writer.WriteStringValue(QueryOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MailCount))
                {
                    writer.WritePropertyName("mailCount"u8);
                    writer.WriteNumberValue(MailCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsVolumeAnomaly))
                {
                    writer.WritePropertyName("isVolumeAnomaly"u8);
                    writer.WriteBooleanValue(IsVolumeAnomaly.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Source))
                {
                    writer.WritePropertyName("source"u8);
                    writer.WriteStringValue(Source);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterSourceIdentifier))
                {
                    writer.WritePropertyName("clusterSourceIdentifier"u8);
                    writer.WriteStringValue(ClusterSourceIdentifier);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterSourceType))
                {
                    writer.WritePropertyName("clusterSourceType"u8);
                    writer.WriteStringValue(ClusterSourceType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterQueryStartOn))
                {
                    writer.WritePropertyName("clusterQueryStartTime"u8);
                    writer.WriteStringValue(ClusterQueryStartOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterQueryEndOn))
                {
                    writer.WritePropertyName("clusterQueryEndTime"u8);
                    writer.WriteStringValue(ClusterQueryEndOn.Value, "O");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClusterGroup))
                {
                    writer.WritePropertyName("clusterGroup"u8);
                    writer.WriteStringValue(ClusterGroup);
                }
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

        SecurityInsightsMailClusterEntity IJsonModel<SecurityInsightsMailClusterEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsMailClusterEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsMailClusterEntity(document.RootElement, options);
        }

        internal static SecurityInsightsMailClusterEntity DeserializeSecurityInsightsMailClusterEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<IReadOnlyList<string>> networkMessageIds = default;
            Optional<BinaryData> countByDeliveryStatus = default;
            Optional<BinaryData> countByThreatType = default;
            Optional<BinaryData> countByProtectionStatus = default;
            Optional<IReadOnlyList<string>> threats = default;
            Optional<string> query = default;
            Optional<DateTimeOffset> queryTime = default;
            Optional<int> mailCount = default;
            Optional<bool> isVolumeAnomaly = default;
            Optional<string> source = default;
            Optional<string> clusterSourceIdentifier = default;
            Optional<string> clusterSourceType = default;
            Optional<DateTimeOffset> clusterQueryStartTime = default;
            Optional<DateTimeOffset> clusterQueryEndTime = default;
            Optional<string> clusterGroup = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("networkMessageIds"u8))
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
                            networkMessageIds = array;
                            continue;
                        }
                        if (property0.NameEquals("countByDeliveryStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countByDeliveryStatus = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("countByThreatType"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countByThreatType = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("countByProtectionStatus"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countByProtectionStatus = BinaryData.FromString(property0.Value.GetRawText());
                            continue;
                        }
                        if (property0.NameEquals("threats"u8))
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
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("query"u8))
                        {
                            query = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queryTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            queryTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("mailCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            mailCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("isVolumeAnomaly"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isVolumeAnomaly = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("source"u8))
                        {
                            source = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceIdentifier"u8))
                        {
                            clusterSourceIdentifier = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterSourceType"u8))
                        {
                            clusterSourceType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryStartTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterQueryStartTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterQueryEndTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clusterQueryEndTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("clusterGroup"u8))
                        {
                            clusterGroup = property0.Value.GetString();
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
            return new SecurityInsightsMailClusterEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, Optional.ToList(networkMessageIds), countByDeliveryStatus.Value, countByThreatType.Value, countByProtectionStatus.Value, Optional.ToList(threats), query.Value, Optional.ToNullable(queryTime), Optional.ToNullable(mailCount), Optional.ToNullable(isVolumeAnomaly), source.Value, clusterSourceIdentifier.Value, clusterSourceType.Value, Optional.ToNullable(clusterQueryStartTime), Optional.ToNullable(clusterQueryEndTime), clusterGroup.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsMailClusterEntity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsMailClusterEntity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsMailClusterEntity IPersistableModel<SecurityInsightsMailClusterEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsMailClusterEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsMailClusterEntity(document.RootElement, options);
        }

        string IPersistableModel<SecurityInsightsMailClusterEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
