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
    public partial class SiteRecoveryJobErrorDetails : IUtf8JsonSerializable, IModelJsonSerializable<SiteRecoveryJobErrorDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SiteRecoveryJobErrorDetails>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SiteRecoveryJobErrorDetails>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(ServiceErrorDetails))
            {
                writer.WritePropertyName("serviceErrorDetails"u8);
                if (ServiceErrorDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryServiceError>)ServiceErrorDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ProviderErrorDetails))
            {
                writer.WritePropertyName("providerErrorDetails"u8);
                if (ProviderErrorDetails is null)
                {
                    writer.WriteNullValue();
                }
                else
                {
                    ((IModelJsonSerializable<SiteRecoveryJobProviderError>)ProviderErrorDetails).Serialize(writer, options);
                }
            }
            if (Optional.IsDefined(ErrorLevel))
            {
                writer.WritePropertyName("errorLevel"u8);
                writer.WriteStringValue(ErrorLevel);
            }
            if (Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("creationTime"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (Optional.IsDefined(TaskId))
            {
                writer.WritePropertyName("taskId"u8);
                writer.WriteStringValue(TaskId);
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

        internal static SiteRecoveryJobErrorDetails DeserializeSiteRecoveryJobErrorDetails(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SiteRecoveryServiceError> serviceErrorDetails = default;
            Optional<SiteRecoveryJobProviderError> providerErrorDetails = default;
            Optional<string> errorLevel = default;
            Optional<DateTimeOffset> creationTime = default;
            Optional<string> taskId = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("serviceErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    serviceErrorDetails = SiteRecoveryServiceError.DeserializeSiteRecoveryServiceError(property.Value);
                    continue;
                }
                if (property.NameEquals("providerErrorDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    providerErrorDetails = SiteRecoveryJobProviderError.DeserializeSiteRecoveryJobProviderError(property.Value);
                    continue;
                }
                if (property.NameEquals("errorLevel"u8))
                {
                    errorLevel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("creationTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    creationTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("taskId"u8))
                {
                    taskId = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new SiteRecoveryJobErrorDetails(serviceErrorDetails.Value, providerErrorDetails.Value, errorLevel.Value, Optional.ToNullable(creationTime), taskId.Value, rawData);
        }

        SiteRecoveryJobErrorDetails IModelJsonSerializable<SiteRecoveryJobErrorDetails>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryJobErrorDetails(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SiteRecoveryJobErrorDetails>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SiteRecoveryJobErrorDetails IModelSerializable<SiteRecoveryJobErrorDetails>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryJobErrorDetails(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SiteRecoveryJobErrorDetails"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SiteRecoveryJobErrorDetails"/> to convert. </param>
        public static implicit operator RequestContent(SiteRecoveryJobErrorDetails model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SiteRecoveryJobErrorDetails"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SiteRecoveryJobErrorDetails(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSiteRecoveryJobErrorDetails(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
