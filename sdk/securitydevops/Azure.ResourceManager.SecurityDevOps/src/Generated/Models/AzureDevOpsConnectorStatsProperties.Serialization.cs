// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityDevOps.Models
{
    public partial class AzureDevOpsConnectorStatsProperties : IUtf8JsonSerializable, IJsonModel<AzureDevOpsConnectorStatsProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AzureDevOpsConnectorStatsProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<AzureDevOpsConnectorStatsProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AzureDevOpsConnectorStatsProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AzureDevOpsConnectorStatsProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProvisioningState))
            {
                writer.WritePropertyName("provisioningState"u8);
                writer.WriteStringValue(ProvisioningState.Value.ToString());
            }
            if (Optional.IsDefined(OrgsCount))
            {
                writer.WritePropertyName("orgsCount"u8);
                writer.WriteNumberValue(OrgsCount.Value);
            }
            if (Optional.IsDefined(ProjectsCount))
            {
                writer.WritePropertyName("projectsCount"u8);
                writer.WriteNumberValue(ProjectsCount.Value);
            }
            if (Optional.IsDefined(ReposCount))
            {
                writer.WritePropertyName("reposCount"u8);
                writer.WriteNumberValue(ReposCount.Value);
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

        AzureDevOpsConnectorStatsProperties IJsonModel<AzureDevOpsConnectorStatsProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDevOpsConnectorStatsProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAzureDevOpsConnectorStatsProperties(document.RootElement, options);
        }

        internal static AzureDevOpsConnectorStatsProperties DeserializeAzureDevOpsConnectorStatsProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ProvisioningState> provisioningState = default;
            Optional<long> orgsCount = default;
            Optional<long> projectsCount = default;
            Optional<long> reposCount = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new ProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("orgsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    orgsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("projectsCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    projectsCount = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("reposCount"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    reposCount = property.Value.GetInt64();
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AzureDevOpsConnectorStatsProperties(Optional.ToNullable(provisioningState), Optional.ToNullable(orgsCount), Optional.ToNullable(projectsCount), Optional.ToNullable(reposCount), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AzureDevOpsConnectorStatsProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDevOpsConnectorStatsProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AzureDevOpsConnectorStatsProperties IPersistableModel<AzureDevOpsConnectorStatsProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AzureDevOpsConnectorStatsProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAzureDevOpsConnectorStatsProperties(document.RootElement, options);
        }

        string IPersistableModel<AzureDevOpsConnectorStatsProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
