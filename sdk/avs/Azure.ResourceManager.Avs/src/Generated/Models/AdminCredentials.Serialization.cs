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
    public partial class AdminCredentials : IUtf8JsonSerializable, IJsonModel<AdminCredentials>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AdminCredentials>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AdminCredentials>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AdminCredentials>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AdminCredentials>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NsxtUsername))
                {
                    writer.WritePropertyName("nsxtUsername"u8);
                    writer.WriteStringValue(NsxtUsername);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NsxtPassword))
                {
                    writer.WritePropertyName("nsxtPassword"u8);
                    writer.WriteStringValue(NsxtPassword);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VCenterUsername))
                {
                    writer.WritePropertyName("vcenterUsername"u8);
                    writer.WriteStringValue(VCenterUsername);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(VCenterPassword))
                {
                    writer.WritePropertyName("vcenterPassword"u8);
                    writer.WriteStringValue(VCenterPassword);
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

        AdminCredentials IJsonModel<AdminCredentials>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AdminCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAdminCredentials(document.RootElement, options);
        }

        internal static AdminCredentials DeserializeAdminCredentials(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> nsxtUsername = default;
            Optional<string> nsxtPassword = default;
            Optional<string> vcenterUsername = default;
            Optional<string> vcenterPassword = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("nsxtUsername"u8))
                {
                    nsxtUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("nsxtPassword"u8))
                {
                    nsxtPassword = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcenterUsername"u8))
                {
                    vcenterUsername = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vcenterPassword"u8))
                {
                    vcenterPassword = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AdminCredentials(nsxtUsername.Value, nsxtPassword.Value, vcenterUsername.Value, vcenterPassword.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AdminCredentials>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AdminCredentials)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AdminCredentials IPersistableModel<AdminCredentials>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AdminCredentials)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAdminCredentials(document.RootElement, options);
        }

        string IPersistableModel<AdminCredentials>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
