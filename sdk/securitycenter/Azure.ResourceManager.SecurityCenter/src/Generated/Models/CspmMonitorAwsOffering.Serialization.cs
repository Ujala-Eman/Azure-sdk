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
    public partial class CspmMonitorAwsOffering : IUtf8JsonSerializable, IModelJsonSerializable<CspmMonitorAwsOffering>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<CspmMonitorAwsOffering>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<CspmMonitorAwsOffering>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CspmMonitorAwsOffering>(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(NativeCloudConnection))
            {
                writer.WritePropertyName("nativeCloudConnection"u8);
                if (NativeCloudConnection is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<CspmMonitorAwsOfferingNativeCloudConnection>)NativeCloudConnection).Serialize(writer, options);
                }
            }
            writer.WritePropertyName("offeringType"u8);
            writer.WriteStringValue(OfferingType.ToString());
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

        internal static CspmMonitorAwsOffering DeserializeCspmMonitorAwsOffering(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CspmMonitorAwsOfferingNativeCloudConnection> nativeCloudConnection = default;
            OfferingType offeringType = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nativeCloudConnection"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nativeCloudConnection = CspmMonitorAwsOfferingNativeCloudConnection.DeserializeCspmMonitorAwsOfferingNativeCloudConnection(property.Value);
                    continue;
                }
                if (property.NameEquals("offeringType"u8))
                {
                    offeringType = new OfferingType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new CspmMonitorAwsOffering(offeringType, description.Value, nativeCloudConnection.Value, rawData);
        }

        CspmMonitorAwsOffering IModelJsonSerializable<CspmMonitorAwsOffering>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CspmMonitorAwsOffering>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeCspmMonitorAwsOffering(doc.RootElement, options);
        }

        BinaryData IModelSerializable<CspmMonitorAwsOffering>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CspmMonitorAwsOffering>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        CspmMonitorAwsOffering IModelSerializable<CspmMonitorAwsOffering>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<CspmMonitorAwsOffering>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeCspmMonitorAwsOffering(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="CspmMonitorAwsOffering"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="CspmMonitorAwsOffering"/> to convert. </param>
        public static implicit operator RequestContent(CspmMonitorAwsOffering model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="CspmMonitorAwsOffering"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator CspmMonitorAwsOffering(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeCspmMonitorAwsOffering(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
