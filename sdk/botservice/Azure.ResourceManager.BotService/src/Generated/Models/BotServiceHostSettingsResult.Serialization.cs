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

namespace Azure.ResourceManager.BotService.Models
{
    public partial class BotServiceHostSettingsResult : IUtf8JsonSerializable, IJsonModel<BotServiceHostSettingsResult>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BotServiceHostSettingsResult>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<BotServiceHostSettingsResult>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<BotServiceHostSettingsResult>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<BotServiceHostSettingsResult>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(OAuthUri))
            {
                writer.WritePropertyName("OAuthUrl"u8);
                writer.WriteStringValue(OAuthUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ToBotFromChannelOpenIdMetadataUri))
            {
                writer.WritePropertyName("ToBotFromChannelOpenIdMetadataUrl"u8);
                writer.WriteStringValue(ToBotFromChannelOpenIdMetadataUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ToBotFromChannelTokenIssuer))
            {
                writer.WritePropertyName("ToBotFromChannelTokenIssuer"u8);
                writer.WriteStringValue(ToBotFromChannelTokenIssuer);
            }
            if (Optional.IsDefined(ToBotFromEmulatorOpenIdMetadataUri))
            {
                writer.WritePropertyName("ToBotFromEmulatorOpenIdMetadataUrl"u8);
                writer.WriteStringValue(ToBotFromEmulatorOpenIdMetadataUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ToChannelFromBotLoginUri))
            {
                writer.WritePropertyName("ToChannelFromBotLoginUrl"u8);
                writer.WriteStringValue(ToChannelFromBotLoginUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ToChannelFromBotOAuthScope))
            {
                writer.WritePropertyName("ToChannelFromBotOAuthScope"u8);
                writer.WriteStringValue(ToChannelFromBotOAuthScope);
            }
            if (Optional.IsDefined(ValidateAuthority))
            {
                writer.WritePropertyName("ValidateAuthority"u8);
                writer.WriteBooleanValue(ValidateAuthority.Value);
            }
            if (Optional.IsDefined(BotOpenIdMetadata))
            {
                writer.WritePropertyName("BotOpenIdMetadata"u8);
                writer.WriteStringValue(BotOpenIdMetadata);
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

        BotServiceHostSettingsResult IJsonModel<BotServiceHostSettingsResult>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BotServiceHostSettingsResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBotServiceHostSettingsResult(document.RootElement, options);
        }

        internal static BotServiceHostSettingsResult DeserializeBotServiceHostSettingsResult(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Uri> oAuthUrl = default;
            Optional<Uri> toBotFromChannelOpenIdMetadataUrl = default;
            Optional<string> toBotFromChannelTokenIssuer = default;
            Optional<Uri> toBotFromEmulatorOpenIdMetadataUrl = default;
            Optional<Uri> toChannelFromBotLoginUrl = default;
            Optional<string> toChannelFromBotOAuthScope = default;
            Optional<bool> validateAuthority = default;
            Optional<string> botOpenIdMetadata = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("OAuthUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    oAuthUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ToBotFromChannelOpenIdMetadataUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toBotFromChannelOpenIdMetadataUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ToBotFromChannelTokenIssuer"u8))
                {
                    toBotFromChannelTokenIssuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ToBotFromEmulatorOpenIdMetadataUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toBotFromEmulatorOpenIdMetadataUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ToChannelFromBotLoginUrl"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    toChannelFromBotLoginUrl = new Uri(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("ToChannelFromBotOAuthScope"u8))
                {
                    toChannelFromBotOAuthScope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("ValidateAuthority"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    validateAuthority = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("BotOpenIdMetadata"u8))
                {
                    botOpenIdMetadata = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new BotServiceHostSettingsResult(oAuthUrl.Value, toBotFromChannelOpenIdMetadataUrl.Value, toBotFromChannelTokenIssuer.Value, toBotFromEmulatorOpenIdMetadataUrl.Value, toChannelFromBotLoginUrl.Value, toChannelFromBotOAuthScope.Value, Optional.ToNullable(validateAuthority), botOpenIdMetadata.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BotServiceHostSettingsResult>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BotServiceHostSettingsResult)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        BotServiceHostSettingsResult IPersistableModel<BotServiceHostSettingsResult>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(BotServiceHostSettingsResult)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeBotServiceHostSettingsResult(document.RootElement, options);
        }

        string IPersistableModel<BotServiceHostSettingsResult>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
