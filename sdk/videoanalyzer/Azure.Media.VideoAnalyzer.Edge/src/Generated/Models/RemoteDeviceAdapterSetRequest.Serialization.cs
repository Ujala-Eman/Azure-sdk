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

namespace Azure.Media.VideoAnalyzer.Edge.Models
{
    public partial class RemoteDeviceAdapterSetRequest : IUtf8JsonSerializable, IJsonModel<RemoteDeviceAdapterSetRequest>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RemoteDeviceAdapterSetRequest>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RemoteDeviceAdapterSetRequest>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("remoteDeviceAdapter"u8);
            writer.WriteObjectValue(RemoteDeviceAdapter);
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                writer.WritePropertyName("methodName"u8);
                writer.WriteStringValue(MethodName);
            }
            if (Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("@apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        RemoteDeviceAdapterSetRequest IJsonModel<RemoteDeviceAdapterSetRequest>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemoteDeviceAdapterSetRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRemoteDeviceAdapterSetRequest(document.RootElement, options);
        }

        internal static RemoteDeviceAdapterSetRequest DeserializeRemoteDeviceAdapterSetRequest(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            RemoteDeviceAdapter remoteDeviceAdapter = default;
            string methodName = default;
            Optional<string> apiVersion = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("remoteDeviceAdapter"u8))
                {
                    remoteDeviceAdapter = RemoteDeviceAdapter.DeserializeRemoteDeviceAdapter(property.Value);
                    continue;
                }
                if (property.NameEquals("methodName"u8))
                {
                    methodName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@apiVersion"u8))
                {
                    apiVersion = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RemoteDeviceAdapterSetRequest(methodName, apiVersion.Value, serializedAdditionalRawData, remoteDeviceAdapter);
        }

        BinaryData IModel<RemoteDeviceAdapterSetRequest>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemoteDeviceAdapterSetRequest)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RemoteDeviceAdapterSetRequest IModel<RemoteDeviceAdapterSetRequest>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RemoteDeviceAdapterSetRequest)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRemoteDeviceAdapterSetRequest(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RemoteDeviceAdapterSetRequest>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
