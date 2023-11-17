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

namespace Azure.ResourceManager.Sql.Models
{
    public partial class SqlServicePrincipal : IUtf8JsonSerializable, IJsonModel<SqlServicePrincipal>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SqlServicePrincipal>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SqlServicePrincipal>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SqlServicePrincipal>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SqlServicePrincipal>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PrincipalId))
                {
                    writer.WritePropertyName("principalId"u8);
                    writer.WriteStringValue(PrincipalId.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ClientId))
                {
                    writer.WritePropertyName("clientId"u8);
                    writer.WriteStringValue(ClientId.Value);
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
            if (Optional.IsDefined(PrincipalType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(PrincipalType.Value.ToString());
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

        SqlServicePrincipal IJsonModel<SqlServicePrincipal>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlServicePrincipal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSqlServicePrincipal(document.RootElement, options);
        }

        internal static SqlServicePrincipal DeserializeSqlServicePrincipal(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<Guid> principalId = default;
            Optional<Guid> clientId = default;
            Optional<Guid> tenantId = default;
            Optional<SqlServicePrincipalType> type = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("principalId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    principalId = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("clientId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    clientId = property.Value.GetGuid();
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
                if (property.NameEquals("type"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    type = new SqlServicePrincipalType(property.Value.GetString());
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SqlServicePrincipal(Optional.ToNullable(principalId), Optional.ToNullable(clientId), Optional.ToNullable(tenantId), Optional.ToNullable(type), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SqlServicePrincipal>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlServicePrincipal)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SqlServicePrincipal IPersistableModel<SqlServicePrincipal>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SqlServicePrincipal)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSqlServicePrincipal(document.RootElement, options);
        }

        string IPersistableModel<SqlServicePrincipal>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
