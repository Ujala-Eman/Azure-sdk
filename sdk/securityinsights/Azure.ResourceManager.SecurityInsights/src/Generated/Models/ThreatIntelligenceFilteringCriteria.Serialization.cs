// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    public partial class ThreatIntelligenceFilteringCriteria : IUtf8JsonSerializable, IJsonModel<ThreatIntelligenceFilteringCriteria>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ThreatIntelligenceFilteringCriteria>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<ThreatIntelligenceFilteringCriteria>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceFilteringCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceFilteringCriteria)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (PageSize.HasValue)
            {
                writer.WritePropertyName("pageSize"u8);
                writer.WriteNumberValue(PageSize.Value);
            }
            if (MinConfidence.HasValue)
            {
                writer.WritePropertyName("minConfidence"u8);
                writer.WriteNumberValue(MinConfidence.Value);
            }
            if (MaxConfidence.HasValue)
            {
                writer.WritePropertyName("maxConfidence"u8);
                writer.WriteNumberValue(MaxConfidence.Value);
            }
            if (MinValidUntil.HasValue)
            {
                writer.WritePropertyName("minValidUntil"u8);
                writer.WriteStringValue(MinValidUntil.Value, "O");
            }
            if (MaxValidUntil.HasValue)
            {
                writer.WritePropertyName("maxValidUntil"u8);
                writer.WriteStringValue(MaxValidUntil.Value, "O");
            }
            if (IsIncludeDisabled.HasValue)
            {
                writer.WritePropertyName("includeDisabled"u8);
                writer.WriteBooleanValue(IsIncludeDisabled.Value);
            }
            if (!(SortBy is ChangeTrackingList<ThreatIntelligenceSortingCriteria> collection && collection.IsUndefined))
            {
                writer.WritePropertyName("sortBy"u8);
                writer.WriteStartArray();
                foreach (var item in SortBy)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Sources is ChangeTrackingList<string> collection0 && collection0.IsUndefined))
            {
                writer.WritePropertyName("sources"u8);
                writer.WriteStartArray();
                foreach (var item in Sources)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(PatternTypes is ChangeTrackingList<string> collection1 && collection1.IsUndefined))
            {
                writer.WritePropertyName("patternTypes"u8);
                writer.WriteStartArray();
                foreach (var item in PatternTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(ThreatTypes is ChangeTrackingList<string> collection2 && collection2.IsUndefined))
            {
                writer.WritePropertyName("threatTypes"u8);
                writer.WriteStartArray();
                foreach (var item in ThreatTypes)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Ids is ChangeTrackingList<string> collection3 && collection3.IsUndefined))
            {
                writer.WritePropertyName("ids"u8);
                writer.WriteStartArray();
                foreach (var item in Ids)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (!(Keywords is ChangeTrackingList<string> collection4 && collection4.IsUndefined))
            {
                writer.WritePropertyName("keywords"u8);
                writer.WriteStartArray();
                foreach (var item in Keywords)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (SkipToken != null)
            {
                writer.WritePropertyName("skipToken"u8);
                writer.WriteStringValue(SkipToken);
            }
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

        ThreatIntelligenceFilteringCriteria IJsonModel<ThreatIntelligenceFilteringCriteria>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceFilteringCriteria>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ThreatIntelligenceFilteringCriteria)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeThreatIntelligenceFilteringCriteria(document.RootElement, options);
        }

        internal static ThreatIntelligenceFilteringCriteria DeserializeThreatIntelligenceFilteringCriteria(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<int> pageSize = default;
            Optional<int> minConfidence = default;
            Optional<int> maxConfidence = default;
            Optional<DateTimeOffset> minValidUntil = default;
            Optional<DateTimeOffset> maxValidUntil = default;
            Optional<bool> includeDisabled = default;
            Optional<IList<ThreatIntelligenceSortingCriteria>> sortBy = default;
            Optional<IList<string>> sources = default;
            Optional<IList<string>> patternTypes = default;
            Optional<IList<string>> threatTypes = default;
            Optional<IList<string>> ids = default;
            Optional<IList<string>> keywords = default;
            Optional<string> skipToken = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pageSize"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pageSize = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minConfidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minConfidence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("maxConfidence"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxConfidence = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("minValidUntil"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    minValidUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("maxValidUntil"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    maxValidUntil = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("includeDisabled"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    includeDisabled = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("sortBy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ThreatIntelligenceSortingCriteria> array = new List<ThreatIntelligenceSortingCriteria>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ThreatIntelligenceSortingCriteria.DeserializeThreatIntelligenceSortingCriteria(item, options));
                    }
                    sortBy = array;
                    continue;
                }
                if (property.NameEquals("sources"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    sources = array;
                    continue;
                }
                if (property.NameEquals("patternTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    patternTypes = array;
                    continue;
                }
                if (property.NameEquals("threatTypes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    threatTypes = array;
                    continue;
                }
                if (property.NameEquals("ids"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    ids = array;
                    continue;
                }
                if (property.NameEquals("keywords"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    keywords = array;
                    continue;
                }
                if (property.NameEquals("skipToken"u8))
                {
                    skipToken = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ThreatIntelligenceFilteringCriteria(Optional.ToNullable(pageSize), Optional.ToNullable(minConfidence), Optional.ToNullable(maxConfidence), Optional.ToNullable(minValidUntil), Optional.ToNullable(maxValidUntil), Optional.ToNullable(includeDisabled), Optional.ToList(sortBy), Optional.ToList(sources), Optional.ToList(patternTypes), Optional.ToList(threatTypes), Optional.ToList(ids), Optional.ToList(keywords), skipToken.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ThreatIntelligenceFilteringCriteria>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceFilteringCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceFilteringCriteria)} does not support '{options.Format}' format.");
            }
        }

        ThreatIntelligenceFilteringCriteria IPersistableModel<ThreatIntelligenceFilteringCriteria>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ThreatIntelligenceFilteringCriteria>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeThreatIntelligenceFilteringCriteria(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ThreatIntelligenceFilteringCriteria)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<ThreatIntelligenceFilteringCriteria>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
