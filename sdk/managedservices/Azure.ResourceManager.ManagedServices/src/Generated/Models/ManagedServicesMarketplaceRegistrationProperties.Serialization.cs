// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ManagedServices.Models
{
    public partial class ManagedServicesMarketplaceRegistrationProperties : IUtf8JsonSerializable, IJsonModel<ManagedServicesMarketplaceRegistrationProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ManagedServicesMarketplaceRegistrationProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ManagedServicesMarketplaceRegistrationProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("managedByTenantId"u8);
            writer.WriteStringValue(ManagedByTenantId);
            writer.WritePropertyName("authorizations"u8);
            writer.WriteStartArray();
            foreach (var item in Authorizations)
            {
                writer.WriteObjectValue(item);
            }
            writer.WriteEndArray();
            if (!(EligibleAuthorizations is ChangeTrackingList<ManagedServicesEligibleAuthorization> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("eligibleAuthorizations"u8);
                writer.WriteStartArray();
                foreach (var item in EligibleAuthorizations)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (OfferDisplayName != null)
            {
                writer.WritePropertyName("offerDisplayName"u8);
                writer.WriteStringValue(OfferDisplayName);
            }
            if (PublisherDisplayName != null)
            {
                writer.WritePropertyName("publisherDisplayName"u8);
                writer.WriteStringValue(PublisherDisplayName);
            }
            if (PlanDisplayName != null)
            {
                writer.WritePropertyName("planDisplayName"u8);
                writer.WriteStringValue(PlanDisplayName);
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

        ManagedServicesMarketplaceRegistrationProperties IJsonModel<ManagedServicesMarketplaceRegistrationProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeManagedServicesMarketplaceRegistrationProperties(document.RootElement, options);
        }

        internal static ManagedServicesMarketplaceRegistrationProperties DeserializeManagedServicesMarketplaceRegistrationProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid managedByTenantId = default;
            IReadOnlyList<ManagedServicesAuthorization> authorizations = default;
            IReadOnlyList<ManagedServicesEligibleAuthorization> eligibleAuthorizations = default;
            string offerDisplayName = default;
            string publisherDisplayName = default;
            string planDisplayName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("managedByTenantId"u8))
                {
                    managedByTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("authorizations"u8))
                {
                    List<ManagedServicesAuthorization> array = new List<ManagedServicesAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesAuthorization.DeserializeManagedServicesAuthorization(item, options));
                    }
                    authorizations = array;
                    continue;
                }
                if (property.NameEquals("eligibleAuthorizations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ManagedServicesEligibleAuthorization> array = new List<ManagedServicesEligibleAuthorization>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ManagedServicesEligibleAuthorization.DeserializeManagedServicesEligibleAuthorization(item, options));
                    }
                    eligibleAuthorizations = array;
                    continue;
                }
                if (property.NameEquals("offerDisplayName"u8))
                {
                    offerDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisherDisplayName"u8))
                {
                    publisherDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("planDisplayName"u8))
                {
                    planDisplayName = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ManagedServicesMarketplaceRegistrationProperties(
                managedByTenantId,
                authorizations,
                eligibleAuthorizations ?? new ChangeTrackingList<ManagedServicesEligibleAuthorization>(),
                offerDisplayName,
                publisherDisplayName,
                planDisplayName,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        ManagedServicesMarketplaceRegistrationProperties IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeManagedServicesMarketplaceRegistrationProperties(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ManagedServicesMarketplaceRegistrationProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ManagedServicesMarketplaceRegistrationProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
