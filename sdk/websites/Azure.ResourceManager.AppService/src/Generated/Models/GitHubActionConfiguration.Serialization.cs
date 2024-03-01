// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class GitHubActionConfiguration : IUtf8JsonSerializable, IJsonModel<GitHubActionConfiguration>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<GitHubActionConfiguration>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<GitHubActionConfiguration>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubActionConfiguration)} does not support '{format}' format.");
            }

            writer.WriteStartObject();
            if (CodeConfiguration != null)
            {
                writer.WritePropertyName("codeConfiguration"u8);
                writer.WriteObjectValue(CodeConfiguration);
            }
            if (ContainerConfiguration != null)
            {
                writer.WritePropertyName("containerConfiguration"u8);
                writer.WriteObjectValue(ContainerConfiguration);
            }
            if (IsLinux.HasValue)
            {
                writer.WritePropertyName("isLinux"u8);
                writer.WriteBooleanValue(IsLinux.Value);
            }
            if (GenerateWorkflowFile.HasValue)
            {
                writer.WritePropertyName("generateWorkflowFile"u8);
                writer.WriteBooleanValue(GenerateWorkflowFile.Value);
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

        GitHubActionConfiguration IJsonModel<GitHubActionConfiguration>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(GitHubActionConfiguration)} does not support '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeGitHubActionConfiguration(document.RootElement, options);
        }

        internal static GitHubActionConfiguration DeserializeGitHubActionConfiguration(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            GitHubActionCodeConfiguration codeConfiguration = default;
            GitHubActionContainerConfiguration containerConfiguration = default;
            bool? isLinux = default;
            bool? generateWorkflowFile = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    codeConfiguration = GitHubActionCodeConfiguration.DeserializeGitHubActionCodeConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("containerConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    containerConfiguration = GitHubActionContainerConfiguration.DeserializeGitHubActionContainerConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("isLinux"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isLinux = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("generateWorkflowFile"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    generateWorkflowFile = property.Value.GetBoolean();
                    continue;
                }
                if (options.Format != "W")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new GitHubActionConfiguration(codeConfiguration, containerConfiguration, isLinux, generateWorkflowFile, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<GitHubActionConfiguration>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(GitHubActionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        GitHubActionConfiguration IPersistableModel<GitHubActionConfiguration>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<GitHubActionConfiguration>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeGitHubActionConfiguration(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(GitHubActionConfiguration)} does not support '{options.Format}' format.");
            }
        }

        string IPersistableModel<GitHubActionConfiguration>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
