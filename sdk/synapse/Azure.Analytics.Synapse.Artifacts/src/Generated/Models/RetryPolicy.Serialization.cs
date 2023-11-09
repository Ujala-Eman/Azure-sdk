// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Net.ClientModel;
using System.Net.ClientModel.Core;
using System.Text.Json;
using System.Text.Json.Serialization;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    [JsonConverter(typeof(RetryPolicyConverter))]
    public partial class RetryPolicy : IUtf8JsonSerializable, IJsonModel<RetryPolicy>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<RetryPolicy>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<RetryPolicy>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Count))
            {
                writer.WritePropertyName("count"u8);
                writer.WriteObjectValue(Count);
            }
            if (Optional.IsDefined(IntervalInSeconds))
            {
                writer.WritePropertyName("intervalInSeconds"u8);
                writer.WriteNumberValue(IntervalInSeconds.Value);
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

        RetryPolicy IJsonModel<RetryPolicy>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RetryPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeRetryPolicy(document.RootElement, options);
        }

        internal static RetryPolicy DeserializeRetryPolicy(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<object> count = default;
            Optional<int> intervalInSeconds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("count"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    count = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("intervalInSeconds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    intervalInSeconds = property.Value.GetInt32();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new RetryPolicy(count.Value, Optional.ToNullable(intervalInSeconds), serializedAdditionalRawData);
        }

        BinaryData IModel<RetryPolicy>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RetryPolicy)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        RetryPolicy IModel<RetryPolicy>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(RetryPolicy)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeRetryPolicy(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<RetryPolicy>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class RetryPolicyConverter : JsonConverter<RetryPolicy>
        {
            public override void Write(Utf8JsonWriter writer, RetryPolicy model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override RetryPolicy Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeRetryPolicy(document.RootElement);
            }
        }
    }
}
