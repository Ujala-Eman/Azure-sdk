// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    public partial class NacosComponent : IUtf8JsonSerializable, IJsonModel<NacosComponent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<NacosComponent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<NacosComponent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NacosComponent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NacosComponent)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (Optional.IsDefined(Ingress))
            {
                writer.WritePropertyName("ingress"u8);
                writer.WriteObjectValue(Ingress, options);
            }
        }

        NacosComponent IJsonModel<NacosComponent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NacosComponent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(NacosComponent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeNacosComponent(document.RootElement, options);
        }

        internal static NacosComponent DeserializeNacosComponent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            JavaComponentIngress ingress = default;
            JavaComponentType componentType = default;
            JavaComponentProvisioningState? provisioningState = default;
            IList<JavaComponentConfigurationProperty> configurations = default;
            JavaComponentPropertiesScale scale = default;
            IList<JavaComponentServiceBind> serviceBinds = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("ingress"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    ingress = JavaComponentIngress.DeserializeJavaComponentIngress(property.Value, options);
                    continue;
                }
                if (property.NameEquals("componentType"u8))
                {
                    componentType = new JavaComponentType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new JavaComponentProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("configurations"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JavaComponentConfigurationProperty> array = new List<JavaComponentConfigurationProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JavaComponentConfigurationProperty.DeserializeJavaComponentConfigurationProperty(item, options));
                    }
                    configurations = array;
                    continue;
                }
                if (property.NameEquals("scale"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    scale = JavaComponentPropertiesScale.DeserializeJavaComponentPropertiesScale(property.Value, options);
                    continue;
                }
                if (property.NameEquals("serviceBinds"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<JavaComponentServiceBind> array = new List<JavaComponentServiceBind>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(JavaComponentServiceBind.DeserializeJavaComponentServiceBind(item, options));
                    }
                    serviceBinds = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new NacosComponent(
                componentType,
                provisioningState,
                configurations ?? new ChangeTrackingList<JavaComponentConfigurationProperty>(),
                scale,
                serviceBinds ?? new ChangeTrackingList<JavaComponentServiceBind>(),
                serializedAdditionalRawData,
                ingress);
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue("IngressFqdn", out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  ingress: ");
                builder.AppendLine("{");
                builder.Append("    fqdn: ");
                builder.AppendLine(propertyOverride);
                builder.AppendLine("  }");
            }
            else
            {
                if (Optional.IsDefined(Ingress))
                {
                    builder.Append("  ingress: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Ingress, options, 2, false, "  ingress: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ComponentType), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  componentType: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                builder.Append("  componentType: ");
                builder.AppendLine($"'{ComponentType.ToString()}'");
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ProvisioningState), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  provisioningState: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    builder.Append("  provisioningState: ");
                    builder.AppendLine($"'{ProvisioningState.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Configurations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  configurations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(Configurations))
                {
                    if (Configurations.Any())
                    {
                        builder.Append("  configurations: ");
                        builder.AppendLine("[");
                        foreach (var item in Configurations)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  configurations: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Scale), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  scale: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Scale))
                {
                    builder.Append("  scale: ");
                    BicepSerializationHelpers.AppendChildObject(builder, Scale, options, 2, false, "  scale: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ServiceBinds), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  serviceBinds: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsCollectionDefined(ServiceBinds))
                {
                    if (ServiceBinds.Any())
                    {
                        builder.Append("  serviceBinds: ");
                        builder.AppendLine("[");
                        foreach (var item in ServiceBinds)
                        {
                            BicepSerializationHelpers.AppendChildObject(builder, item, options, 4, true, "  serviceBinds: ");
                        }
                        builder.AppendLine("  ]");
                    }
                }
            }

            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<NacosComponent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NacosComponent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(NacosComponent)} does not support writing '{options.Format}' format.");
            }
        }

        NacosComponent IPersistableModel<NacosComponent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<NacosComponent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeNacosComponent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(NacosComponent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<NacosComponent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
