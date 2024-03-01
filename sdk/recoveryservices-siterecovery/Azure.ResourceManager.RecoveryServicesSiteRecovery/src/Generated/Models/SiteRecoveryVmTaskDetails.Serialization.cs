// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    public partial class SiteRecoveryVmTaskDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryVmTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryVmTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryVmTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVmTaskDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (SkippedReason != null)
            {
                writer.WritePropertyName("skippedReason"u8);
                writer.WriteStringValue(SkippedReason);
            }
            if (SkippedReasonString != null)
            {
                writer.WritePropertyName("skippedReasonString"u8);
                writer.WriteStringValue(SkippedReasonString);
            }
            if (JobTask != null)
            {
                writer.WritePropertyName("jobTask"u8);
                writer.WriteObjectValue(JobTask);
            }
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
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

        SiteRecoveryVmTaskDetails IJsonModel<SiteRecoveryVmTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmTaskDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SiteRecoveryVmTaskDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryVmTaskDetails(document.RootElement, options);
        }

        internal static SiteRecoveryVmTaskDetails DeserializeSiteRecoveryVmTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string skippedReason = default;
            string skippedReasonString = default;
            SiteRecoveryJobEntity jobTask = default;
            string instanceType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("skippedReason"u8))
                {
                    skippedReason = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("skippedReasonString"u8))
                {
                    skippedReasonString = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("jobTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    jobTask = SiteRecoveryJobEntity.DeserializeSiteRecoveryJobEntity(property.Value, options);
                    continue;
                }
                if (property.NameEquals("instanceType"u8))
                {
                    instanceType = property.Value.GetString();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SiteRecoveryVmTaskDetails(instanceType, serializedAdditionalRawData, jobTask, skippedReason, skippedReasonString);
        }

        BinaryData IPersistableModel<SiteRecoveryVmTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVmTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        SiteRecoveryVmTaskDetails IPersistableModel<SiteRecoveryVmTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SiteRecoveryVmTaskDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSiteRecoveryVmTaskDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SiteRecoveryVmTaskDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<SiteRecoveryVmTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
