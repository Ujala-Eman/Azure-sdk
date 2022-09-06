// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Maps.Search.Models
{
    public partial class GeoJsonMultiLineStringData : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("coordinates");
            writer.WriteStartArray();
            foreach (var item in Coordinates)
            {
                writer.WriteStartArray();
                foreach (var item0 in item)
                {
                    writer.WriteStartArray();
                    foreach (var item1 in item0)
                    {
                        writer.WriteNumberValue(item1);
                    }
                    writer.WriteEndArray();
                }
                writer.WriteEndArray();
            }
            writer.WriteEndArray();
            writer.WriteEndObject();
        }

        internal static GeoJsonMultiLineStringData DeserializeGeoJsonMultiLineStringData(JsonElement element)
        {
            IList<IList<IList<double>>> coordinates = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("coordinates"))
                {
                    List<IList<IList<double>>> array = new List<IList<IList<double>>>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        List<IList<double>> array0 = new List<IList<double>>();
                        foreach (var item0 in item.EnumerateArray())
                        {
                            List<double> array1 = new List<double>();
                            foreach (var item1 in item0.EnumerateArray())
                            {
                                array1.Add(item1.GetDouble());
                            }
                            array0.Add(array1);
                        }
                        array.Add(array0);
                    }
                    coordinates = array;
                    continue;
                }
            }
            return new GeoJsonMultiLineStringData(coordinates);
        }
    }
}
