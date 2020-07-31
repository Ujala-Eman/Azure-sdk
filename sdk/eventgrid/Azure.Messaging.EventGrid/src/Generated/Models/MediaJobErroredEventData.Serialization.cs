// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.Messaging.EventGrid.Models;

namespace Azure.Messaging.EventGrid.Models.SystemEvents
{
    public partial class MediaJobErroredEventData
    {
        internal static MediaJobErroredEventData DeserializeMediaJobErroredEventData(JsonElement element)
        {
            Optional<IReadOnlyList<MediaJobOutput>> outputs = default;
            Optional<MediaJobState> previousState = default;
            Optional<MediaJobState> state = default;
            Optional<IReadOnlyDictionary<string, string>> correlationData = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("outputs"))
                {
                    List<MediaJobOutput> array = new List<MediaJobOutput>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MediaJobOutput.DeserializeMediaJobOutput(item));
                    }
                    outputs = array;
                    continue;
                }
                if (property.NameEquals("previousState"))
                {
                    previousState = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("state"))
                {
                    state = property.Value.GetString().ToMediaJobState();
                    continue;
                }
                if (property.NameEquals("correlationData"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    correlationData = dictionary;
                    continue;
                }
            }
            return new MediaJobErroredEventData(Optional.ToNullable(previousState), Optional.ToNullable(state), Optional.ToDictionary(correlationData), Optional.ToList(outputs));
        }
    }
}
