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
    public partial class RecoveryAvailabilitySetCustomDetails : IUtf8JsonSerializable, IModelJsonSerializable<RecoveryAvailabilitySetCustomDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RecoveryAvailabilitySetCustomDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RecoveryAvailabilitySetCustomDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("resourceType"u8);
            writer.WriteStringValue(ResourceType);
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

        internal static RecoveryAvailabilitySetCustomDetails DeserializeRecoveryAvailabilitySetCustomDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("resourceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Existing": return ExistingRecoveryAvailabilitySet.DeserializeExistingRecoveryAvailabilitySet(element);
                }
            }

            // Unknown type found so we will deserialize the base properties only
            string resourceType = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new UnknownRecoveryAvailabilitySetCustomDetails(resourceType, rawData);
        }

        RecoveryAvailabilitySetCustomDetails IModelJsonSerializable<RecoveryAvailabilitySetCustomDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryAvailabilitySetCustomDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RecoveryAvailabilitySetCustomDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RecoveryAvailabilitySetCustomDetails IModelSerializable<RecoveryAvailabilitySetCustomDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRecoveryAvailabilitySetCustomDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="RecoveryAvailabilitySetCustomDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="RecoveryAvailabilitySetCustomDetails"/> to convert. </param>
        public static implicit operator RequestContent(RecoveryAvailabilitySetCustomDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="RecoveryAvailabilitySetCustomDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator RecoveryAvailabilitySetCustomDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRecoveryAvailabilitySetCustomDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
