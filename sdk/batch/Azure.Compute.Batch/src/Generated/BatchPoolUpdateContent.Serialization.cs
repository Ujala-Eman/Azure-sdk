// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Compute.Batch
{
    public partial class BatchPoolUpdateContent : IUtf8JsonSerializable, IJsonModel<BatchPoolUpdateContent>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<BatchPoolUpdateContent>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<BatchPoolUpdateContent>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolUpdateContent)} does not support writing '{format}' format.");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Optional.IsDefined(VmSize))
            {
                writer.WritePropertyName("vmSize"u8);
                writer.WriteStringValue(VmSize);
            }
            if (Optional.IsDefined(EnableInterNodeCommunication))
            {
                writer.WritePropertyName("enableInterNodeCommunication"u8);
                writer.WriteBooleanValue(EnableInterNodeCommunication.Value);
            }
            if (Optional.IsDefined(StartTask))
            {
                writer.WritePropertyName("startTask"u8);
                writer.WriteObjectValue(StartTask, options);
            }
            if (Optional.IsCollectionDefined(ApplicationPackageReferences))
            {
                writer.WritePropertyName("applicationPackageReferences"u8);
                writer.WriteStartArray();
                foreach (var item in ApplicationPackageReferences)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Metadata))
            {
                writer.WritePropertyName("metadata"u8);
                writer.WriteStartArray();
                foreach (var item in Metadata)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(VirtualMachineConfiguration))
            {
                writer.WritePropertyName("virtualMachineConfiguration"u8);
                writer.WriteObjectValue(VirtualMachineConfiguration, options);
            }
            if (Optional.IsDefined(TargetNodeCommunicationMode))
            {
                writer.WritePropertyName("targetNodeCommunicationMode"u8);
                writer.WriteStringValue(TargetNodeCommunicationMode.Value.ToString());
            }
            if (Optional.IsDefined(TaskSlotsPerNode))
            {
                writer.WritePropertyName("taskSlotsPerNode"u8);
                writer.WriteNumberValue(TaskSlotsPerNode.Value);
            }
            if (Optional.IsDefined(TaskSchedulingPolicy))
            {
                writer.WritePropertyName("taskSchedulingPolicy"u8);
                writer.WriteObjectValue(TaskSchedulingPolicy, options);
            }
            if (Optional.IsDefined(NetworkConfiguration))
            {
                writer.WritePropertyName("networkConfiguration"u8);
                writer.WriteObjectValue(NetworkConfiguration, options);
            }
            if (Optional.IsCollectionDefined(ResourceTags))
            {
                writer.WritePropertyName("resourceTags"u8);
                writer.WriteStartObject();
                foreach (var item in ResourceTags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(UserAccounts))
            {
                writer.WritePropertyName("userAccounts"u8);
                writer.WriteStartArray();
                foreach (var item in UserAccounts)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(MountConfiguration))
            {
                writer.WritePropertyName("mountConfiguration"u8);
                writer.WriteStartArray();
                foreach (var item in MountConfiguration)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UpgradePolicy))
            {
                writer.WritePropertyName("upgradePolicy"u8);
                writer.WriteObjectValue(UpgradePolicy, options);
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

        BatchPoolUpdateContent IJsonModel<BatchPoolUpdateContent>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolUpdateContent>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(BatchPoolUpdateContent)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeBatchPoolUpdateContent(document.RootElement, options);
        }

        internal static BatchPoolUpdateContent DeserializeBatchPoolUpdateContent(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string displayName = default;
            string vmSize = default;
            bool? enableInterNodeCommunication = default;
            BatchStartTask startTask = default;
            IList<BatchApplicationPackageReference> applicationPackageReferences = default;
            IList<MetadataItem> metadata = default;
            VirtualMachineConfiguration virtualMachineConfiguration = default;
            BatchNodeCommunicationMode? targetNodeCommunicationMode = default;
            int? taskSlotsPerNode = default;
            BatchTaskSchedulingPolicy taskSchedulingPolicy = default;
            NetworkConfiguration networkConfiguration = default;
            IDictionary<string, string> resourceTags = default;
            IList<UserAccount> userAccounts = default;
            IList<MountConfiguration> mountConfiguration = default;
            UpgradePolicy upgradePolicy = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("displayName"u8))
                {
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("vmSize"u8))
                {
                    vmSize = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("enableInterNodeCommunication"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    enableInterNodeCommunication = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("startTask"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    startTask = BatchStartTask.DeserializeBatchStartTask(property.Value, options);
                    continue;
                }
                if (property.NameEquals("applicationPackageReferences"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<BatchApplicationPackageReference> array = new List<BatchApplicationPackageReference>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(BatchApplicationPackageReference.DeserializeBatchApplicationPackageReference(item, options));
                    }
                    applicationPackageReferences = array;
                    continue;
                }
                if (property.NameEquals("metadata"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MetadataItem> array = new List<MetadataItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(MetadataItem.DeserializeMetadataItem(item, options));
                    }
                    metadata = array;
                    continue;
                }
                if (property.NameEquals("virtualMachineConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    virtualMachineConfiguration = VirtualMachineConfiguration.DeserializeVirtualMachineConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("targetNodeCommunicationMode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    targetNodeCommunicationMode = new BatchNodeCommunicationMode(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("taskSlotsPerNode"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taskSlotsPerNode = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("taskSchedulingPolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    taskSchedulingPolicy = BatchTaskSchedulingPolicy.DeserializeBatchTaskSchedulingPolicy(property.Value, options);
                    continue;
                }
                if (property.NameEquals("networkConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    networkConfiguration = NetworkConfiguration.DeserializeNetworkConfiguration(property.Value, options);
                    continue;
                }
                if (property.NameEquals("resourceTags"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    resourceTags = dictionary;
                    continue;
                }
                if (property.NameEquals("userAccounts"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UserAccount> array = new List<UserAccount>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UserAccount.DeserializeUserAccount(item, options));
                    }
                    userAccounts = array;
                    continue;
                }
                if (property.NameEquals("mountConfiguration"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<MountConfiguration> array = new List<MountConfiguration>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Batch.MountConfiguration.DeserializeMountConfiguration(item, options));
                    }
                    mountConfiguration = array;
                    continue;
                }
                if (property.NameEquals("upgradePolicy"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    upgradePolicy = UpgradePolicy.DeserializeUpgradePolicy(property.Value, options);
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new BatchPoolUpdateContent(
                displayName,
                vmSize,
                enableInterNodeCommunication,
                startTask,
                applicationPackageReferences ?? new ChangeTrackingList<BatchApplicationPackageReference>(),
                metadata ?? new ChangeTrackingList<MetadataItem>(),
                virtualMachineConfiguration,
                targetNodeCommunicationMode,
                taskSlotsPerNode,
                taskSchedulingPolicy,
                networkConfiguration,
                resourceTags ?? new ChangeTrackingDictionary<string, string>(),
                userAccounts ?? new ChangeTrackingList<UserAccount>(),
                mountConfiguration ?? new ChangeTrackingList<MountConfiguration>(),
                upgradePolicy,
                serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<BatchPoolUpdateContent>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(BatchPoolUpdateContent)} does not support writing '{options.Format}' format.");
            }
        }

        BatchPoolUpdateContent IPersistableModel<BatchPoolUpdateContent>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<BatchPoolUpdateContent>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeBatchPoolUpdateContent(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(BatchPoolUpdateContent)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<BatchPoolUpdateContent>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";

        /// <summary> Deserializes the model from a raw response. </summary>
        /// <param name="response"> The response to deserialize the model from. </param>
        internal static BatchPoolUpdateContent FromResponse(Response response)
        {
            using var document = JsonDocument.Parse(response.Content);
            return DeserializeBatchPoolUpdateContent(document.RootElement);
        }

        /// <summary> Convert into a <see cref="RequestContent"/>. </summary>
        internal virtual RequestContent ToRequestContent()
        {
            var content = new Utf8JsonRequestContent();
            content.JsonWriter.WriteObjectValue(this, ModelSerializationExtensions.WireOptions);
            return content;
        }
    }
}
