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

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class InMageVolumeExclusionOptions : IUtf8JsonSerializable, IJsonModel<InMageVolumeExclusionOptions>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<InMageVolumeExclusionOptions>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<InMageVolumeExclusionOptions>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<InMageVolumeExclusionOptions>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<InMageVolumeExclusionOptions>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(VolumeLabel))
            {
                writer.WritePropertyName("volumeLabel"u8);
                writer.WriteStringValue(VolumeLabel);
            }
            if (Optional.IsDefined(OnlyExcludeIfSingleVolume))
            {
                writer.WritePropertyName("onlyExcludeIfSingleVolume"u8);
                writer.WriteStringValue(OnlyExcludeIfSingleVolume);
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

        InMageVolumeExclusionOptions IJsonModel<InMageVolumeExclusionOptions>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageVolumeExclusionOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeInMageVolumeExclusionOptions(document.RootElement, options);
        }

        internal static InMageVolumeExclusionOptions DeserializeInMageVolumeExclusionOptions(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> volumeLabel = default;
            Optional<string> onlyExcludeIfSingleVolume = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("volumeLabel"u8))
                {
                    volumeLabel = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("onlyExcludeIfSingleVolume"u8))
                {
                    onlyExcludeIfSingleVolume = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new InMageVolumeExclusionOptions(volumeLabel.Value, onlyExcludeIfSingleVolume.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<InMageVolumeExclusionOptions>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageVolumeExclusionOptions)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        InMageVolumeExclusionOptions IPersistableModel<InMageVolumeExclusionOptions>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(InMageVolumeExclusionOptions)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeInMageVolumeExclusionOptions(document.RootElement, options);
        }

        string IPersistableModel<InMageVolumeExclusionOptions>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
