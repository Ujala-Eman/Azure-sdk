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

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    public partial class ControlFamily : IUtf8JsonSerializable, IJsonModel<ControlFamily>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<ControlFamily>)this).Write(writer, ModelReaderWriterOptions.Wire);

        void IJsonModel<ControlFamily>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            if ((options.Format != "W" || ((IPersistableModel<ControlFamily>)this).GetWireFormat(options) != "J") && options.Format != "J")
            {
                throw new InvalidOperationException($"Must use 'J' format when calling the {nameof(IJsonModel<ControlFamily>)} interface");
            }

            writer.WriteStartObject();
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FamilyName))
                {
                    writer.WritePropertyName("familyName"u8);
                    writer.WriteStringValue(FamilyName);
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FamilyType))
                {
                    writer.WritePropertyName("familyType"u8);
                    writer.WriteStringValue(FamilyType.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsDefined(FamilyStatus))
                {
                    writer.WritePropertyName("familyStatus"u8);
                    writer.WriteStringValue(FamilyStatus.Value.ToString());
                }
            }
            if (options.Format == "J")
            {
                if (Optional.IsCollectionDefined(Controls))
                {
                    writer.WritePropertyName("controls"u8);
                    writer.WriteStartArray();
                    foreach (var item in Controls)
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

        ControlFamily IJsonModel<ControlFamily>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ControlFamily)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeControlFamily(document.RootElement, options);
        }

        internal static ControlFamily DeserializeControlFamily(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<string> familyName = default;
            Optional<ControlFamilyType> familyType = default;
            Optional<ControlFamilyStatus> familyStatus = default;
            Optional<IReadOnlyList<Control>> controls = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> additionalPropertiesDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("familyName"u8))
                {
                    familyName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("familyType"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyType = new ControlFamilyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("familyStatus"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    familyStatus = new ControlFamilyStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("controls"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<Control> array = new List<Control>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(Control.DeserializeControl(item));
                    }
                    controls = array;
                    continue;
                }
                if (options.Format == "J")
                {
                    additionalPropertiesDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = additionalPropertiesDictionary;
            return new ControlFamily(familyName.Value, Optional.ToNullable(familyType), Optional.ToNullable(familyStatus), Optional.ToList(controls), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<ControlFamily>.Write(ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ControlFamily)} does not support '{options.Format}' format.");
            }

            return ModelReaderWriter.Write(this, options);
        }

        ControlFamily IPersistableModel<ControlFamily>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            bool isValid = options.Format == "J" || options.Format == "W";
            if (!isValid)
            {
                throw new FormatException($"The model {nameof(ControlFamily)} does not support '{options.Format}' format.");
            }

            using JsonDocument document = JsonDocument.Parse(data);
            return DeserializeControlFamily(document.RootElement, options);
        }

        string IPersistableModel<ControlFamily>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
