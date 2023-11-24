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

namespace Azure.Communication.CallAutomation
{
    internal partial class RejectCallRequestInternal : IUtf8JsonSerializable, IJsonModel<RejectCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RejectCallRequestInternal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RejectCallRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RejectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RejectCallRequestInternal)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            if (Optional.IsDefined(CallRejectReason))
            {
                writer.WritePropertyName("callRejectReason"u8);
                writer.WriteStringValue(CallRejectReason.Value.ToString());
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

        RejectCallRequestInternal IJsonModel<RejectCallRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RejectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(RejectCallRequestInternal)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRejectCallRequestInternal(document.RootElement, options);
        }

        internal static RejectCallRequestInternal DeserializeRejectCallRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string incomingCallContext = default;
            Optional<CallRejectReason> callRejectReason = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("callRejectReason"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    callRejectReason = new CallRejectReason(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RejectCallRequestInternal(incomingCallContext, Optional.ToNullable(callRejectReason), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RejectCallRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RejectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(RejectCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        RejectCallRequestInternal IPersistableModel<RejectCallRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RejectCallRequestInternal>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRejectCallRequestInternal(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(RejectCallRequestInternal)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RejectCallRequestInternal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
