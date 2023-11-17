// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class UriRewriteActionProperties : IUtf8JsonSerializable, IJsonModel<UriRewriteActionProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UriRewriteActionProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<UriRewriteActionProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<UriRewriteActionProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<UriRewriteActionProperties>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("typeName"u8);
            writer.WriteStringValue(ActionType.ToString());
            writer.WritePropertyName("sourcePattern"u8);
            writer.WriteStringValue(SourcePattern);
            writer.WritePropertyName("destination"u8);
            writer.WriteStringValue(Destination);
            if (Optional.IsDefined(PreserveUnmatchedPath))
            {
                writer.WritePropertyName("preserveUnmatchedPath"u8);
                writer.WriteBooleanValue(PreserveUnmatchedPath.Value);
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

        UriRewriteActionProperties IJsonModel<UriRewriteActionProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriRewriteActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUriRewriteActionProperties(document.RootElement, options);
        }

        internal static UriRewriteActionProperties DeserializeUriRewriteActionProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UriRewriteActionType typeName = default;
            string sourcePattern = default;
            string destination = default;
            Optional<bool> preserveUnmatchedPath = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"u8))
                {
                    typeName = new UriRewriteActionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourcePattern"u8))
                {
                    sourcePattern = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destination"u8))
                {
                    destination = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("preserveUnmatchedPath"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    preserveUnmatchedPath = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UriRewriteActionProperties(typeName, sourcePattern, destination, Optional.ToNullable(preserveUnmatchedPath), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UriRewriteActionProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriRewriteActionProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        UriRewriteActionProperties IPersistableModel<UriRewriteActionProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(UriRewriteActionProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeUriRewriteActionProperties(document.RootElement, options);
        }

        string IPersistableModel<UriRewriteActionProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
