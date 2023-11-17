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

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    public partial class ApplicationInsightsComponentBillingFeatures : IUtf8JsonSerializable, IJsonModel<ApplicationInsightsComponentBillingFeatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApplicationInsightsComponentBillingFeatures>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ApplicationInsightsComponentBillingFeatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ApplicationInsightsComponentBillingFeatures>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ApplicationInsightsComponentBillingFeatures>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DataVolumeCap))
            {
                writer.WritePropertyName("DataVolumeCap"u8);
                writer.WriteObjectValue(DataVolumeCap);
            }
            if (Optional.IsCollectionDefined(CurrentBillingFeatures))
            {
                writer.WritePropertyName("CurrentBillingFeatures"u8);
                writer.WriteStartArray();
                foreach (var item in CurrentBillingFeatures)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        ApplicationInsightsComponentBillingFeatures IJsonModel<ApplicationInsightsComponentBillingFeatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentBillingFeatures)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApplicationInsightsComponentBillingFeatures(document.RootElement, options);
        }

        internal static ApplicationInsightsComponentBillingFeatures DeserializeApplicationInsightsComponentBillingFeatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ApplicationInsightsComponentDataVolumeCap> dataVolumeCap = default;
            Optional<IList<string>> currentBillingFeatures = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("DataVolumeCap"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dataVolumeCap = ApplicationInsightsComponentDataVolumeCap.DeserializeApplicationInsightsComponentDataVolumeCap(property.Value);
                    continue;
                }
                if (property.NameEquals("CurrentBillingFeatures"u8))
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
                    currentBillingFeatures = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApplicationInsightsComponentBillingFeatures(dataVolumeCap.Value, Optional.ToList(currentBillingFeatures), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApplicationInsightsComponentBillingFeatures>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentBillingFeatures)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ApplicationInsightsComponentBillingFeatures IPersistableModel<ApplicationInsightsComponentBillingFeatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ApplicationInsightsComponentBillingFeatures)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeApplicationInsightsComponentBillingFeatures(document.RootElement, options);
        }

        string IPersistableModel<ApplicationInsightsComponentBillingFeatures>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
