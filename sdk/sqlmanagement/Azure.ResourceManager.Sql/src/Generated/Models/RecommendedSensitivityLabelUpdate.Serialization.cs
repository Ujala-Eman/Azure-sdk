// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    public partial class RecommendedSensitivityLabelUpdate : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Op))
            {
                writer.WritePropertyName("op");
                writer.WriteStringValue(Op.Value.ToSerialString());
            }
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("schema");
                writer.WriteStringValue(Schema);
            }
            if (Optional.IsDefined(Table))
            {
                writer.WritePropertyName("table");
                writer.WriteStringValue(Table);
            }
            if (Optional.IsDefined(Column))
            {
                writer.WritePropertyName("column");
                writer.WriteStringValue(Column);
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static RecommendedSensitivityLabelUpdate DeserializeRecommendedSensitivityLabelUpdate(JsonElement element)
        {
            Optional<string> id = default;
            Optional<string> name = default;
            Optional<string> type = default;
            Optional<RecommendedSensitivityLabelUpdateKind> op = default;
            Optional<string> schema = default;
            Optional<string> table = default;
            Optional<string> column = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("op"))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                property0.ThrowNonNullablePropertyIsNull();
                                continue;
                            }
                            op = property0.Value.GetString().ToRecommendedSensitivityLabelUpdateKind();
                            continue;
                        }
                        if (property0.NameEquals("schema"))
                        {
                            schema = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("table"))
                        {
                            table = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("column"))
                        {
                            column = property0.Value.GetString();
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new RecommendedSensitivityLabelUpdate(id.Value, name.Value, type.Value, Optional.ToNullable(op), schema.Value, table.Value, column.Value);
        }
    }
}
