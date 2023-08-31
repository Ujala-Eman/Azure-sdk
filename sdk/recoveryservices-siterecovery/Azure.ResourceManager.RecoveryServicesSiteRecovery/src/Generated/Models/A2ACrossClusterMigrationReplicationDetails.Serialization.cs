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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class A2ACrossClusterMigrationReplicationDetails : IUtf8JsonSerializable, IModelJsonSerializable<A2ACrossClusterMigrationReplicationDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<A2ACrossClusterMigrationReplicationDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<A2ACrossClusterMigrationReplicationDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<A2ACrossClusterMigrationReplicationDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(FabricObjectId))
            {
                writer.WritePropertyName("fabricObjectId"u8);
                writer.WriteStringValue(FabricObjectId);
            }
            if (Optional.IsDefined(PrimaryFabricLocation))
            {
                writer.WritePropertyName("primaryFabricLocation"u8);
                writer.WriteStringValue(PrimaryFabricLocation.Value);
            }
            if (Optional.IsDefined(OSType))
            {
                writer.WritePropertyName("osType"u8);
                writer.WriteStringValue(OSType);
            }
            if (Optional.IsDefined(VmProtectionState))
            {
                writer.WritePropertyName("vmProtectionState"u8);
                writer.WriteStringValue(VmProtectionState);
            }
            if (Optional.IsDefined(VmProtectionStateDescription))
            {
                writer.WritePropertyName("vmProtectionStateDescription"u8);
                writer.WriteStringValue(VmProtectionStateDescription);
            }
            if (Optional.IsDefined(LifecycleId))
            {
                writer.WritePropertyName("lifecycleId"u8);
                writer.WriteStringValue(LifecycleId);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        internal static A2ACrossClusterMigrationReplicationDetails DeserializeA2ACrossClusterMigrationReplicationDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> fabricObjectId = default;
            Optional<AzureLocation> primaryFabricLocation = default;
            Optional<string> osType = default;
            Optional<string> vmProtectionState = default;
            Optional<string> vmProtectionStateDescription = default;
            Optional<string> lifecycleId = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("fabricObjectId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fabricObjectId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("primaryFabricLocation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    primaryFabricLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("osType"u8))
                {
                    osType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionState"u8))
                {
                    vmProtectionState = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmProtectionStateDescription"u8))
                {
                    vmProtectionStateDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("lifecycleId"u8))
                {
                    lifecycleId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new A2ACrossClusterMigrationReplicationDetails(instanceType, fabricObjectId.Value, Optional.ToNullable(primaryFabricLocation), osType.Value, vmProtectionState.Value, vmProtectionStateDescription.Value, lifecycleId.Value, rawData);
        }

        A2ACrossClusterMigrationReplicationDetails IModelJsonSerializable<A2ACrossClusterMigrationReplicationDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<A2ACrossClusterMigrationReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeA2ACrossClusterMigrationReplicationDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<A2ACrossClusterMigrationReplicationDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<A2ACrossClusterMigrationReplicationDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        A2ACrossClusterMigrationReplicationDetails IModelSerializable<A2ACrossClusterMigrationReplicationDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<A2ACrossClusterMigrationReplicationDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeA2ACrossClusterMigrationReplicationDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="A2ACrossClusterMigrationReplicationDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="A2ACrossClusterMigrationReplicationDetails"/> to convert. </param>
        public static implicit operator RequestContent(A2ACrossClusterMigrationReplicationDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="A2ACrossClusterMigrationReplicationDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator A2ACrossClusterMigrationReplicationDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeA2ACrossClusterMigrationReplicationDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
