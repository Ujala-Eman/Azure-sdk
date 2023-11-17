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
    public partial class SecurityInsightsProcessEntity : IUtf8JsonSerializable, IJsonModel<SecurityInsightsProcessEntity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityInsightsProcessEntity>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityInsightsProcessEntity>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityInsightsProcessEntity>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityInsightsProcessEntity>)} interface");
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
                if (Optional.IsDefined(AccountEntityId))
                {
                    writer.WritePropertyName("accountEntityId"u8);
                    writer.WriteStringValue(AccountEntityId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CommandLine))
                {
                    writer.WritePropertyName("commandLine"u8);
                    writer.WriteStringValue(CommandLine);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    writer.WritePropertyName("creationTimeUtc"u8);
                    writer.WriteStringValue(CreatedOn.Value, "O");
                }
            }
            if (Optional.IsDefined(ElevationToken))
            {
                writer.WritePropertyName("elevationToken"u8);
                writer.WriteStringValue(ElevationToken.Value.ToSerialString());
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
                if (Optional.IsDefined(HostLogonSessionEntityId))
                {
                    writer.WritePropertyName("hostLogonSessionEntityId"u8);
                    writer.WriteStringValue(HostLogonSessionEntityId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ImageFileEntityId))
                {
                    writer.WritePropertyName("imageFileEntityId"u8);
                    writer.WriteStringValue(ImageFileEntityId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ParentProcessEntityId))
                {
                    writer.WritePropertyName("parentProcessEntityId"u8);
                    writer.WriteStringValue(ParentProcessEntityId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProcessId))
                {
                    writer.WritePropertyName("processId"u8);
                    writer.WriteStringValue(ProcessId);
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

        SecurityInsightsProcessEntity IJsonModel<SecurityInsightsProcessEntity>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityInsightsProcessEntity(document.RootElement, options);
        }

        internal static SecurityInsightsProcessEntity DeserializeSecurityInsightsProcessEntity(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<string> accountEntityId = default;
            Optional<string> commandLine = default;
            Optional<DateTimeOffset> creationTimeUtc = default;
            Optional<SecurityInsightsProcessElevationToken> elevationToken = default;
            Optional<string> hostEntityId = default;
            Optional<string> hostLogonSessionEntityId = default;
            Optional<string> imageFileEntityId = default;
            Optional<string> parentProcessEntityId = default;
            Optional<string> processId = default;
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
                        if (property0.NameEquals("accountEntityId"u8))
                        {
                            accountEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("commandLine"u8))
                        {
                            commandLine = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("creationTimeUtc"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            creationTimeUtc = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("elevationToken"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            elevationToken = property0.Value.GetString().ToSecurityInsightsProcessElevationToken();
                            continue;
                        }
                        if (property0.NameEquals("hostEntityId"u8))
                        {
                            hostEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("hostLogonSessionEntityId"u8))
                        {
                            hostLogonSessionEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("imageFileEntityId"u8))
                        {
                            imageFileEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("parentProcessEntityId"u8))
                        {
                            parentProcessEntityId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("processId"u8))
                        {
                            processId = property0.Value.GetString();
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
            return new SecurityInsightsProcessEntity(id, name, type, systemData.Value, kind, serializedAdditionalRawData, Optional.ToDictionary(additionalData), friendlyName.Value, accountEntityId.Value, commandLine.Value, Optional.ToNullable(creationTimeUtc), Optional.ToNullable(elevationToken), hostEntityId.Value, hostLogonSessionEntityId.Value, imageFileEntityId.Value, parentProcessEntityId.Value, processId.Value);
        }

        BinaryData IPersistableModel<SecurityInsightsProcessEntity>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityInsightsProcessEntity IPersistableModel<SecurityInsightsProcessEntity>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityInsightsProcessEntity)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityInsightsProcessEntity(document.RootElement, options);
        }

        string IPersistableModel<SecurityInsightsProcessEntity>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
