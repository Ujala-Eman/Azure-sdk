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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class ManagementLockData : IUtf8JsonSerializable, IJsonModel<ManagementLockData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagementLockData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagementLockData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagementLockData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagementLockData>)} interface");
            }

            writer.WriteStartObject();
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
            writer.WritePropertyName("level"u8);
            writer.WriteStringValue(Level.ToString());
            if (Optional.IsDefined(Notes))
            {
                writer.WritePropertyName("notes"u8);
                writer.WriteStringValue(Notes);
            }
            if (Optional.IsCollectionDefined(Owners))
            {
                writer.WritePropertyName("owners"u8);
                writer.WriteStartArray();
                foreach (var item in Owners)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ManagementLockData IJsonModel<ManagementLockData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementLockData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagementLockData(document.RootElement, options);
        }

        internal static ManagementLockData DeserializeManagementLockData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            ManagementLockLevel level = default;
            Optional<string> notes = default;
            Optional<IList<ManagementLockOwner>> owners = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
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
                        if (property0.NameEquals("level"u8))
                        {
                            level = new ManagementLockLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("notes"u8))
                        {
                            notes = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("owners"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagementLockOwner> array = new List<ManagementLockOwner>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagementLockOwner.DeserializeManagementLockOwner(item));
                            }
                            owners = array;
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
            return new ManagementLockData(id, name, type, systemData.Value, level, notes.Value, Optional.ToList(owners), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagementLockData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementLockData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagementLockData IPersistableModel<ManagementLockData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagementLockData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagementLockData(document.RootElement, options);
        }

        string IPersistableModel<ManagementLockData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
