// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    public partial class VpnClientContent : IUtf8JsonSerializable, IJsonModel<VpnClientContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<VpnClientContent>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<VpnClientContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientContent)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ProcessorArchitecture))
            {
                writer.WritePropertyName("processorArchitecture"u8);
                writer.WriteStringValue(ProcessorArchitecture.Value.ToString());
            }
            if (Optional.IsDefined(AuthenticationMethod))
            {
                writer.WritePropertyName("authenticationMethod"u8);
                writer.WriteStringValue(AuthenticationMethod.Value.ToString());
            }
            if (Optional.IsDefined(RadiusServerAuthCertificate))
            {
                writer.WritePropertyName("radiusServerAuthCertificate"u8);
                writer.WriteStringValue(RadiusServerAuthCertificate);
            }
            if (Optional.IsCollectionDefined(ClientRootCertificates))
            {
                writer.WritePropertyName("clientRootCertificates"u8);
                writer.WriteStartArray();
                foreach (var item in ClientRootCertificates)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
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

        VpnClientContent IJsonModel<VpnClientContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(VpnClientContent)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeVpnClientContent(document.RootElement, options);
        }

        internal static VpnClientContent DeserializeVpnClientContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ProcessorArchitecture? processorArchitecture = default;
            NetworkAuthenticationMethod? authenticationMethod = default;
            string radiusServerAuthCertificate = default;
            IList<string> clientRootCertificates = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("processorArchitecture"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    processorArchitecture = new ProcessorArchitecture(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("authenticationMethod"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    authenticationMethod = new NetworkAuthenticationMethod(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("radiusServerAuthCertificate"u8))
                {
                    radiusServerAuthCertificate = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("clientRootCertificates"u8))
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
                    clientRootCertificates = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new VpnClientContent(processorArchitecture, authenticationMethod, radiusServerAuthCertificate, clientRootCertificates ?? new ChangeTrackingList<string>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<VpnClientContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(VpnClientContent)} does not support '{options.Format}' format.");
            }
        }

        VpnClientContent IPersistableModel<VpnClientContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<VpnClientContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeVpnClientContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(VpnClientContent)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<VpnClientContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
