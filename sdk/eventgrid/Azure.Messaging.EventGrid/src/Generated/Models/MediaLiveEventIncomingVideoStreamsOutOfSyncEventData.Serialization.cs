// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    public partial class MediaLiveEventIncomingVideoStreamsOutOfSyncEventData
    {
        internal static MediaLiveEventIncomingVideoStreamsOutOfSyncEventData DeserializeMediaLiveEventIncomingVideoStreamsOutOfSyncEventData(JsonElement element)
        {
            Optional<string> firstTimestamp = default;
            Optional<string> firstDuration = default;
            Optional<string> secondTimestamp = default;
            Optional<string> secondDuration = default;
            Optional<string> timescale = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("firstTimestamp"))
                {
                    firstTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("firstDuration"))
                {
                    firstDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondTimestamp"))
                {
                    secondTimestamp = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("secondDuration"))
                {
                    secondDuration = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("timescale"))
                {
                    timescale = property.Value.GetString();
                    continue;
                }
            }
            return new MediaLiveEventIncomingVideoStreamsOutOfSyncEventData(firstTimestamp.Value, firstDuration.Value, secondTimestamp.Value, secondDuration.Value, timescale.Value);
        }
    }
}
