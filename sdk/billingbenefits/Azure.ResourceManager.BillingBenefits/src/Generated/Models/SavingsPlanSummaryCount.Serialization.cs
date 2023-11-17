// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.BillingBenefits.Models
{
    internal partial class SavingsPlanSummaryCount : IUtf8JsonSerializable, IJsonModel<SavingsPlanSummaryCount>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SavingsPlanSummaryCount>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<SavingsPlanSummaryCount>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<SavingsPlanSummaryCount>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<SavingsPlanSummaryCount>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SucceededCount))
                {
                    writer.WritePropertyName("succeededCount"u8);
                    writer.WriteNumberValue(SucceededCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FailedCount))
                {
                    writer.WritePropertyName("failedCount"u8);
                    writer.WriteNumberValue(FailedCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ExpiringCount))
                {
                    writer.WritePropertyName("expiringCount"u8);
                    writer.WriteNumberValue(ExpiringCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ExpiredCount))
                {
                    writer.WritePropertyName("expiredCount"u8);
                    writer.WriteNumberValue(ExpiredCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PendingCount))
                {
                    writer.WritePropertyName("pendingCount"u8);
                    writer.WriteNumberValue(PendingCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CancelledCount))
                {
                    writer.WritePropertyName("cancelledCount"u8);
                    writer.WriteNumberValue(CancelledCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProcessingCount))
                {
                    writer.WritePropertyName("processingCount"u8);
                    writer.WriteNumberValue(ProcessingCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(NoBenefitCount))
                {
                    writer.WritePropertyName("noBenefitCount"u8);
                    writer.WriteNumberValue(NoBenefitCount.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(WarningCount))
                {
                    writer.WritePropertyName("warningCount"u8);
                    writer.WriteNumberValue(WarningCount.Value);
                }
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

        SavingsPlanSummaryCount IJsonModel<SavingsPlanSummaryCount>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSavingsPlanSummaryCount(document.RootElement, options);
        }

        internal static SavingsPlanSummaryCount DeserializeSavingsPlanSummaryCount(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<float> succeededCount = default;
            Optional<float> failedCount = default;
            Optional<float> expiringCount = default;
            Optional<float> expiredCount = default;
            Optional<float> pendingCount = default;
            Optional<float> cancelledCount = default;
            Optional<float> processingCount = default;
            Optional<float> noBenefitCount = default;
            Optional<float> warningCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("succeededCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    succeededCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("failedCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    failedCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiringCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiringCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("expiredCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiredCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("pendingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pendingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("cancelledCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    cancelledCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("processingCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processingCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("noBenefitCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    noBenefitCount = property.Value.GetSingle();
                    continue;
                }
                if (property.NameEquals("warningCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    warningCount = property.Value.GetSingle();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SavingsPlanSummaryCount(Optional.ToNullable(succeededCount), Optional.ToNullable(failedCount), Optional.ToNullable(expiringCount), Optional.ToNullable(expiredCount), Optional.ToNullable(pendingCount), Optional.ToNullable(cancelledCount), Optional.ToNullable(processingCount), Optional.ToNullable(noBenefitCount), Optional.ToNullable(warningCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SavingsPlanSummaryCount>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SavingsPlanSummaryCount IPersistableModel<SavingsPlanSummaryCount>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SavingsPlanSummaryCount)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSavingsPlanSummaryCount(document.RootElement, options);
        }

        string IPersistableModel<SavingsPlanSummaryCount>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
