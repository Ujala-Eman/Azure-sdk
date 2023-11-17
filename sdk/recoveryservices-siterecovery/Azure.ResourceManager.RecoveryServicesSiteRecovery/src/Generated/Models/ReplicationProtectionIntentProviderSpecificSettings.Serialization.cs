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
    [PersistableModelProxy(typeof(UnknownReplicationProtectionIntentProviderSpecificSettings))]
    public partial class ReplicationProtectionIntentProviderSpecificSettings : IUtf8JsonSerializable, IJsonModel<ReplicationProtectionIntentProviderSpecificSettings>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ReplicationProtectionIntentProviderSpecificSettings>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ReplicationProtectionIntentProviderSpecificSettings>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ReplicationProtectionIntentProviderSpecificSettings>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ReplicationProtectionIntentProviderSpecificSettings>)} interface");
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

        ReplicationProtectionIntentProviderSpecificSettings IJsonModel<ReplicationProtectionIntentProviderSpecificSettings>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProtectionIntentProviderSpecificSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeReplicationProtectionIntentProviderSpecificSettings(document.RootElement, options);
        }

        internal static ReplicationProtectionIntentProviderSpecificSettings DeserializeReplicationProtectionIntentProviderSpecificSettings(JsonElement element, ModelReaderWriterOptions options = null)
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
                    case "A2A": return A2AReplicationIntentDetails.DeserializeA2AReplicationIntentDetails(element);
                }
            }
            return UnknownReplicationProtectionIntentProviderSpecificSettings.DeserializeUnknownReplicationProtectionIntentProviderSpecificSettings(element);
        }

        BinaryData IPersistableModel<ReplicationProtectionIntentProviderSpecificSettings>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProtectionIntentProviderSpecificSettings)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ReplicationProtectionIntentProviderSpecificSettings IPersistableModel<ReplicationProtectionIntentProviderSpecificSettings>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ReplicationProtectionIntentProviderSpecificSettings)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeReplicationProtectionIntentProviderSpecificSettings(document.RootElement, options);
        }

        string IPersistableModel<ReplicationProtectionIntentProviderSpecificSettings>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
