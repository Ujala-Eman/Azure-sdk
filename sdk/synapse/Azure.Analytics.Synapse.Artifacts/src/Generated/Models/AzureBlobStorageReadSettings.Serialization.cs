// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(AzureBlobStorageReadSettingsConverter))]
    public partial class AzureBlobStorageReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive"u8);
                writer.WriteObjectValue(Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath"u8);
                writer.WriteObjectValue(WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName"u8);
                writer.WriteObjectValue(WildcardFileName);
            }
            if (Optional.IsDefined(Prefix))
            {
                writer.WritePropertyName("prefix"u8);
                writer.WriteObjectValue(Prefix);
            }
            if (Optional.IsDefined(FileListPath))
            {
                writer.WritePropertyName("fileListPath"u8);
                writer.WriteObjectValue(FileListPath);
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery"u8);
                writer.WriteObjectValue(EnablePartitionDiscovery);
            }
            if (Optional.IsDefined(PartitionRootPath))
            {
                writer.WritePropertyName("partitionRootPath"u8);
                writer.WriteObjectValue(PartitionRootPath);
            }
            if (Optional.IsDefined(DeleteFilesAfterCompletion))
            {
                writer.WritePropertyName("deleteFilesAfterCompletion"u8);
                writer.WriteObjectValue(DeleteFilesAfterCompletion);
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart"u8);
                writer.WriteObjectValue(ModifiedDatetimeStart);
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd"u8);
                writer.WriteObjectValue(ModifiedDatetimeEnd);
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections"u8);
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            if (AdditionalProperties != null)
            {
                foreach (var item in AdditionalProperties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
            }
            writer.WriteEndObject();
        }

        internal static AzureBlobStorageReadSettings DeserializeAzureBlobStorageReadSettings(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> recursive = default;
            Optional<object> wildcardFolderPath = default;
            Optional<object> wildcardFileName = default;
            Optional<object> prefix = default;
            Optional<object> fileListPath = default;
            Optional<object> enablePartitionDiscovery = default;
            Optional<object> partitionRootPath = default;
            Optional<object> deleteFilesAfterCompletion = default;
            Optional<object> modifiedDatetimeStart = default;
            Optional<object> modifiedDatetimeEnd = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    recursive = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFolderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFileName"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    wildcardFileName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("prefix"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    prefix = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("fileListPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    fileListPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enablePartitionDiscovery = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("partitionRootPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    partitionRootPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("deleteFilesAfterCompletion"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    deleteFilesAfterCompletion = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeStart"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeStart = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeEnd"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    modifiedDatetimeEnd = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureBlobStorageReadSettings(type, maxConcurrentConnections.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, prefix.Value, fileListPath.Value, enablePartitionDiscovery.Value, partitionRootPath.Value, deleteFilesAfterCompletion.Value, modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value);
        }

        internal partial class AzureBlobStorageReadSettingsConverter : JsonConverter<AzureBlobStorageReadSettings>
        {
            public override void Write(Utf8JsonWriter writer, AzureBlobStorageReadSettings model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override AzureBlobStorageReadSettings Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeAzureBlobStorageReadSettings(document.RootElement);
            }
        }
    }
}
