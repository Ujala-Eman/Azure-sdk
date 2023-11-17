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

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    public partial class RecoveryPointRehydrationInfo : IUtf8JsonSerializable, IJsonModel<RecoveryPointRehydrationInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RecoveryPointRehydrationInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RecoveryPointRehydrationInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<RecoveryPointRehydrationInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<RecoveryPointRehydrationInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RehydrationRetentionDuration))
            {
                writer.WritePropertyName("rehydrationRetentionDuration"u8);
                writer.WriteStringValue(RehydrationRetentionDuration.Value, "P");
            }
            if (Optional.IsDefined(RehydrationPriority))
            {
                writer.WritePropertyName("rehydrationPriority"u8);
                writer.WriteStringValue(RehydrationPriority.Value.ToString());
            }
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

        RecoveryPointRehydrationInfo IJsonModel<RecoveryPointRehydrationInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRecoveryPointRehydrationInfo(document.RootElement, options);
        }

        internal static RecoveryPointRehydrationInfo DeserializeRecoveryPointRehydrationInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<TimeSpan> rehydrationRetentionDuration = default;
            Optional<RehydrationPriority> rehydrationPriority = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("rehydrationRetentionDuration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationRetentionDuration = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("rehydrationPriority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    rehydrationPriority = new RehydrationPriority(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RecoveryPointRehydrationInfo(Optional.ToNullable(rehydrationRetentionDuration), Optional.ToNullable(rehydrationPriority), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RecoveryPointRehydrationInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RecoveryPointRehydrationInfo IPersistableModel<RecoveryPointRehydrationInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RecoveryPointRehydrationInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRecoveryPointRehydrationInfo(document.RootElement, options);
        }

        string IPersistableModel<RecoveryPointRehydrationInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
