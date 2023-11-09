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

namespace Azure.ResourceManager.AppService.Models
{
    public partial class FunctionAppRuntimes : IUtf8JsonSerializable, IJsonModel<FunctionAppRuntimes>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<FunctionAppRuntimes>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<FunctionAppRuntimes>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(LinuxRuntimeSettings))
                {
                    writer.WritePropertyName("linuxRuntimeSettings"u8);
                    writer.WriteObjectValue(LinuxRuntimeSettings);
                }
            }
            if (options.Format == ModelReaderWriterFormat.Json)
            {
                if (Optional.IsDefined(WindowsRuntimeSettings))
                {
                    writer.WritePropertyName("windowsRuntimeSettings"u8);
                    writer.WriteObjectValue(WindowsRuntimeSettings);
                }
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

        FunctionAppRuntimes IJsonModel<FunctionAppRuntimes>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeFunctionAppRuntimes(document.RootElement, options);
        }

        internal static FunctionAppRuntimes DeserializeFunctionAppRuntimes(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<FunctionAppRuntimeSettings> linuxRuntimeSettings = default;
            Optional<FunctionAppRuntimeSettings> windowsRuntimeSettings = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linuxRuntimeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    linuxRuntimeSettings = FunctionAppRuntimeSettings.DeserializeFunctionAppRuntimeSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("windowsRuntimeSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    windowsRuntimeSettings = FunctionAppRuntimeSettings.DeserializeFunctionAppRuntimeSettings(property.Value);
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new FunctionAppRuntimes(linuxRuntimeSettings.Value, windowsRuntimeSettings.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<FunctionAppRuntimes>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimes)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        FunctionAppRuntimes IModel<FunctionAppRuntimes>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(FunctionAppRuntimes)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeFunctionAppRuntimes(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<FunctionAppRuntimes>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
