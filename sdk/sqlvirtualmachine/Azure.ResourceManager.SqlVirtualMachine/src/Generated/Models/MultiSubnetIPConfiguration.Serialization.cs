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

namespace Azure.ResourceManager.SqlVirtualMachine.Models
{
    public partial class MultiSubnetIPConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<MultiSubnetIPConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<MultiSubnetIPConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<MultiSubnetIPConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("privateIpAddress"u8);
            if (PrivateIPAddress is null)
            {
                writer.WriteNullValue();
            }
            else
            {
                ((IModelJsonSerializable<AvailabilityGroupListenerPrivateIPAddress>)PrivateIPAddress).Serialize(writer, options);
            }
            writer.WritePropertyName("sqlVirtualMachineInstance"u8);
            writer.WriteStringValue(SqlVmInstance);
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

        internal static MultiSubnetIPConfiguration DeserializeMultiSubnetIPConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AvailabilityGroupListenerPrivateIPAddress privateIPAddress = default;
            string sqlVmInstance = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("privateIpAddress"u8))
                {
                    privateIPAddress = AvailabilityGroupListenerPrivateIPAddress.DeserializeAvailabilityGroupListenerPrivateIPAddress(property.Value);
                    continue;
                }
                if (property.NameEquals("sqlVirtualMachineInstance"u8))
                {
                    sqlVmInstance = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new MultiSubnetIPConfiguration(privateIPAddress, sqlVmInstance, rawData);
        }

        MultiSubnetIPConfiguration IModelJsonSerializable<MultiSubnetIPConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeMultiSubnetIPConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<MultiSubnetIPConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        MultiSubnetIPConfiguration IModelSerializable<MultiSubnetIPConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeMultiSubnetIPConfiguration(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="MultiSubnetIPConfiguration"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="MultiSubnetIPConfiguration"/> to convert. </param>
        public static implicit operator RequestContent(MultiSubnetIPConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="MultiSubnetIPConfiguration"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator MultiSubnetIPConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeMultiSubnetIPConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
