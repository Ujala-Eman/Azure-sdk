// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ClientModel.Primitives;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Gallery.Models
{
    public partial class UefiKeySignatures : IUtf8JsonSerializable, IJsonModel<UefiKeySignatures>
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer) => ((IJsonModel<UefiKeySignatures>)this).Write(writer, ModelSerializationExtensions.WireOptions);

        void IJsonModel<UefiKeySignatures>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            JsonModelWriteCore(writer, options);
            writer.WriteEndObject();
        }

        /// <param name="writer"> The JSON writer. </param>
        /// <param name="options"> The client options for reading and writing models. </param>
        protected virtual void JsonModelWriteCore(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support writing '{format}' format.");
            }

            if (Optional.IsDefined(Pk))
            {
                writer.WritePropertyName("pk"u8);
                writer.WriteObjectValue(Pk, options);
            }
            if (Optional.IsCollectionDefined(Kek))
            {
                writer.WritePropertyName("kek"u8);
                writer.WriteStartArray();
                foreach (var item in Kek)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Db))
            {
                writer.WritePropertyName("db"u8);
                writer.WriteStartArray();
                foreach (var item in Db)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Dbx))
            {
                writer.WritePropertyName("dbx"u8);
                writer.WriteStartArray();
                foreach (var item in Dbx)
                {
                    writer.WriteObjectValue(item, options);
                }
                writer.WriteEndArray();
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
        }

        UefiKeySignatures IJsonModel<UefiKeySignatures>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;
            if (format != "J")
            {
                throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support reading '{format}' format.");
            }

            using JsonDocument document = JsonDocument.ParseValue(ref reader);
            return DeserializeUefiKeySignatures(document.RootElement, options);
        }

        internal static UefiKeySignatures DeserializeUefiKeySignatures(JsonElement element, ModelReaderWriterOptions options = null)
        {
            options ??= ModelSerializationExtensions.WireOptions;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            UefiKey pk = default;
            IList<UefiKey> kek = default;
            IList<UefiKey> db = default;
            IList<UefiKey> dbx = default;
            IDictionary<string, BinaryData> serializedAdditionalRawData = default;
            Dictionary<string, BinaryData> rawDataDictionary = new Dictionary<string, BinaryData>();
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("pk"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    pk = UefiKey.DeserializeUefiKey(property.Value, options);
                    continue;
                }
                if (property.NameEquals("kek"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item, options));
                    }
                    kek = array;
                    continue;
                }
                if (property.NameEquals("db"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item, options));
                    }
                    db = array;
                    continue;
                }
                if (property.NameEquals("dbx"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<UefiKey> array = new List<UefiKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(UefiKey.DeserializeUefiKey(item, options));
                    }
                    dbx = array;
                    continue;
                }
                if (options.Format != "W")
                {
                    rawDataDictionary.Add(property.Name, BinaryData.FromString(property.Value.GetRawText()));
                }
            }
            serializedAdditionalRawData = rawDataDictionary;
            return new UefiKeySignatures(pk, kek ?? new ChangeTrackingList<UefiKey>(), db ?? new ChangeTrackingList<UefiKey>(), dbx ?? new ChangeTrackingList<UefiKey>(), serializedAdditionalRawData);
        }

        BinaryData IPersistableModel<UefiKeySignatures>.Write(ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    return ModelReaderWriter.Write(this, options);
                default:
                    throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support writing '{options.Format}' format.");
            }
        }

        UefiKeySignatures IPersistableModel<UefiKeySignatures>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            var format = options.Format == "W" ? ((IPersistableModel<UefiKeySignatures>)this).GetFormatFromOptions(options) : options.Format;

            switch (format)
            {
                case "J":
                    {
                        using JsonDocument document = JsonDocument.Parse(data);
                        return DeserializeUefiKeySignatures(document.RootElement, options);
                    }
                default:
                    throw new FormatException($"The model {nameof(UefiKeySignatures)} does not support reading '{options.Format}' format.");
            }
        }

        string IPersistableModel<UefiKeySignatures>.GetFormatFromOptions(ModelReaderWriterOptions options) => "J";
    }
}
