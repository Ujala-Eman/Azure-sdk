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

namespace Azure.ResourceManager.StorageCache.Models
{
    public partial class AmlFileSystemPropertiesMaintenanceWindow : IUtf8JsonSerializable, IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>)this).Write(writer, ModelReaderWriterOptions.DefaultWireOptions);

        void IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DayOfWeek))
            {
                writer.WritePropertyName("dayOfWeek"u8);
                writer.WriteStringValue(DayOfWeek.Value.ToSerialString());
            }
            if (Optional.IsDefined(TimeOfDayUTC))
            {
                writer.WritePropertyName("timeOfDayUTC"u8);
                writer.WriteStringValue(TimeOfDayUTC);
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

        AmlFileSystemPropertiesMaintenanceWindow IJsonModel<AmlFileSystemPropertiesMaintenanceWindow>.Read(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeAmlFileSystemPropertiesMaintenanceWindow(document.RootElement, options);
        }

        internal static AmlFileSystemPropertiesMaintenanceWindow DeserializeAmlFileSystemPropertiesMaintenanceWindow(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.DefaultWireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<MaintenanceDayOfWeekType> dayOfWeek = default;
            Optional<string> timeOfDayUTC = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("dayOfWeek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    dayOfWeek = property.Value.GetString().ToMaintenanceDayOfWeekType();
                    continue;
                }
                if (property.NameEquals("timeOfDayUTC"u8))
                {
                    timeOfDayUTC = property.Value.GetString();
                    continue;
                }
                if (options.Format == ModelReaderWriterFormat.Json)
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new AmlFileSystemPropertiesMaintenanceWindow(Optional.ToNullable(dayOfWeek), timeOfDayUTC.Value, serializedAdditionalRawData);
        }

        BinaryData IModel<AmlFileSystemPropertiesMaintenanceWindow>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        AmlFileSystemPropertiesMaintenanceWindow IModel<AmlFileSystemPropertiesMaintenanceWindow>.Read(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == ModelReaderWriterFormat.Json || options.Format == ModelReaderWriterFormat.Wire;
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(AmlFileSystemPropertiesMaintenanceWindow)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeAmlFileSystemPropertiesMaintenanceWindow(document.RootElement, options);
        }

        ModelReaderWriterFormat IModel<AmlFileSystemPropertiesMaintenanceWindow>.GetWireFormat(ModelReaderWriterOptions options) => ModelReaderWriterFormat.Json;
    }
}
