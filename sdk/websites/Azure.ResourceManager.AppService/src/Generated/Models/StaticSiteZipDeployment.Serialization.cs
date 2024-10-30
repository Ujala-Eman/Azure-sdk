// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    public partial class StaticSiteZipDeployment : IUtf8JsonSerializable, IJsonModel<StaticSiteZipDeployment>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<StaticSiteZipDeployment>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<StaticSiteZipDeployment>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteZipDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteZipDeployment)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Kind))
            {
                writer.WritePropertyName("kind"u8);
                writer.WriteStringValue(Kind);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Optional.IsDefined(AppZipUri))
            {
                writer.WritePropertyName("appZipUrl"u8);
                writer.WriteStringValue(AppZipUri.AbsoluteUri);
            }
            if (Optional.IsDefined(ApiZipUri))
            {
                writer.WritePropertyName("apiZipUrl"u8);
                writer.WriteStringValue(ApiZipUri.AbsoluteUri);
            }
            if (Optional.IsDefined(DeploymentTitle))
            {
                writer.WritePropertyName("deploymentTitle"u8);
                writer.WriteStringValue(DeploymentTitle);
            }
            if (Optional.IsDefined(Provider))
            {
                writer.WritePropertyName("provider"u8);
                writer.WriteStringValue(Provider);
            }
            if (Optional.IsDefined(FunctionLanguage))
            {
                writer.WritePropertyName("functionLanguage"u8);
                writer.WriteStringValue(FunctionLanguage);
            }
            writer.WriteEndObject();
        }

        StaticSiteZipDeployment IJsonModel<StaticSiteZipDeployment>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteZipDeployment>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(StaticSiteZipDeployment)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeStaticSiteZipDeployment(document.RootElement, options);
        }

        internal static StaticSiteZipDeployment DeserializeStaticSiteZipDeployment(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string kind = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            Uri appZipUrl = default;
            Uri apiZipUrl = default;
            string deploymentTitle = default;
            string provider = default;
            string functionLanguage = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("kind"u8))
                {
                    kind = property.Value.GetString();
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
                        if (property0.NameEquals("appZipUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            appZipUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("apiZipUrl"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            apiZipUrl = new Uri(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("deploymentTitle"u8))
                        {
                            deploymentTitle = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("provider"u8))
                        {
                            provider = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("functionLanguage"u8))
                        {
                            functionLanguage = property0.Value.GetString();
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
            return new StaticSiteZipDeployment(
                id,
                name,
                type,
                systemData,
                appZipUrl,
                apiZipUrl,
                deploymentTitle,
                provider,
                functionLanguage,
                kind,
                serializedAdditionalRawData);
        }

        private BinaryData SerializeBicep(ModelReaderWriterOptions options)
        {
            StringBuilder builder = new StringBuilder();
            BicepModelReaderWriterOptions bicepOptions = options as BicepModelReaderWriterOptions;
            IDictionary<string, string> propertyOverrides = null;
            bool hasObjectOverride = bicepOptions != null && bicepOptions.PropertyOverrides.TryGetValue(this, out propertyOverrides);
            bool hasPropertyOverride = false;
            string propertyOverride = null;

            builder.AppendLine("{");

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Name), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  name: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Name))
                {
                    builder.Append("  name: ");
                    if (Name.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Name}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Name}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Kind), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  kind: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Kind))
                {
                    builder.Append("  kind: ");
                    if (Kind.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Kind}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Kind}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Id), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  id: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Id))
                {
                    builder.Append("  id: ");
                    builder.AppendLine($"'{Id.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(SystemData), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  systemData: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(SystemData))
                {
                    builder.Append("  systemData: ");
                    builder.AppendLine($"'{SystemData.ToString()}'");
                }
            }

            builder.Append("  properties:");
            builder.AppendLine(" {");
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AppZipUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    appZipUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AppZipUri))
                {
                    builder.Append("    appZipUrl: ");
                    builder.AppendLine($"'{AppZipUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ApiZipUri), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    apiZipUrl: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ApiZipUri))
                {
                    builder.Append("    apiZipUrl: ");
                    builder.AppendLine($"'{ApiZipUri.AbsoluteUri}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeploymentTitle), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deploymentTitle: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeploymentTitle))
                {
                    builder.Append("    deploymentTitle: ");
                    if (DeploymentTitle.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{DeploymentTitle}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{DeploymentTitle}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Provider), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    provider: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Provider))
                {
                    builder.Append("    provider: ");
                    if (Provider.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{Provider}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{Provider}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(FunctionLanguage), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    functionLanguage: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(FunctionLanguage))
                {
                    builder.Append("    functionLanguage: ");
                    if (FunctionLanguage.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{FunctionLanguage}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{FunctionLanguage}'");
                    }
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<StaticSiteZipDeployment>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteZipDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(StaticSiteZipDeployment)} does not support writing '{options.Format}' format.");
            }
        }

        StaticSiteZipDeployment IPersistableModel<StaticSiteZipDeployment>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<StaticSiteZipDeployment>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeStaticSiteZipDeployment(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(StaticSiteZipDeployment)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<StaticSiteZipDeployment>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
