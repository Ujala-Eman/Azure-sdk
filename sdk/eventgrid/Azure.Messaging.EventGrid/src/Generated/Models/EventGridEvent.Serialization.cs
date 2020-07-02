// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models
{
    public partial class EventGridEvent : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id");
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Topic))
            {
                writer.WritePropertyName("topic");
                writer.WriteStringValue(Topic);
            }
            writer.WritePropertyName("subject");
            writer.WriteStringValue(Subject);
            writer.WritePropertyName("data");
            writer.WriteObjectValue(Data);
            writer.WritePropertyName("eventType");
            writer.WriteStringValue(EventType);
            writer.WritePropertyName("eventTime");
            writer.WriteStringValue(EventTime, "O");
            if (Optional.IsDefined(MetadataVersion))
            {
                writer.WritePropertyName("metadataVersion");
                writer.WriteStringValue(MetadataVersion);
            }
            writer.WritePropertyName("dataVersion");
            writer.WriteStringValue(DataVersion);
            writer.WriteEndObject();
        }
    }
}
