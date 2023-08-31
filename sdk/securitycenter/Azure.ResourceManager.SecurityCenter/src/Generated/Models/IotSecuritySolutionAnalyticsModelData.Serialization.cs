// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    public partial class IotSecuritySolutionAnalyticsModelData : IUtf8JsonSerializable, IModelJsonSerializable<IotSecuritySolutionAnalyticsModelData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<IotSecuritySolutionAnalyticsModelData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<IotSecuritySolutionAnalyticsModelData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(TopAlertedDevices))
            {
                writer.WritePropertyName("topAlertedDevices"u8);
                writer.WriteStartArray();
                foreach (var item in TopAlertedDevices)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IotSecurityAlertedDevice>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MostPrevalentDeviceAlerts))
            {
                writer.WritePropertyName("mostPrevalentDeviceAlerts"u8);
                writer.WriteStartArray();
                foreach (var item in MostPrevalentDeviceAlerts)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IotSecurityDeviceAlert>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MostPrevalentDeviceRecommendations))
            {
                writer.WritePropertyName("mostPrevalentDeviceRecommendations"u8);
                writer.WriteStartArray();
                foreach (var item in MostPrevalentDeviceRecommendations)
                {
                    if (item is null)
                    {
                        writer.WriteNullValue();
                    }
                    else
                    {
                        ((IModelJsonSerializable<IotSecurityDeviceRecommendation>)item).Serialize(writer, options);
                    }
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static IotSecuritySolutionAnalyticsModelData DeserializeIotSecuritySolutionAnalyticsModelData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IotSeverityMetrics> metrics = default;
            Optional<long> unhealthyDeviceCount = default;
            Optional<IReadOnlyList<IotSecuritySolutionAnalyticsModelDevicesMetrics>> devicesMetrics = default;
            Optional<IList<IotSecurityAlertedDevice>> topAlertedDevices = default;
            Optional<IList<IotSecurityDeviceAlert>> mostPrevalentDeviceAlerts = default;
            Optional<IList<IotSecurityDeviceRecommendation>> mostPrevalentDeviceRecommendations = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metrics = IotSeverityMetrics.DeserializeIotSeverityMetrics(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("unhealthyDeviceCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            unhealthyDeviceCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("devicesMetrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecuritySolutionAnalyticsModelDevicesMetrics> array = new List<IotSecuritySolutionAnalyticsModelDevicesMetrics>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecuritySolutionAnalyticsModelDevicesMetrics.DeserializeIotSecuritySolutionAnalyticsModelDevicesMetrics(item));
                            }
                            devicesMetrics = array;
                            continue;
                        }
                        if (property0.NameEquals("topAlertedDevices"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityAlertedDevice> array = new List<IotSecurityAlertedDevice>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityAlertedDevice.DeserializeIotSecurityAlertedDevice(item));
                            }
                            topAlertedDevices = array;
                            continue;
                        }
                        if (property0.NameEquals("mostPrevalentDeviceAlerts"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityDeviceAlert> array = new List<IotSecurityDeviceAlert>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityDeviceAlert.DeserializeIotSecurityDeviceAlert(item));
                            }
                            mostPrevalentDeviceAlerts = array;
                            continue;
                        }
                        if (property0.NameEquals("mostPrevalentDeviceRecommendations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<IotSecurityDeviceRecommendation> array = new List<IotSecurityDeviceRecommendation>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(IotSecurityDeviceRecommendation.DeserializeIotSecurityDeviceRecommendation(item));
                            }
                            mostPrevalentDeviceRecommendations = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new IotSecuritySolutionAnalyticsModelData(id, name, type, systemData.Value, metrics.Value, Optional.ToNullable(unhealthyDeviceCount), Optional.ToList(devicesMetrics), Optional.ToList(topAlertedDevices), Optional.ToList(mostPrevalentDeviceAlerts), Optional.ToList(mostPrevalentDeviceRecommendations), rawData);
        }

        IotSecuritySolutionAnalyticsModelData IModelJsonSerializable<IotSecuritySolutionAnalyticsModelData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeIotSecuritySolutionAnalyticsModelData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<IotSecuritySolutionAnalyticsModelData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        IotSecuritySolutionAnalyticsModelData IModelSerializable<IotSecuritySolutionAnalyticsModelData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeIotSecuritySolutionAnalyticsModelData(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="IotSecuritySolutionAnalyticsModelData"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="IotSecuritySolutionAnalyticsModelData"/> to convert. </param>
        public static implicit operator RequestContent(IotSecuritySolutionAnalyticsModelData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="IotSecuritySolutionAnalyticsModelData"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator IotSecuritySolutionAnalyticsModelData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeIotSecuritySolutionAnalyticsModelData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
