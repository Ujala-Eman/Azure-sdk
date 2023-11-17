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
using Azure.ResourceManager.ApiManagement.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.ApiManagement
{
    public partial class DiagnosticContractData : IUtf8JsonSerializable, IJsonModel<DiagnosticContractData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<DiagnosticContractData>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<DiagnosticContractData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<DiagnosticContractData>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<DiagnosticContractData>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format == "J")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SystemData))
                {
                    writer.WritePropertyName("systemData"u8);
                    JsonSerializer.Serialize(writer, SystemData);
                }
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AlwaysLog))
            {
                writer.WritePropertyName("alwaysLog"u8);
                writer.WriteStringValue(AlwaysLog.Value.ToString());
            }
            if (Optional.IsDefined(LoggerId))
            {
                writer.WritePropertyName("loggerId"u8);
                writer.WriteStringValue(LoggerId);
            }
            if (Optional.IsDefined(Sampling))
            {
                writer.WritePropertyName("sampling"u8);
                writer.WriteObjectValue(Sampling);
            }
            if (Optional.IsDefined(Frontend))
            {
                writer.WritePropertyName("frontend"u8);
                writer.WriteObjectValue(Frontend);
            }
            if (Optional.IsDefined(Backend))
            {
                writer.WritePropertyName("backend"u8);
                writer.WriteObjectValue(Backend);
            }
            if (Optional.IsDefined(IsLogClientIPEnabled))
            {
                writer.WritePropertyName("logClientIp"u8);
                writer.WriteBooleanValue(IsLogClientIPEnabled.Value);
            }
            if (Optional.IsDefined(HttpCorrelationProtocol))
            {
                writer.WritePropertyName("httpCorrelationProtocol"u8);
                writer.WriteStringValue(HttpCorrelationProtocol.Value.ToString());
            }
            if (Optional.IsDefined(Verbosity))
            {
                writer.WritePropertyName("verbosity"u8);
                writer.WriteStringValue(Verbosity.Value.ToString());
            }
            if (Optional.IsDefined(OperationNameFormat))
            {
                writer.WritePropertyName("operationNameFormat"u8);
                writer.WriteStringValue(OperationNameFormat.Value.ToString());
            }
            if (Optional.IsDefined(Metrics))
            {
                writer.WritePropertyName("metrics"u8);
                writer.WriteBooleanValue(Metrics.Value);
            }
            writer.WriteEndObject();
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

        DiagnosticContractData IJsonModel<DiagnosticContractData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticContractData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeDiagnosticContractData(document.RootElement, options);
        }

        internal static DiagnosticContractData DeserializeDiagnosticContractData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            Optional<SystemData> systemData = default;
            Optional<AlwaysLog> alwaysLog = default;
            Optional<string> loggerId = default;
            Optional<SamplingSettings> sampling = default;
            Optional<PipelineDiagnosticSettings> frontend = default;
            Optional<PipelineDiagnosticSettings> backend = default;
            Optional<bool> logClientIP = default;
            Optional<HttpCorrelationProtocol> httpCorrelationProtocol = default;
            Optional<TraceVerbosityLevel> verbosity = default;
            Optional<OperationNameFormat> operationNameFormat = default;
            Optional<bool> metrics = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("name"u8))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = new ResourceType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("systemData"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    systemData = JsonSerializer.Deserialize<SystemData>(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("properties"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("alwaysLog"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            alwaysLog = new AlwaysLog(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("loggerId"u8))
                        {
                            loggerId = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("sampling"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            sampling = SamplingSettings.DeserializeSamplingSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("frontend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            frontend = PipelineDiagnosticSettings.DeserializePipelineDiagnosticSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("backend"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            backend = PipelineDiagnosticSettings.DeserializePipelineDiagnosticSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("logClientIp"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            logClientIP = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("httpCorrelationProtocol"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            httpCorrelationProtocol = new HttpCorrelationProtocol(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("verbosity"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            verbosity = new TraceVerbosityLevel(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("operationNameFormat"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            operationNameFormat = new OperationNameFormat(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("metrics"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            metrics = property0.Value.GetBoolean();
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new DiagnosticContractData(id, name, type, systemData.Value, Optional.ToNullable(alwaysLog), loggerId.Value, sampling.Value, frontend.Value, backend.Value, Optional.ToNullable(logClientIP), Optional.ToNullable(httpCorrelationProtocol), Optional.ToNullable(verbosity), Optional.ToNullable(operationNameFormat), Optional.ToNullable(metrics), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<DiagnosticContractData>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticContractData)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        DiagnosticContractData IPersistableModel<DiagnosticContractData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(DiagnosticContractData)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeDiagnosticContractData(document.RootElement, options);
        }

        string IPersistableModel<DiagnosticContractData>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
