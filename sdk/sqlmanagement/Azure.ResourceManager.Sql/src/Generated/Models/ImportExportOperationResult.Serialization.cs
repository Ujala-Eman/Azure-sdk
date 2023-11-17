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
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ImportExportOperationResult : IUtf8JsonSerializable, IJsonModel<ImportExportOperationResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ImportExportOperationResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ImportExportOperationResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ImportExportOperationResult>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ImportExportOperationResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RequestId))
                {
                    writer.WritePropertyName("requestId"u8);
                    writer.WriteStringValue(RequestId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(RequestType))
                {
                    writer.WritePropertyName("requestType"u8);
                    writer.WriteStringValue(RequestType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(QueuedTime))
                {
                    writer.WritePropertyName("queuedTime"u8);
                    writer.WriteStringValue(QueuedTime);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(LastModifiedTime))
                {
                    writer.WritePropertyName("lastModifiedTime"u8);
                    writer.WriteStringValue(LastModifiedTime);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(BlobUri))
                {
                    writer.WritePropertyName("blobUri"u8);
                    writer.WriteStringValue(BlobUri.AbsoluteUri);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ServerName))
                {
                    writer.WritePropertyName("serverName"u8);
                    writer.WriteStringValue(ServerName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DatabaseName))
                {
                    writer.WritePropertyName("databaseName"u8);
                    writer.WriteStringValue(DatabaseName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Status))
                {
                    writer.WritePropertyName("status"u8);
                    writer.WriteStringValue(Status);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ErrorMessage))
                {
                    writer.WritePropertyName("errorMessage"u8);
                    writer.WriteStringValue(ErrorMessage);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(PrivateEndpointConnections))
                {
                    writer.WritePropertyName("privateEndpointConnections"u8);
                    writer.WriteStartArray();
                    foreach (var item in PrivateEndpointConnections)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            writer.WriteEndObject();
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

        ImportExportOperationResult IJsonModel<ImportExportOperationResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImportExportOperationResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeImportExportOperationResult(document.RootElement, options);
        }

        internal static ImportExportOperationResult DeserializeImportExportOperationResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<Guid> requestId = default;
            Optional<string> requestType = default;
            Optional<string> queuedTime = default;
            Optional<string> lastModifiedTime = default;
            Optional<Uri> blobUri = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> status = default;
            Optional<string> errorMessage = default;
            Optional<IReadOnlyList<PrivateEndpointConnectionRequestStatus>> privateEndpointConnections = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("requestId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requestId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("requestType"u8))
                        {
                            requestType = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("queuedTime"u8))
                        {
                            queuedTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("lastModifiedTime"u8))
                        {
                            lastModifiedTime = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("blobUri"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            blobUri = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            status = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("privateEndpointConnections"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<PrivateEndpointConnectionRequestStatus> array = new List<PrivateEndpointConnectionRequestStatus>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(PrivateEndpointConnectionRequestStatus.DeserializePrivateEndpointConnectionRequestStatus(item));
                            }
                            privateEndpointConnections = array;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ImportExportOperationResult(id, name, type, systemData.Value, Optional.ToNullable(requestId), requestType.Value, queuedTime.Value, lastModifiedTime.Value, blobUri.Value, serverName.Value, databaseName.Value, status.Value, errorMessage.Value, Optional.ToList(privateEndpointConnections), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ImportExportOperationResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImportExportOperationResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ImportExportOperationResult IPersistableModel<ImportExportOperationResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ImportExportOperationResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeImportExportOperationResult(document.RootElement, options);
        }

        string IPersistableModel<ImportExportOperationResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
