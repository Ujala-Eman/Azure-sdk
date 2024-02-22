// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    public partial class DevTestLabEvaluatePoliciesContent : IUtf8JsonSerializable, IJsonModel<DevTestLabEvaluatePoliciesContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DevTestLabEvaluatePoliciesContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DevTestLabEvaluatePoliciesContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePoliciesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabEvaluatePoliciesContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(Policies))
            {
                writer.WritePropertyName("policies"u8);
                writer.WriteStartArray();
                foreach (var item in Policies)
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

        DevTestLabEvaluatePoliciesContent IJsonModel<DevTestLabEvaluatePoliciesContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePoliciesContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(DevTestLabEvaluatePoliciesContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDevTestLabEvaluatePoliciesContent(document.RootElement, options);
        }

        internal static DevTestLabEvaluatePoliciesContent DeserializeDevTestLabEvaluatePoliciesContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IList<DevTestLabEvaluatePolicy>> policies = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("policies"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<DevTestLabEvaluatePolicy> array = new List<DevTestLabEvaluatePolicy>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(DevTestLabEvaluatePolicy.DeserializeDevTestLabEvaluatePolicy(item, options));
                    }
                    policies = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DevTestLabEvaluatePoliciesContent(Optional.ToList(policies), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DevTestLabEvaluatePoliciesContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePoliciesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(DevTestLabEvaluatePoliciesContent)} does not support '{options.Format}' format.");
            }
        }

        DevTestLabEvaluatePoliciesContent IPersistableModel<DevTestLabEvaluatePoliciesContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<DevTestLabEvaluatePoliciesContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeDevTestLabEvaluatePoliciesContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(DevTestLabEvaluatePoliciesContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<DevTestLabEvaluatePoliciesContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
