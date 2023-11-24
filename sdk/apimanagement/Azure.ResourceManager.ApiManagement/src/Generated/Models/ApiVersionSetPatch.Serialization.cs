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

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiVersionSetPatch : IUtf8JsonSerializable, IJsonModel<ApiVersionSetPatch>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ApiVersionSetPatch>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ApiVersionSetPatch>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiVersionSetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApiVersionSetPatch)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(VersionQueryName))
            {
                writer.WritePropertyName("versionQueryName"u8);
                writer.WriteStringValue(VersionQueryName);
            }
            if (Optional.IsDefined(VersionHeaderName))
            {
                writer.WritePropertyName("versionHeaderName"u8);
                writer.WriteStringValue(VersionHeaderName);
            }
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(VersioningScheme))
            {
                writer.WritePropertyName("versioningScheme"u8);
                writer.WriteStringValue(VersioningScheme.Value.ToString());
            }
            writer.WriteEndObject();
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

        ApiVersionSetPatch IJsonModel<ApiVersionSetPatch>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiVersionSetPatch>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(ApiVersionSetPatch)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeApiVersionSetPatch(document.RootElement, options);
        }

        internal static ApiVersionSetPatch DeserializeApiVersionSetPatch(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> description = default;
            Optional<string> versionQueryName = default;
            Optional<string> versionHeaderName = default;
            Optional<string> displayName = default;
            Optional<VersioningScheme> versioningScheme = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("versionQueryName"u8))
                        {
                            versionQueryName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("versionHeaderName"u8))
                        {
                            versionHeaderName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("versioningScheme"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            versioningScheme = new VersioningScheme(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ApiVersionSetPatch(description.Value, versionQueryName.Value, versionHeaderName.Value, displayName.Value, Optional.ToNullable(versioningScheme), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ApiVersionSetPatch>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiVersionSetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(ApiVersionSetPatch)} does not support '{options.Format}' format.");
            }
        }

        ApiVersionSetPatch IPersistableModel<ApiVersionSetPatch>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ApiVersionSetPatch>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeApiVersionSetPatch(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(ApiVersionSetPatch)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ApiVersionSetPatch>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
