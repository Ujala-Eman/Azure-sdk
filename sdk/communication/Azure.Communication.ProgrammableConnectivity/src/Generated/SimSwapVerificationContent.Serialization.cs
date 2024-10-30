// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ProgrammableConnectivity
{
    public partial class SimSwapVerificationContent : IUtf8JsonSerializable, IJsonModel<SimSwapVerificationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SimSwapVerificationContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SimSwapVerificationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimSwapVerificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimSwapVerificationContent)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(PhoneNumber))
            {
                writer.WritePropertyName("phoneNumber"u8);
                writer.WriteStringValue(PhoneNumber);
            }
            if (Optional.IsDefined(MaxAgeHours))
            {
                writer.WritePropertyName("maxAgeHours"u8);
                writer.WriteNumberValue(MaxAgeHours.Value);
            }
            writer.WritePropertyName("networkIdentifier"u8);
            writer.WriteObjectValue(NetworkIdentifier, options);
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

        SimSwapVerificationContent IJsonModel<SimSwapVerificationContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimSwapVerificationContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SimSwapVerificationContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSimSwapVerificationContent(document.RootElement, options);
        }

        internal static SimSwapVerificationContent DeserializeSimSwapVerificationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string phoneNumber = default;
            int? maxAgeHours = default;
            NetworkIdentifier networkIdentifier = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("phoneNumber"u8))
                {
                    phoneNumber = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("maxAgeHours"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxAgeHours = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("networkIdentifier"u8))
                {
                    networkIdentifier = NetworkIdentifier.DeserializeNetworkIdentifier(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SimSwapVerificationContent(phoneNumber, maxAgeHours, networkIdentifier, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SimSwapVerificationContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimSwapVerificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SimSwapVerificationContent)} does not support writing '{options.Format}' format.");
            }
        }

        SimSwapVerificationContent IPersistableModel<SimSwapVerificationContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SimSwapVerificationContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSimSwapVerificationContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SimSwapVerificationContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SimSwapVerificationContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static SimSwapVerificationContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeSimSwapVerificationContent(document.RootElement);
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
