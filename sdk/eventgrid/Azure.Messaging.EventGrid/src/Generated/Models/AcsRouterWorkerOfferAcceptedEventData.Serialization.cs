// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Messaging.EventGrid;

namespace Azure.Messaging.EventGrid.SystemEvents
{
    [JsonConverter(typeof(AcsRouterWorkerOfferAcceptedEventDataConverter))]
    public partial class AcsRouterWorkerOfferAcceptedEventData
    {
        internal static AcsRouterWorkerOfferAcceptedEventData DeserializeAcsRouterWorkerOfferAcceptedEventData(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string queueId = default;
            string offerId = default;
            string assignmentId = default;
            int? jobPriority = default;
            IReadOnlyDictionary<string, string> workerLabels = default;
            IReadOnlyDictionary<string, string> workerTags = default;
            IReadOnlyDictionary<string, string> jobLabels = default;
            IReadOnlyDictionary<string, string> jobTags = default;
            string workerId = default;
            string jobId = default;
            string channelReference = default;
            string channelId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("queueId"u8))
                {
                    queueId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offerId"u8))
                {
                    offerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("assignmentId"u8))
                {
                    assignmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobPriority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("workerLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("workerTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    workerTags = dictionary;
                    continue;
                }
                if (property.NameEquals("jobLabels"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobLabels = dictionary;
                    continue;
                }
                if (property.NameEquals("jobTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    jobTags = dictionary;
                    continue;
                }
                if (property.NameEquals("workerId"u8))
                {
                    workerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobId"u8))
                {
                    jobId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelReference"u8))
                {
                    channelReference = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("channelId"u8))
                {
                    channelId = property.Value.GetString();
                    continue;
                }
            }
            return new AcsRouterWorkerOfferAcceptedEventData(
                jobId,
                channelReference,
                channelId,
                workerId,
                queueId,
                offerId,
                assignmentId,
                jobPriority,
                workerLabels ?? new ChangeTrackingDictionary<string, string>(),
                workerTags ?? new ChangeTrackingDictionary<string, string>(),
                jobLabels ?? new ChangeTrackingDictionary<string, string>(),
                jobTags ?? new ChangeTrackingDictionary<string, string>());
        }

        internal partial class AcsRouterWorkerOfferAcceptedEventDataConverter : JsonConverter<AcsRouterWorkerOfferAcceptedEventData>
        {
            public override void Write(Utf8JsonWriter writer, AcsRouterWorkerOfferAcceptedEventData model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override AcsRouterWorkerOfferAcceptedEventData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAcsRouterWorkerOfferAcceptedEventData(document.RootElement);
            }
        }
    }
}
