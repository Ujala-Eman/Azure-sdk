// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(SapTableLinkedServiceConverter))]
    public partial class SapTableLinkedService : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (ConnectVia != null)
            {
                writer.WritePropertyName("connectVia"u8);
                writer.WriteObjectValue(ConnectVia);
            }
            if (Description != null)
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (!(Parameters is ChangeTrackingDictionary<string, ParameterSpecification> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("parameters"u8);
                writer.WriteStartObject();
                foreach (var item in Parameters)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (!(Annotations is ChangeTrackingList<object> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("annotations"u8);
                writer.WriteStartArray();
                foreach (var item in Annotations)
                {
                    if (item == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            if (Server != null)
            {
                writer.WritePropertyName("server"u8);
                writer.WriteObjectValue(Server);
            }
            if (SystemNumber != null)
            {
                writer.WritePropertyName("systemNumber"u8);
                writer.WriteObjectValue(SystemNumber);
            }
            if (ClientId != null)
            {
                writer.WritePropertyName("clientId"u8);
                writer.WriteObjectValue(ClientId);
            }
            if (Language != null)
            {
                writer.WritePropertyName("language"u8);
                writer.WriteObjectValue(Language);
            }
            if (SystemId != null)
            {
                writer.WritePropertyName("systemId"u8);
                writer.WriteObjectValue(SystemId);
            }
            if (UserName != null)
            {
                writer.WritePropertyName("userName"u8);
                writer.WriteObjectValue(UserName);
            }
            if (Password != null)
            {
                writer.WritePropertyName("password"u8);
                writer.WriteObjectValue(Password);
            }
            if (MessageServer != null)
            {
                writer.WritePropertyName("messageServer"u8);
                writer.WriteObjectValue(MessageServer);
            }
            if (MessageServerService != null)
            {
                writer.WritePropertyName("messageServerService"u8);
                writer.WriteObjectValue(MessageServerService);
            }
            if (SncMode != null)
            {
                writer.WritePropertyName("sncMode"u8);
                writer.WriteObjectValue(SncMode);
            }
            if (SncMyName != null)
            {
                writer.WritePropertyName("sncMyName"u8);
                writer.WriteObjectValue(SncMyName);
            }
            if (SncPartnerName != null)
            {
                writer.WritePropertyName("sncPartnerName"u8);
                writer.WriteObjectValue(SncPartnerName);
            }
            if (SncLibraryPath != null)
            {
                writer.WritePropertyName("sncLibraryPath"u8);
                writer.WriteObjectValue(SncLibraryPath);
            }
            if (SncQop != null)
            {
                writer.WritePropertyName("sncQop"u8);
                writer.WriteObjectValue(SncQop);
            }
            if (LogonGroup != null)
            {
                writer.WritePropertyName("logonGroup"u8);
                writer.WriteObjectValue(LogonGroup);
            }
            if (EncryptedCredential != null)
            {
                writer.WritePropertyName("encryptedCredential"u8);
                writer.WriteObjectValue(EncryptedCredential);
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static SapTableLinkedService DeserializeSapTableLinkedService(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string type = default;
            IntegrationRuntimeReference connectVia = default;
            string description = default;
            IDictionary<string, ParameterSpecification> parameters = default;
            IList<object> annotations = default;
            object server = default;
            object systemNumber = default;
            object clientId = default;
            object language = default;
            object systemId = default;
            object userName = default;
            SecretBase password = default;
            object messageServer = default;
            object messageServerService = default;
            object sncMode = default;
            object sncMyName = default;
            object sncPartnerName = default;
            object sncLibraryPath = default;
            object sncQop = default;
            object logonGroup = default;
            object encryptedCredential = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("connectVia"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    connectVia = IntegrationRuntimeReference.DeserializeIntegrationRuntimeReference(property.Value);
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, ParameterSpecification> dictionary = new Dictionary<string, ParameterSpecification>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ParameterSpecification.DeserializeParameterSpecification(property0.Value));
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("annotations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    annotations = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("server"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            server = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemNumber"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemNumber = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("clientId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("language"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            language = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("systemId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            systemId = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("userName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            userName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("password"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            password = SecretBase.DeserializeSecretBase(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("messageServer"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageServer = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("messageServerService"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageServerService = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncMode = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncMyName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncMyName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncPartnerName"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncPartnerName = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncLibraryPath"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncLibraryPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sncQop"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sncQop = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("logonGroup"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logonGroup = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("encryptedCredential"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            encryptedCredential = property0.Value.GetObject();
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new SapTableLinkedService(
                type,
                connectVia,
                description,
                parameters ?? new ChangeTrackingDictionary<string, ParameterSpecification>(),
                annotations ?? new ChangeTrackingList<object>(),
                additionalProperties,
                server,
                systemNumber,
                clientId,
                language,
                systemId,
                userName,
                password,
                messageServer,
                messageServerService,
                sncMode,
                sncMyName,
                sncPartnerName,
                sncLibraryPath,
                sncQop,
                logonGroup,
                encryptedCredential);
        }

        internal partial class SapTableLinkedServiceConverter : JsonConverter<SapTableLinkedService>
        {
            public override void Write(Utf8JsonWriter writer, SapTableLinkedService model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override SapTableLinkedService Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeSapTableLinkedService(document.RootElement);
            }
        }
    }
}
