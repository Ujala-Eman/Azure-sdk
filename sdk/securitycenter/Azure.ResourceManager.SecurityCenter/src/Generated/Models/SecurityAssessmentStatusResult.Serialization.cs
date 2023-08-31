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
    public partial class SecurityAssessmentStatusResult : IUtf8JsonSerializable, IModelJsonSerializable<SecurityAssessmentStatusResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<SecurityAssessmentStatusResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<SecurityAssessmentStatusResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAssessmentStatusResult>(this, options.Format);

            writer.WriteStartObject();
            writer.WritePropertyName("code"u8);
            writer.WriteStringValue(Code.ToString());
            if (Optional.IsDefined(Cause))
            {
                writer.WritePropertyName("cause"u8);
                writer.WriteStringValue(Cause);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
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

        internal static SecurityAssessmentStatusResult DeserializeSecurityAssessmentStatusResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<DateTimeOffset> firstEvaluationDate = default;
            Optional<DateTimeOffset> statusChangeDate = default;
            SecurityAssessmentStatusCode code = default;
            Optional<string> cause = default;
            Optional<string> description = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstEvaluationDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    firstEvaluationDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusChangeDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("code"u8))
                {
                    code = new SecurityAssessmentStatusCode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("cause"u8))
                {
                    cause = property.Value.GetString();
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
            return new SecurityAssessmentStatusResult(code, cause.Value, description.Value, Optional.ToNullable(firstEvaluationDate), Optional.ToNullable(statusChangeDate), rawData);
        }

        SecurityAssessmentStatusResult IModelJsonSerializable<SecurityAssessmentStatusResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAssessmentStatusResult>(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityAssessmentStatusResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<SecurityAssessmentStatusResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAssessmentStatusResult>(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        SecurityAssessmentStatusResult IModelSerializable<SecurityAssessmentStatusResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat<SecurityAssessmentStatusResult>(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeSecurityAssessmentStatusResult(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="SecurityAssessmentStatusResult"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="SecurityAssessmentStatusResult"/> to convert. </param>
        public static implicit operator RequestContent(SecurityAssessmentStatusResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="SecurityAssessmentStatusResult"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator SecurityAssessmentStatusResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeSecurityAssessmentStatusResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
