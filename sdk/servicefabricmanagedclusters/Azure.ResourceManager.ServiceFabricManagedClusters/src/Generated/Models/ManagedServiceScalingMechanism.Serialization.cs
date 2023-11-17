// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabricManagedClusters.Models
{
    [PersistableModelProxy(typeof(UnknownScalingMechanism))]
    public partial class ManagedServiceScalingMechanism : IUtf8JsonSerializable, IJsonModel<ManagedServiceScalingMechanism>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServiceScalingMechanism>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServiceScalingMechanism>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ManagedServiceScalingMechanism>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ManagedServiceScalingMechanism>)} interface");
            }

            writer.WriteStartObject();
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

        ManagedServiceScalingMechanism IJsonModel<ManagedServiceScalingMechanism>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServiceScalingMechanism(document.RootElement, options);
        }

        internal static ManagedServiceScalingMechanism DeserializeManagedServiceScalingMechanism(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("kind", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AddRemoveIncrementalNamedPartition": return NamedPartitionAddOrRemoveScalingMechanism.DeserializeNamedPartitionAddOrRemoveScalingMechanism(element);
                    case "ScalePartitionInstanceCount": return PartitionInstanceCountScalingMechanism.DeserializePartitionInstanceCountScalingMechanism(element);
                }
            }
            return UnknownScalingMechanism.DeserializeUnknownScalingMechanism(element);
        }

        BinaryData IPersistableModel<ManagedServiceScalingMechanism>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ManagedServiceScalingMechanism IPersistableModel<ManagedServiceScalingMechanism>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ManagedServiceScalingMechanism)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeManagedServiceScalingMechanism(document.RootElement, options);
        }

        string IPersistableModel<ManagedServiceScalingMechanism>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
