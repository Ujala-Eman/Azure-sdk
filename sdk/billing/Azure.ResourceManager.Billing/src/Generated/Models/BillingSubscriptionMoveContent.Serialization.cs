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

namespace Azure.ResourceManager.Billing.Models
{
    public partial class BillingSubscriptionMoveContent : IUtf8JsonSerializable, IJsonModel<BillingSubscriptionMoveContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BillingSubscriptionMoveContent>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BillingSubscriptionMoveContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BillingSubscriptionMoveContent>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BillingSubscriptionMoveContent>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DestinationEnrollmentAccountId))
            {
                writer.WritePropertyName("destinationEnrollmentAccountId"u8);
                writer.WriteStringValue(DestinationEnrollmentAccountId);
            }
            if (Optional.IsDefined(DestinationInvoiceSectionId))
            {
                writer.WritePropertyName("destinationInvoiceSectionId"u8);
                writer.WriteStringValue(DestinationInvoiceSectionId);
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

        BillingSubscriptionMoveContent IJsonModel<BillingSubscriptionMoveContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBillingSubscriptionMoveContent(document.RootElement, options);
        }

        internal static BillingSubscriptionMoveContent DeserializeBillingSubscriptionMoveContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> destinationEnrollmentAccountId = default;
            Optional<ResourceIdentifier> destinationInvoiceSectionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("destinationEnrollmentAccountId"u8))
                {
                    destinationEnrollmentAccountId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("destinationInvoiceSectionId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    destinationInvoiceSectionId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BillingSubscriptionMoveContent(destinationEnrollmentAccountId.Value, destinationInvoiceSectionId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BillingSubscriptionMoveContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BillingSubscriptionMoveContent IPersistableModel<BillingSubscriptionMoveContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BillingSubscriptionMoveContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBillingSubscriptionMoveContent(document.RootElement, options);
        }

        string IPersistableModel<BillingSubscriptionMoveContent>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
