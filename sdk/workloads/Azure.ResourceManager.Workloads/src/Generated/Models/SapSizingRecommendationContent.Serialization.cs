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

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapSizingRecommendationContent : IUtf8JsonSerializable, IJsonModel<SapSizingRecommendationContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SapSizingRecommendationContent>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<SapSizingRecommendationContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("appLocation"u8);
            writer.WriteStringValue(AppLocation);
            writer.WritePropertyName("environment"u8);
            writer.WriteStringValue(Environment.ToString());
            writer.WritePropertyName("sapProduct"u8);
            writer.WriteStringValue(SapProduct.ToString());
            writer.WritePropertyName("deploymentType"u8);
            writer.WriteStringValue(DeploymentType.ToString());
            writer.WritePropertyName("saps"u8);
            writer.WriteNumberValue(Saps);
            writer.WritePropertyName("dbMemory"u8);
            writer.WriteNumberValue(DBMemory);
            writer.WritePropertyName("databaseType"u8);
            writer.WriteStringValue(DatabaseType.ToString());
            if (Optional.IsDefined(DBScaleMethod))
            {
                writer.WritePropertyName("dbScaleMethod"u8);
                writer.WriteStringValue(DBScaleMethod.Value.ToString());
            }
            if (Optional.IsDefined(HighAvailabilityType))
            {
                writer.WritePropertyName("highAvailabilityType"u8);
                writer.WriteStringValue(HighAvailabilityType.Value.ToString());
            }
            if (_serializedAdditionalRawData != null && options.Format == ModelReaderWriterFormat.Json)
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

        SapSizingRecommendationContent IJsonModel<SapSizingRecommendationContent>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSapSizingRecommendationContent(document.RootElement, options);
        }

        internal static SapSizingRecommendationContent DeserializeSapSizingRecommendationContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation appLocation = default;
            SapEnvironmentType environment = default;
            SapProductType sapProduct = default;
            SapDeploymentType deploymentType = default;
            long saps = default;
            long dbMemory = default;
            SapDatabaseType databaseType = default;
            Optional<SapDatabaseScaleMethod> dbScaleMethod = default;
            Optional<SapHighAvailabilityType> highAvailabilityType = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("appLocation"u8))
                {
                    appLocation = new AzureLocation(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("environment"u8))
                {
                    environment = new SapEnvironmentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sapProduct"u8))
                {
                    sapProduct = new SapProductType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("deploymentType"u8))
                {
                    deploymentType = new SapDeploymentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("saps"u8))
                {
                    saps = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("dbMemory"u8))
                {
                    dbMemory = property.Value.GetInt64();
                    continue;
                }
                if (property.NameEquals("databaseType"u8))
                {
                    databaseType = new SapDatabaseType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("dbScaleMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dbScaleMethod = new SapDatabaseScaleMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("highAvailabilityType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    highAvailabilityType = new SapHighAvailabilityType(property.Value.GetString());
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new SapSizingRecommendationContent(appLocation, environment, sapProduct, deploymentType, saps, dbMemory, databaseType, Optional.ToNullable(dbScaleMethod), Optional.ToNullable(highAvailabilityType), serializedAdditionalRawData);
        }

        BinaryData IModel<SapSizingRecommendationContent>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationContent)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        SapSizingRecommendationContent IModel<SapSizingRecommendationContent>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(SapSizingRecommendationContent)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeSapSizingRecommendationContent(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<SapSizingRecommendationContent>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
