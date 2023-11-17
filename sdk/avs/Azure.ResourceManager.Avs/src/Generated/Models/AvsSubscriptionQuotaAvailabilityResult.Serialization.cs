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

namespace Azure.ResourceManager.Avs.Models
{
    public partial class AvsSubscriptionQuotaAvailabilityResult : IUtf8JsonSerializable, IJsonModel<AvsSubscriptionQuotaAvailabilityResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AvsSubscriptionQuotaAvailabilityResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AvsSubscriptionQuotaAvailabilityResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AvsSubscriptionQuotaAvailabilityResult>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(HostsRemaining))
                {
                    writer.WritePropertyName("hostsRemaining"u8);
                    writer.WriteStartObject();
                    foreach (var item in HostsRemaining)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteNumberValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(QuotaEnabled))
                {
                    writer.WritePropertyName("quotaEnabled"u8);
                    writer.WriteStringValue(QuotaEnabled.Value.ToString());
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

        AvsSubscriptionQuotaAvailabilityResult IJsonModel<AvsSubscriptionQuotaAvailabilityResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement, options);
        }

        internal static AvsSubscriptionQuotaAvailabilityResult DeserializeAvsSubscriptionQuotaAvailabilityResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<IReadOnlyDictionary<string, int>> hostsRemaining = default;
            Optional<AvsSubscriptionQuotaEnabled> quotaEnabled = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("hostsRemaining"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, int> dictionary = new Dictionary<string, int>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetInt32());
                    }
                    hostsRemaining = dictionary;
                    continue;
                }
                if (property.NameEquals("quotaEnabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    quotaEnabled = new AvsSubscriptionQuotaEnabled(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AvsSubscriptionQuotaAvailabilityResult(Optional.ToDictionary(hostsRemaining), Optional.ToNullable(quotaEnabled), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AvsSubscriptionQuotaAvailabilityResult IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AvsSubscriptionQuotaAvailabilityResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAvsSubscriptionQuotaAvailabilityResult(document.RootElement, options);
        }

        string IPersistableModel<AvsSubscriptionQuotaAvailabilityResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
