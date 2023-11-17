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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class BackendAuthorizationHeaderCredentials : IUtf8JsonSerializable, IJsonModel<BackendAuthorizationHeaderCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BackendAuthorizationHeaderCredentials>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BackendAuthorizationHeaderCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BackendAuthorizationHeaderCredentials>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BackendAuthorizationHeaderCredentials>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("scheme"u8);
            writer.WriteStringValue(Scheme);
            writer.WritePropertyName("parameter"u8);
            writer.WriteStringValue(Parameter);
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

        BackendAuthorizationHeaderCredentials IJsonModel<BackendAuthorizationHeaderCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBackendAuthorizationHeaderCredentials(document.RootElement, options);
        }

        internal static BackendAuthorizationHeaderCredentials DeserializeBackendAuthorizationHeaderCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string scheme = default;
            string parameter = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("scheme"u8))
                {
                    scheme = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameter"u8))
                {
                    parameter = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BackendAuthorizationHeaderCredentials(scheme, parameter, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BackendAuthorizationHeaderCredentials>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BackendAuthorizationHeaderCredentials IPersistableModel<BackendAuthorizationHeaderCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BackendAuthorizationHeaderCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBackendAuthorizationHeaderCredentials(document.RootElement, options);
        }

        string IPersistableModel<BackendAuthorizationHeaderCredentials>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
