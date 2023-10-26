// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.CallAutomation
{
    public partial class RecordingStateChanged
    {
        internal static RecordingStateChanged DeserializeRecordingStateChanged(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> recordingId = default;
            Optional<RecordingState> state = default;
            Optional<DateTimeOffset> startDateTime = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recordingId"u8))
                {
                    recordingId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new RecordingState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("startDateTime"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startDateTime = property.Value.GetDateTimeOffset("O");
                    continue;
                }
            }
            return new RecordingStateChanged(recordingId.Value, state, Optional.ToNullable(startDateTime));
        }
    }
}
