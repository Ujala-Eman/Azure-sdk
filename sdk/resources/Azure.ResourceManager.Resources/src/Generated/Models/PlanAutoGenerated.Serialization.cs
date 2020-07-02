// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class PlanAutoGenerated : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("publisher");
            writer.WriteStringValue(Publisher);
            writer.WritePropertyName("product");
            writer.WriteStringValue(Product);
            if (Optional.IsDefined(PromotionCode))
            {
                writer.WritePropertyName("promotionCode");
                writer.WriteStringValue(PromotionCode);
            }
            writer.WritePropertyName("version");
            writer.WriteStringValue(Version);
            writer.WriteEndObject();
        }

        internal static PlanAutoGenerated DeserializePlanAutoGenerated(JsonElement element)
        {
            string name = default;
            string publisher = default;
            string product = default;
            Optional<string> promotionCode = default;
            string version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("publisher"))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("product"))
                {
                    product = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("promotionCode"))
                {
                    promotionCode = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
            }
            return new PlanAutoGenerated(name, publisher, product, promotionCode.HasValue ? promotionCode.Value : null, version);
        }
    }
}
