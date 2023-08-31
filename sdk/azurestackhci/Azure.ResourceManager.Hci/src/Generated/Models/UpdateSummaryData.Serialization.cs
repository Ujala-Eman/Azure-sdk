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
using Azure.ResourceManager.Hci.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Hci
{
    public partial class UpdateSummaryData : IUtf8JsonSerializable, IModelJsonSerializable<UpdateSummaryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<UpdateSummaryData>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<UpdateSummaryData>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(OemFamily))
            {
                writer.WritePropertyName("oemFamily"u8);
                writer.WriteStringValue(OemFamily);
            }
            if (Optional.IsDefined(HardwareModel))
            {
                writer.WritePropertyName("hardwareModel"u8);
                writer.WriteStringValue(HardwareModel);
            }
            if (Optional.IsCollectionDefined(PackageVersions))
            {
                writer.WritePropertyName("packageVersions"u8);
                writer.WriteStartArray();
                foreach (var item in PackageVersions)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(CurrentVersion))
            {
                writer.WritePropertyName("currentVersion"u8);
                writer.WriteStringValue(CurrentVersion);
            }
            if (Optional.IsDefined(LastUpdated))
            {
                writer.WritePropertyName("lastUpdated"u8);
                writer.WriteStringValue(LastUpdated.Value, "O");
            }
            if (Optional.IsDefined(LastChecked))
            {
                writer.WritePropertyName("lastChecked"u8);
                writer.WriteStringValue(LastChecked.Value, "O");
            }
            if (Optional.IsDefined(HealthState))
            {
                writer.WritePropertyName("healthState"u8);
                writer.WriteStringValue(HealthState.Value.ToString());
            }
            if (Optional.IsCollectionDefined(HealthCheckResult))
            {
                writer.WritePropertyName("healthCheckResult"u8);
                writer.WriteStartArray();
                foreach (var item in HealthCheckResult)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(HealthCheckOn))
            {
                writer.WritePropertyName("healthCheckDate"u8);
                writer.WriteStringValue(HealthCheckOn.Value, "O");
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
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

        internal static UpdateSummaryData DeserializeUpdateSummaryData(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<HciProvisioningState> provisioningState = default;
            Optional<string> oemFamily = default;
            Optional<string> hardwareModel = default;
            Optional<IList<HciPackageVersionInfo>> packageVersions = default;
            Optional<string> currentVersion = default;
            Optional<DateTimeOffset> lastUpdated = default;
            Optional<DateTimeOffset> lastChecked = default;
            Optional<HciHealthState> healthState = default;
            Optional<IList<HciPrecheckResult>> healthCheckResult = default;
            Optional<DateTimeOffset> healthCheckDate = default;
            Optional<UpdateSummariesPropertiesState> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            provisioningState = new HciProvisioningState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("oemFamily"u8))
                        {
                            oemFamily = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hardwareModel"u8))
                        {
                            hardwareModel = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("packageVersions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HciPackageVersionInfo> array = new List<HciPackageVersionInfo>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HciPackageVersionInfo.DeserializeHciPackageVersionInfo(item));
                            }
                            packageVersions = array;
                            continue;
                        }
                        if (property0.NameEquals("currentVersion"u8))
                        {
                            currentVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastUpdated"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastUpdated = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("lastChecked"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastChecked = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("healthState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthState = new HciHealthState(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("healthCheckResult"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<HciPrecheckResult> array = new List<HciPrecheckResult>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(HciPrecheckResult.DeserializeHciPrecheckResult(item));
                            }
                            healthCheckResult = array;
                            continue;
                        }
                        if (property0.NameEquals("healthCheckDate"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            healthCheckDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            state = new UpdateSummariesPropertiesState(property0.Value.GetString());
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
            return new UpdateSummaryData(id, name, type, systemData.Value, Optional.ToNullable(location), Optional.ToNullable(provisioningState), oemFamily.Value, hardwareModel.Value, Optional.ToList(packageVersions), currentVersion.Value, Optional.ToNullable(lastUpdated), Optional.ToNullable(lastChecked), Optional.ToNullable(healthState), Optional.ToList(healthCheckResult), Optional.ToNullable(healthCheckDate), Optional.ToNullable(state), rawData);
        }

        UpdateSummaryData IModelJsonSerializable<UpdateSummaryData>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeUpdateSummaryData(doc.RootElement, options);
        }

        BinaryData IModelSerializable<UpdateSummaryData>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        UpdateSummaryData IModelSerializable<UpdateSummaryData>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeUpdateSummaryData(doc.RootElement, options);
        }

        public static implicit operator RequestContent(UpdateSummaryData model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator UpdateSummaryData(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeUpdateSummaryData(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
