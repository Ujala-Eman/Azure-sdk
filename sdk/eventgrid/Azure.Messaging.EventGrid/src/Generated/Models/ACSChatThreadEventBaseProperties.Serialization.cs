// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    public partial class ACSChatThreadEventBaseProperties
    {
        internal static ACSChatThreadEventBaseProperties DeserializeACSChatThreadEventBaseProperties(JsonElement element)
        {
            Optional<DateTimeOffset> createTime = default;
            Optional<int> version = default;
            Optional<string> recipientId = default;
            Optional<string> transactionId = default;
            Optional<string> threadId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("createTime"))
                {
                    createTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("recipientId"))
                {
                    recipientId = property.Value.GetString();
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
            return new ACSChatThreadEventBaseProperties(recipientId.Value, transactionId.Value, threadId.Value, Optional.ToNullable(createTime), Optional.ToNullable(version));
        }
    }
}
