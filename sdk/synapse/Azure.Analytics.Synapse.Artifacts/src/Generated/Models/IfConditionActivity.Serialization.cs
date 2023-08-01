// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(IfConditionActivityConverter))]
    public partial class IfConditionActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name"u8);
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type"u8);
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(State))
            {
                writer.WritePropertyName("state"u8);
                writer.WriteStringValue(State.Value.ToString());
            }
            if (Optional.IsDefined(OnInactiveMarkAs))
            {
                writer.WritePropertyName("onInactiveMarkAs"u8);
                writer.WriteStringValue(OnInactiveMarkAs.Value.ToString());
            }
            if (Optional.IsCollectionDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties"u8);
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties"u8);
            writer.WriteStartObject();
            writer.WritePropertyName("expression"u8);
            writer.WriteObjectValue(Expression);
            if (Optional.IsCollectionDefined(IfTrueActivities))
            {
                writer.WritePropertyName("ifTrueActivities"u8);
                writer.WriteStartArray();
                foreach (var item in IfTrueActivities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(IfFalseActivities))
            {
                writer.WritePropertyName("ifFalseActivities"u8);
                writer.WriteStartArray();
                foreach (var item in IfFalseActivities)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static IfConditionActivity DeserializeIfConditionActivity(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<ActivityState> state = default;
            Optional<ActivityOnInactiveMarkAs> onInactiveMarkAs = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            Expression expression = default;
            Optional<IList<Activity>> ifTrueActivities = default;
            Optional<IList<Activity>> ifFalseActivities = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = new Dictionary<string, object>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"u8))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("state"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    state = new ActivityState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("onInactiveMarkAs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    onInactiveMarkAs = new ActivityOnInactiveMarkAs(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ActivityDependency.DeserializeActivityDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserProperty.DeserializeUserProperty(item));
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("expression"u8))
                        {
                            expression = Expression.DeserializeExpression(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("ifTrueActivities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Activity> array = new List<Activity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeActivity(item));
                            }
                            ifTrueActivities = array;
                            continue;
                        }
                        if (property0.NameEquals("ifFalseActivities"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            List<Activity> array = new List<Activity>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DeserializeActivity(item));
                            }
                            ifFalseActivities = array;
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
            }
            additionalProperties = additionalPropertiesDictionary;
            return new IfConditionActivity(name, type, description.Value, Optional.ToNullable(state), Optional.ToNullable(onInactiveMarkAs), Optional.ToList(dependsOn), Optional.ToList(userProperties), additionalProperties, expression, Optional.ToList(ifTrueActivities), Optional.ToList(ifFalseActivities));
        }

        internal partial class IfConditionActivityConverter : JsonConverter<IfConditionActivity>
        {
            public override void Write(Utf8JsonWriter writer, IfConditionActivity model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override IfConditionActivity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeIfConditionActivity(document.RootElement);
            }
        }
    }
}
