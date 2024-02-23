// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpNameAvailabilityResult : IUtf8JsonSerializable, IJsonModel<SelfHelpNameAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpNameAvailabilityResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpNameAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpNameAvailabilityResult)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (IsNameAvailable.HasValue)
            {
                writer.WritePropertyName("nameAvailable"u8);
                writer.WriteBooleanValue(IsNameAvailable.Value);
            }
            if (Reason != null)
            {
                writer.WritePropertyName("reason"u8);
                writer.WriteStringValue(Reason);
            }
            if (Message != null)
            {
                writer.WritePropertyName("message"u8);
                writer.WriteStringValue(Message);
            }
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        SelfHelpNameAvailabilityResult IJsonModel<SelfHelpNameAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SelfHelpNameAvailabilityResult)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpNameAvailabilityResult(document.RootElement, options);
        }

        internal static SelfHelpNameAvailabilityResult DeserializeSelfHelpNameAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> nameAvailable = default;
            Optional<string> reason = default;
            Optional<string> message = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nameAvailable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    nameAvailable = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("reason"u8))
                {
                    reason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpNameAvailabilityResult(Optional.ToNullable(nameAvailable), reason.Value, message.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpNameAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SelfHelpNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        SelfHelpNameAvailabilityResult IPersistableModel<SelfHelpNameAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SelfHelpNameAvailabilityResult>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSelfHelpNameAvailabilityResult(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SelfHelpNameAvailabilityResult)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SelfHelpNameAvailabilityResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
