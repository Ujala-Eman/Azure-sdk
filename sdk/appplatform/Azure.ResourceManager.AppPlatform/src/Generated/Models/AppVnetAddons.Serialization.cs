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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppVnetAddons : IUtf8JsonSerializable, IJsonModel<AppVnetAddons>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppVnetAddons>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppVnetAddons>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppVnetAddons>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppVnetAddons>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(IsPublicEndpoint))
            {
                writer.WritePropertyName("publicEndpoint"u8);
                writer.WriteBooleanValue(IsPublicEndpoint.Value);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PublicEndpointUri))
                {
                    writer.WritePropertyName("publicEndpointUrl"u8);
                    writer.WriteStringValue(PublicEndpointUri.AbsoluteUri);
                }
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

        AppVnetAddons IJsonModel<AppVnetAddons>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppVnetAddons)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppVnetAddons(document.RootElement, options);
        }

        internal static AppVnetAddons DeserializeAppVnetAddons(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<bool> publicEndpoint = default;
            Optional<Uri> publicEndpointUri = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publicEndpoint"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicEndpoint = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("publicEndpointUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    publicEndpointUri = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppVnetAddons(Optional.ToNullable(publicEndpoint), publicEndpointUri.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppVnetAddons>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppVnetAddons)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppVnetAddons IPersistableModel<AppVnetAddons>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppVnetAddons)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppVnetAddons(document.RootElement, options);
        }

        string IPersistableModel<AppVnetAddons>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
