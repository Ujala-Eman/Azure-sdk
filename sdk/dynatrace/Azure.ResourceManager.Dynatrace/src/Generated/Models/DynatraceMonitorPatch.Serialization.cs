// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Dynatrace.Models
{
    public partial class DynatraceMonitorPatch : IUtf8JsonSerializable, IJsonModel<DynatraceMonitorPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DynatraceMonitorPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DynatraceMonitorPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorPatch)} does not support '{format}' format.");
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
            if (MonitoringStatus.HasValue)
            {
                writer.WritePropertyName("monitoringStatus"u8);
                writer.WriteStringValue(MonitoringStatus.Value.ToString());
            }
            if (MarketplaceSubscriptionStatus.HasValue)
            {
                writer.WritePropertyName("marketplaceSubscriptionStatus"u8);
                writer.WriteStringValue(MarketplaceSubscriptionStatus.Value.ToString());
            }
            if (DynatraceEnvironmentProperties != null)
            {
                writer.WritePropertyName("dynatraceEnvironmentProperties"u8);
                writer.WriteObjectValue(DynatraceEnvironmentProperties);
            }
            if (UserInfo != null)
            {
                writer.WritePropertyName("userInfo"u8);
                writer.WriteObjectValue(UserInfo);
            }
            if (PlanData != null)
            {
                writer.WritePropertyName("planData"u8);
                writer.WriteObjectValue(PlanData);
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

        DynatraceMonitorPatch IJsonModel<DynatraceMonitorPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DynatraceMonitorPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDynatraceMonitorPatch(document.RootElement, options);
        }

        internal static DynatraceMonitorPatch DeserializeDynatraceMonitorPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IDictionary<string, string> tags = default;
            DynatraceMonitoringStatus? monitoringStatus = default;
            DynatraceMonitorMarketplaceSubscriptionStatus? marketplaceSubscriptionStatus = default;
            DynatraceEnvironmentProperties dynatraceEnvironmentProperties = default;
            DynatraceMonitorUserInfo userInfo = default;
            DynatraceBillingPlanInfo planData = default;
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
                if (property.NameEquals("monitoringStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    monitoringStatus = new DynatraceMonitoringStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("marketplaceSubscriptionStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    marketplaceSubscriptionStatus = new DynatraceMonitorMarketplaceSubscriptionStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dynatraceEnvironmentProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dynatraceEnvironmentProperties = DynatraceEnvironmentProperties.DeserializeDynatraceEnvironmentProperties(property.Value, options);
                    continue;
                }
                if (property.NameEquals("userInfo"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    userInfo = DynatraceMonitorUserInfo.DeserializeDynatraceMonitorUserInfo(property.Value, options);
                    continue;
                }
                if (property.NameEquals("planData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    planData = DynatraceBillingPlanInfo.DeserializeDynatraceBillingPlanInfo(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DynatraceMonitorPatch(
                tags ?? new ChangeTrackingDictionary<string, string>(),
                monitoringStatus,
                marketplaceSubscriptionStatus,
                dynatraceEnvironmentProperties,
                userInfo,
                planData,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DynatraceMonitorPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorPatch)} does not support '{options.Format}' format.");
            }
        }

        DynatraceMonitorPatch IPersistableModel<DynatraceMonitorPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DynatraceMonitorPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDynatraceMonitorPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DynatraceMonitorPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DynatraceMonitorPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
