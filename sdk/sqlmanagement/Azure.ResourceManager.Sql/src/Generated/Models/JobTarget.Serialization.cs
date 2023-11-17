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
    public partial class JobTarget : IUtf8JsonSerializable, IJsonModel<JobTarget>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<JobTarget>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<JobTarget>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<JobTarget>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<JobTarget>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(MembershipType))
            {
                writer.WritePropertyName("membershipType"u8);
                writer.WriteStringValue(MembershipType.Value.ToSerialString());
            }
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(TargetType.ToString());
            if (Optional.IsDefined(ServerName))
            {
                writer.WritePropertyName("serverName"u8);
                writer.WriteStringValue(ServerName);
            }
            if (Optional.IsDefined(DatabaseName))
            {
                writer.WritePropertyName("databaseName"u8);
                writer.WriteStringValue(DatabaseName);
            }
            if (Optional.IsDefined(ElasticPoolName))
            {
                writer.WritePropertyName("elasticPoolName"u8);
                writer.WriteStringValue(ElasticPoolName);
            }
            if (Optional.IsDefined(ShardMapName))
            {
                writer.WritePropertyName("shardMapName"u8);
                writer.WriteStringValue(ShardMapName);
            }
            if (Optional.IsDefined(RefreshCredential))
            {
                writer.WritePropertyName("refreshCredential"u8);
                writer.WriteStringValue(RefreshCredential);
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

        JobTarget IJsonModel<JobTarget>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobTarget)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeJobTarget(document.RootElement, options);
        }

        internal static JobTarget DeserializeJobTarget(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<JobTargetGroupMembershipType> membershipType = default;
            JobTargetType type = default;
            Optional<string> serverName = default;
            Optional<string> databaseName = default;
            Optional<string> elasticPoolName = default;
            Optional<string> shardMapName = default;
            Optional<string> refreshCredential = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("membershipType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    membershipType = property.Value.GetString().ToJobTargetGroupMembershipType();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new JobTargetType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("serverName"u8))
                {
                    serverName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("databaseName"u8))
                {
                    databaseName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("elasticPoolName"u8))
                {
                    elasticPoolName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("shardMapName"u8))
                {
                    shardMapName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("refreshCredential"u8))
                {
                    refreshCredential = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new JobTarget(Optional.ToNullable(membershipType), type, serverName.Value, databaseName.Value, elasticPoolName.Value, shardMapName.Value, refreshCredential.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<JobTarget>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobTarget)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        JobTarget IPersistableModel<JobTarget>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(JobTarget)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeJobTarget(document.RootElement, options);
        }

        string IPersistableModel<JobTarget>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
