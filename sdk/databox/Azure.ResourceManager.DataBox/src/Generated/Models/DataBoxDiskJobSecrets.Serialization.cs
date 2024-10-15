// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class DataBoxDiskJobSecrets : IUtf8JsonSerializable, IJsonModel<DataBoxDiskJobSecrets>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DataBoxDiskJobSecrets>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<DataBoxDiskJobSecrets>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsCollectionDefined(DiskSecrets))
            {
                writer.WritePropertyName("diskSecrets"u8);
                writer.WriteStartArray();
                foreach (var item in DiskSecrets)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (options.Format != "W" && Optional.IsDefined(Passkey))
            {
                writer.WritePropertyName("passKey"u8);
                writer.WriteStringValue(Passkey);
            }
            if (options.Format != "W" && Optional.IsDefined(IsPasskeyUserDefined))
            {
                writer.WritePropertyName("isPasskeyUserDefined"u8);
                writer.WriteBooleanValue(IsPasskeyUserDefined.Value);
            }
        }

        DataBoxDiskJobSecrets IJsonModel<DataBoxDiskJobSecrets>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDataBoxDiskJobSecrets(document.RootElement, options);
        }

        internal static DataBoxDiskJobSecrets DeserializeDataBoxDiskJobSecrets(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<DataBoxDiskSecret> diskSecrets = default;
            string passKey = default;
            bool? isPasskeyUserDefined = default;
            DataBoxOrderType jobSecretsType = default;
            DataCenterAccessSecurityCode dcAccessSecurityCode = default;
            ResponseError error = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("diskSecrets"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DataBoxDiskSecret> array = new List<DataBoxDiskSecret>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DataBoxDiskSecret.DeserializeDataBoxDiskSecret(item, options));
                    }
                    diskSecrets = array;
                    continue;
                }
                if (property.NameEquals("passKey"u8))
                {
                    passKey = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isPasskeyUserDefined"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isPasskeyUserDefined = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobSecretsType"u8))
                {
                    jobSecretsType = property.Value.GetString().ToDataBoxOrderType();
                    continue;
                }
                if (property.NameEquals("dcAccessSecurityCode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dcAccessSecurityCode = DataCenterAccessSecurityCode.DeserializeDataCenterAccessSecurityCode(property.Value, options);
                    continue;
                }
                if (property.NameEquals("error"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    error = JsonSerializer.Deserialize<ResponseError>(property.Value.GetRawText());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new DataBoxDiskJobSecrets(
                jobSecretsType,
                dcAccessSecurityCode,
                error,
                serializedAdditionalRawData,
                diskSecrets ?? new ChangeTrackingList<DataBoxDiskSecret>(),
                passKey,
                isPasskeyUserDefined);
        }

        BinaryData IPersistableModel<DataBoxDiskJobSecrets>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support writing '{options.Format}' format.");
            }
        }

        DataBoxDiskJobSecrets IPersistableModel<DataBoxDiskJobSecrets>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DataBoxDiskJobSecrets>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDataBoxDiskJobSecrets(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DataBoxDiskJobSecrets)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<DataBoxDiskJobSecrets>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
