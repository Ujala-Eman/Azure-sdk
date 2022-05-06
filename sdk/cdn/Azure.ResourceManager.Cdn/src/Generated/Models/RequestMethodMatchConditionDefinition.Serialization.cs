// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    public partial class RequestMethodMatchConditionDefinition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("typeName");
            writer.WriteStringValue(TypeDefinition.ToString());
            writer.WritePropertyName("operator");
            writer.WriteStringValue(Operator.ToString());
            if (Optional.IsDefined(NegateCondition))
            {
                writer.WritePropertyName("negateCondition");
                writer.WriteBooleanValue(NegateCondition.Value);
            }
            if (Optional.IsCollectionDefined(Transforms))
            {
                writer.WritePropertyName("transforms");
                writer.WriteStartArray();
                foreach (var item in Transforms)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MatchValues))
            {
                writer.WritePropertyName("matchValues");
                writer.WriteStartArray();
                foreach (var item in MatchValues)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        internal static RequestMethodMatchConditionDefinition DeserializeRequestMethodMatchConditionDefinition(JsonElement element)
        {
            RequestMethodMatchConditionType typeName = default;
            RequestMethodOperator @operator = default;
            Optional<bool> negateCondition = default;
            Optional<IList<PreTransformCategory>> transforms = default;
            Optional<IList<RequestMethodMatchConditionParametersMatchValuesItem>> matchValues = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("typeName"))
                {
                    typeName = new RequestMethodMatchConditionType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("operator"))
                {
                    @operator = new RequestMethodOperator(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("negateCondition"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    negateCondition = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("transforms"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<PreTransformCategory> array = new List<PreTransformCategory>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new PreTransformCategory(item.GetString()));
                    }
                    transforms = array;
                    continue;
                }
                if (property.NameEquals("matchValues"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RequestMethodMatchConditionParametersMatchValuesItem> array = new List<RequestMethodMatchConditionParametersMatchValuesItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(new RequestMethodMatchConditionParametersMatchValuesItem(item.GetString()));
                    }
                    matchValues = array;
                    continue;
                }
            }
            return new RequestMethodMatchConditionDefinition(typeName, @operator, Optional.ToNullable(negateCondition), Optional.ToList(transforms), Optional.ToList(matchValues));
        }
    }
}
