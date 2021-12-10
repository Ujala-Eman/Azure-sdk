// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Purview.Administration.Models
{
    public partial class PathPatternExtractorConfig : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsCollectionDefined(AcceptedPatterns))
            {
                writer.WritePropertyName("acceptedPatterns");
                writer.WriteStartArray();
                foreach (var item in AcceptedPatterns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ComplexReplacers))
            {
                writer.WritePropertyName("complexReplacers");
                writer.WriteStartArray();
                foreach (var item in ComplexReplacers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("createdBy");
            writer.WriteStringValue(CreatedBy);
            writer.WritePropertyName("enableDefaultPatterns");
            writer.WriteBooleanValue(EnableDefaultPatterns);
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
            if (Optional.IsCollectionDefined(NormalizationRules))
            {
                writer.WritePropertyName("normalizationRules");
                writer.WriteStartArray();
                foreach (var item in NormalizationRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RegexReplacers))
            {
                writer.WritePropertyName("regexReplacers");
                writer.WriteStartArray();
                foreach (var item in RegexReplacers)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(RejectedPatterns))
            {
                writer.WritePropertyName("rejectedPatterns");
                writer.WriteStartArray();
                foreach (var item in RejectedPatterns)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(ScopedRules))
            {
                writer.WritePropertyName("scopedRules");
                writer.WriteStartArray();
                foreach (var item in ScopedRules)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteNumberValue(Version.Value);
            }
            writer.WriteEndObject();
        }

        internal static PathPatternExtractorConfig DeserializePathPatternExtractorConfig(JsonElement element)
        {
            Optional<IList<Filter>> acceptedPatterns = default;
            Optional<IList<ComplexReplacerConfig>> complexReplacers = default;
            string createdBy = default;
            bool enableDefaultPatterns = default;
            Optional<long> lastUpdatedTimestamp = default;
            Optional<string> modifiedBy = default;
            Optional<IList<NormalizationRule>> normalizationRules = default;
            Optional<IList<RegexReplacer>> regexReplacers = default;
            Optional<IList<Filter>> rejectedPatterns = default;
            Optional<IList<ScopedRule>> scopedRules = default;
            Optional<int> version = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("acceptedPatterns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Filter> array = new List<Filter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Filter.DeserializeFilter(item));
                    }
                    acceptedPatterns = array;
                    continue;
                }
                if (property.NameEquals("complexReplacers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ComplexReplacerConfig> array = new List<ComplexReplacerConfig>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ComplexReplacerConfig.DeserializeComplexReplacerConfig(item));
                    }
                    complexReplacers = array;
                    continue;
                }
                if (property.NameEquals("createdBy"))
                {
                    createdBy = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableDefaultPatterns"))
                {
                    enableDefaultPatterns = property.Value.GetBoolean();
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
                if (property.NameEquals("normalizationRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<NormalizationRule> array = new List<NormalizationRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(NormalizationRule.DeserializeNormalizationRule(item));
                    }
                    normalizationRules = array;
                    continue;
                }
                if (property.NameEquals("regexReplacers"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<RegexReplacer> array = new List<RegexReplacer>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(RegexReplacer.DeserializeRegexReplacer(item));
                    }
                    regexReplacers = array;
                    continue;
                }
                if (property.NameEquals("rejectedPatterns"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<Filter> array = new List<Filter>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Filter.DeserializeFilter(item));
                    }
                    rejectedPatterns = array;
                    continue;
                }
                if (property.NameEquals("scopedRules"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    List<ScopedRule> array = new List<ScopedRule>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ScopedRule.DeserializeScopedRule(item));
                    }
                    scopedRules = array;
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    version = property.Value.GetInt32();
                    continue;
                }
            }
            return new PathPatternExtractorConfig(Optional.ToList(acceptedPatterns), Optional.ToList(complexReplacers), createdBy, enableDefaultPatterns, Optional.ToNullable(lastUpdatedTimestamp), modifiedBy.Value, Optional.ToList(normalizationRules), Optional.ToList(regexReplacers), Optional.ToList(rejectedPatterns), Optional.ToList(scopedRules), Optional.ToNullable(version));
        }
    }
}
