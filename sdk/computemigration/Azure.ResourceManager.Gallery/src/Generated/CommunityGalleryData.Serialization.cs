// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Gallery.Models;

namespace Azure.ResourceManager.Gallery
{
    public partial class CommunityGalleryData : IUtf8JsonSerializable, IJsonModel<CommunityGalleryData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<CommunityGalleryData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<CommunityGalleryData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Disclaimer))
            {
                writer.WritePropertyName("disclaimer"u8);
                writer.WriteStringValue(Disclaimer);
            }
            if (Optional.IsCollectionDefined(ArtifactTags))
            {
                writer.WritePropertyName("artifactTags"u8);
                writer.WriteStartObject();
                foreach (var item in ArtifactTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(CommunityMetadata))
            {
                writer.WritePropertyName("communityMetadata"u8);
                writer.WriteObjectValue(CommunityMetadata, options);
            }
            writer.WriteEndObject();
        }

        CommunityGalleryData IJsonModel<CommunityGalleryData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(CommunityGalleryData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeCommunityGalleryData(document.RootElement, options);
        }

        internal static CommunityGalleryData DeserializeCommunityGalleryData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            AzureLocation? location = default;
            ResourceType? type = default;
            string disclaimer = default;
            IReadOnlyDictionary<string, string> artifactTags = default;
            CommunityGalleryMetadata communityMetadata = default;
            string uniqueId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("disclaimer"u8))
                        {
                            disclaimer = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("artifactTags"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            Dictionary<string, string> dictionary = new Dictionary<string, string>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                dictionary.Add(property1.Name, property1.Value.GetString());
                            }
                            artifactTags = dictionary;
                            continue;
                        }
                        if (property0.NameEquals("communityMetadata"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            communityMetadata = CommunityGalleryMetadata.DeserializeCommunityGalleryMetadata(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (property.NameEquals("identifier"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("uniqueId"u8))
                        {
                            uniqueId = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new CommunityGalleryData(
                name,
                location,
                type,
                uniqueId,
                serializedAdditionalRawData,
                disclaimer,
                artifactTags ?? new ChangeTrackingDictionary<string, string>(),
                communityMetadata);
        }

        BinaryData IPersistableModel<CommunityGalleryData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryData)} does not support writing '{options.Format}' format.");
            }
        }

        CommunityGalleryData IPersistableModel<CommunityGalleryData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<CommunityGalleryData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeCommunityGalleryData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(CommunityGalleryData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<CommunityGalleryData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
