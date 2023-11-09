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
    [JsonConverter(typeof(GitHubClientSecretConverter))]
    public partial class GitHubClientSecret : IUtf8JsonSerializable, IJsonModel<GitHubClientSecret>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubClientSecret>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<GitHubClientSecret>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ByoaSecretAkvUrl))
            {
                writer.WritePropertyName("byoaSecretAkvUrl"u8);
                writer.WriteStringValue(ByoaSecretAkvUrl);
            }
            if (Optional.IsDefined(ByoaSecretName))
            {
                writer.WritePropertyName("byoaSecretName"u8);
                writer.WriteStringValue(ByoaSecretName);
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

        GitHubClientSecret IJsonModel<GitHubClientSecret>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GitHubClientSecret)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubClientSecret(document.RootElement, options);
        }

        internal static GitHubClientSecret DeserializeGitHubClientSecret(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> byoaSecretAkvUrl = default;
            Optional<string> byoaSecretName = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("byoaSecretAkvUrl"u8))
                {
                    byoaSecretAkvUrl = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("byoaSecretName"u8))
                {
                    byoaSecretName = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubClientSecret(byoaSecretAkvUrl.Value, byoaSecretName.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<GitHubClientSecret>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GitHubClientSecret)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        GitHubClientSecret IModel<GitHubClientSecret>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(GitHubClientSecret)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeGitHubClientSecret(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<GitHubClientSecret>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;

        internal partial class GitHubClientSecretConverter : JsonConverter<GitHubClientSecret>
        {
            public override void Write(Utf8JsonWriter writer, GitHubClientSecret model, JsonSerializerOptions options)
            {
                writer.WriteObjectValue(model);
            }
            public override GitHubClientSecret Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            {
                using var document = JsonDocument.ParseValue(ref reader);
                return DeserializeGitHubClientSecret(document.RootElement);
            }
        }
    }
}
