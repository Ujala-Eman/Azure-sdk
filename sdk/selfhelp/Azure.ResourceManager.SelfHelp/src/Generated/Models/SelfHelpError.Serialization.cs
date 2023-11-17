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

namespace Azure.ResourceManager.SelfHelp.Models
{
    public partial class SelfHelpError : IUtf8JsonSerializable, IJsonModel<SelfHelpError>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SelfHelpError>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SelfHelpError>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SelfHelpError>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SelfHelpError>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Code))
                {
                    writer.WritePropertyName("code"u8);
                    writer.WriteStringValue(Code);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ErrorType))
                {
                    writer.WritePropertyName("type"u8);
                    writer.WriteStringValue(ErrorType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Message))
                {
                    writer.WritePropertyName("message"u8);
                    writer.WriteStringValue(Message);
                }
            }
            if (Optional.IsCollectionDefined(Details))
            {
                writer.WritePropertyName("details"u8);
                writer.WriteStartArray();
                foreach (var item in Details)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SelfHelpError IJsonModel<SelfHelpError>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSelfHelpError(document.RootElement, options);
        }

        internal static SelfHelpError DeserializeSelfHelpError(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> code = default;
            Optional<string> type = default;
            Optional<string> message = default;
            Optional<IReadOnlyList<SelfHelpError>> details = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("code"u8))
                {
                    code = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("message"u8))
                {
                    message = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("details"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SelfHelpError> array = new List<SelfHelpError>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DeserializeSelfHelpError(item));
                    }
                    details = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SelfHelpError(code.Value, type.Value, message.Value, Optional.ToList(details), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SelfHelpError>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpError)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SelfHelpError IPersistableModel<SelfHelpError>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SelfHelpError)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSelfHelpError(document.RootElement, options);
        }

        string IPersistableModel<SelfHelpError>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
