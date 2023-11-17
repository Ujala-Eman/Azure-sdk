// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    [PersistableModelProxy(typeof(UnknownGroupTaskDetails))]
    public partial class SiteRecoveryGroupTaskDetails : IUtf8JsonSerializable, IJsonModel<SiteRecoveryGroupTaskDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SiteRecoveryGroupTaskDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<SiteRecoveryGroupTaskDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SiteRecoveryGroupTaskDetails>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SiteRecoveryGroupTaskDetails>)} interface");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("instanceType"u8);
            writer.WriteStringValue(InstanceType);
            if (Optional.IsCollectionDefined(ChildTasks))
            {
                writer.WritePropertyName("childTasks"u8);
                writer.WriteStartArray();
                foreach (var item in ChildTasks)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        SiteRecoveryGroupTaskDetails IJsonModel<SiteRecoveryGroupTaskDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryGroupTaskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSiteRecoveryGroupTaskDetails(document.RootElement, options);
        }

        internal static SiteRecoveryGroupTaskDetails DeserializeSiteRecoveryGroupTaskDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("instanceType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "InlineWorkflowTaskDetails": return InlineWorkflowTaskDetails.DeserializeInlineWorkflowTaskDetails(element);
                    case "RecoveryPlanGroupTaskDetails": return RecoveryPlanGroupTaskDetails.DeserializeRecoveryPlanGroupTaskDetails(element);
                    case "RecoveryPlanShutdownGroupTaskDetails": return RecoveryPlanShutdownGroupTaskDetails.DeserializeRecoveryPlanShutdownGroupTaskDetails(element);
                }
            }
            return UnknownGroupTaskDetails.DeserializeUnknownGroupTaskDetails(element);
        }

        BinaryData IPersistableModel<SiteRecoveryGroupTaskDetails>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryGroupTaskDetails)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SiteRecoveryGroupTaskDetails IPersistableModel<SiteRecoveryGroupTaskDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SiteRecoveryGroupTaskDetails)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSiteRecoveryGroupTaskDetails(document.RootElement, options);
        }

        string IPersistableModel<SiteRecoveryGroupTaskDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
