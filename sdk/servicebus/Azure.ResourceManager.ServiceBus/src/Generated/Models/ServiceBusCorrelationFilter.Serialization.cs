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

namespace Azure.ResourceManager.ServiceBus.Models
{
    public partial class ServiceBusCorrelationFilter : IUtf8JsonSerializable, IJsonModel<ServiceBusCorrelationFilter>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusCorrelationFilter>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ServiceBusCorrelationFilter>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ServiceBusCorrelationFilter>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ServiceBusCorrelationFilter>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(ApplicationProperties))
            {
                writer.WritePropertyName("properties"u8);
                writer.WriteStartObject();
                foreach (var item in ApplicationProperties)
                {
                    writer.WritePropertyName(item.Key);
                    if (item.Value == null)
                    {
                        writer.WriteNullValue();
                        continue;
                    }
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(CorrelationId))
            {
                writer.WritePropertyName("correlationId"u8);
                writer.WriteStringValue(CorrelationId);
            }
            if (Optional.IsDefined(MessageId))
            {
                writer.WritePropertyName("messageId"u8);
                writer.WriteStringValue(MessageId);
            }
            if (Optional.IsDefined(SendTo))
            {
                writer.WritePropertyName("to"u8);
                writer.WriteStringValue(SendTo);
            }
            if (Optional.IsDefined(ReplyTo))
            {
                writer.WritePropertyName("replyTo"u8);
                writer.WriteStringValue(ReplyTo);
            }
            if (Optional.IsDefined(Subject))
            {
                writer.WritePropertyName("label"u8);
                writer.WriteStringValue(Subject);
            }
            if (Optional.IsDefined(SessionId))
            {
                writer.WritePropertyName("sessionId"u8);
                writer.WriteStringValue(SessionId);
            }
            if (Optional.IsDefined(ReplyToSessionId))
            {
                writer.WritePropertyName("replyToSessionId"u8);
                writer.WriteStringValue(ReplyToSessionId);
            }
            if (Optional.IsDefined(ContentType))
            {
                writer.WritePropertyName("contentType"u8);
                writer.WriteStringValue(ContentType);
            }
            if (Optional.IsDefined(RequiresPreprocessing))
            {
                writer.WritePropertyName("requiresPreprocessing"u8);
                writer.WriteBooleanValue(RequiresPreprocessing.Value);
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

        ServiceBusCorrelationFilter IJsonModel<ServiceBusCorrelationFilter>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusCorrelationFilter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusCorrelationFilter(document.RootElement, options);
        }

        internal static ServiceBusCorrelationFilter DeserializeServiceBusCorrelationFilter(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IDictionary<string, object>> properties = default;
            Optional<string> correlationId = default;
            Optional<string> messageId = default;
            Optional<string> to = default;
            Optional<string> replyTo = default;
            Optional<string> label = default;
            Optional<string> sessionId = default;
            Optional<string> replyToSessionId = default;
            Optional<string> contentType = default;
            Optional<bool> requiresPreprocessing = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetObject());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("correlationId"u8))
                {
                    correlationId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("messageId"u8))
                {
                    messageId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("to"u8))
                {
                    to = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyTo"u8))
                {
                    replyTo = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("label"u8))
                {
                    label = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sessionId"u8))
                {
                    sessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("replyToSessionId"u8))
                {
                    replyToSessionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentType"u8))
                {
                    contentType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("requiresPreprocessing"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    requiresPreprocessing = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ServiceBusCorrelationFilter(Optional.ToDictionary(properties), correlationId.Value, messageId.Value, to.Value, replyTo.Value, label.Value, sessionId.Value, replyToSessionId.Value, contentType.Value, Optional.ToNullable(requiresPreprocessing), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ServiceBusCorrelationFilter>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusCorrelationFilter)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ServiceBusCorrelationFilter IPersistableModel<ServiceBusCorrelationFilter>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ServiceBusCorrelationFilter)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeServiceBusCorrelationFilter(document.RootElement, options);
        }

        string IPersistableModel<ServiceBusCorrelationFilter>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
