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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class JitNetworkAccessRequestPort : IUtf8JsonSerializable, IModelJsonSerializable<JitNetworkAccessRequestPort>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<JitNetworkAccessRequestPort>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<JitNetworkAccessRequestPort>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("number"u8);
            writer.WriteNumberValue(Number);
            if (Optional.IsDefined(AllowedSourceAddressPrefix))
            {
                writer.WritePropertyName("allowedSourceAddressPrefix"u8);
                writer.WriteStringValue(AllowedSourceAddressPrefix);
            }
            if (Optional.IsCollectionDefined(AllowedSourceAddressPrefixes))
            {
                writer.WritePropertyName("allowedSourceAddressPrefixes"u8);
                writer.WriteStartArray();
                foreach (var item in AllowedSourceAddressPrefixes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("endTimeUtc"u8);
            writer.WriteStringValue(EndOn, "O");
            writer.WritePropertyName("status"u8);
            writer.WriteStringValue(Status.ToString());
            writer.WritePropertyName("statusReason"u8);
            writer.WriteStringValue(StatusReason.ToString());
            if (Optional.IsDefined(MappedPort))
            {
                writer.WritePropertyName("mappedPort"u8);
                writer.WriteNumberValue(MappedPort.Value);
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

        internal static JitNetworkAccessRequestPort DeserializeJitNetworkAccessRequestPort(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int number = default;
            Optional<string> allowedSourceAddressPrefix = default;
            Optional<IList<string>> allowedSourceAddressPrefixes = default;
            DateTimeOffset endTimeUtc = default;
            JitNetworkAccessPortStatus status = default;
            JitNetworkAccessPortStatusReason statusReason = default;
            Optional<int> mappedPort = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefix"u8))
                {
                    allowedSourceAddressPrefix = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("allowedSourceAddressPrefixes"u8))
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
                    allowedSourceAddressPrefixes = array;
                    continue;
                }
                if (property.NameEquals("endTimeUtc"u8))
                {
                    endTimeUtc = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = new JitNetworkAccessPortStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("statusReason"u8))
                {
                    statusReason = new JitNetworkAccessPortStatusReason(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("mappedPort"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    mappedPort = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new JitNetworkAccessRequestPort(number, allowedSourceAddressPrefix.Value, Optional.ToList(allowedSourceAddressPrefixes), endTimeUtc, status, statusReason, Optional.ToNullable(mappedPort), rawData);
        }

        JitNetworkAccessRequestPort IModelJsonSerializable<JitNetworkAccessRequestPort>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeJitNetworkAccessRequestPort(doc.RootElement, options);
        }

        BinaryData IModelSerializable<JitNetworkAccessRequestPort>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        JitNetworkAccessRequestPort IModelSerializable<JitNetworkAccessRequestPort>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeJitNetworkAccessRequestPort(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="JitNetworkAccessRequestPort"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="JitNetworkAccessRequestPort"/> to convert. </param>
        public static implicit operator RequestContent(JitNetworkAccessRequestPort model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="JitNetworkAccessRequestPort"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator JitNetworkAccessRequestPort(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeJitNetworkAccessRequestPort(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
