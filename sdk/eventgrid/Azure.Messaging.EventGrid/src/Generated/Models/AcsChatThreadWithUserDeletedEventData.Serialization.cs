// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsChatThreadWithUserDeletedEventDataConverter))]
    public partial class AcsChatThreadWithUserDeletedEventData
    {
        internal static AcsChatThreadWithUserDeletedEventData DeserializeAcsChatThreadWithUserDeletedEventData(JsonElement element)
        {
            Optional<CommunicationIdentifierModel> deletedByCommunicationIdentifier = default;
            Optional<DateTimeOffset> deleteTime = default;
            Optional<DateTimeOffset> createTime = default;
            Optional<long> version = default;
            Optional<CommunicationIdentifierModel> recipientCommunicationIdentifier = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("deletedByCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deletedByCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("deleteTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    deleteTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("createTime"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("recipientCommunicationIdentifier"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    recipientCommunicationIdentifier = CommunicationIdentifierModel.DeserializeCommunicationIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("transactionId"))
                {
                    transactionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("threadId"))
                {
                    threadId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsChatThreadWithUserDeletedEventData(recipientCommunicationIdentifier.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version), deletedByCommunicationIdentifier.Value, Optional.ToNullable(deleteTime));
        }

        internal partial class AcsChatThreadWithUserDeletedEventDataConverter : JsonConverter<AcsChatThreadWithUserDeletedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsChatThreadWithUserDeletedEventData model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AcsChatThreadWithUserDeletedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsChatThreadWithUserDeletedEventData(document.RootElement);
            }
        }
    }
}
