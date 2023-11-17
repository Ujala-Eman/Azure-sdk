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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlSynapseLinkWorkspaceInfo : IUtf8JsonSerializable, IJsonModel<SqlSynapseLinkWorkspaceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlSynapseLinkWorkspaceInfo>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlSynapseLinkWorkspaceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SqlSynapseLinkWorkspaceInfo>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SqlSynapseLinkWorkspaceInfo>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(WorkspaceId))
            {
                writer.WritePropertyName("workspaceId"u8);
                writer.WriteStringValue(WorkspaceId);
            }
            if (Optional.IsDefined(LinkConnectionName))
            {
                writer.WritePropertyName("linkConnectionName"u8);
                writer.WriteStringValue(LinkConnectionName);
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

        SqlSynapseLinkWorkspaceInfo IJsonModel<SqlSynapseLinkWorkspaceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlSynapseLinkWorkspaceInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlSynapseLinkWorkspaceInfo(document.RootElement, options);
        }

        internal static SqlSynapseLinkWorkspaceInfo DeserializeSqlSynapseLinkWorkspaceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> workspaceId = default;
            Optional<string> linkConnectionName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    workspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("linkConnectionName"u8))
                {
                    linkConnectionName = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlSynapseLinkWorkspaceInfo(workspaceId.Value, linkConnectionName.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlSynapseLinkWorkspaceInfo>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlSynapseLinkWorkspaceInfo)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SqlSynapseLinkWorkspaceInfo IPersistableModel<SqlSynapseLinkWorkspaceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlSynapseLinkWorkspaceInfo)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSqlSynapseLinkWorkspaceInfo(document.RootElement, options);
        }

        string IPersistableModel<SqlSynapseLinkWorkspaceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
