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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class VMwareCbtTestMigrateContent : IUtf8JsonSerializable, IJsonModel<VMwareCbtTestMigrateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VMwareCbtTestMigrateContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VMwareCbtTestMigrateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<VMwareCbtTestMigrateContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<VMwareCbtTestMigrateContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
            writer.WritePropertyName("networkId"u8);
            writer.WriteStringValue(NetworkId);
            if (Optional.IsCollectionDefined(VmNics))
            {
                writer.WritePropertyName("vmNics"u8);
                writer.WriteStartArray();
                foreach (var item in VmNics)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(OSUpgradeVersion))
            {
                writer.WritePropertyName("osUpgradeVersion"u8);
                writer.WriteStringValue(OSUpgradeVersion);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        VMwareCbtTestMigrateContent IJsonModel<VMwareCbtTestMigrateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtTestMigrateContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVMwareCbtTestMigrateContent(document.RootElement, options);
        }

        internal static VMwareCbtTestMigrateContent DeserializeVMwareCbtTestMigrateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryPointId = default;
            ResourceIdentifier networkId = default;
            Optional<IList<VMwareCbtNicContent>> vmNics = default;
            Optional<string> osUpgradeVersion = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointId"u8))
                {
                    recoveryPointId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("networkId"u8))
                {
                    networkId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmNics"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<VMwareCbtNicContent> array = new List<VMwareCbtNicContent>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(VMwareCbtNicContent.DeserializeVMwareCbtNicContent(item));
                    }
                    vmNics = array;
                    continue;
                }
                if (property.NameEquals("osUpgradeVersion"u8))
                {
                    osUpgradeVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VMwareCbtTestMigrateContent(instanceType, serializedAdditionalRawData, recoveryPointId, networkId, Optional.ToList(vmNics), osUpgradeVersion.Value);
        }

        BinaryData IPersistableModel<VMwareCbtTestMigrateContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtTestMigrateContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        VMwareCbtTestMigrateContent IPersistableModel<VMwareCbtTestMigrateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(VMwareCbtTestMigrateContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeVMwareCbtTestMigrateContent(document.RootElement, options);
        }

        string IPersistableModel<VMwareCbtTestMigrateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
