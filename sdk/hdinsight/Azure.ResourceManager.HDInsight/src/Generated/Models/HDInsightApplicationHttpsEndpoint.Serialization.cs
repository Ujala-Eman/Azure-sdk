// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.HDInsight.Models
{
    public partial class HDInsightApplicationHttpsEndpoint : IUtf8JsonSerializable, IModelJsonSerializable<HDInsightApplicationHttpsEndpoint>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<HDInsightApplicationHttpsEndpoint>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<HDInsightApplicationHttpsEndpoint>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AccessModes))
            {
                writer.WritePropertyName("accessModes"u8);
                writer.WriteStartArray();
                foreach (var item in AccessModes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(DestinationPort))
            {
                writer.WritePropertyName("destinationPort"u8);
                writer.WriteNumberValue(DestinationPort.Value);
            }
            if (Optional.IsDefined(PrivateIPAddress))
            {
                writer.WritePropertyName("privateIPAddress"u8);
                writer.WriteStringValue(PrivateIPAddress.ToString());
            }
            if (Optional.IsDefined(SubDomainSuffix))
            {
                writer.WritePropertyName("subDomainSuffix"u8);
                writer.WriteStringValue(SubDomainSuffix);
            }
            if (Optional.IsDefined(DisableGatewayAuth))
            {
                writer.WritePropertyName("disableGatewayAuth"u8);
                writer.WriteBooleanValue(DisableGatewayAuth.Value);
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

        internal static HDInsightApplicationHttpsEndpoint DeserializeHDInsightApplicationHttpsEndpoint(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<string>> accessModes = default;
            Optional<string> location = default;
            Optional<int> destinationPort = default;
            Optional<int> publicPort = default;
            Optional<IPAddress> privateIPAddress = default;
            Optional<string> subDomainSuffix = default;
            Optional<bool> disableGatewayAuth = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accessModes"u8))
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
                    accessModes = array;
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("publicPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicPort = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("privateIPAddress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    privateIPAddress = IPAddress.Parse(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subDomainSuffix"u8))
                {
                    subDomainSuffix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disableGatewayAuth"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    disableGatewayAuth = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new HDInsightApplicationHttpsEndpoint(Optional.ToList(accessModes), location.Value, Optional.ToNullable(destinationPort), Optional.ToNullable(publicPort), privateIPAddress.Value, subDomainSuffix.Value, Optional.ToNullable(disableGatewayAuth), rawData);
        }

        HDInsightApplicationHttpsEndpoint IModelJsonSerializable<HDInsightApplicationHttpsEndpoint>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeHDInsightApplicationHttpsEndpoint(doc.RootElement, options);
        }

        BinaryData IModelSerializable<HDInsightApplicationHttpsEndpoint>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        HDInsightApplicationHttpsEndpoint IModelSerializable<HDInsightApplicationHttpsEndpoint>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeHDInsightApplicationHttpsEndpoint(doc.RootElement, options);
        }

        public static implicit operator RequestContent(HDInsightApplicationHttpsEndpoint model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator HDInsightApplicationHttpsEndpoint(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeHDInsightApplicationHttpsEndpoint(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
