// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(PolicyModificationResultConverter))]
    public partial class PolicyModificationResult : IUtf8JsonSerializable, IModelJsonSerializable<PolicyModificationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<PolicyModificationResult>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<PolicyModificationResult>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(PolicyResolution))
            {
                writer.WritePropertyName("x-ms-policy-result"u8);
                writer.WriteStringValue(PolicyResolution.ToString());
            }
            if (Optional.IsDefined(BasePolicyTokenHash))
            {
                writer.WritePropertyName("x-ms-policy-token-hash"u8);
                writer.WriteStringValue(BasePolicyTokenHash);
            }
            if (Optional.IsDefined(BasePolicySigner))
            {
                writer.WritePropertyName("x-ms-policy-signer"u8);
                writer.WriteObjectValue(BasePolicySigner);
            }
            if (Optional.IsDefined(BasePolicy))
            {
                writer.WritePropertyName("x-ms-policy"u8);
                writer.WriteStringValue(BasePolicy);
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

        internal static PolicyModificationResult DeserializePolicyModificationResult(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyModification> xMsPolicyResult = default;
            Optional<string> xMsPolicyTokenHash = default;
            Optional<JsonWebKey> xMsPolicySigner = default;
            Optional<string> xMsPolicy = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x-ms-policy-result"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicyResult = new PolicyModification(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("x-ms-policy-token-hash"u8))
                {
                    xMsPolicyTokenHash = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("x-ms-policy-signer"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    xMsPolicySigner = JsonWebKey.DeserializeJsonWebKey(property.Value);
                    continue;
                }
                if (property.NameEquals("x-ms-policy"u8))
                {
                    xMsPolicy = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new PolicyModificationResult(xMsPolicyResult, xMsPolicyTokenHash.Value, xMsPolicySigner.Value, xMsPolicy.Value, rawData);
        }

        PolicyModificationResult IModelJsonSerializable<PolicyModificationResult>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyModificationResult(doc.RootElement, options);
        }

        BinaryData IModelSerializable<PolicyModificationResult>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        PolicyModificationResult IModelSerializable<PolicyModificationResult>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializePolicyModificationResult(doc.RootElement, options);
        }

        public static implicit operator RequestContent(PolicyModificationResult model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator PolicyModificationResult(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializePolicyModificationResult(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }

        internal partial class PolicyModificationResultConverter : JsonConverter<PolicyModificationResult>
        {
            public override void Write(Utf8JsonWriter writer, PolicyModificationResult model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override PolicyModificationResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializePolicyModificationResult(document.RootElement);
            }
        }
    }
}
