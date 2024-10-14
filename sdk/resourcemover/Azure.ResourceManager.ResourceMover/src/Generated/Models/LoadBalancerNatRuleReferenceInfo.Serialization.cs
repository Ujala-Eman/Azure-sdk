// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class LoadBalancerNatRuleReferenceInfo : IUtf8JsonSerializable, IJsonModel<LoadBalancerNatRuleReferenceInfo>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<LoadBalancerNatRuleReferenceInfo>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<LoadBalancerNatRuleReferenceInfo>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerNatRuleReferenceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerNatRuleReferenceInfo)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
        }

        LoadBalancerNatRuleReferenceInfo IJsonModel<LoadBalancerNatRuleReferenceInfo>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerNatRuleReferenceInfo>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(LoadBalancerNatRuleReferenceInfo)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeLoadBalancerNatRuleReferenceInfo(document.RootElement, options);
        }

        internal static LoadBalancerNatRuleReferenceInfo DeserializeLoadBalancerNatRuleReferenceInfo(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            ResourceIdentifier sourceArmResourceId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sourceArmResourceId"u8))
                {
                    sourceArmResourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new LoadBalancerNatRuleReferenceInfo(sourceArmResourceId, serializedAdditionalRawData, name);
        }

        BinaryData IPersistableModel<LoadBalancerNatRuleReferenceInfo>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerNatRuleReferenceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerNatRuleReferenceInfo)} does not support writing '{options.Format}' format.");
            }
        }

        LoadBalancerNatRuleReferenceInfo IPersistableModel<LoadBalancerNatRuleReferenceInfo>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<LoadBalancerNatRuleReferenceInfo>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeLoadBalancerNatRuleReferenceInfo(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(LoadBalancerNatRuleReferenceInfo)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<LoadBalancerNatRuleReferenceInfo>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
