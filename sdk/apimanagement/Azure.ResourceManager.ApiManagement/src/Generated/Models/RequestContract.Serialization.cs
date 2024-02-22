// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class RequestContract : IUtf8JsonSerializable, IJsonModel<RequestContract>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RequestContract>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<RequestContract>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestContract)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsCollectionDefined(QueryParameters))
            {
                writer.WritePropertyName("queryParameters"u8);
                writer.WriteStartArray();
                foreach (var item in QueryParameters)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Headers))
            {
                writer.WritePropertyName("headers"u8);
                writer.WriteStartArray();
                foreach (var item in Headers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Representations))
            {
                writer.WritePropertyName("representations"u8);
                writer.WriteStartArray();
                foreach (var item in Representations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        RequestContract IJsonModel<RequestContract>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestContract>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(RequestContract)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRequestContract(document.RootElement, options);
        }

        internal static RequestContract DeserializeRequestContract(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<IList<ParameterContract>> queryParameters = default;
            Optional<IList<ParameterContract>> headers = default;
            Optional<IList<RepresentationContract>> representations = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("queryParameters"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParameterContract> array = new List<ParameterContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParameterContract.DeserializeParameterContract(item, options));
                    }
                    queryParameters = array;
                    continue;
                }
                if (property.NameEquals("headers"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ParameterContract> array = new List<ParameterContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ParameterContract.DeserializeParameterContract(item, options));
                    }
                    headers = array;
                    continue;
                }
                if (property.NameEquals("representations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<RepresentationContract> array = new List<RepresentationContract>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RepresentationContract.DeserializeRepresentationContract(item, options));
                    }
                    representations = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RequestContract(description.Value, Optional.ToList(queryParameters), Optional.ToList(headers), Optional.ToList(representations), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<RequestContract>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(RequestContract)} does not support '{options.Format}' format.");
            }
        }

        RequestContract IPersistableModel<RequestContract>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<RequestContract>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeRequestContract(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(RequestContract)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<RequestContract>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
