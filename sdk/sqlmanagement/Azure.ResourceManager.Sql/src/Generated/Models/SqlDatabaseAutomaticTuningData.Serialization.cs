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
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    public partial class SqlDatabaseAutomaticTuningData : IUtf8JsonSerializable, IJsonModel<SqlDatabaseAutomaticTuningData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlDatabaseAutomaticTuningData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlDatabaseAutomaticTuningData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SqlDatabaseAutomaticTuningData)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(DesiredState))
            {
                writer.WritePropertyName("desiredState"u8);
                writer.WriteStringValue(DesiredState.Value.ToSerialString());
            }
            if (options.Format != "W" && Optional.IsDefined(ActualState))
            {
                writer.WritePropertyName("actualState"u8);
                writer.WriteStringValue(ActualState.Value.ToSerialString());
            }
            if (Optional.IsCollectionDefined(Options))
            {
                writer.WritePropertyName("options"u8);
                writer.WriteStartObject();
                foreach (var item in Options)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
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

        SqlDatabaseAutomaticTuningData IJsonModel<SqlDatabaseAutomaticTuningData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SqlDatabaseAutomaticTuningData)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlDatabaseAutomaticTuningData(document.RootElement, options);
        }

        internal static SqlDatabaseAutomaticTuningData DeserializeSqlDatabaseAutomaticTuningData(JsonElement element, ModelReaderWriterOptions options = null)
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
            Optional<AutomaticTuningMode> desiredState = default;
            Optional<AutomaticTuningMode> actualState = default;
            Optional<IDictionary<string, AutomaticTuningOptions>> options0 = default;
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
                        if (property0.NameEquals("desiredState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            desiredState = property0.Value.GetString().ToAutomaticTuningMode();
                            continue;
                        }
                        if (property0.NameEquals("actualState"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            actualState = property0.Value.GetString().ToAutomaticTuningMode();
                            continue;
                        }
                        if (property0.NameEquals("options"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, AutomaticTuningOptions> dictionary = new Dictionary<string, AutomaticTuningOptions>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, AutomaticTuningOptions.DeserializeAutomaticTuningOptions(property1.Value));
                            }
                            options0 = dictionary;
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlDatabaseAutomaticTuningData(id, name, type, systemData.Value, Optional.ToNullable(desiredState), Optional.ToNullable(actualState), Optional.ToDictionary(options0), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlDatabaseAutomaticTuningData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SqlDatabaseAutomaticTuningData)} does not support '{options.Format}' format.");
            }
        }

        SqlDatabaseAutomaticTuningData IPersistableModel<SqlDatabaseAutomaticTuningData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SqlDatabaseAutomaticTuningData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSqlDatabaseAutomaticTuningData(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SqlDatabaseAutomaticTuningData)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SqlDatabaseAutomaticTuningData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
