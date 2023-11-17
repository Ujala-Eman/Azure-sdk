// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class UnmuteParticipantsResult : IUtf8JsonSerializable, IJsonModel<UnmuteParticipantsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UnmuteParticipantsResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<UnmuteParticipantsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<UnmuteParticipantsResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<UnmuteParticipantsResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OperationContext))
            {
                writer.WritePropertyName("operationContext"u8);
                writer.WriteStringValue(OperationContext);
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

        UnmuteParticipantsResult IJsonModel<UnmuteParticipantsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UnmuteParticipantsResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnmuteParticipantsResult(document.RootElement, options);
        }

        internal static UnmuteParticipantsResult DeserializeUnmuteParticipantsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> operationContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("operationContext"u8))
                {
                    operationContext = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnmuteParticipantsResult(operationContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UnmuteParticipantsResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UnmuteParticipantsResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UnmuteParticipantsResult IPersistableModel<UnmuteParticipantsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UnmuteParticipantsResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUnmuteParticipantsResult(document.RootElement, options);
        }

        string IPersistableModel<UnmuteParticipantsResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
