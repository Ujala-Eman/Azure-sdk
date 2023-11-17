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

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    public partial class NamedPartitionAddOrRemoveScalingMechanism : IUtf8JsonSerializable, IJsonModel<NamedPartitionAddOrRemoveScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NamedPartitionAddOrRemoveScalingMechanism>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<NamedPartitionAddOrRemoveScalingMechanism>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<NamedPartitionAddOrRemoveScalingMechanism>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<NamedPartitionAddOrRemoveScalingMechanism>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("minPartitionCount"u8);
            writer.WriteNumberValue(MinPartitionCount);
            writer.WritePropertyName("maxPartitionCount"u8);
            writer.WriteNumberValue(MaxPartitionCount);
            writer.WritePropertyName("scaleIncrement"u8);
            writer.WriteNumberValue(ScaleIncrement);
            writer.WritePropertyName("kind"u8);
            writer.WriteStringValue(Kind.ToString());
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

        NamedPartitionAddOrRemoveScalingMechanism IJsonModel<NamedPartitionAddOrRemoveScalingMechanism>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NamedPartitionAddOrRemoveScalingMechanism)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNamedPartitionAddOrRemoveScalingMechanism(document.RootElement, options);
        }

        internal static NamedPartitionAddOrRemoveScalingMechanism DeserializeNamedPartitionAddOrRemoveScalingMechanism(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int minPartitionCount = default;
            int maxPartitionCount = default;
            int scaleIncrement = default;
            ServiceScalingMechanismKind kind = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("minPartitionCount"u8))
                {
                    minPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxPartitionCount"u8))
                {
                    maxPartitionCount = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("scaleIncrement"u8))
                {
                    scaleIncrement = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"u8))
                {
                    kind = new ServiceScalingMechanismKind(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new NamedPartitionAddOrRemoveScalingMechanism(kind, serializedAdditionalRawData, minPartitionCount, maxPartitionCount, scaleIncrement);
        }

        BinaryData IPersistableModel<NamedPartitionAddOrRemoveScalingMechanism>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NamedPartitionAddOrRemoveScalingMechanism)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        NamedPartitionAddOrRemoveScalingMechanism IPersistableModel<NamedPartitionAddOrRemoveScalingMechanism>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(NamedPartitionAddOrRemoveScalingMechanism)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeNamedPartitionAddOrRemoveScalingMechanism(document.RootElement, options);
        }

        string IPersistableModel<NamedPartitionAddOrRemoveScalingMechanism>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
