// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Communication;
using Azure.Core;

namespace Azure.Communication.CallingServer
{
    internal partial class RedirectCallRequestInternal : IUtf8JsonSerializable, IJsonModel<RedirectCallRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RedirectCallRequestInternal>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RedirectCallRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RedirectCallRequestInternal>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RedirectCallRequestInternal>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("incomingCallContext"u8);
            writer.WriteStringValue(IncomingCallContext);
            writer.WritePropertyName("target"u8);
            writer.WriteObjectValue(Target);
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

        RedirectCallRequestInternal IJsonModel<RedirectCallRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedirectCallRequestInternal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRedirectCallRequestInternal(document.RootElement, options);
        }

        internal static RedirectCallRequestInternal DeserializeRedirectCallRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string incomingCallContext = default;
            CommunicationIdentifierModel target = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("incomingCallContext"u8))
                {
                    incomingCallContext = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("target"u8))
                {
                    target = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RedirectCallRequestInternal(incomingCallContext, target, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RedirectCallRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedirectCallRequestInternal)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RedirectCallRequestInternal IPersistableModel<RedirectCallRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RedirectCallRequestInternal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRedirectCallRequestInternal(document.RootElement, options);
        }

        string IPersistableModel<RedirectCallRequestInternal>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
