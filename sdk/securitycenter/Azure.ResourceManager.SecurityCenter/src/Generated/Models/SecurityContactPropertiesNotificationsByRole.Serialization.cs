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

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class SecurityContactPropertiesNotificationsByRole : IUtf8JsonSerializable, IJsonModel<SecurityContactPropertiesNotificationsByRole>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SecurityContactPropertiesNotificationsByRole>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SecurityContactPropertiesNotificationsByRole>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SecurityContactPropertiesNotificationsByRole>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SecurityContactPropertiesNotificationsByRole>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsCollectionDefined(Roles))
            {
                writer.WritePropertyName("roles"u8);
                writer.WriteStartArray();
                foreach (var item in Roles)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
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

        SecurityContactPropertiesNotificationsByRole IJsonModel<SecurityContactPropertiesNotificationsByRole>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityContactPropertiesNotificationsByRole)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSecurityContactPropertiesNotificationsByRole(document.RootElement, options);
        }

        internal static SecurityContactPropertiesNotificationsByRole DeserializeSecurityContactPropertiesNotificationsByRole(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<SecurityAlertNotificationByRoleState> state = default;
            Optional<IList<SecurityAlertReceivingRole>> roles = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new SecurityAlertNotificationByRoleState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("roles"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityAlertReceivingRole> array = new List<SecurityAlertReceivingRole>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityAlertReceivingRole(item.GetString()));
                    }
                    roles = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SecurityContactPropertiesNotificationsByRole(Optional.ToNullable(state), Optional.ToList(roles), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SecurityContactPropertiesNotificationsByRole>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityContactPropertiesNotificationsByRole)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SecurityContactPropertiesNotificationsByRole IPersistableModel<SecurityContactPropertiesNotificationsByRole>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SecurityContactPropertiesNotificationsByRole)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSecurityContactPropertiesNotificationsByRole(document.RootElement, options);
        }

        string IPersistableModel<SecurityContactPropertiesNotificationsByRole>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
