// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    public partial class SourceControlData : IUtf8JsonSerializable, IJsonModel<SourceControlData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<SourceControlData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<SourceControlData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlData)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ETag))
            {
                writer.WritePropertyName("etag"u8);
                writer.WriteStringValue(ETag.Value.ToString());
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(Id);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("name"u8);
                writer.WriteStringValue(Name);
            }
            if (options.Format != "W")
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ResourceType);
            }
            if (options.Format != "W" && Optional.IsDefined(SystemData))
            {
                writer.WritePropertyName("systemData"u8);
                JsonSerializer.Serialize(writer, SystemData);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(IdPropertiesId))
            {
                writer.WritePropertyName("id"u8);
                writer.WriteStringValue(IdPropertiesId);
            }
            if (options.Format != "W" && Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version"u8);
                writer.WriteStringValue(Version.Value.ToString());
            }
            writer.WritePropertyName("displayName"u8);
            writer.WriteStringValue(DisplayName);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("repoType"u8);
            writer.WriteStringValue(RepoType.ToString());
            writer.WritePropertyName("contentTypes"u8);
            writer.WriteStartArray();
            foreach (var item in ContentTypes)
            {
                writer.WriteStringValue(item.ToString());
            }
            writer.WriteEndArray();
            writer.WritePropertyName("repository"u8);
            writer.WriteObjectValue(Repository, options);
            if (Optional.IsDefined(ServicePrincipal))
            {
                writer.WritePropertyName("servicePrincipal"u8);
                writer.WriteObjectValue(ServicePrincipal, options);
            }
            if (Optional.IsDefined(RepositoryAccess))
            {
                writer.WritePropertyName("repositoryAccess"u8);
                writer.WriteObjectValue(RepositoryAccess, options);
            }
            if (Optional.IsDefined(RepositoryResourceInfo))
            {
                writer.WritePropertyName("repositoryResourceInfo"u8);
                writer.WriteObjectValue(RepositoryResourceInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(LastDeploymentInfo))
            {
                writer.WritePropertyName("lastDeploymentInfo"u8);
                writer.WriteObjectValue(LastDeploymentInfo, options);
            }
            if (options.Format != "W" && Optional.IsDefined(PullRequest))
            {
                writer.WritePropertyName("pullRequest"u8);
                writer.WriteObjectValue(PullRequest, options);
            }
            writer.WriteEndObject();
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

        SourceControlData IJsonModel<SourceControlData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(SourceControlData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeSourceControlData(document.RootElement, options);
        }

        internal static SourceControlData DeserializeSourceControlData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            ETag? etag = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            string id0 = default;
            Models.Version? version = default;
            string displayName = default;
            string description = default;
            RepoType repoType = default;
            IList<Models.ContentType> contentTypes = default;
            Repository repository = default;
            ServicePrincipal servicePrincipal = default;
            RepositoryAccess repositoryAccess = default;
            RepositoryResourceInfo repositoryResourceInfo = default;
            DeploymentInfo lastDeploymentInfo = default;
            PullRequestInfo pullRequest = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("etag"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    etag = new ETag(property.Value.GetString());
                    continue;
                }
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
                        if (property0.NameEquals("id"u8))
                        {
                            id0 = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("version"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            version = new Models.Version(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("displayName"u8))
                        {
                            displayName = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("description"u8))
                        {
                            description = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("repoType"u8))
                        {
                            repoType = new RepoType(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("contentTypes"u8))
                        {
                            List<Models.ContentType> array = new List<Models.ContentType>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(new Models.ContentType(item.GetString()));
                            }
                            contentTypes = array;
                            continue;
                        }
                        if (property0.NameEquals("repository"u8))
                        {
                            repository = Repository.DeserializeRepository(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("servicePrincipal"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            servicePrincipal = ServicePrincipal.DeserializeServicePrincipal(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("repositoryAccess"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryAccess = RepositoryAccess.DeserializeRepositoryAccess(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("repositoryResourceInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            repositoryResourceInfo = RepositoryResourceInfo.DeserializeRepositoryResourceInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lastDeploymentInfo"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lastDeploymentInfo = DeploymentInfo.DeserializeDeploymentInfo(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("pullRequest"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            pullRequest = PullRequestInfo.DeserializePullRequestInfo(property0.Value, options);
                            continue;
                        }
                    }
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new SourceControlData(
                id,
                name,
                type,
                systemData,
                id0,
                version,
                displayName,
                description,
                repoType,
                contentTypes,
                repository,
                servicePrincipal,
                repositoryAccess,
                repositoryResourceInfo,
                lastDeploymentInfo,
                pullRequest,
                etag,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<SourceControlData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(SourceControlData)} does not support writing '{options.Format}' format.");
            }
        }

        SourceControlData IPersistableModel<SourceControlData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<SourceControlData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeSourceControlData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(SourceControlData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<SourceControlData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
