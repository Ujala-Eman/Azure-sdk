// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.ClientModel.Primitives;
using System.ClientModel.Internal;
using System.Text.Json;

namespace System.ClientModel.Tests.Client.Models.ResourceManager.Resources
{
    public partial class ProviderExtendedLocation : IJsonModel<ProviderExtendedLocation>
    {
        internal static ProviderExtendedLocation DeserializeProviderExtendedLocation(JsonElement element, ModelReaderWriterOptions options = default)
        {
            options ??= ModelReaderWriterOptions.Wire;

            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            OptionalProperty<string> location = default;
            OptionalProperty<string> type = default;
            OptionalProperty<IReadOnlyList<string>> extendedLocations = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("location"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"u8))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("extendedLocations"u8))
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
                    extendedLocations = array;
                    continue;
                }
            }
            return new ProviderExtendedLocation(location, type.Value, OptionalProperty.ToList(extendedLocations));
        }

        void IJsonModel<ProviderExtendedLocation>.Write(Utf8JsonWriter writer, ModelReaderWriterOptions options) => Serialize(writer, options);

        private void Serialize(Utf8JsonWriter writer, ModelReaderWriterOptions options)
        {
            writer.WriteStartObject();
            if (OptionalProperty.IsDefined(Location))
            {
                writer.WritePropertyName("location"u8);
                writer.WriteStringValue(Location);
            }
            if (OptionalProperty.IsDefined(ProviderExtendedLocationType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ProviderExtendedLocationType);
            }
            if (OptionalProperty.IsCollectionDefined(ExtendedLocations))
            {
                writer.WritePropertyName("extendedLocations"u8);
                writer.WriteStartArray();
                foreach (var item in ExtendedLocations)
                {
                    writer.WriteStringValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WriteEndObject();
        }

        private struct ProviderExtendedLocationProperties
        {
            public OptionalProperty<string> Location { get; set; }
            public OptionalProperty<string> ProviderExtendedLocationType { get; set; }
            public OptionalProperty<IReadOnlyList<string>> ExtendedLocations { get; set; }
        }

        ProviderExtendedLocation IJsonModel<ProviderExtendedLocation>.Create(ref Utf8JsonReader reader, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.ParseValue(ref reader);
            return DeserializeProviderExtendedLocation(doc.RootElement, options);
        }

        ProviderExtendedLocation IModel<ProviderExtendedLocation>.Create(BinaryData data, ModelReaderWriterOptions options)
        {
            using var doc = JsonDocument.Parse(data);
            return DeserializeProviderExtendedLocation(doc.RootElement, options);
        }

        BinaryData IModel<ProviderExtendedLocation>.Write(ModelReaderWriterOptions options)
        {
            ModelReaderWriterHelper.ValidateFormat(this, options.Format);

            return ModelReaderWriter.Write(this, options);
        }

        string IModel<ProviderExtendedLocation>.GetWireFormat(ModelReaderWriterOptions options) => "J";
    }
}
