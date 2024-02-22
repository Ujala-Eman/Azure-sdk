// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    [PersistableModelProxy(typeof(UnknownIdentityConfiguration))]
    public partial class MachineLearningIdentityConfiguration : IUtf8JsonSerializable, IJsonModel<MachineLearningIdentityConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MachineLearningIdentityConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MachineLearningIdentityConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningIdentityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningIdentityConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            writer.WritePropertyName("identityType"u8);
            writer.WriteStringValue(IdentityType.ToString());
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

        MachineLearningIdentityConfiguration IJsonModel<MachineLearningIdentityConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningIdentityConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(MachineLearningIdentityConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMachineLearningIdentityConfiguration(document.RootElement, options);
        }

        internal static MachineLearningIdentityConfiguration DeserializeMachineLearningIdentityConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            if (element.TryGetProperty("identityType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "AMLToken": return AmlToken.DeserializeAmlToken(element, options);
                    case "Managed": return MachineLearningManagedIdentity.DeserializeMachineLearningManagedIdentity(element, options);
                    case "UserIdentity": return MachineLearningUserIdentity.DeserializeMachineLearningUserIdentity(element, options);
                }
            }
            return UnknownIdentityConfiguration.DeserializeUnknownIdentityConfiguration(element, options);
        }

        BinaryData IPersistableModel<MachineLearningIdentityConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningIdentityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(MachineLearningIdentityConfiguration)} does not support '{options.Format}' format.");
            }
        }

        MachineLearningIdentityConfiguration IPersistableModel<MachineLearningIdentityConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<MachineLearningIdentityConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeMachineLearningIdentityConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(MachineLearningIdentityConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<MachineLearningIdentityConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
