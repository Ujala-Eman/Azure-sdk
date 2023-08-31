// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;

namespace Azure.ResourceManager.Authorization.Models
{
    public partial class RoleAssignmentScheduleTicketInfo : IUtf8JsonSerializable, IModelJsonSerializable<RoleAssignmentScheduleTicketInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<RoleAssignmentScheduleTicketInfo>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<RoleAssignmentScheduleTicketInfo>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

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
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static RoleAssignmentScheduleTicketInfo DeserializeRoleAssignmentScheduleTicketInfo(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> ticketNumber = default;
            Optional<string> ticketSystem = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
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
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new RoleAssignmentScheduleTicketInfo(ticketNumber.Value, ticketSystem.Value, rawData);
        }

        RoleAssignmentScheduleTicketInfo IModelJsonSerializable<RoleAssignmentScheduleTicketInfo>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeRoleAssignmentScheduleTicketInfo(doc.RootElement, options);
        }

        BinaryData IModelSerializable<RoleAssignmentScheduleTicketInfo>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        RoleAssignmentScheduleTicketInfo IModelSerializable<RoleAssignmentScheduleTicketInfo>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeRoleAssignmentScheduleTicketInfo(doc.RootElement, options);
        }

        public static implicit operator RequestContent(RoleAssignmentScheduleTicketInfo model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        public static explicit operator RoleAssignmentScheduleTicketInfo(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeRoleAssignmentScheduleTicketInfo(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
