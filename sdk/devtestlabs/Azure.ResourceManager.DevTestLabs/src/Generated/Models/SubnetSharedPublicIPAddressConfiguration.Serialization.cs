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

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class SubnetSharedPublicIPAddressConfiguration : IUtf8JsonSerializable, IModelJsonSerializable<SubnetSharedPublicIPAddressConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SubnetSharedPublicIPAddressConfiguration>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SubnetSharedPublicIPAddressConfiguration>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AllowedPorts))
            {
                writer.WritePropertyName("allowedPorts"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedPorts)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        internal static SubnetSharedPublicIPAddressConfiguration DeserializeSubnetSharedPublicIPAddressConfiguration(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DevTestLabPort>> allowedPorts = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("allowedPorts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabPort> array = new List<DevTestLabPort>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabPort.DeserializeDevTestLabPort(item));
                    }
                    allowedPorts = array;
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SubnetSharedPublicIPAddressConfiguration(Optional.ToList(allowedPorts), rawData);
        }

        SubnetSharedPublicIPAddressConfiguration IModelJsonSerializable<SubnetSharedPublicIPAddressConfiguration>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSubnetSharedPublicIPAddressConfiguration(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SubnetSharedPublicIPAddressConfiguration>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SubnetSharedPublicIPAddressConfiguration IModelSerializable<SubnetSharedPublicIPAddressConfiguration>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSubnetSharedPublicIPAddressConfiguration(doc.RootElement, options);
        }

        public static implicit operator RequestContent(SubnetSharedPublicIPAddressConfiguration model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator SubnetSharedPublicIPAddressConfiguration(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSubnetSharedPublicIPAddressConfiguration(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
