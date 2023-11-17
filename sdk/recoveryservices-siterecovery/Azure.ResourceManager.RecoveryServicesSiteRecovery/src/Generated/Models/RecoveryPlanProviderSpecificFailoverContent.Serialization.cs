// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownRecoveryPlanProviderSpecificFailoverContent))]
    public partial class RecoveryPlanProviderSpecificFailoverContent : IUtf8JsonSerializable, IJsonModel<RecoveryPlanProviderSpecificFailoverContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPlanProviderSpecificFailoverContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPlanProviderSpecificFailoverContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RecoveryPlanProviderSpecificFailoverContent>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RecoveryPlanProviderSpecificFailoverContent>)} interface");
            }

            writer.WriteStartObject();
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

        RecoveryPlanProviderSpecificFailoverContent IJsonModel<RecoveryPlanProviderSpecificFailoverContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanProviderSpecificFailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPlanProviderSpecificFailoverContent(document.RootElement, options);
        }

        internal static RecoveryPlanProviderSpecificFailoverContent DeserializeRecoveryPlanProviderSpecificFailoverContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "A2A": return RecoveryPlanA2AFailoverContent.DeserializeRecoveryPlanA2AFailoverContent(element);
                    case "HyperVReplicaAzure": return RecoveryPlanHyperVReplicaAzureFailoverContent.DeserializeRecoveryPlanHyperVReplicaAzureFailoverContent(element);
                    case "HyperVReplicaAzureFailback": return RecoveryPlanHyperVReplicaAzureFailbackContent.DeserializeRecoveryPlanHyperVReplicaAzureFailbackContent(element);
                    case "InMage": return RecoveryPlanInMageFailoverContent.DeserializeRecoveryPlanInMageFailoverContent(element);
                    case "InMageAzureV2": return RecoveryPlanInMageAzureV2FailoverContent.DeserializeRecoveryPlanInMageAzureV2FailoverContent(element);
                    case "InMageRcm": return RecoveryPlanInMageRcmFailoverContent.DeserializeRecoveryPlanInMageRcmFailoverContent(element);
                    case "InMageRcmFailback": return RecoveryPlanInMageRcmFailbackFailoverContent.DeserializeRecoveryPlanInMageRcmFailbackFailoverContent(element);
                }
            }
            return UnknownRecoveryPlanProviderSpecificFailoverContent.DeserializeUnknownRecoveryPlanProviderSpecificFailoverContent(element);
        }

        BinaryData IPersistableModel<RecoveryPlanProviderSpecificFailoverContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanProviderSpecificFailoverContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecoveryPlanProviderSpecificFailoverContent IPersistableModel<RecoveryPlanProviderSpecificFailoverContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPlanProviderSpecificFailoverContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecoveryPlanProviderSpecificFailoverContent(document.RootElement, options);
        }

        string IPersistableModel<RecoveryPlanProviderSpecificFailoverContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
