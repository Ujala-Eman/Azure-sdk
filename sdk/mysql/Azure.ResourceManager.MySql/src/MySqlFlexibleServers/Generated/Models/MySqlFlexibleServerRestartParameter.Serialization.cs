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

namespace Azure.ResourceManager.MySql.FlexibleServers.Models
{
    public partial class MySqlFlexibleServerRestartParameter : IUtf8JsonSerializable, IJsonModel<MySqlFlexibleServerRestartParameter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MySqlFlexibleServerRestartParameter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MySqlFlexibleServerRestartParameter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerRestartParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerRestartParameter)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(RestartWithFailover))
            {
                writer.WritePropertyName("restartWithFailover"u8);
                writer.WriteStringValue(RestartWithFailover.Value.ToString());
            }
            if (Optional.IsDefined(MaxFailoverSeconds))
            {
                writer.WritePropertyName("maxFailoverSeconds"u8);
                writer.WriteNumberValue(MaxFailoverSeconds.Value);
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

        MySqlFlexibleServerRestartParameter IJsonModel<MySqlFlexibleServerRestartParameter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerRestartParameter>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerRestartParameter)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMySqlFlexibleServerRestartParameter(document.RootElement, options);
        }

        internal static MySqlFlexibleServerRestartParameter DeserializeMySqlFlexibleServerRestartParameter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MySqlFlexibleServerEnableStatusEnum> restartWithFailover = default;
            Optional<int> maxFailoverSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("restartWithFailover"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    restartWithFailover = new MySqlFlexibleServerEnableStatusEnum(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("maxFailoverSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxFailoverSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MySqlFlexibleServerRestartParameter(Optional.ToNullable(restartWithFailover), Optional.ToNullable(maxFailoverSeconds), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MySqlFlexibleServerRestartParameter>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerRestartParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerRestartParameter)} does not support '{options.Format}' format.");
            }
        }

        MySqlFlexibleServerRestartParameter IPersistableModel<MySqlFlexibleServerRestartParameter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MySqlFlexibleServerRestartParameter>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMySqlFlexibleServerRestartParameter(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MySqlFlexibleServerRestartParameter)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MySqlFlexibleServerRestartParameter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
