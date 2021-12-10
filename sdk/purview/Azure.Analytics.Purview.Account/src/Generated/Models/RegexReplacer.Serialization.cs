// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Account.Models
{
    public partial class RegexReplacer : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Condition))
            {
                writer.WritePropertyName("condition");
                writer.WriteStringValue(Condition);
            }
            if (Optional.IsDefined(CreatedBy))
            {
                writer.WritePropertyName("createdBy");
                writer.WriteStringValue(CreatedBy);
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("disabled");
            writer.WriteBooleanValue(Disabled);
            if (Optional.IsDefined(DisableRecursiveReplacerApplication))
            {
                writer.WritePropertyName("disableRecursiveReplacerApplication");
                writer.WriteBooleanValue(DisableRecursiveReplacerApplication.Value);
            }
            if (Optional.IsDefined(DoNotReplaceRegex))
            {
                writer.WritePropertyName("doNotReplaceRegex");
                writer.WriteObjectValue(DoNotReplaceRegex);
            }
            if (Optional.IsDefined(LastUpdatedTimestamp))
            {
                writer.WritePropertyName("lastUpdatedTimestamp");
                writer.WriteNumberValue(LastUpdatedTimestamp.Value);
            }
            if (Optional.IsDefined(ModifiedBy))
            {
                writer.WritePropertyName("modifiedBy");
                writer.WriteStringValue(ModifiedBy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            if (Optional.IsDefined(Regex))
            {
                writer.WritePropertyName("regex");
                writer.WriteObjectValue(Regex);
            }
            if (Optional.IsDefined(ReplaceWith))
            {
                writer.WritePropertyName("replaceWith");
                writer.WriteStringValue(ReplaceWith);
            }
            writer.WriteEndObject();
        }

        internal static RegexReplacer DeserializeRegexReplacer(JsonElement element)
        {
            Optional<string> condition = default;
            Optional<string> createdBy = default;
            Optional<string> description = default;
            bool disabled = default;
            Optional<bool> disableRecursiveReplacerApplication = default;
            Optional<FastRegex> doNotReplaceRegex = default;
            Optional<long> lastUpdatedTimestamp = default;
            Optional<string> modifiedBy = default;
            string name = default;
            Optional<FastRegex> regex = default;
            Optional<string> replaceWith = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("condition"))
                {
                    condition = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("disabled"))
                {
                    disabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("disableRecursiveReplacerApplication"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    disableRecursiveReplacerApplication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("doNotReplaceRegex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    doNotReplaceRegex = FastRegex.DeserializeFastRegex(property.Value);
                    continue;
                }
                if (property.NameEquals("lastUpdatedTimestamp"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    lastUpdatedTimestamp = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("modifiedBy"))
                {
                    modifiedBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("regex"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    regex = FastRegex.DeserializeFastRegex(property.Value);
                    continue;
                }
                if (property.NameEquals("replaceWith"))
                {
                    replaceWith = property.Value.GetString();
                    continue;
                }
            }
            return new RegexReplacer(condition.Value, createdBy.Value, description.Value, disabled, Optional.ToNullable(disableRecursiveReplacerApplication), doNotReplaceRegex.Value, Optional.ToNullable(lastUpdatedTimestamp), modifiedBy.Value, name, regex.Value, replaceWith.Value);
        }
    }
}
