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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class SecurityInsightsAccountEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsAccountEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsAccountEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsAccountEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityInsightsAccountEntity>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityInsightsAccountEntity>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(AdditionalData))
                {
                    writer.WritePropertyName("additionalData"u8);
                    writer.WriteStartObject();
                    foreach (var item in AdditionalData)
                    {
                        writer.WritePropertyName(item.Key);
                        if (item.Value == null)
                        {
                            writer.WriteNullValue();
                            continue;
                        }
#if NET6_0_OR_GREATER
				writer.WriteRawValue(item.Value);
#else
                        using (JsonDocument document = JsonDocument.Parse(item.Value))
                        {
                            JsonSerializer.Serialize(writer, document.RootElement);
                        }
#endif
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FriendlyName))
                {
                    writer.WritePropertyName("friendlyName"u8);
                    writer.WriteStringValue(FriendlyName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AadTenantId))
                {
                    writer.WritePropertyName("aadTenantId"u8);
                    writer.WriteStringValue(AadTenantId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AadUserId))
                {
                    writer.WritePropertyName("aadUserId"u8);
                    writer.WriteStringValue(AadUserId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(AccountName))
                {
                    writer.WritePropertyName("accountName"u8);
                    writer.WriteStringValue(AccountName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DisplayName))
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(HostEntityId))
                {
                    writer.WritePropertyName("hostEntityId"u8);
                    writer.WriteStringValue(HostEntityId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsDomainJoined))
                {
                    writer.WritePropertyName("isDomainJoined"u8);
                    writer.WriteBooleanValue(IsDomainJoined.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NtDomain))
                {
                    writer.WritePropertyName("ntDomain"u8);
                    writer.WriteStringValue(NtDomain);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ObjectGuid))
                {
                    writer.WritePropertyName("objectGuid"u8);
                    writer.WriteStringValue(ObjectGuid.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Puid))
                {
                    writer.WritePropertyName("puid"u8);
                    writer.WriteStringValue(Puid);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Sid))
                {
                    writer.WritePropertyName("sid"u8);
                    writer.WriteStringValue(Sid);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(UpnSuffix))
                {
                    writer.WritePropertyName("upnSuffix"u8);
                    writer.WriteStringValue(UpnSuffix);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DnsDomain))
                {
                    writer.WritePropertyName("dnsDomain"u8);
                    writer.WriteStringValue(DnsDomain);
                }
            }
            writer.WriteEndObject();
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

        SecurityInsightsAccountEntity IJsonModel<SecurityInsightsAccountEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsAccountEntity(document.RootElement, options);
        }

        internal static SecurityInsightsAccountEntity DeserializeSecurityInsightsAccountEntity(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            SecurityInsightsEntityKind kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<IReadOnlyDictionary<string, BinaryData>> additionalData = default;
            Optional<string> friendlyName = default;
            Optional<string> aadTenantId = default;
            Optional<string> aadUserId = default;
            Optional<string> accountName = default;
            Optional<string> displayName = default;
            Optional<string> hostEntityId = default;
            Optional<bool> isDomainJoined = default;
            Optional<string> ntDomain = default;
            Optional<Guid> objectGuid = default;
            Optional<string> puid = default;
            Optional<string> sid = default;
            Optional<string> upnSuffix = default;
            Optional<string> dnsDomain = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = new SecurityInsightsEntityKind(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("additionalData"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, BinaryData> dictionary = new Dictionary<string, BinaryData>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, BinaryData.FromString(property1.Value.GetRawText()));
                                }
                            }
                            additionalData = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("friendlyName"u8))
                        {
                            friendlyName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadTenantId"u8))
                        {
                            aadTenantId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("aadUserId"u8))
                        {
                            aadUserId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("accountName"u8))
                        {
                            accountName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isDomainJoined"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isDomainJoined = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("ntDomain"u8))
                        {
                            ntDomain = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("objectGuid"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            objectGuid = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("puid"u8))
                        {
                            puid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sid"u8))
                        {
                            sid = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("upnSuffix"u8))
                        {
                            upnSuffix = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("dnsDomain"u8))
                        {
                            dnsDomain = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityInsightsAccountEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, aadTenantId.Value, aadUserId.Value, accountName.Value, displayName.Value, hostEntityId.Value, Optional.ToNullable(isDomainJoined), ntDomain.Value, Optional.ToNullable(objectGuid), puid.Value, sid.Value, upnSuffix.Value, dnsDomain.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsAccountEntity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsAccountEntity IPersistableModel<SecurityInsightsAccountEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsAccountEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsAccountEntity(document.RootElement, options);
        }

        string IPersistableModel<SecurityInsightsAccountEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
