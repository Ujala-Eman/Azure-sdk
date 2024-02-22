// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyTokenRestriction : IUtf8JsonSerializable, IJsonModel<ContentKeyPolicyTokenRestriction>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ContentKeyPolicyTokenRestriction>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ContentKeyPolicyTokenRestriction>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyTokenRestriction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyTokenRestriction)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("issuer"u8);
            writer.WriteStringValue(Issuer);
            writer.WritePropertyName("audience"u8);
            writer.WriteStringValue(Audience);
            if (PrimaryVerificationKey != null)
            {
                writer.WritePropertyName("primaryVerificationKey"u8);
                writer.WriteObjectValue(PrimaryVerificationKey);
            }
            else
            {
                writer.WriteNull("primaryVerificationKey");
            }
            if (Optional.IsCollectionDefined(AlternateVerificationKeys))
            {
                writer.WritePropertyName("alternateVerificationKeys"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateVerificationKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RequiredClaims))
            {
                writer.WritePropertyName("requiredClaims"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredClaims)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("restrictionTokenType"u8);
            writer.WriteStringValue(RestrictionTokenType.ToString());
            if (Optional.IsDefined(OpenIdConnectDiscoveryDocument))
            {
                writer.WritePropertyName("openIdConnectDiscoveryDocument"u8);
                writer.WriteStringValue(OpenIdConnectDiscoveryDocument);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
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

        ContentKeyPolicyTokenRestriction IJsonModel<ContentKeyPolicyTokenRestriction>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyTokenRestriction>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ContentKeyPolicyTokenRestriction)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeContentKeyPolicyTokenRestriction(document.RootElement, options);
        }

        internal static ContentKeyPolicyTokenRestriction DeserializeContentKeyPolicyTokenRestriction(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string issuer = default;
            string audience = default;
            ContentKeyPolicyRestrictionTokenKey primaryVerificationKey = default;
            Optional<IList<ContentKeyPolicyRestrictionTokenKey>> alternateVerificationKeys = default;
            Optional<IList<ContentKeyPolicyTokenClaim>> requiredClaims = default;
            ContentKeyPolicyRestrictionTokenType restrictionTokenType = default;
            Optional<string> openIdConnectDiscoveryDocument = default;
            string odataType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"u8))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryVerificationKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryVerificationKey = null;
                        continue;
                    }
                    primaryVerificationKey = ContentKeyPolicyRestrictionTokenKey.DeserializeContentKeyPolicyRestrictionTokenKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("alternateVerificationKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContentKeyPolicyRestrictionTokenKey> array = new List<ContentKeyPolicyRestrictionTokenKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyRestrictionTokenKey.DeserializeContentKeyPolicyRestrictionTokenKey(item, options));
                    }
                    alternateVerificationKeys = array;
                    continue;
                }
                if (property.NameEquals("requiredClaims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContentKeyPolicyTokenClaim> array = new List<ContentKeyPolicyTokenClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyTokenClaim.DeserializeContentKeyPolicyTokenClaim(item, options));
                    }
                    requiredClaims = array;
                    continue;
                }
                if (property.NameEquals("restrictionTokenType"u8))
                {
                    restrictionTokenType = new ContentKeyPolicyRestrictionTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openIdConnectDiscoveryDocument"u8))
                {
                    openIdConnectDiscoveryDocument = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ContentKeyPolicyTokenRestriction(odataType, serializedAdditionalRawData, issuer, audience, primaryVerificationKey, Optional.ToList(alternateVerificationKeys), Optional.ToList(requiredClaims), restrictionTokenType, openIdConnectDiscoveryDocument.Value);
        }

        BinaryData IPersistableModel<ContentKeyPolicyTokenRestriction>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyTokenRestriction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyTokenRestriction)} does not support '{options.Format}' format.");
            }
        }

        ContentKeyPolicyTokenRestriction IPersistableModel<ContentKeyPolicyTokenRestriction>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ContentKeyPolicyTokenRestriction>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeContentKeyPolicyTokenRestriction(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ContentKeyPolicyTokenRestriction)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ContentKeyPolicyTokenRestriction>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
