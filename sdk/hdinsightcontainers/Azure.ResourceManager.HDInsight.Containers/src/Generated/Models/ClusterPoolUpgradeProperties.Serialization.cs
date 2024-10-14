// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HDInsight.Containers.Models
{
    [PersistableModelProxy(typeof(UnknownClusterPoolUpgradeProperties))]
    public partial class ClusterPoolUpgradeProperties : IUtf8JsonSerializable, IJsonModel<ClusterPoolUpgradeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ClusterPoolUpgradeProperties>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ClusterPoolUpgradeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolUpgradeProperties)} does not support writing '{format}' format.");
            }

            writer.WritePropertyName("upgradeType"u8);
            writer.WriteStringValue(UpgradeType.ToString());
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

        ClusterPoolUpgradeProperties IJsonModel<ClusterPoolUpgradeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ClusterPoolUpgradeProperties)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeClusterPoolUpgradeProperties(document.RootElement, options);
        }

        internal static ClusterPoolUpgradeProperties DeserializeClusterPoolUpgradeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("upgradeType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AKSPatchUpgrade": return ClusterPoolAKSPatchVersionUpgradeProperties.DeserializeClusterPoolAKSPatchVersionUpgradeProperties(element, options);
                    case "NodeOsUpgrade": return ClusterPoolNodeOSImageUpdateProperties.DeserializeClusterPoolNodeOSImageUpdateProperties(element, options);
                }
            }
            return UnknownClusterPoolUpgradeProperties.DeserializeUnknownClusterPoolUpgradeProperties(element, options);
        }

        BinaryData IPersistableModel<ClusterPoolUpgradeProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolUpgradeProperties)} does not support writing '{options.Format}' format.");
            }
        }

        ClusterPoolUpgradeProperties IPersistableModel<ClusterPoolUpgradeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ClusterPoolUpgradeProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeClusterPoolUpgradeProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ClusterPoolUpgradeProperties)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ClusterPoolUpgradeProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
