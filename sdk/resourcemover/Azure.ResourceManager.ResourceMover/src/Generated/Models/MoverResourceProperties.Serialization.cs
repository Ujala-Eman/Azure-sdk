// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ResourceMover.Models
{
    public partial class MoverResourceProperties : IUtf8JsonSerializable, IJsonModel<MoverResourceProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<MoverResourceProperties>)this).Write(writer, new ModelReaderWriterOptions("W"));

        void IJsonModel<MoverResourceProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<MoverResourceProperties>)this).GetFormatFromOptions(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<MoverResourceProperties>)} interface");
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
            writer.WritePropertyName("sourceId"u8);
            writer.WriteStringValue(SourceId);
            if (options.Format == "J")
            {
                if (Optional.IsDefined(TargetId))
                {
                    if (TargetId != null)
                    {
                        writer.WritePropertyName("targetId"u8);
                        writer.WriteStringValue(TargetId);
                    }
                    else
                    {
                        writer.WriteNull("targetId");
                    }
                }
            }
            if (Optional.IsDefined(ExistingTargetId))
            {
                if (ExistingTargetId != null)
                {
                    writer.WritePropertyName("existingTargetId"u8);
                    writer.WriteStringValue(ExistingTargetId);
                }
                else
                {
                    writer.WriteNull("existingTargetId");
                }
            }
            if (Optional.IsDefined(ResourceSettings))
            {
                if (ResourceSettings != null)
                {
                    writer.WritePropertyName("resourceSettings"u8);
                    writer.WriteObjectValue(ResourceSettings);
                }
                else
                {
                    writer.WriteNull("resourceSettings");
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(SourceResourceSettings))
                {
                    if (SourceResourceSettings != null)
                    {
                        writer.WritePropertyName("sourceResourceSettings"u8);
                        writer.WriteObjectValue(SourceResourceSettings);
                    }
                    else
                    {
                        writer.WriteNull("sourceResourceSettings");
                    }
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(MoveStatus))
                {
                    writer.WritePropertyName("moveStatus"u8);
                    writer.WriteObjectValue(MoveStatus);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(DependsOn))
                {
                    writer.WritePropertyName("dependsOn"u8);
                    writer.WriteStartArray();
                    foreach (var item in DependsOn)
                    {
                        writer.WriteObjectValue(item);
                    }
                    writer.WriteEndArray();
                }
            }
            if (Optional.IsCollectionDefined(DependsOnOverrides))
            {
                writer.WritePropertyName("dependsOnOverrides"u8);
                writer.WriteStartArray();
                foreach (var item in DependsOnOverrides)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(IsResolveRequired))
                {
                    writer.WritePropertyName("isResolveRequired"u8);
                    writer.WriteBooleanValue(IsResolveRequired.Value);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(Errors))
                {
                    if (Errors != null)
                    {
                        writer.WritePropertyName("errors"u8);
                        writer.WriteObjectValue(Errors);
                    }
                    else
                    {
                        writer.WriteNull("errors");
                    }
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

        MoverResourceProperties IJsonModel<MoverResourceProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeMoverResourceProperties(document.RootElement, options);
        }

        internal static MoverResourceProperties DeserializeMoverResourceProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= new ModelReaderWriterOptions("W");

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MoverProvisioningState> provisioningState = default;
            ResourceIdentifier sourceId = default;
            Optional<ResourceIdentifier> targetId = default;
            Optional<ResourceIdentifier> existingTargetId = default;
            Optional<MoverResourceSettings> resourceSettings = default;
            Optional<MoverResourceSettings> sourceResourceSettings = default;
            Optional<MoverResourcePropertiesMoveStatus> moveStatus = default;
            Optional<IReadOnlyList<MoverResourceDependency>> dependsOn = default;
            Optional<IList<MoverResourceDependencyOverride>> dependsOnOverrides = default;
            Optional<bool> isResolveRequired = default;
            Optional<MoveResourcePropertiesErrors> errors = default;
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
                    provisioningState = new MoverProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("sourceId"u8))
                {
                    sourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("targetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        targetId = null;
                        continue;
                    }
                    targetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("existingTargetId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        existingTargetId = null;
                        continue;
                    }
                    existingTargetId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("resourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        resourceSettings = null;
                        continue;
                    }
                    resourceSettings = MoverResourceSettings.DeserializeMoverResourceSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("sourceResourceSettings"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        sourceResourceSettings = null;
                        continue;
                    }
                    sourceResourceSettings = MoverResourceSettings.DeserializeMoverResourceSettings(property.Value);
                    continue;
                }
                if (property.NameEquals("moveStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    moveStatus = MoverResourcePropertiesMoveStatus.DeserializeMoverResourcePropertiesMoveStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("dependsOn"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverResourceDependency> array = new List<MoverResourceDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverResourceDependency.DeserializeMoverResourceDependency(item));
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("dependsOnOverrides"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MoverResourceDependencyOverride> array = new List<MoverResourceDependencyOverride>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MoverResourceDependencyOverride.DeserializeMoverResourceDependencyOverride(item));
                    }
                    dependsOnOverrides = array;
                    continue;
                }
                if (property.NameEquals("isResolveRequired"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    isResolveRequired = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("errors"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        errors = null;
                        continue;
                    }
                    errors = MoveResourcePropertiesErrors.DeserializeMoveResourcePropertiesErrors(property.Value);
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new MoverResourceProperties(Optional.ToNullable(provisioningState), sourceId, targetId.Value, existingTargetId.Value, resourceSettings.Value, sourceResourceSettings.Value, moveStatus.Value, Optional.ToList(dependsOn), Optional.ToList(dependsOnOverrides), Optional.ToNullable(isResolveRequired), errors.Value, serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<MoverResourceProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        MoverResourceProperties IPersistableModel<MoverResourceProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(MoverResourceProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeMoverResourceProperties(document.RootElement, options);
        }

        string IPersistableModel<MoverResourceProperties>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
