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
    internal partial class UnknownAuthenticationDetailsProperties : IUtf8JsonSerializable, IJsonModel<AuthenticationDetailsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AuthenticationDetailsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AuthenticationDetailsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AuthenticationDetailsProperties)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(AuthenticationProvisioningState))
            {
                writer.WritePropertyName("authenticationProvisioningState"u8);
                writer.WriteStringValue(AuthenticationProvisioningState.Value.ToString());
            }
            if (options.Format != "W" && Optional.IsCollectionDefined(GrantedPermissions))
            {
                writer.WritePropertyName("grantedPermissions"u8);
                writer.WriteStartArray();
                foreach (var item in GrantedPermissions)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("authenticationType"u8);
            writer.WriteStringValue(AuthenticationType.ToString());
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

        AuthenticationDetailsProperties IJsonModel<AuthenticationDetailsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new InvalidOperationException($"The model {nameof(AuthenticationDetailsProperties)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUnknownAuthenticationDetailsProperties(document.RootElement, options);
        }

        internal static UnknownAuthenticationDetailsProperties DeserializeUnknownAuthenticationDetailsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AuthenticationProvisioningState> authenticationProvisioningState = default;
            Optional<IReadOnlyList<SecurityCenterCloudPermission>> grantedPermissions = default;
            AuthenticationType authenticationType = "Unknown";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("authenticationProvisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationProvisioningState = new AuthenticationProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("grantedPermissions"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<SecurityCenterCloudPermission> array = new List<SecurityCenterCloudPermission>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new SecurityCenterCloudPermission(item.GetString()));
                    }
                    grantedPermissions = array;
                    continue;
                }
                if (property.NameEquals("authenticationType"u8))
                {
                    authenticationType = new AuthenticationType(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new UnknownAuthenticationDetailsProperties(Optional.ToNullable(authenticationProvisioningState), Optional.ToList(grantedPermissions), authenticationType, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AuthenticationDetailsProperties>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new InvalidOperationException($"The model {nameof(AuthenticationDetailsProperties)} does not support '{options.Format}' format.");
            }
        }

        AuthenticationDetailsProperties IPersistableModel<AuthenticationDetailsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<AuthenticationDetailsProperties>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUnknownAuthenticationDetailsProperties(document.RootElement, options);
                    }
                default:
                    throw new InvalidOperationException($"The model {nameof(AuthenticationDetailsProperties)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<AuthenticationDetailsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
