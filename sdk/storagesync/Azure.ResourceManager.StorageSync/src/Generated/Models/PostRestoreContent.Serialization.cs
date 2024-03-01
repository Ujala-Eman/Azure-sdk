// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.StorageSync.Models
{
    public partial class PostRestoreContent : IUtf8JsonSerializable, IJsonModel<PostRestoreContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<PostRestoreContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<PostRestoreContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostRestoreContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Partition != null)
            {
                writer.WritePropertyName("partition"u8);
                writer.WriteStringValue(Partition);
            }
            if (ReplicaGroup != null)
            {
                writer.WritePropertyName("replicaGroup"u8);
                writer.WriteStringValue(ReplicaGroup);
            }
            if (RequestId != null)
            {
                writer.WritePropertyName("requestId"u8);
                writer.WriteStringValue(RequestId);
            }
            if (AzureFileShareUri != null)
            {
                writer.WritePropertyName("azureFileShareUri"u8);
                writer.WriteStringValue(AzureFileShareUri.AbsoluteUri);
            }
            if (Status != null)
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status);
            }
            if (SourceAzureFileShareUri != null)
            {
                writer.WritePropertyName("sourceAzureFileShareUri"u8);
                writer.WriteStringValue(SourceAzureFileShareUri.AbsoluteUri);
            }
            if (FailedFileList != null)
            {
                writer.WritePropertyName("failedFileList"u8);
                writer.WriteStringValue(FailedFileList);
            }
            if (!(RestoreFileSpec is ChangeTrackingList<RestoreFileSpec> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("restoreFileSpec"u8);
                writer.WriteStartArray();
                foreach (var item in RestoreFileSpec)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
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

        PostRestoreContent IJsonModel<PostRestoreContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostRestoreContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(PostRestoreContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializePostRestoreContent(document.RootElement, options);
        }

        internal static PostRestoreContent DeserializePostRestoreContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string partition = default;
            string replicaGroup = default;
            string requestId = default;
            Uri azureFileShareUri = default;
            string status = default;
            Uri sourceAzureFileShareUri = default;
            string failedFileList = default;
            IList<RestoreFileSpec> restoreFileSpec = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("partition"u8))
                {
                    partition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replicaGroup"u8))
                {
                    replicaGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requestId"u8))
                {
                    requestId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("azureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    azureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    status = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceAzureFileShareUri"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    sourceAzureFileShareUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("failedFileList"u8))
                {
                    failedFileList = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("restoreFileSpec"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RestoreFileSpec> array = new List<RestoreFileSpec>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Models.RestoreFileSpec.DeserializeRestoreFileSpec(item, options));
                    }
                    restoreFileSpec = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new PostRestoreContent(
                partition,
                replicaGroup,
                requestId,
                azureFileShareUri,
                status,
                sourceAzureFileShareUri,
                failedFileList,
                restoreFileSpec ?? new ChangeTrackingList<RestoreFileSpec>(),
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<PostRestoreContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(PostRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        PostRestoreContent IPersistableModel<PostRestoreContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<PostRestoreContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializePostRestoreContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(PostRestoreContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<PostRestoreContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
