// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class GovernanceAssignmentAdditionalInfo : IUtf8JsonSerializable, IJsonModel<GovernanceAssignmentAdditionalInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GovernanceAssignmentAdditionalInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GovernanceAssignmentAdditionalInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<GovernanceAssignmentAdditionalInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<GovernanceAssignmentAdditionalInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TicketNumber))
            {
                writer.WritePropertyName("ticketNumber"u8);
                writer.WriteNumberValue(TicketNumber.Value);
            }
            if (Optional.IsDefined(TicketLink))
            {
                writer.WritePropertyName("ticketLink"u8);
                writer.WriteStringValue(TicketLink);
            }
            if (Optional.IsDefined(TicketStatus))
            {
                writer.WritePropertyName("ticketStatus"u8);
                writer.WriteStringValue(TicketStatus);
            }
            if (_serializedAdditionalRawData != null && options.Format == "J")
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

        GovernanceAssignmentAdditionalInfo IJsonModel<GovernanceAssignmentAdditionalInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGovernanceAssignmentAdditionalInfo(document.RootElement, options);
        }

        internal static GovernanceAssignmentAdditionalInfo DeserializeGovernanceAssignmentAdditionalInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> ticketNumber = default;
            Optional<string> ticketLink = default;
            Optional<string> ticketStatus = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticketNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ticketNumber = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("ticketLink"u8))
                {
                    ticketLink = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketStatus"u8))
                {
                    ticketStatus = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GovernanceAssignmentAdditionalInfo(Optional.ToNullable(ticketNumber), ticketLink.Value, ticketStatus.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GovernanceAssignmentAdditionalInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        GovernanceAssignmentAdditionalInfo IPersistableModel<GovernanceAssignmentAdditionalInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GovernanceAssignmentAdditionalInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeGovernanceAssignmentAdditionalInfo(document.RootElement, options);
        }

        string IPersistableModel<GovernanceAssignmentAdditionalInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
