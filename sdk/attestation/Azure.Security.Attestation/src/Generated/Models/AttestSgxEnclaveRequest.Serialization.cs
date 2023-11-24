// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Security.Attestation
{
    internal partial class AttestSgxEnclaveRequest : IUtf8JsonSerializable, IJsonModel<AttestSgxEnclaveRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AttestSgxEnclaveRequest>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AttestSgxEnclaveRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestSgxEnclaveRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AttestSgxEnclaveRequest)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Quote))
            {
                writer.WritePropertyName("quote"u8);
                writer.WriteBase64StringValue(Quote, "U");
            }
            if (Optional.IsDefined(RuntimeData))
            {
                writer.WritePropertyName("runtimeData"u8);
                writer.WriteObjectValue(RuntimeData);
            }
            if (Optional.IsDefined(InitTimeData))
            {
                writer.WritePropertyName("initTimeData"u8);
                writer.WriteObjectValue(InitTimeData);
            }
            if (Optional.IsDefined(DraftPolicyForAttestation))
            {
                writer.WritePropertyName("draftPolicyForAttestation"u8);
                writer.WriteStringValue(DraftPolicyForAttestation);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        AttestSgxEnclaveRequest IJsonModel<AttestSgxEnclaveRequest>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestSgxEnclaveRequest>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AttestSgxEnclaveRequest)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAttestSgxEnclaveRequest(document.RootElement, options);
        }

        internal static AttestSgxEnclaveRequest DeserializeAttestSgxEnclaveRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<byte[]> quote = default;
            Optional<RuntimeData> runtimeData = default;
            Optional<InitTimeData> initTimeData = default;
            Optional<string> draftPolicyForAttestation = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("quote"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quote = property.Value.GetBytesFromBase64("U");
                    continue;
                }
                if (property.NameEquals("runtimeData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    runtimeData = RuntimeData.DeserializeRuntimeData(property.Value);
                    continue;
                }
                if (property.NameEquals("initTimeData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    initTimeData = InitTimeData.DeserializeInitTimeData(property.Value);
                    continue;
                }
                if (property.NameEquals("draftPolicyForAttestation"u8))
                {
                    draftPolicyForAttestation = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AttestSgxEnclaveRequest(quote.Value, runtimeData.Value, initTimeData.Value, draftPolicyForAttestation.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AttestSgxEnclaveRequest>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestSgxEnclaveRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AttestSgxEnclaveRequest)} does not support '{options.Format}' format.");
            }
        }

        AttestSgxEnclaveRequest IPersistableModel<AttestSgxEnclaveRequest>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AttestSgxEnclaveRequest>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAttestSgxEnclaveRequest(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AttestSgxEnclaveRequest)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AttestSgxEnclaveRequest>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
