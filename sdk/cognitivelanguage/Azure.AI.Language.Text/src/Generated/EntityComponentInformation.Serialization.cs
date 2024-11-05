// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.AI.Language.Text
{
    [PersistableModelProxy(typeof(UnknownEntityComponentInformation))]
    public partial class EntityComponentInformation : IUtf8JsonSerializable, IJsonModel<EntityComponentInformation>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<EntityComponentInformation>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<EntityComponentInformation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityComponentInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityComponentInformation)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("entityComponentKind"u8);
            writer.WriteStringValue(EntityComponentKind.ToString());
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
        }

        EntityComponentInformation IJsonModel<EntityComponentInformation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityComponentInformation>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(EntityComponentInformation)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeEntityComponentInformation(document.RootElement, options);
        }

        internal static EntityComponentInformation DeserializeEntityComponentInformation(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("entityComponentKind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "LearnedComponent": return LearnedComponent.DeserializeLearnedComponent(element, options);
                    case "ListComponent": return ListComponent.DeserializeListComponent(element, options);
                    case "PrebuiltComponent": return PrebuiltComponent.DeserializePrebuiltComponent(element, options);
                }
            }
            return UnknownEntityComponentInformation.DeserializeUnknownEntityComponentInformation(element, options);
        }

        BinaryData IPersistableModel<EntityComponentInformation>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityComponentInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(EntityComponentInformation)} does not support writing '{options.Format}' format.");
            }
        }

        EntityComponentInformation IPersistableModel<EntityComponentInformation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<EntityComponentInformation>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeEntityComponentInformation(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(EntityComponentInformation)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<EntityComponentInformation>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static EntityComponentInformation FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeEntityComponentInformation(document.RootElement);
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
