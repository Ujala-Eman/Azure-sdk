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
using Azure.ResourceManager.Resources.Models;

namespace Azure.ResourceManager.Resources
{
    public partial class TenantData : IUtf8JsonSerializable, IJsonModel<TenantData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<TenantData>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<TenantData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<TenantData>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<TenantData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Id))
                {
                    writer.WritePropertyName("id"u8);
                    writer.WriteStringValue(Id);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TenantId))
                {
                    writer.WritePropertyName("tenantId"u8);
                    writer.WriteStringValue(TenantId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TenantCategory))
                {
                    writer.WritePropertyName("tenantCategory"u8);
                    writer.WriteStringValue(TenantCategory.Value.ToSerialString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Country))
                {
                    writer.WritePropertyName("country"u8);
                    writer.WriteStringValue(Country);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CountryCode))
                {
                    writer.WritePropertyName("countryCode"u8);
                    writer.WriteStringValue(CountryCode);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DisplayName))
                {
                    writer.WritePropertyName("displayName"u8);
                    writer.WriteStringValue(DisplayName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Domains))
                {
                    writer.WritePropertyName("domains"u8);
                    writer.WriteStartArray();
                    foreach (var item in Domains)
                    {
                        writer.WriteStringValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(DefaultDomain))
                {
                    writer.WritePropertyName("defaultDomain"u8);
                    writer.WriteStringValue(DefaultDomain);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TenantType))
                {
                    writer.WritePropertyName("tenantType"u8);
                    writer.WriteStringValue(TenantType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TenantBrandingLogoUri))
                {
                    writer.WritePropertyName("tenantBrandingLogoUrl"u8);
                    writer.WriteStringValue(TenantBrandingLogoUri.AbsoluteUri);
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

        TenantData IJsonModel<TenantData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeTenantData(document.RootElement, options);
        }

        internal static TenantData DeserializeTenantData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> id = default;
            Optional<Guid> tenantId = default;
            Optional<TenantCategory> tenantCategory = default;
            Optional<string> country = default;
            Optional<string> countryCode = default;
            Optional<string> displayName = default;
            Optional<IReadOnlyList<string>> domains = default;
            Optional<string> defaultDomain = default;
            Optional<string> tenantType = default;
            Optional<Uri> tenantBrandingLogoUrl = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("tenantCategory"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantCategory = property.Value.GetString().ToTenantCategory();
                    continue;
                }
                if (property.NameEquals("country"u8))
                {
                    country = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("countryCode"u8))
                {
                    countryCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("domains"u8))
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
                    domains = array;
                    continue;
                }
                if (property.NameEquals("defaultDomain"u8))
                {
                    defaultDomain = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantType"u8))
                {
                    tenantType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tenantBrandingLogoUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    tenantBrandingLogoUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new TenantData(id.Value, Optional.ToNullable(tenantId), Optional.ToNullable(tenantCategory), country.Value, countryCode.Value, displayName.Value, Optional.ToList(domains), defaultDomain.Value, tenantType.Value, tenantBrandingLogoUrl.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<TenantData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        TenantData IPersistableModel<TenantData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(TenantData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeTenantData(document.RootElement, options);
        }

        string IPersistableModel<TenantData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
