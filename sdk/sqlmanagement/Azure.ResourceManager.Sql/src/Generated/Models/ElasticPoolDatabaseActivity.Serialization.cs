// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure;
using Azure.Core;
using Azure.Core.Serialization;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class ElasticPoolDatabaseActivity : IUtf8JsonSerializable, IModelJsonSerializable<ElasticPoolDatabaseActivity>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IModelJsonSerializable<ElasticPoolDatabaseActivity>)this).Serialize(writer, ModelSerializerOptions.DefaultWireOptions);

        void IModelJsonSerializable<ElasticPoolDatabaseActivity>.Serialize(Utf8JsonWriter writer, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            writer.WriteStartObject();
            if (Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            writer.WriteEndObject();
            if (_rawData is not null && options.Format == ModelSerializerFormat.Json)
            {
                foreach (var property in _rawData)
                {
                    writer.WritePropertyName(property.Key);
#if NET6_0_OR_GREATER
				writer.WriteRawValue(property.Value);
#else
                    JsonSerializer.Serialize(writer, JsonDocument.Parse(property.Value.ToString()).RootElement);
#endif
                }
            }
            writer.WriteEndObject();
        }

        internal static ElasticPoolDatabaseActivity DeserializeElasticPoolDatabaseActivity(JsonElement element, ModelSerializerOptions options = default)
        {
            options ??= ModelSerializerOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AzureLocation> location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<string> databaseName = default;
            Optional<DateTimeOffset> endTime = default;
            Optional<int> errorCode = default;
            Optional<string> errorMessage = default;
            Optional<int> errorSeverity = default;
            Optional<string> operation = default;
            Optional<Guid> operationId = default;
            Optional<int> percentComplete = default;
            Optional<string> requestedElasticPoolName = default;
            Optional<string> currentElasticPoolName = default;
            Optional<string> currentServiceObjective = default;
            Optional<string> requestedServiceObjective = default;
            Optional<string> serverName = default;
            Optional<DateTimeOffset> startTime = default;
            Optional<string> state = default;
            Dictionary<string, BinaryData> rawData = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("databaseName"u8))
                        {
                            databaseName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("endTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            endTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("errorCode"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorCode = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("errorMessage"u8))
                        {
                            errorMessage = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("errorSeverity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            errorSeverity = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("operation"u8))
                        {
                            operation = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("operationId"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationId = property0.Value.GetGuid();
                            continue;
                        }
                        if (property0.NameEquals("percentComplete"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            percentComplete = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("requestedElasticPoolName"u8))
                        {
                            requestedElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentElasticPoolName"u8))
                        {
                            currentElasticPoolName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("currentServiceObjective"u8))
                        {
                            currentServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("requestedServiceObjective"u8))
                        {
                            requestedServiceObjective = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("serverName"u8))
                        {
                            serverName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("startTime"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            startTime = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("state"u8))
                        {
                            state = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == ModelSerializerFormat.Json)
                {
                    rawData.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                    continue;
                }
            }
            return new ElasticPoolDatabaseActivity(id, name, type, systemData.Value, Optional.ToNullable(location), databaseName.Value, Optional.ToNullable(endTime), Optional.ToNullable(errorCode), errorMessage.Value, Optional.ToNullable(errorSeverity), operation.Value, Optional.ToNullable(operationId), Optional.ToNullable(percentComplete), requestedElasticPoolName.Value, currentElasticPoolName.Value, currentServiceObjective.Value, requestedServiceObjective.Value, serverName.Value, Optional.ToNullable(startTime), state.Value, rawData);
        }

        ElasticPoolDatabaseActivity IModelJsonSerializable<ElasticPoolDatabaseActivity>.Deserialize(ref Utf8JsonReader reader, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeElasticPoolDatabaseActivity(doc.RootElement, options);
        }

        BinaryData IModelSerializable<ElasticPoolDatabaseActivity>.Serialize(ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            return ModelSerializer.SerializeCore(this, options);
        }

        ElasticPoolDatabaseActivity IModelSerializable<ElasticPoolDatabaseActivity>.Deserialize(BinaryData data, ModelSerializerOptions options)
        {
            ModelSerializerHelper.ValidateFormat(this, options.Format);

            using var doc = JsonDocument.Parse(data);
            return DeserializeElasticPoolDatabaseActivity(doc.RootElement, options);
        }

        /// <summary> Converts a <see cref="ElasticPoolDatabaseActivity"/> into a <see cref="RequestContent"/>. </summary>
        /// <param name="model"> The <see cref="ElasticPoolDatabaseActivity"/> to convert. </param>
        public static implicit operator RequestContent(ElasticPoolDatabaseActivity model)
        {
            if (model is null)
            {
                return null;
            }

            return RequestContent.Create(model, ModelSerializerOptions.DefaultWireOptions);
        }

        /// <summary> Converts a <see cref="Response"/> into a <see cref="ElasticPoolDatabaseActivity"/>. </summary>
        /// <param name="response"> The <see cref="Response"/> to convert. </param>
        public static explicit operator ElasticPoolDatabaseActivity(Response response)
        {
            if (response is null)
            {
                return null;
            }

            using JsonDocument doc = JsonDocument.Parse(response.ContentStream);
            return DeserializeElasticPoolDatabaseActivity(doc.RootElement, ModelSerializerOptions.DefaultWireOptions);
        }
    }
}
