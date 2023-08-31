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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ManagedInstanceVcoresCapability : IUtf8JsonSerializable, IModelJsonSerializable<ManagedInstanceVcoresCapability>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ManagedInstanceVcoresCapability>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ManagedInstanceVcoresCapability>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Reason))
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
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

        internal static ManagedInstanceVcoresCapability DeserializeManagedInstanceVcoresCapability(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> name = default;
            Optional<int> value = default;
            Optional<MaxSizeCapability> includedMaxSize = default;
            Optional<IReadOnlyList<MaxSizeRangeCapability>> supportedStorageSizes = default;
            Optional<bool> instancePoolSupported = default;
            Optional<bool> standaloneSupported = default;
            Optional<IReadOnlyList<ManagedInstanceMaintenanceConfigurationCapability>> supportedMaintenanceConfigurations = default;
            Optional<SqlCapabilityStatus> status = default;
            Optional<string> reason = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("includedMaxSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includedMaxSize = MaxSizeCapability.DeserializeMaxSizeCapability(property.Value);
                    continue;
                }
                if (property.NameEquals("supportedStorageSizes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MaxSizeRangeCapability> array = new List<MaxSizeRangeCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MaxSizeRangeCapability.DeserializeMaxSizeRangeCapability(item));
                    }
                    supportedStorageSizes = array;
                    continue;
                }
                if (property.NameEquals("instancePoolSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    instancePoolSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("standaloneSupported"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    standaloneSupported = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("supportedMaintenanceConfigurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedInstanceMaintenanceConfigurationCapability> array = new List<ManagedInstanceMaintenanceConfigurationCapability>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedInstanceMaintenanceConfigurationCapability.DeserializeManagedInstanceMaintenanceConfigurationCapability(item));
                    }
                    supportedMaintenanceConfigurations = array;
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = property.Value.GetString().ToSqlCapabilityStatus();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ManagedInstanceVcoresCapability(name.Value, Optional.ToNullable(value), includedMaxSize.Value, Optional.ToList(supportedStorageSizes), Optional.ToNullable(instancePoolSupported), Optional.ToNullable(standaloneSupported), Optional.ToList(supportedMaintenanceConfigurations), Optional.ToNullable(status), reason.Value, rawData);
        }

        ManagedInstanceVcoresCapability IModelJsonSerializable<ManagedInstanceVcoresCapability>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedInstanceVcoresCapability(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ManagedInstanceVcoresCapability>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ManagedInstanceVcoresCapability IModelSerializable<ManagedInstanceVcoresCapability>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeManagedInstanceVcoresCapability(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ManagedInstanceVcoresCapability"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ManagedInstanceVcoresCapability"/> to convert. </param>
        public static implicit operator RequestContent(ManagedInstanceVcoresCapability model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ManagedInstanceVcoresCapability"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ManagedInstanceVcoresCapability(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeManagedInstanceVcoresCapability(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
