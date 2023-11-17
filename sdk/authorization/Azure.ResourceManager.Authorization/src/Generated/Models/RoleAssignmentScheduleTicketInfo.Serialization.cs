// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleAssignmentScheduleTicketInfo : IUtf8JsonSerializable, IJsonModel<RoleAssignmentScheduleTicketInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RoleAssignmentScheduleTicketInfo>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<RoleAssignmentScheduleTicketInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RoleAssignmentScheduleTicketInfo>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RoleAssignmentScheduleTicketInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(TicketNumber))
            {
                writer.WritePropertyName("ticketNumber"u8);
                writer.WriteStringValue(TicketNumber);
            }
            if (Optional.IsDefined(TicketSystem))
            {
                writer.WritePropertyName("ticketSystem"u8);
                writer.WriteStringValue(TicketSystem);
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

        RoleAssignmentScheduleTicketInfo IJsonModel<RoleAssignmentScheduleTicketInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleAssignmentScheduleTicketInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentScheduleTicketInfo(document.RootElement, options);
        }

        internal static RoleAssignmentScheduleTicketInfo DeserializeRoleAssignmentScheduleTicketInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ticketNumber = default;
            Optional<string> ticketSystem = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ticketNumber"u8))
                {
                    ticketNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ticketSystem"u8))
                {
                    ticketSystem = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RoleAssignmentScheduleTicketInfo(ticketNumber.Value, ticketSystem.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RoleAssignmentScheduleTicketInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleAssignmentScheduleTicketInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RoleAssignmentScheduleTicketInfo IPersistableModel<RoleAssignmentScheduleTicketInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RoleAssignmentScheduleTicketInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRoleAssignmentScheduleTicketInfo(document.RootElement, options);
        }

        string IPersistableModel<RoleAssignmentScheduleTicketInfo>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
