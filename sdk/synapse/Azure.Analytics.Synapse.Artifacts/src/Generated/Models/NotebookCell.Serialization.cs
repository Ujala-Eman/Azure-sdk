// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class NotebookCell : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("cell_type");
            writer.WriteStringValue(CellType);
            writer.WritePropertyName("metadata");
            writer.WriteObjectValue(Metadata);
            writer.WritePropertyName("source");
            writer.WriteStartArray();
            foreach (var item in Source)
            {
                writer.WriteStringValue(item);
            }
            writer.WriteEndArray();
            if (Optional.IsDefined(Attachments))
            {
                writer.WritePropertyName("attachments");
                writer.WriteObjectValue(Attachments);
            }
            if (Optional.IsDefined(Outputs))
            {
                writer.WritePropertyName("outputs");
                writer.WriteStartArray();
                foreach (var item in Outputs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static NotebookCell DeserializeNotebookCell(JsonElement element)
        {
            string cellType = default;
            object metadata = default;
            IList<string> source = default;
            Optional<object> attachments = default;
            Optional<IList<NotebookCellOutputItem>> outputs = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("cell_type"))
                {
                    cellType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("metadata"))
                {
                    metadata = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("source"))
                {
                    List<string> array = new List<string>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetString());
                        }
                    }
                    source = array;
                    continue;
                }
                if (property.NameEquals("attachments"))
                {
                    attachments = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    List<NotebookCellOutputItem> array = new List<NotebookCellOutputItem>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(NotebookCellOutputItem.DeserializeNotebookCellOutputItem(item));
                        }
                    }
                    outputs = array;
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new NotebookCell(cellType, metadata, source, attachments.HasValue ? attachments.Value : null, new ChangeTrackingList<NotebookCellOutputItem>(outputs), additionalProperties);
        }
    }
}
