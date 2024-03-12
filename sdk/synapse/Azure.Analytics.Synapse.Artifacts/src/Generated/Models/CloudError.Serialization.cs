// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Analytics.Synapse.Artifacts;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(CloudErrorConverter))]
    public partial class CloudError
    {
        internal static CloudError DeserializeCloudError(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string code = default;
            string message = default;
            string target = default;
            IReadOnlyList<CloudError> details = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("code"u8))
                        {
                            code = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("message"u8))
                        {
                            message = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("target"u8))
                        {
                            target = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("details"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<CloudError> array = new List<CloudError>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeCloudError(item));
                            }
                            details = array;
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new CloudError(code, message, target, details ?? new ChangeTrackingList<CloudError>());
        }

        internal partial class CloudErrorConverter : JsonConverter<CloudError>
        {
            public override void Write(Utf8JsonWriter writer, CloudError model, JsonSerializerOptions options)
            {
                throw new NotImplementedException();
            }
            public override CloudError Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeCloudError(document.RootElement);
            }
        }
    }
}
