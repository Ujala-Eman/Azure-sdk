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
using Azure.ResourceManager.NetApp;

namespace Azure.ResourceManager.NetApp.Models
{
    internal partial class SnapshotPolicyVolumeList : IUtf8JsonSerializable, IJsonModel<SnapshotPolicyVolumeList>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SnapshotPolicyVolumeList>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SnapshotPolicyVolumeList>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyVolumeList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SnapshotPolicyVolumeList)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStartArray();
                foreach (var item in Value)
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

        SnapshotPolicyVolumeList IJsonModel<SnapshotPolicyVolumeList>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyVolumeList>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(SnapshotPolicyVolumeList)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSnapshotPolicyVolumeList(document.RootElement, options);
        }

        internal static SnapshotPolicyVolumeList DeserializeSnapshotPolicyVolumeList(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyList<NetAppVolumeData>> value = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<NetAppVolumeData> array = new List<NetAppVolumeData>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NetAppVolumeData.DeserializeNetAppVolumeData(item));
                    }
                    value = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SnapshotPolicyVolumeList(Optional.ToList(value), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SnapshotPolicyVolumeList>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyVolumeList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(SnapshotPolicyVolumeList)} does not support '{options.Format}' format.");
            }
        }

        SnapshotPolicyVolumeList IPersistableModel<SnapshotPolicyVolumeList>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SnapshotPolicyVolumeList>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSnapshotPolicyVolumeList(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(SnapshotPolicyVolumeList)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SnapshotPolicyVolumeList>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
