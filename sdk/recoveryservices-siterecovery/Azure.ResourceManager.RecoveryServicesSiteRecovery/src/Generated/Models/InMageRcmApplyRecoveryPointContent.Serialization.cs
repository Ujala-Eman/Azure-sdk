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
    public partial class InMageRcmApplyRecoveryPointContent : IUtf8JsonSerializable, IJsonModel<InMageRcmApplyRecoveryPointContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageRcmApplyRecoveryPointContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageRcmApplyRecoveryPointContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<InMageRcmApplyRecoveryPointContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<InMageRcmApplyRecoveryPointContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointId"u8);
            writer.WriteStringValue(RecoveryPointId);
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

        InMageRcmApplyRecoveryPointContent IJsonModel<InMageRcmApplyRecoveryPointContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmApplyRecoveryPointContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageRcmApplyRecoveryPointContent(document.RootElement, options);
        }

        internal static InMageRcmApplyRecoveryPointContent DeserializeInMageRcmApplyRecoveryPointContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier recoveryPointId = default;
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
            return new InMageRcmApplyRecoveryPointContent(instanceType, serializedAdditionalRawData, recoveryPointId);
        }

        BinaryData IPersistableModel<InMageRcmApplyRecoveryPointContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmApplyRecoveryPointContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InMageRcmApplyRecoveryPointContent IPersistableModel<InMageRcmApplyRecoveryPointContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageRcmApplyRecoveryPointContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInMageRcmApplyRecoveryPointContent(document.RootElement, options);
        }

        string IPersistableModel<InMageRcmApplyRecoveryPointContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
