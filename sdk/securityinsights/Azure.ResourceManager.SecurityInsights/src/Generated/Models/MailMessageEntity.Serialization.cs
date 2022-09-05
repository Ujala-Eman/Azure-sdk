// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class MailMessageEntity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind.ToString());
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(BodyFingerprintBin1))
            {
                writer.WritePropertyName("bodyFingerprintBin1");
                writer.WriteNumberValue(BodyFingerprintBin1.Value);
            }
            if (Optional.IsDefined(BodyFingerprintBin2))
            {
                writer.WritePropertyName("bodyFingerprintBin2");
                writer.WriteNumberValue(BodyFingerprintBin2.Value);
            }
            if (Optional.IsDefined(BodyFingerprintBin3))
            {
                writer.WritePropertyName("bodyFingerprintBin3");
                writer.WriteNumberValue(BodyFingerprintBin3.Value);
            }
            if (Optional.IsDefined(BodyFingerprintBin4))
            {
                writer.WritePropertyName("bodyFingerprintBin4");
                writer.WriteNumberValue(BodyFingerprintBin4.Value);
            }
            if (Optional.IsDefined(BodyFingerprintBin5))
            {
                writer.WritePropertyName("bodyFingerprintBin5");
                writer.WriteNumberValue(BodyFingerprintBin5.Value);
            }
            if (Optional.IsDefined(AntispamDirection))
            {
                writer.WritePropertyName("antispamDirection");
                writer.WriteStringValue(AntispamDirection.Value.ToString());
            }
            if (Optional.IsDefined(DeliveryAction))
            {
                writer.WritePropertyName("deliveryAction");
                writer.WriteStringValue(DeliveryAction.Value.ToSerialString());
            }
            if (Optional.IsDefined(DeliveryLocation))
            {
                writer.WritePropertyName("deliveryLocation");
                writer.WriteStringValue(DeliveryLocation.Value.ToSerialString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static MailMessageEntity DeserializeMailMessageEntity(JsonElement element)
        {
            EntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<IReadOnlyList<string>> fileEntityIds = default;
            Optional<string> recipient = default;
            Optional<IReadOnlyList<string>> urls = default;
            Optional<IReadOnlyList<string>> threats = default;
            Optional<string> p1Sender = default;
            Optional<string> p1SenderDisplayName = default;
            Optional<string> p1SenderDomain = default;
            Optional<string> senderIP = default;
            Optional<string> p2Sender = default;
            Optional<string> p2SenderDisplayName = default;
            Optional<string> p2SenderDomain = default;
            Optional<DateTimeOffset> receiveDate = default;
            Optional<Guid> networkMessageId = default;
            Optional<string> internetMessageId = default;
            Optional<string> subject = default;
            Optional<string> language = default;
            Optional<IReadOnlyList<string>> threatDetectionMethods = default;
            Optional<int> bodyFingerprintBin1 = default;
            Optional<int> bodyFingerprintBin2 = default;
            Optional<int> bodyFingerprintBin3 = default;
            Optional<int> bodyFingerprintBin4 = default;
            Optional<int> bodyFingerprintBin5 = default;
            Optional<AntispamMailDirection> antispamDirection = default;
            Optional<DeliveryAction> deliveryAction = default;
            Optional<DeliveryLocation> deliveryLocation = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"))
                {
                    kind = new EntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.ToString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("fileEntityIds"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            fileEntityIds = array;
                            continue;
                        }
                        if (property0.NameEquals("recipient"))
                        {
                            recipient = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("urls"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            urls = array;
                            continue;
                        }
                        if (property0.NameEquals("threats"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threats = array;
                            continue;
                        }
                        if (property0.NameEquals("p1Sender"))
                        {
                            p1Sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p1SenderDisplayName"))
                        {
                            p1SenderDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p1SenderDomain"))
                        {
                            p1SenderDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("senderIP"))
                        {
                            senderIP = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p2Sender"))
                        {
                            p2Sender = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p2SenderDisplayName"))
                        {
                            p2SenderDisplayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("p2SenderDomain"))
                        {
                            p2SenderDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("receiveDate"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            receiveDate = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("networkMessageId"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            networkMessageId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("internetMessageId"))
                        {
                            internetMessageId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("subject"))
                        {
                            subject = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("language"))
                        {
                            language = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("threatDetectionMethods"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            List<string> array = new List<string>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(item.GetString());
                            }
                            threatDetectionMethods = array;
                            continue;
                        }
                        if (property0.NameEquals("bodyFingerprintBin1"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bodyFingerprintBin1 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bodyFingerprintBin2"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bodyFingerprintBin2 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bodyFingerprintBin3"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bodyFingerprintBin3 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bodyFingerprintBin4"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bodyFingerprintBin4 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("bodyFingerprintBin5"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            bodyFingerprintBin5 = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("antispamDirection"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            antispamDirection = new AntispamMailDirection(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deliveryAction"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deliveryAction = property0.Value.GetString().ToDeliveryAction();
                            continue;
                        }
                        if (property0.NameEquals("deliveryLocation"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            deliveryLocation = property0.Value.GetString().ToDeliveryLocation();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new MailMessageEntity(id, name, type, systemData.Value, kind, Optional.ToDictionary(additionalData), friendlyName.Value, Optional.ToList(fileEntityIds), recipient.Value, Optional.ToList(urls), Optional.ToList(threats), p1Sender.Value, p1SenderDisplayName.Value, p1SenderDomain.Value, senderIP.Value, p2Sender.Value, p2SenderDisplayName.Value, p2SenderDomain.Value, Optional.ToNullable(receiveDate), Optional.ToNullable(networkMessageId), internetMessageId.Value, subject.Value, language.Value, Optional.ToList(threatDetectionMethods), Optional.ToNullable(bodyFingerprintBin1), Optional.ToNullable(bodyFingerprintBin2), Optional.ToNullable(bodyFingerprintBin3), Optional.ToNullable(bodyFingerprintBin4), Optional.ToNullable(bodyFingerprintBin5), Optional.ToNullable(antispamDirection), Optional.ToNullable(deliveryAction), Optional.ToNullable(deliveryLocation));
        }
    }
}
