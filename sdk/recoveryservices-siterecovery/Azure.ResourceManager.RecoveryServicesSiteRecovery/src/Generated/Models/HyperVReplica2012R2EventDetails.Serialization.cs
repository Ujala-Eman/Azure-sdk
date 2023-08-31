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
    public partial class HyperVReplica2012R2EventDetails : IUtf8JsonSerializable, IModelJsonSerializable<HyperVReplica2012R2EventDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HyperVReplica2012R2EventDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HyperVReplica2012R2EventDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplica2012R2EventDetails>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ContainerName))
            {
                writer.WritePropertyName("containerName"u8);
                writer.WriteStringValue(ContainerName);
            }
            if (Optional.IsDefined(FabricName))
            {
                writer.WritePropertyName("fabricName"u8);
                writer.WriteStringValue(FabricName);
            }
            if (Optional.IsDefined(RemoteContainerName))
            {
                writer.WritePropertyName("remoteContainerName"u8);
                writer.WriteStringValue(RemoteContainerName);
            }
            if (Optional.IsDefined(RemoteFabricName))
            {
                writer.WritePropertyName("remoteFabricName"u8);
                writer.WriteStringValue(RemoteFabricName);
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

        internal static HyperVReplica2012R2EventDetails DeserializeHyperVReplica2012R2EventDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> containerName = default;
            Optional<string> fabricName = default;
            Optional<string> remoteContainerName = default;
            Optional<string> remoteFabricName = default;
            string instanceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("containerName"u8))
                {
                    containerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("fabricName"u8))
                {
                    fabricName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteContainerName"u8))
                {
                    remoteContainerName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("remoteFabricName"u8))
                {
                    remoteFabricName = property.Value.GetString();
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
            return new HyperVReplica2012R2EventDetails(instanceType, containerName.Value, fabricName.Value, remoteContainerName.Value, remoteFabricName.Value, rawData);
        }

        HyperVReplica2012R2EventDetails IModelJsonSerializable<HyperVReplica2012R2EventDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplica2012R2EventDetails>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHyperVReplica2012R2EventDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HyperVReplica2012R2EventDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplica2012R2EventDetails>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HyperVReplica2012R2EventDetails IModelSerializable<HyperVReplica2012R2EventDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<HyperVReplica2012R2EventDetails>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHyperVReplica2012R2EventDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="HyperVReplica2012R2EventDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="HyperVReplica2012R2EventDetails"/> to convert. </param>
        public static implicit operator RequestContent(HyperVReplica2012R2EventDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="HyperVReplica2012R2EventDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator HyperVReplica2012R2EventDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHyperVReplica2012R2EventDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
