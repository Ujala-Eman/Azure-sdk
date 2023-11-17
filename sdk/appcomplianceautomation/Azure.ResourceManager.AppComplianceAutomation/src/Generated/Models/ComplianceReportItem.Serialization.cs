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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ComplianceReportItem : IUtf8JsonSerializable, IJsonModel<ComplianceReportItem>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ComplianceReportItem>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ComplianceReportItem>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ComplianceReportItem>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ComplianceReportItem>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(CategoryName))
                {
                    writer.WritePropertyName("categoryName"u8);
                    writer.WriteStringValue(CategoryName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ControlId))
                {
                    writer.WritePropertyName("controlId"u8);
                    writer.WriteStringValue(ControlId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ControlName))
                {
                    writer.WritePropertyName("controlName"u8);
                    writer.WriteStringValue(ControlName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ControlType))
                {
                    writer.WritePropertyName("controlType"u8);
                    writer.WriteStringValue(ControlType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ComplianceState))
                {
                    writer.WritePropertyName("complianceState"u8);
                    writer.WriteStringValue(ComplianceState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PolicyId))
                {
                    writer.WritePropertyName("policyId"u8);
                    writer.WriteStringValue(PolicyId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PolicyDisplayName))
                {
                    writer.WritePropertyName("policyDisplayName"u8);
                    writer.WriteStringValue(PolicyDisplayName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(PolicyDescription))
                {
                    writer.WritePropertyName("policyDescription"u8);
                    writer.WriteStringValue(PolicyDescription);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SubscriptionId))
                {
                    writer.WritePropertyName("subscriptionId"u8);
                    writer.WriteStringValue(SubscriptionId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceGroup))
                {
                    writer.WritePropertyName("resourceGroup"u8);
                    writer.WriteStringValue(ResourceGroup);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceType))
                {
                    writer.WritePropertyName("resourceType"u8);
                    writer.WriteStringValue(ResourceType);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceId))
                {
                    writer.WritePropertyName("resourceId"u8);
                    writer.WriteStringValue(ResourceId);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(StatusChangeDate))
                {
                    writer.WritePropertyName("statusChangeDate"u8);
                    writer.WriteStringValue(StatusChangeDate);
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

        ComplianceReportItem IJsonModel<ComplianceReportItem>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComplianceReportItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeComplianceReportItem(document.RootElement, options);
        }

        internal static ComplianceReportItem DeserializeComplianceReportItem(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> categoryName = default;
            Optional<string> controlId = default;
            Optional<string> controlName = default;
            Optional<ControlType> controlType = default;
            Optional<ComplianceState> complianceState = default;
            Optional<string> policyId = default;
            Optional<string> policyDisplayName = default;
            Optional<string> policyDescription = default;
            Optional<string> subscriptionId = default;
            Optional<string> resourceGroup = default;
            Optional<string> resourceType = default;
            Optional<string> resourceId = default;
            Optional<string> statusChangeDate = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("categoryName"u8))
                {
                    categoryName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlId"u8))
                {
                    controlId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlName"u8))
                {
                    controlName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("controlType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    controlType = new ControlType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("complianceState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    complianceState = new ComplianceState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("policyId"u8))
                {
                    policyId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDisplayName"u8))
                {
                    policyDisplayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("policyDescription"u8))
                {
                    policyDescription = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("subscriptionId"u8))
                {
                    subscriptionId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceGroup"u8))
                {
                    resourceGroup = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceType"u8))
                {
                    resourceType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("resourceId"u8))
                {
                    resourceId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("statusChangeDate"u8))
                {
                    statusChangeDate = property.Value.GetString();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ComplianceReportItem(categoryName.Value, controlId.Value, controlName.Value, Optional.ToNullable(controlType), Optional.ToNullable(complianceState), policyId.Value, policyDisplayName.Value, policyDescription.Value, subscriptionId.Value, resourceGroup.Value, resourceType.Value, resourceId.Value, statusChangeDate.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ComplianceReportItem>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComplianceReportItem)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ComplianceReportItem IPersistableModel<ComplianceReportItem>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ComplianceReportItem)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeComplianceReportItem(document.RootElement, options);
        }

        string IPersistableModel<ComplianceReportItem>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
