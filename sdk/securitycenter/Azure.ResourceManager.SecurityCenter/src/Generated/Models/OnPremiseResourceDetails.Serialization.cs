// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    public partial class OnPremiseResourceDetails : IUtf8JsonSerializable, IJsonModel<OnPremiseResourceDetails>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<OnPremiseResourceDetails>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<OnPremiseResourceDetails>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnPremiseResourceDetails)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("workspaceId"u8);
            writer.WriteStringValue(WorkspaceId);
            writer.WritePropertyName("vmuuid"u8);
            writer.WriteStringValue(VmUuid);
            writer.WritePropertyName("sourceComputerId"u8);
            writer.WriteStringValue(SourceComputerId);
            writer.WritePropertyName("machineName"u8);
            writer.WriteStringValue(MachineName);
            writer.WritePropertyName("source"u8);
            writer.WriteStringValue(Source.ToString());
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

        OnPremiseResourceDetails IJsonModel<OnPremiseResourceDetails>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseResourceDetails>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(OnPremiseResourceDetails)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeOnPremiseResourceDetails(document.RootElement, options);
        }

        internal static OnPremiseResourceDetails DeserializeOnPremiseResourceDetails(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("source", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "OnPremiseSql": return OnPremiseSqlResourceDetails.DeserializeOnPremiseSqlResourceDetails(element, options);
                }
            }
            ResourceIdentifier workspaceId = default;
            Guid vmuuid = default;
            string sourceComputerId = default;
            string machineName = default;
            HealthReportSource source = "AutoRest.CSharp.Output.Models.Types.EnumTypeValue";
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("workspaceId"u8))
                {
                    workspaceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("vmuuid"u8))
                {
                    vmuuid = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("sourceComputerId"u8))
                {
                    sourceComputerId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("machineName"u8))
                {
                    machineName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("source"u8))
                {
                    source = new HealthReportSource(property.Value.GetString());
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new OnPremiseResourceDetails(source, serializedAdditionalRawData, workspaceId, vmuuid, sourceComputerId, machineName);
        }

        BinaryData IPersistableModel<OnPremiseResourceDetails>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(OnPremiseResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        OnPremiseResourceDetails IPersistableModel<OnPremiseResourceDetails>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<OnPremiseResourceDetails>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeOnPremiseResourceDetails(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(OnPremiseResourceDetails)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<OnPremiseResourceDetails>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
