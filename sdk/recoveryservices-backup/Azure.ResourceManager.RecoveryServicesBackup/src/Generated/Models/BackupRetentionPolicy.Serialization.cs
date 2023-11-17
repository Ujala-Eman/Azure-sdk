// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesBackup.Models
{
    [PersistableModelProxy(typeof(UnknownRetentionPolicy))]
    public partial class BackupRetentionPolicy : IUtf8JsonSerializable, IJsonModel<BackupRetentionPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackupRetentionPolicy>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<BackupRetentionPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BackupRetentionPolicy>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BackupRetentionPolicy>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("retentionPolicyType"u8);
            writer.WriteStringValue(RetentionPolicyType);
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

        BackupRetentionPolicy IJsonModel<BackupRetentionPolicy>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackupRetentionPolicy(document.RootElement, options);
        }

        internal static BackupRetentionPolicy DeserializeBackupRetentionPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("retentionPolicyType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LongTermRetentionPolicy": return LongTermRetentionPolicy.DeserializeLongTermRetentionPolicy(element);
                    case "SimpleRetentionPolicy": return SimpleRetentionPolicy.DeserializeSimpleRetentionPolicy(element);
                }
            }
            return UnknownRetentionPolicy.DeserializeUnknownRetentionPolicy(element);
        }

        BinaryData IPersistableModel<BackupRetentionPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackupRetentionPolicy IPersistableModel<BackupRetentionPolicy>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackupRetentionPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackupRetentionPolicy(document.RootElement, options);
        }

        string IPersistableModel<BackupRetentionPolicy>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
