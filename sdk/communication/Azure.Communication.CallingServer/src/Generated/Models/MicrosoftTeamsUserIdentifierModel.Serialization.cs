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

namespace Azure.Communication
{
    internal partial class MicrosoftTeamsUserIdentifierModel : IUtf8JsonSerializable, IJsonModel<MicrosoftTeamsUserIdentifierModel>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MicrosoftTeamsUserIdentifierModel>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MicrosoftTeamsUserIdentifierModel>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftTeamsUserIdentifierModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MicrosoftTeamsUserIdentifierModel)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("userId"u8);
            writer.WriteStringValue(UserId);
            if (Optional.IsDefined(IsAnonymous))
            {
                writer.WritePropertyName("isAnonymous"u8);
                writer.WriteBooleanValue(IsAnonymous.Value);
            }
            if (Optional.IsDefined(Cloud))
            {
                writer.WritePropertyName("cloud"u8);
                writer.WriteStringValue(Cloud.Value.ToString());
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

        MicrosoftTeamsUserIdentifierModel IJsonModel<MicrosoftTeamsUserIdentifierModel>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftTeamsUserIdentifierModel>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(MicrosoftTeamsUserIdentifierModel)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMicrosoftTeamsUserIdentifierModel(document.RootElement, options);
        }

        internal static MicrosoftTeamsUserIdentifierModel DeserializeMicrosoftTeamsUserIdentifierModel(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string userId = default;
            Optional<bool> isAnonymous = default;
            Optional<CommunicationCloudEnvironmentModel> cloud = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("userId"u8))
                {
                    userId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("isAnonymous"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isAnonymous = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("cloud"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cloud = new CommunicationCloudEnvironmentModel(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MicrosoftTeamsUserIdentifierModel(userId, Optional.ToNullable(isAnonymous), Optional.ToNullable(cloud), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MicrosoftTeamsUserIdentifierModel>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftTeamsUserIdentifierModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(MicrosoftTeamsUserIdentifierModel)} does not support '{options.Format}' format.");
            }
        }

        MicrosoftTeamsUserIdentifierModel IPersistableModel<MicrosoftTeamsUserIdentifierModel>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MicrosoftTeamsUserIdentifierModel>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMicrosoftTeamsUserIdentifierModel(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(MicrosoftTeamsUserIdentifierModel)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MicrosoftTeamsUserIdentifierModel>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
