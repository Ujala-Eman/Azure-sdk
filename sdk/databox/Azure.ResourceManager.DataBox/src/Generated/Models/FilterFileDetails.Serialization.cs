// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    public partial class FilterFileDetails : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("filterFileType");
            writer.WriteStringValue(FilterFileType.ToSerialString());
            writer.WritePropertyName("filterFilePath");
            writer.WriteStringValue(FilterFilePath);
            writer.WriteEndObject();
        }

        internal static FilterFileDetails DeserializeFilterFileDetails(JsonElement element)
        {
            FilterFileType filterFileType = default;
            string filterFilePath = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("filterFileType"))
                {
                    filterFileType = property.Value.GetString().ToFilterFileType();
                    continue;
                }
                if (property.NameEquals("filterFilePath"))
                {
                    filterFilePath = property.Value.GetString();
                    continue;
                }
            }
            return new FilterFileDetails(filterFileType, filterFilePath);
        }
    }
}
