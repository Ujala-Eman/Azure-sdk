// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ComputeFleet.Models
{
    public partial class ComputeFleetSecurityPostureReference : IUtf8JsonSerializable, IJsonModel<ComputeFleetSecurityPostureReference>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComputeFleetSecurityPostureReference>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ComputeFleetSecurityPostureReference>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSecurityPostureReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetSecurityPostureReference)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (Optional.IsCollectionDefined(ExcludeExtensions))
            {
                writer.WritePropertyName("excludeExtensions"u8);
                writer.WriteStartArray();
                foreach (var item in ExcludeExtensions)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(IsOverridable))
            {
                writer.WritePropertyName("isOverridable"u8);
                writer.WriteBooleanValue(IsOverridable.Value);
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

        ComputeFleetSecurityPostureReference IJsonModel<ComputeFleetSecurityPostureReference>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSecurityPostureReference>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ComputeFleetSecurityPostureReference)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComputeFleetSecurityPostureReference(document.RootElement, options);
        }

        internal static ComputeFleetSecurityPostureReference DeserializeComputeFleetSecurityPostureReference(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string id = default;
            IList<string> excludeExtensions = default;
            bool? isOverridable = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("excludeExtensions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    excludeExtensions = array;
                    continue;
                }
                if (property.NameEquals("isOverridable"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isOverridable = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new ComputeFleetSecurityPostureReference(id, excludeExtensions ?? new ChangeTrackingList<string>(), isOverridable, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComputeFleetSecurityPostureReference>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSecurityPostureReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetSecurityPostureReference)} does not support writing '{options.Format}' format.");
            }
        }

        ComputeFleetSecurityPostureReference IPersistableModel<ComputeFleetSecurityPostureReference>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ComputeFleetSecurityPostureReference>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeComputeFleetSecurityPostureReference(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ComputeFleetSecurityPostureReference)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ComputeFleetSecurityPostureReference>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
