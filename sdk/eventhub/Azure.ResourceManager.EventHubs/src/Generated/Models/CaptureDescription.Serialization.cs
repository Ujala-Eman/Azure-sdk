// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.EventHubs.Models
{
    public partial class CaptureDescription : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Enabled))
            {
                writer.WritePropertyName("enabled");
                writer.WriteBooleanValue(Enabled.Value);
            }
            if (Optional.IsDefined(Encoding))
            {
                writer.WritePropertyName("encoding");
                writer.WriteStringValue(Encoding.Value.ToSerialString());
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds");
                writer.WriteNumberValue(IntervalInSeconds.Value);
            }
            if (Optional.IsDefined(SizeLimitInBytes))
            {
                writer.WritePropertyName("sizeLimitInBytes");
                writer.WriteNumberValue(SizeLimitInBytes.Value);
            }
            if (Optional.IsDefined(Destination))
            {
                writer.WritePropertyName("destination");
                writer.WriteObjectValue(Destination);
            }
            if (Optional.IsDefined(SkipEmptyArchives))
            {
                writer.WritePropertyName("skipEmptyArchives");
                writer.WriteBooleanValue(SkipEmptyArchives.Value);
            }
            writer.WriteEndObject();
        }

        internal static CaptureDescription DeserializeCaptureDescription(JsonElement element)
        {
            Optional<bool> enabled = default;
            Optional<EncodingCaptureDescription> encoding = default;
            Optional<int> intervalInSeconds = default;
            Optional<int> sizeLimitInBytes = default;
            Optional<Destination> destination = default;
            Optional<bool> skipEmptyArchives = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("enabled"))
                {
                    enabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("encoding"))
                {
                    encoding = property.Value.GetString().ToEncodingCaptureDescription();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"))
                {
                    intervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("sizeLimitInBytes"))
                {
                    sizeLimitInBytes = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("destination"))
                {
                    destination = Destination.DeserializeDestination(property.Value);
                    continue;
                }
                if (property.NameEquals("skipEmptyArchives"))
                {
                    skipEmptyArchives = property.Value.GetBoolean();
                    continue;
                }
            }
            return new CaptureDescription(enabled.HasValue ? enabled.Value : (bool?)null, encoding.HasValue ? encoding.Value : (EncodingCaptureDescription?)null, intervalInSeconds.HasValue ? intervalInSeconds.Value : (int?)null, sizeLimitInBytes.HasValue ? sizeLimitInBytes.Value : (int?)null, destination.HasValue ? destination.Value : null, skipEmptyArchives.HasValue ? skipEmptyArchives.Value : (bool?)null);
        }
    }
}
