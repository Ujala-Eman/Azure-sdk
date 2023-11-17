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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class ManagedRuleSetDefinition : IUtf8JsonSerializable, IJsonModel<ManagedRuleSetDefinition>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedRuleSetDefinition>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ManagedRuleSetDefinition>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagedRuleSetDefinition>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagedRuleSetDefinition>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku"u8);
                writer.WriteObjectValue(Sku);
            }
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
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RuleSetType))
                {
                    writer.WritePropertyName("ruleSetType"u8);
                    writer.WriteStringValue(RuleSetType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RuleSetVersion))
                {
                    writer.WritePropertyName("ruleSetVersion"u8);
                    writer.WriteStringValue(RuleSetVersion);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(RuleGroups))
                {
                    writer.WritePropertyName("ruleGroups"u8);
                    writer.WriteStartArray();
                    foreach (var item in RuleGroups)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
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

        ManagedRuleSetDefinition IJsonModel<ManagedRuleSetDefinition>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedRuleSetDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedRuleSetDefinition(document.RootElement, options);
        }

        internal static ManagedRuleSetDefinition DeserializeManagedRuleSetDefinition(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<CdnSku> sku = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> provisioningState = default;
            Optional<string> ruleSetType = default;
            Optional<string> ruleSetVersion = default;
            Optional<IReadOnlyList<ManagedRuleGroupDefinition>> ruleGroups = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("sku"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sku = CdnSku.DeserializeCdnSku(property.Value);
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
                        if (property0.NameEquals("provisioningState"u8))
                        {
                            provisioningState = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetType"u8))
                        {
                            ruleSetType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleSetVersion"u8))
                        {
                            ruleSetVersion = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("ruleGroups"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ManagedRuleGroupDefinition> array = new List<ManagedRuleGroupDefinition>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ManagedRuleGroupDefinition.DeserializeManagedRuleGroupDefinition(item));
                            }
                            ruleGroups = array;
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
            return new ManagedRuleSetDefinition(id, name, type, systemData.Value, sku.Value, provisioningState.Value, ruleSetType.Value, ruleSetVersion.Value, Optional.ToList(ruleGroups), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedRuleSetDefinition>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedRuleSetDefinition)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedRuleSetDefinition IPersistableModel<ManagedRuleSetDefinition>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedRuleSetDefinition)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedRuleSetDefinition(document.RootElement, options);
        }

        string IPersistableModel<ManagedRuleSetDefinition>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
