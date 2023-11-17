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

namespace Azure.ResourceManager.Purview.Models
{
    public partial class DefaultPurviewAccountPayload : IUtf8JsonSerializable, IJsonModel<DefaultPurviewAccountPayload>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DefaultPurviewAccountPayload>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<DefaultPurviewAccountPayload>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DefaultPurviewAccountPayload>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DefaultPurviewAccountPayload>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(AccountName))
            {
                writer.WritePropertyName("accountName"u8);
                writer.WriteStringValue(AccountName);
            }
            if (Optional.IsDefined(ResourceGroupName))
            {
                writer.WritePropertyName("resourceGroupName"u8);
                writer.WriteStringValue(ResourceGroupName);
            }
            if (Optional.IsDefined(Scope))
            {
                writer.WritePropertyName("scope"u8);
                writer.WriteStringValue(Scope);
            }
            if (Optional.IsDefined(ScopeTenantId))
            {
                writer.WritePropertyName("scopeTenantId"u8);
                writer.WriteStringValue(ScopeTenantId.Value);
            }
            if (Optional.IsDefined(ScopeType))
            {
                writer.WritePropertyName("scopeType"u8);
                writer.WriteStringValue(ScopeType.Value.ToString());
            }
            if (Optional.IsDefined(SubscriptionId))
            {
                writer.WritePropertyName("subscriptionId"u8);
                writer.WriteStringValue(SubscriptionId);
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

        DefaultPurviewAccountPayload IJsonModel<DefaultPurviewAccountPayload>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefaultPurviewAccountPayload)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDefaultPurviewAccountPayload(document.RootElement, options);
        }

        internal static DefaultPurviewAccountPayload DeserializeDefaultPurviewAccountPayload(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> accountName = default;
            Optional<string> resourceGroupName = default;
            Optional<string> scope = default;
            Optional<Guid> scopeTenantId = default;
            Optional<PurviewAccountScopeType> scopeType = default;
            Optional<string> subscriptionId = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("accountName"u8))
                {
                    accountName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroupName"u8))
                {
                    resourceGroupName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scope"u8))
                {
                    scope = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("scopeTenantId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scopeTenantId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("scopeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scopeType = new PurviewAccountScopeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DefaultPurviewAccountPayload(accountName.Value, resourceGroupName.Value, scope.Value, Optional.ToNullable(scopeTenantId), Optional.ToNullable(scopeType), subscriptionId.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DefaultPurviewAccountPayload>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefaultPurviewAccountPayload)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DefaultPurviewAccountPayload IPersistableModel<DefaultPurviewAccountPayload>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DefaultPurviewAccountPayload)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDefaultPurviewAccountPayload(document.RootElement, options);
        }

        string IPersistableModel<DefaultPurviewAccountPayload>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
