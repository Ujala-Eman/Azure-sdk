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
using Azure.ResourceManager.ServiceBus.Models;

namespace Azure.ResourceManager.ServiceBus
{
    public partial class ServiceBusSubscriptionData : IUtf8JsonSerializable, IJsonModel<ServiceBusSubscriptionData>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ServiceBusSubscriptionData>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<ServiceBusSubscriptionData>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected override void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusSubscriptionData)} does not support writing '{format}' format.");
            }

            base.JsonModelWriteCore(writer, options);
            if (options.Format != "W" && Optional.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location.Value);
            }
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (options.Format != "W" && Optional.IsDefined(MessageCount))
            {
                writer.WritePropertyName("messageCount"u8);
                writer.WriteNumberValue(MessageCount.Value);
            }
            if (options.Format != "W" && Optional.IsDefined(CreatedOn))
            {
                writer.WritePropertyName("createdAt"u8);
                writer.WriteStringValue(CreatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(AccessedOn))
            {
                writer.WritePropertyName("accessedAt"u8);
                writer.WriteStringValue(AccessedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(UpdatedOn))
            {
                writer.WritePropertyName("updatedAt"u8);
                writer.WriteStringValue(UpdatedOn.Value, "O");
            }
            if (options.Format != "W" && Optional.IsDefined(CountDetails))
            {
                writer.WritePropertyName("countDetails"u8);
                writer.WriteObjectValue(CountDetails, options);
            }
            if (Optional.IsDefined(LockDuration))
            {
                writer.WritePropertyName("lockDuration"u8);
                writer.WriteStringValue(LockDuration.Value, "P");
            }
            if (Optional.IsDefined(RequiresSession))
            {
                writer.WritePropertyName("requiresSession"u8);
                writer.WriteBooleanValue(RequiresSession.Value);
            }
            if (Optional.IsDefined(DefaultMessageTimeToLive))
            {
                writer.WritePropertyName("defaultMessageTimeToLive"u8);
                writer.WriteStringValue(DefaultMessageTimeToLive.Value, "P");
            }
            if (Optional.IsDefined(DeadLetteringOnFilterEvaluationExceptions))
            {
                writer.WritePropertyName("deadLetteringOnFilterEvaluationExceptions"u8);
                writer.WriteBooleanValue(DeadLetteringOnFilterEvaluationExceptions.Value);
            }
            if (Optional.IsDefined(DeadLetteringOnMessageExpiration))
            {
                writer.WritePropertyName("deadLetteringOnMessageExpiration"u8);
                writer.WriteBooleanValue(DeadLetteringOnMessageExpiration.Value);
            }
            if (Optional.IsDefined(DuplicateDetectionHistoryTimeWindow))
            {
                writer.WritePropertyName("duplicateDetectionHistoryTimeWindow"u8);
                writer.WriteStringValue(DuplicateDetectionHistoryTimeWindow.Value, "P");
            }
            if (Optional.IsDefined(MaxDeliveryCount))
            {
                writer.WritePropertyName("maxDeliveryCount"u8);
                writer.WriteNumberValue(MaxDeliveryCount.Value);
            }
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToSerialString());
            }
            if (Optional.IsDefined(EnableBatchedOperations))
            {
                writer.WritePropertyName("enableBatchedOperations"u8);
                writer.WriteBooleanValue(EnableBatchedOperations.Value);
            }
            if (Optional.IsDefined(AutoDeleteOnIdle))
            {
                writer.WritePropertyName("autoDeleteOnIdle"u8);
                writer.WriteStringValue(AutoDeleteOnIdle.Value, "P");
            }
            if (Optional.IsDefined(ForwardTo))
            {
                writer.WritePropertyName("forwardTo"u8);
                writer.WriteStringValue(ForwardTo);
            }
            if (Optional.IsDefined(ForwardDeadLetteredMessagesTo))
            {
                writer.WritePropertyName("forwardDeadLetteredMessagesTo"u8);
                writer.WriteStringValue(ForwardDeadLetteredMessagesTo);
            }
            if (Optional.IsDefined(IsClientAffine))
            {
                writer.WritePropertyName("isClientAffine"u8);
                writer.WriteBooleanValue(IsClientAffine.Value);
            }
            if (Optional.IsDefined(ClientAffineProperties))
            {
                writer.WritePropertyName("clientAffineProperties"u8);
                writer.WriteObjectValue(ClientAffineProperties, options);
            }
            writer.WriteEndObject();
        }

        ServiceBusSubscriptionData IJsonModel<ServiceBusSubscriptionData>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(ServiceBusSubscriptionData)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeServiceBusSubscriptionData(document.RootElement, options);
        }

        internal static ServiceBusSubscriptionData DeserializeServiceBusSubscriptionData(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            AzureLocation? location = default;
            ResourceIdentifier id = default;
            string name = default;
            ResourceType type = default;
            SystemData systemData = default;
            long? messageCount = default;
            DateTimeOffset? createdAt = default;
            DateTimeOffset? accessedAt = default;
            DateTimeOffset? updatedAt = default;
            MessageCountDetails countDetails = default;
            TimeSpan? lockDuration = default;
            bool? requiresSession = default;
            TimeSpan? defaultMessageTimeToLive = default;
            bool? deadLetteringOnFilterEvaluationExceptions = default;
            bool? deadLetteringOnMessageExpiration = default;
            TimeSpan? duplicateDetectionHistoryTimeWindow = default;
            int? maxDeliveryCount = default;
            ServiceBusMessagingEntityStatus? status = default;
            bool? enableBatchedOperations = default;
            TimeSpan? autoDeleteOnIdle = default;
            string forwardTo = default;
            string forwardDeadLetteredMessagesTo = default;
            bool? isClientAffine = default;
            ServiceBusClientAffineProperties clientAffineProperties = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = new AzureLocation(property.Value.GetString());
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
                        if (property0.NameEquals("messageCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            messageCount = property0.Value.GetInt64();
                            continue;
                        }
                        if (property0.NameEquals("createdAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            createdAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("accessedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            accessedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("updatedAt"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            updatedAt = property0.Value.GetDateTimeOffset("O");
                            continue;
                        }
                        if (property0.NameEquals("countDetails"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            countDetails = MessageCountDetails.DeserializeMessageCountDetails(property0.Value, options);
                            continue;
                        }
                        if (property0.NameEquals("lockDuration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            lockDuration = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("requiresSession"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            requiresSession = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("defaultMessageTimeToLive"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            defaultMessageTimeToLive = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("deadLetteringOnFilterEvaluationExceptions"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deadLetteringOnFilterEvaluationExceptions = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("deadLetteringOnMessageExpiration"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            deadLetteringOnMessageExpiration = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("duplicateDetectionHistoryTimeWindow"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            duplicateDetectionHistoryTimeWindow = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("maxDeliveryCount"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            maxDeliveryCount = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("status"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            status = property0.Value.GetString().ToServiceBusMessagingEntityStatus();
                            continue;
                        }
                        if (property0.NameEquals("enableBatchedOperations"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            enableBatchedOperations = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("autoDeleteOnIdle"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            autoDeleteOnIdle = property0.Value.GetTimeSpan("P");
                            continue;
                        }
                        if (property0.NameEquals("forwardTo"u8))
                        {
                            forwardTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("forwardDeadLetteredMessagesTo"u8))
                        {
                            forwardDeadLetteredMessagesTo = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("isClientAffine"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            isClientAffine = property0.Value.GetBoolean();
                            continue;
                        }
                        if (property0.NameEquals("clientAffineProperties"u8))
                        {
                            if (property0.Value.ValueKind == JsonValueKind.Null)
                            {
                                continue;
                            }
                            clientAffineProperties = ServiceBusClientAffineProperties.DeserializeServiceBusClientAffineProperties(property0.Value, options);
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
            return new ServiceBusSubscriptionData(
                id,
                name,
                type,
                systemData,
                messageCount,
                createdAt,
                accessedAt,
                updatedAt,
                countDetails,
                lockDuration,
                requiresSession,
                defaultMessageTimeToLive,
                deadLetteringOnFilterEvaluationExceptions,
                deadLetteringOnMessageExpiration,
                duplicateDetectionHistoryTimeWindow,
                maxDeliveryCount,
                status,
                enableBatchedOperations,
                autoDeleteOnIdle,
                forwardTo,
                forwardDeadLetteredMessagesTo,
                isClientAffine,
                clientAffineProperties,
                location,
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

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Location), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("  location: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Location))
                {
                    builder.Append("  location: ");
                    builder.AppendLine($"'{Location.Value.ToString()}'");
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
            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MessageCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    messageCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MessageCount))
                {
                    builder.Append("    messageCount: ");
                    builder.AppendLine($"'{MessageCount.Value.ToString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CreatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    createdAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CreatedOn))
                {
                    builder.Append("    createdAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(CreatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AccessedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    accessedAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AccessedOn))
                {
                    builder.Append("    accessedAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(AccessedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(UpdatedOn), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    updatedAt: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(UpdatedOn))
                {
                    builder.Append("    updatedAt: ");
                    var formattedDateTimeString = TypeFormatters.ToString(UpdatedOn.Value, "o");
                    builder.AppendLine($"'{formattedDateTimeString}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(CountDetails), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    countDetails: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(CountDetails))
                {
                    builder.Append("    countDetails: ");
                    BicepSerializationHelpers.AppendChildObject(builder, CountDetails, options, 4, false, "    countDetails: ");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(LockDuration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    lockDuration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(LockDuration))
                {
                    builder.Append("    lockDuration: ");
                    var formattedTimeSpan = TypeFormatters.ToString(LockDuration.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(RequiresSession), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    requiresSession: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(RequiresSession))
                {
                    builder.Append("    requiresSession: ");
                    var boolValue = RequiresSession.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DefaultMessageTimeToLive), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    defaultMessageTimeToLive: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DefaultMessageTimeToLive))
                {
                    builder.Append("    defaultMessageTimeToLive: ");
                    var formattedTimeSpan = TypeFormatters.ToString(DefaultMessageTimeToLive.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetteringOnFilterEvaluationExceptions), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deadLetteringOnFilterEvaluationExceptions: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetteringOnFilterEvaluationExceptions))
                {
                    builder.Append("    deadLetteringOnFilterEvaluationExceptions: ");
                    var boolValue = DeadLetteringOnFilterEvaluationExceptions.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DeadLetteringOnMessageExpiration), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    deadLetteringOnMessageExpiration: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DeadLetteringOnMessageExpiration))
                {
                    builder.Append("    deadLetteringOnMessageExpiration: ");
                    var boolValue = DeadLetteringOnMessageExpiration.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(DuplicateDetectionHistoryTimeWindow), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    duplicateDetectionHistoryTimeWindow: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(DuplicateDetectionHistoryTimeWindow))
                {
                    builder.Append("    duplicateDetectionHistoryTimeWindow: ");
                    var formattedTimeSpan = TypeFormatters.ToString(DuplicateDetectionHistoryTimeWindow.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(MaxDeliveryCount), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    maxDeliveryCount: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(MaxDeliveryCount))
                {
                    builder.Append("    maxDeliveryCount: ");
                    builder.AppendLine($"{MaxDeliveryCount.Value}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(Status), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    status: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(Status))
                {
                    builder.Append("    status: ");
                    builder.AppendLine($"'{Status.Value.ToSerialString()}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(EnableBatchedOperations), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    enableBatchedOperations: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(EnableBatchedOperations))
                {
                    builder.Append("    enableBatchedOperations: ");
                    var boolValue = EnableBatchedOperations.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(AutoDeleteOnIdle), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    autoDeleteOnIdle: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(AutoDeleteOnIdle))
                {
                    builder.Append("    autoDeleteOnIdle: ");
                    var formattedTimeSpan = TypeFormatters.ToString(AutoDeleteOnIdle.Value, "P");
                    builder.AppendLine($"'{formattedTimeSpan}'");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ForwardTo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    forwardTo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ForwardTo))
                {
                    builder.Append("    forwardTo: ");
                    if (ForwardTo.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ForwardTo}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ForwardTo}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ForwardDeadLetteredMessagesTo), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    forwardDeadLetteredMessagesTo: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ForwardDeadLetteredMessagesTo))
                {
                    builder.Append("    forwardDeadLetteredMessagesTo: ");
                    if (ForwardDeadLetteredMessagesTo.Contains(Environment.NewLine))
                    {
                        builder.AppendLine("'''");
                        builder.AppendLine($"{ForwardDeadLetteredMessagesTo}'''");
                    }
                    else
                    {
                        builder.AppendLine($"'{ForwardDeadLetteredMessagesTo}'");
                    }
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(IsClientAffine), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    isClientAffine: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(IsClientAffine))
                {
                    builder.Append("    isClientAffine: ");
                    var boolValue = IsClientAffine.Value == true ? "true" : "false";
                    builder.AppendLine($"{boolValue}");
                }
            }

            hasPropertyOverride = hasObjectOverride && propertyOverrides.TryGetValue(nameof(ClientAffineProperties), out propertyOverride);
            if (hasPropertyOverride)
            {
                builder.Append("    clientAffineProperties: ");
                builder.AppendLine(propertyOverride);
            }
            else
            {
                if (Optional.IsDefined(ClientAffineProperties))
                {
                    builder.Append("    clientAffineProperties: ");
                    BicepSerializationHelpers.AppendChildObject(builder, ClientAffineProperties, options, 4, false, "    clientAffineProperties: ");
                }
            }

            builder.AppendLine("  }");
            builder.AppendLine("}");
            return BinaryData.FromString(builder.ToString());
        }

        BinaryData IPersistableModel<ServiceBusSubscriptionData>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                case "bicep":
                    return SerializeBicep(options);
                default:
                    throw new FormatException($"The model {nameof(ServiceBusSubscriptionData)} does not support writing '{options.Format}' format.");
            }
        }

        ServiceBusSubscriptionData IPersistableModel<ServiceBusSubscriptionData>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<ServiceBusSubscriptionData>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeServiceBusSubscriptionData(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(ServiceBusSubscriptionData)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<ServiceBusSubscriptionData>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
