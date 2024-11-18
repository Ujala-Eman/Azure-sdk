// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Conversations.Authoring.Models
{
    public partial class AssignedResourceDeploymentsMetadata : IUtf8JsonSerializable, IJsonModel<AssignedResourceDeploymentsMetadata>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AssignedResourceDeploymentsMetadata>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<AssignedResourceDeploymentsMetadata>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedResourceDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignedResourceDeploymentsMetadata)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteStartArray();
            foreach (var item in Value)
            {
                writer.WriteObjectValue(item, options);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(NextLink))
            {
                writer.WritePropertyName("nextLink"u8);
                writer.WriteStringValue(NextLink);
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

        AssignedResourceDeploymentsMetadata IJsonModel<AssignedResourceDeploymentsMetadata>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedResourceDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(AssignedResourceDeploymentsMetadata)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAssignedResourceDeploymentsMetadata(document.RootElement, options);
        }

        internal static AssignedResourceDeploymentsMetadata DeserializeAssignedResourceDeploymentsMetadata(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            IReadOnlyList<AssignedProjectDeploymentsMetadata> value = default;
            string nextLink = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    List<AssignedProjectDeploymentsMetadata> array = new List<AssignedProjectDeploymentsMetadata>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AssignedProjectDeploymentsMetadata.DeserializeAssignedProjectDeploymentsMetadata(item, options));
                    }
                    value = array;
                    continue;
                }
                if (property.NameEquals("nextLink"u8))
                {
                    nextLink = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new AssignedResourceDeploymentsMetadata(value, nextLink, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AssignedResourceDeploymentsMetadata>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedResourceDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(AssignedResourceDeploymentsMetadata)} does not support writing '{options.Format}' format.");
            }
        }

        AssignedResourceDeploymentsMetadata IPersistableModel<AssignedResourceDeploymentsMetadata>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AssignedResourceDeploymentsMetadata>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeAssignedResourceDeploymentsMetadata(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(AssignedResourceDeploymentsMetadata)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<AssignedResourceDeploymentsMetadata>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static AssignedResourceDeploymentsMetadata FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeAssignedResourceDeploymentsMetadata(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
