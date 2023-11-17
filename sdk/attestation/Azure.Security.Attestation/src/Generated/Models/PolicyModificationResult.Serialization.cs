// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Security.Attestation
{
    [JsonConverter(typeof(PolicyModificationResultConverter))]
    public partial class PolicyModificationResult : IUtf8JsonSerializable, IJsonModel<PolicyModificationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyModificationResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<PolicyModificationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<PolicyModificationResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<PolicyModificationResult>)} interface");
            }

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
            if (_serializedAdditionalRawData != null && options.Format == "J")
            {
                foreach (var item in _serializedAdditionalRawData)
                {
                    writer.WritePropertyName(item.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                    using (JsonDocument document = JsonDocument.Parse(item.Value))
                    {
                        JsonSerializer.Serialize(writer, document.RootElement);
                    }
#endif
                }
            }
            writer.WriteEndObject();
        }

        PolicyModificationResult IJsonModel<PolicyModificationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyModificationResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyModificationResult(document.RootElement, options);
        }

        internal static PolicyModificationResult DeserializePolicyModificationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PolicyModification> xMsPolicyResult = default;
            Optional<string> xMsPolicyTokenHash = default;
            Optional<JsonWebKey> xMsPolicySigner = default;
            Optional<string> xMsPolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
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
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyModificationResult(xMsPolicyResult, xMsPolicyTokenHash.Value, xMsPolicySigner.Value, xMsPolicy.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyModificationResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyModificationResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        PolicyModificationResult IPersistableModel<PolicyModificationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(PolicyModificationResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializePolicyModificationResult(document.RootElement, options);
        }

        string IPersistableModel<PolicyModificationResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";

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
