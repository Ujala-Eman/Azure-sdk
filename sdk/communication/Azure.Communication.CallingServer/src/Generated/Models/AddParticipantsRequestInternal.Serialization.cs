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
    internal partial class AddParticipantsRequestInternal : IUtf8JsonSerializable, IJsonModel<AddParticipantsRequestInternal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AddParticipantsRequestInternal>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AddParticipantsRequestInternal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AddParticipantsRequestInternal>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AddParticipantsRequestInternal>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(SourceCallerId))
            {
                writer.WritePropertyName("sourceCallerId"u8);
                writer.WriteObjectValue(SourceCallerId);
            }
            writer.WritePropertyName("participantsToAdd"u8);
            writer.WriteStartArray();
            foreach (var item in ParticipantsToAdd)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(InvitationTimeoutInSeconds))
            {
                writer.WritePropertyName("invitationTimeoutInSeconds"u8);
                writer.WriteNumberValue(InvitationTimeoutInSeconds.Value);
            }
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

        AddParticipantsRequestInternal IJsonModel<AddParticipantsRequestInternal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AddParticipantsRequestInternal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAddParticipantsRequestInternal(document.RootElement, options);
        }

        internal static AddParticipantsRequestInternal DeserializeAddParticipantsRequestInternal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<PhoneNumberIdentifierModel> sourceCallerId = default;
            IList<CommunicationIdentifierModel> participantsToAdd = default;
            Optional<int> invitationTimeoutInSeconds = default;
            Optional<string> operationContext = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sourceCallerId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceCallerId = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("participantsToAdd"u8))
                {
                    List<CommunicationIdentifierModel> array = new List<CommunicationIdentifierModel>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(item));
                    }
                    participantsToAdd = array;
                    continue;
                }
                if (property.NameEquals("invitationTimeoutInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    invitationTimeoutInSeconds = property.Value.GetInt32();
                    continue;
                }
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
            return new AddParticipantsRequestInternal(sourceCallerId.Value, participantsToAdd, Optional.ToNullable(invitationTimeoutInSeconds), operationContext.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AddParticipantsRequestInternal>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AddParticipantsRequestInternal)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AddParticipantsRequestInternal IPersistableModel<AddParticipantsRequestInternal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AddParticipantsRequestInternal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAddParticipantsRequestInternal(document.RootElement, options);
        }

        string IPersistableModel<AddParticipantsRequestInternal>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
