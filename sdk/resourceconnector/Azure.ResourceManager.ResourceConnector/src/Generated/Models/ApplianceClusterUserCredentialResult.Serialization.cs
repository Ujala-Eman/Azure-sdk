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

namespace Azure.ResourceManager.ResourceConnector.Models
{
    public partial class ApplianceClusterUserCredentialResult : IUtf8JsonSerializable, IJsonModel<ApplianceClusterUserCredentialResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplianceClusterUserCredentialResult>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApplianceClusterUserCredentialResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplianceClusterUserCredentialResult>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplianceClusterUserCredentialResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(HybridConnectionConfig))
                {
                    writer.WritePropertyName("hybridConnectionConfig"u8);
                    writer.WriteObjectValue(HybridConnectionConfig);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Kubeconfigs))
                {
                    writer.WritePropertyName("kubeconfigs"u8);
                    writer.WriteStartArray();
                    foreach (var item in Kubeconfigs)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
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

        ApplianceClusterUserCredentialResult IJsonModel<ApplianceClusterUserCredentialResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceClusterUserCredentialResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplianceClusterUserCredentialResult(document.RootElement, options);
        }

        internal static ApplianceClusterUserCredentialResult DeserializeApplianceClusterUserCredentialResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<HybridConnectionConfig> hybridConnectionConfig = default;
            Optional<IReadOnlyList<ApplianceCredentialKubeconfig>> kubeconfigs = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hybridConnectionConfig"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    hybridConnectionConfig = HybridConnectionConfig.DeserializeHybridConnectionConfig(property.Value);
                    continue;
                }
                if (property.NameEquals("kubeconfigs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ApplianceCredentialKubeconfig> array = new List<ApplianceCredentialKubeconfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ApplianceCredentialKubeconfig.DeserializeApplianceCredentialKubeconfig(item));
                    }
                    kubeconfigs = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplianceClusterUserCredentialResult(hybridConnectionConfig.Value, Optional.ToList(kubeconfigs), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplianceClusterUserCredentialResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceClusterUserCredentialResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplianceClusterUserCredentialResult IPersistableModel<ApplianceClusterUserCredentialResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplianceClusterUserCredentialResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplianceClusterUserCredentialResult(document.RootElement, options);
        }

        string IPersistableModel<ApplianceClusterUserCredentialResult>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
