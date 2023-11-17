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

namespace Azure.ResourceManager.ChangeAnalysis.Models
{
    public partial class ChangeProperties : IUtf8JsonSerializable, IJsonModel<ChangeProperties>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ChangeProperties>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ChangeProperties>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ChangeProperties>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ChangeProperties>)} interface");
            }

            writer.WriteStartObject();
            if (Optional.IsDefined(ResourceId))
            {
                writer.WritePropertyName("resourceId"u8);
                writer.WriteStringValue(ResourceId);
            }
            if (Optional.IsDefined(ChangeDetectedOn))
            {
                writer.WritePropertyName("timeStamp"u8);
                writer.WriteStringValue(ChangeDetectedOn.Value, "O");
            }
            if (Optional.IsCollectionDefined(InitiatedByList))
            {
                writer.WritePropertyName("initiatedByList"u8);
                writer.WriteStartArray();
                foreach (var item in InitiatedByList)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(ChangeType))
            {
                writer.WritePropertyName("changeType"u8);
                writer.WriteStringValue(ChangeType.Value.ToString());
            }
            if (Optional.IsCollectionDefined(PropertyChanges))
            {
                writer.WritePropertyName("propertyChanges"u8);
                writer.WriteStartArray();
                foreach (var item in PropertyChanges)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
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

        ChangeProperties IJsonModel<ChangeProperties>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeChangeProperties(document.RootElement, options);
        }

        internal static ChangeProperties DeserializeChangeProperties(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> resourceId = default;
            Optional<DateTimeOffset> timeStamp = default;
            Optional<IReadOnlyList<string>> initiatedByList = default;
            Optional<ChangeType> changeType = default;
            Optional<IReadOnlyList<PropertyChange>> propertyChanges = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("resourceId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    resourceId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeStamp"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    timeStamp = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("initiatedByList"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(item.GetString());
                    }
                    initiatedByList = array;
                    continue;
                }
                if (property.NameEquals("changeType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    changeType = new ChangeType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("propertyChanges"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<PropertyChange> array = new List<PropertyChange>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(PropertyChange.DeserializePropertyChange(item));
                    }
                    propertyChanges = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ChangeProperties(resourceId.Value, Optional.ToNullable(timeStamp), Optional.ToList(initiatedByList), Optional.ToNullable(changeType), Optional.ToList(propertyChanges), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ChangeProperties>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeProperties)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ChangeProperties IPersistableModel<ChangeProperties>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ChangeProperties)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeChangeProperties(document.RootElement, options);
        }

        string IPersistableModel<ChangeProperties>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
