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
    public partial class RecoveryPlanInMageAzureV2FailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("recoveryPointType"u8);
            writer.WriteStringValue(RecoveryPointType.ToString());
            if (Optional.IsDefined(UseMultiVmSyncPoint))
            {
                writer.WritePropertyName("useMultiVmSyncPoint"u8);
                writer.WriteStringValue(UseMultiVmSyncPoint);
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

        RecoveryPlanInMageAzureV2FailoverContent IJsonModel<RecoveryPlanInMageAzureV2FailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanInMageAzureV2FailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanInMageAzureV2FailoverContent DeserializeRecoveryPlanInMageAzureV2FailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            InMageV2RpRecoveryPointType recoveryPointType = default;
            Optional<string> useMultiVmSyncPoint = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recoveryPointType"u8))
                {
                    recoveryPointType = new InMageV2RpRecoveryPointType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("useMultiVmSyncPoint"u8))
                {
                    useMultiVmSyncPoint = property.Value.GetString();
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
            return new RecoveryPlanInMageAzureV2FailoverContent(instanceType, serializedAdditionalRawData, recoveryPointType, useMultiVmSyncPoint.Value);
        }

        BinaryData IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecoveryPlanInMageAzureV2FailoverContent IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanInMageAzureV2FailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanInMageAzureV2FailoverContent(document.RootElement, options);
        }

        string IPersistableModel<RecoveryPlanInMageAzureV2FailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
