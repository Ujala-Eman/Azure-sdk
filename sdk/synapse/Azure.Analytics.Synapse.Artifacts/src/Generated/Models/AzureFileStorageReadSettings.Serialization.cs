// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class AzureFileStorageReadSettings : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive");
                writer.WriteObjectValue(Recursive);
            }
            if (Optional.IsDefined(WildcardFolderPath))
            {
                writer.WritePropertyName("wildcardFolderPath");
                writer.WriteObjectValue(WildcardFolderPath);
            }
            if (Optional.IsDefined(WildcardFileName))
            {
                writer.WritePropertyName("wildcardFileName");
                writer.WriteObjectValue(WildcardFileName);
            }
            if (Optional.IsDefined(EnablePartitionDiscovery))
            {
                writer.WritePropertyName("enablePartitionDiscovery");
                writer.WriteBooleanValue(EnablePartitionDiscovery.Value);
            }
            if (Optional.IsDefined(ModifiedDatetimeStart))
            {
                writer.WritePropertyName("modifiedDatetimeStart");
                writer.WriteObjectValue(ModifiedDatetimeStart);
            }
            if (Optional.IsDefined(ModifiedDatetimeEnd))
            {
                writer.WritePropertyName("modifiedDatetimeEnd");
                writer.WriteObjectValue(ModifiedDatetimeEnd);
            }
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteObjectValue(MaxConcurrentConnections);
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static AzureFileStorageReadSettings DeserializeAzureFileStorageReadSettings(JsonElement element)
        {
            Optional<object> recursive = default;
            Optional<object> wildcardFolderPath = default;
            Optional<object> wildcardFileName = default;
            Optional<bool> enablePartitionDiscovery = default;
            Optional<object> modifiedDatetimeStart = default;
            Optional<object> modifiedDatetimeEnd = default;
            string type = default;
            Optional<object> maxConcurrentConnections = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("recursive"))
                {
                    recursive = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFolderPath"))
                {
                    wildcardFolderPath = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("wildcardFileName"))
                {
                    wildcardFileName = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("enablePartitionDiscovery"))
                {
                    enablePartitionDiscovery = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeStart"))
                {
                    modifiedDatetimeStart = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("modifiedDatetimeEnd"))
                {
                    modifiedDatetimeEnd = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxConcurrentConnections"))
                {
                    maxConcurrentConnections = property.Value.GetObject();
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new AzureFileStorageReadSettings(type, maxConcurrentConnections.Value, additionalProperties, recursive.Value, wildcardFolderPath.Value, wildcardFileName.Value, Optional.ToNullable(enablePartitionDiscovery), modifiedDatetimeStart.Value, modifiedDatetimeEnd.Value);
        }
    }
}
