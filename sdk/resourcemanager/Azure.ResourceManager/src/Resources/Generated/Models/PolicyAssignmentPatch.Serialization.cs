// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PolicyAssignmentPatch : IUtf8JsonSerializable, IJsonModel<PolicyAssignmentPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PolicyAssignmentPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PolicyAssignmentPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Location.HasValue)
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            if (Identity != null)
            {
                writer.WritePropertyName("identity"u8);
                JsonSerializer.Serialize(writer, Identity);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (!(ResourceSelectors is ChangeTrackingList<ResourceSelector> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("resourceSelectors"u8);
                writer.WriteStartArray();
                foreach (var item in ResourceSelectors)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Overrides is ChangeTrackingList<PolicyOverride> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("overrides"u8);
                writer.WriteStartArray();
                foreach (var item in Overrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            if (options.Format != "W" && _serializedAdditionalRawData != null)
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

        PolicyAssignmentPatch IJsonModel<PolicyAssignmentPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PolicyAssignmentPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePolicyAssignmentPatch(document.RootElement, options);
        }

        internal static PolicyAssignmentPatch DeserializePolicyAssignmentPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            Optional<ManagedServiceIdentity> identity = default;
            Optional<IList<ResourceSelector>> resourceSelectors = default;
            Optional<IList<PolicyOverride>> overrides = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("identity"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    identity = JsonSerializer.Deserialize<ManagedServiceIdentity>(property.Value.GetRawText());
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
                        if (property0.NameEquals("resourceSelectors"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<ResourceSelector> array = new List<ResourceSelector>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(ResourceSelector.DeserializeResourceSelector(item, options));
                            }
                            resourceSelectors = array;
                            continue;
                        }
                        if (property0.NameEquals("overrides"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PolicyOverride> array = new List<PolicyOverride>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PolicyOverride.DeserializePolicyOverride(item, options));
                            }
                            overrides = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PolicyAssignmentPatch(Optional.ToNullable(location), identity, Optional.ToList(resourceSelectors), Optional.ToList(overrides), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PolicyAssignmentPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentPatch)} does not support '{options.Format}' format.");
            }
        }

        PolicyAssignmentPatch IPersistableModel<PolicyAssignmentPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PolicyAssignmentPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePolicyAssignmentPatch(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PolicyAssignmentPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PolicyAssignmentPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
