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
    internal partial class DefenderForContainersAwsOfferingKinesisToS3 : IUtf8JsonSerializable, IModelJsonSerializable<DefenderForContainersAwsOfferingKinesisToS3>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<DefenderForContainersAwsOfferingKinesisToS3>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<DefenderForContainersAwsOfferingKinesisToS3>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(CloudRoleArn))
            {
                writer.WritePropertyName("cloudRoleArn"u8);
                writer.WriteStringValue(CloudRoleArn);
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

        internal static DefenderForContainersAwsOfferingKinesisToS3 DeserializeDefenderForContainersAwsOfferingKinesisToS3(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> cloudRoleArn = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cloudRoleArn"u8))
                {
                    cloudRoleArn = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new DefenderForContainersAwsOfferingKinesisToS3(cloudRoleArn.Value, rawData);
        }

        DefenderForContainersAwsOfferingKinesisToS3 IModelJsonSerializable<DefenderForContainersAwsOfferingKinesisToS3>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeDefenderForContainersAwsOfferingKinesisToS3(doc.RootElement, options);
        }

        BinaryData IModelSerializable<DefenderForContainersAwsOfferingKinesisToS3>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        DefenderForContainersAwsOfferingKinesisToS3 IModelSerializable<DefenderForContainersAwsOfferingKinesisToS3>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeDefenderForContainersAwsOfferingKinesisToS3(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="DefenderForContainersAwsOfferingKinesisToS3"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="DefenderForContainersAwsOfferingKinesisToS3"/> to convert. </param>
        public static implicit operator RequestContent(DefenderForContainersAwsOfferingKinesisToS3 model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="DefenderForContainersAwsOfferingKinesisToS3"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator DefenderForContainersAwsOfferingKinesisToS3(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeDefenderForContainersAwsOfferingKinesisToS3(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
