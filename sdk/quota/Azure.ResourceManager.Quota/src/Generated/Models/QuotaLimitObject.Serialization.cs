// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Quota.Models
{
    public partial class QuotaLimitObject : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("value"u8);
            writer.WriteNumberValue(Value);
            if (Optional.IsDefined(LimitType))
            {
                writer.WritePropertyName("limitType"u8);
                writer.WriteStringValue(LimitType.Value.ToString());
            }
            writer.WritePropertyName("limitObjectType"u8);
            writer.WriteStringValue(LimitObjectType.ToString());
            writer.WriteEndObject();
        }

        internal static QuotaLimitObject DeserializeQuotaLimitObject(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            int value = default;
            Optional<QuotaLimitType> limitType = default;
            LimitType limitObjectType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"u8))
                {
                    value = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("limitType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    limitType = new QuotaLimitType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("limitObjectType"u8))
                {
                    limitObjectType = new LimitType(property.Value.GetString());
                    continue;
                }
            }
            return new QuotaLimitObject(limitObjectType, value, Optional.ToNullable(limitType));
        }
    }
}
