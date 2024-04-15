// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication
{
    internal partial class CommunicationIdentifierModel : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Kind.HasValue)
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind.Value.ToString());
            }
            if (RawId != null)
            {
                writer.WritePropertyName("rawId"u8);
                writer.WriteStringValue(RawId);
            }
            if (CommunicationUser != null)
            {
                writer.WritePropertyName("communicationUser"u8);
                writer.WriteObjectValue(CommunicationUser);
            }
            if (PhoneNumber != null)
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteObjectValue(PhoneNumber);
            }
            if (MicrosoftTeamsUser != null)
            {
                writer.WritePropertyName("microsoftTeamsUser"u8);
                writer.WriteObjectValue(MicrosoftTeamsUser);
            }
            if (MicrosoftTeamsApp != null)
            {
                writer.WritePropertyName("microsoftTeamsApp"u8);
                writer.WriteObjectValue(MicrosoftTeamsApp);
            }
            writer.WriteEndObject();
        }

        internal static CommunicationIdentifierModel DeserializeCommunicationIdentifierModel(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            CommunicationIdentifierModelKind? kind = default;
            string rawId = default;
            CommunicationUserIdentifierModel communicationUser = default;
            PhoneNumberIdentifierModel phoneNumber = default;
            MicrosoftTeamsUserIdentifierModel microsoftTeamsUser = default;
            MicrosoftTeamsAppIdentifierModel microsoftTeamsApp = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    kind = new CommunicationIdentifierModelKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rawId"u8))
                {
                    rawId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("communicationUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    communicationUser = CommunicationUserIdentifierModel.DeserializeCommunicationUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("phoneNumber"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    phoneNumber = PhoneNumberIdentifierModel.DeserializePhoneNumberIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsUser"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsUser = MicrosoftTeamsUserIdentifierModel.DeserializeMicrosoftTeamsUserIdentifierModel(property.Value);
                    continue;
                }
                if (property.NameEquals("microsoftTeamsApp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftTeamsApp = MicrosoftTeamsAppIdentifierModel.DeserializeMicrosoftTeamsAppIdentifierModel(property.Value);
                    continue;
                }
            }
            return new CommunicationIdentifierModel(
                kind,
                rawId,
                communicationUser,
                phoneNumber,
                microsoftTeamsUser,
                microsoftTeamsApp);
        }
    }
}
