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

namespace Azure.ResourceManager.AppPlatform.Models
{
    public partial class AppPlatformServiceRegistryProperties : IUtf8JsonSerializable, IJsonModel<AppPlatformServiceRegistryProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AppPlatformServiceRegistryProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<AppPlatformServiceRegistryProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<AppPlatformServiceRegistryProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<AppPlatformServiceRegistryProperties>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ProvisioningState))
                {
                    writer.WritePropertyName("provisioningState"u8);
                    writer.WriteStringValue(ProvisioningState.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(ResourceRequests))
                {
                    writer.WritePropertyName("resourceRequests"u8);
                    writer.WriteObjectValue(ResourceRequests);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Instances))
                {
                    writer.WritePropertyName("instances"u8);
                    writer.WriteStartArray();
                    foreach (var item in Instances)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
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

        AppPlatformServiceRegistryProperties IJsonModel<AppPlatformServiceRegistryProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAppPlatformServiceRegistryProperties(document.RootElement, options);
        }

        internal static AppPlatformServiceRegistryProperties DeserializeAppPlatformServiceRegistryProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<AppPlatformServiceRegistryProvisioningState> provisioningState = default;
            Optional<AppPlatformServiceRegistryResourceRequirements> resourceRequests = default;
            Optional<IReadOnlyList<AppPlatformServiceRegistryInstance>> instances = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("provisioningState"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    provisioningState = new AppPlatformServiceRegistryProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceRequests"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceRequests = AppPlatformServiceRegistryResourceRequirements.DeserializeAppPlatformServiceRegistryResourceRequirements(property.Value);
                    continue;
                }
                if (property.NameEquals("instances"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AppPlatformServiceRegistryInstance> array = new List<AppPlatformServiceRegistryInstance>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AppPlatformServiceRegistryInstance.DeserializeAppPlatformServiceRegistryInstance(item));
                    }
                    instances = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AppPlatformServiceRegistryProperties(Optional.ToNullable(provisioningState), resourceRequests.Value, Optional.ToList(instances), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<AppPlatformServiceRegistryProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AppPlatformServiceRegistryProperties IPersistableModel<AppPlatformServiceRegistryProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AppPlatformServiceRegistryProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAppPlatformServiceRegistryProperties(document.RootElement, options);
        }

        string IPersistableModel<AppPlatformServiceRegistryProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
