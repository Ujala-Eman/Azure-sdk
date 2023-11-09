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

namespace Azure.ResourceManager.Storage.Models
{
    public partial class StorageAccountEndpoints : IUtf8JsonSerializable, IJsonModel<StorageAccountEndpoints>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StorageAccountEndpoints>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<StorageAccountEndpoints>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(BlobUri))
                {
                    writer.WritePropertyName("blob"u8);
                    writer.WriteStringValue(BlobUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(QueueUri))
                {
                    writer.WritePropertyName("queue"u8);
                    writer.WriteStringValue(QueueUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(TableUri))
                {
                    writer.WritePropertyName("table"u8);
                    writer.WriteStringValue(TableUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(FileUri))
                {
                    writer.WritePropertyName("file"u8);
                    writer.WriteStringValue(FileUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WebUri))
                {
                    writer.WritePropertyName("web"u8);
                    writer.WriteStringValue(WebUri.AbsoluteUri);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(DfsUri))
                {
                    writer.WritePropertyName("dfs"u8);
                    writer.WriteStringValue(DfsUri.AbsoluteUri);
                }
            }
            if (Optional.IsDefined(MicrosoftEndpoints))
            {
                writer.WritePropertyName("microsoftEndpoints"u8);
                writer.WriteObjectValue(MicrosoftEndpoints);
            }
            if (Optional.IsDefined(InternetEndpoints))
            {
                writer.WritePropertyName("internetEndpoints"u8);
                writer.WriteObjectValue(InternetEndpoints);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        StorageAccountEndpoints IJsonModel<StorageAccountEndpoints>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStorageAccountEndpoints(document.RootElement, options);
        }

        internal static StorageAccountEndpoints DeserializeStorageAccountEndpoints(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> blob = default;
            Optional<Uri> queue = default;
            Optional<Uri> table = default;
            Optional<Uri> file = default;
            Optional<Uri> web = default;
            Optional<Uri> dfs = default;
            Optional<StorageAccountMicrosoftEndpoints> microsoftEndpoints = default;
            Optional<StorageAccountInternetEndpoints> internetEndpoints = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("blob"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    blob = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("queue"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    queue = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("table"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    table = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("file"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    file = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("web"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    web = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dfs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dfs = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("microsoftEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    microsoftEndpoints = StorageAccountMicrosoftEndpoints.DeserializeStorageAccountMicrosoftEndpoints(property.Value);
                    continue;
                }
                if (property.NameEquals("internetEndpoints"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    internetEndpoints = StorageAccountInternetEndpoints.DeserializeStorageAccountInternetEndpoints(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new StorageAccountEndpoints(blob.Value, queue.Value, table.Value, file.Value, web.Value, dfs.Value, microsoftEndpoints.Value, internetEndpoints.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<StorageAccountEndpoints>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEndpoints)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        StorageAccountEndpoints IModel<StorageAccountEndpoints>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(StorageAccountEndpoints)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeStorageAccountEndpoints(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<StorageAccountEndpoints>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
