// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class ImageReference : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Publisher))
            {
                writer.WritePropertyName("publisher");
                writer.WriteStringValue(Publisher);
            }
            if (Optional.IsDefined(Offer))
            {
                writer.WritePropertyName("offer");
                writer.WriteStringValue(Offer);
            }
            if (Optional.IsDefined(Sku))
            {
                writer.WritePropertyName("sku");
                writer.WriteStringValue(Sku);
            }
            if (Optional.IsDefined(Version))
            {
                writer.WritePropertyName("version");
                writer.WriteStringValue(Version);
            }
            if (Optional.IsDefined(ExactVersion))
            {
                writer.WritePropertyName("exactVersion");
                writer.WriteStringValue(ExactVersion);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static ImageReference DeserializeImageReference(JsonElement element)
        {
            Optional<string> publisher = default;
            Optional<string> offer = default;
            Optional<string> sku = default;
            Optional<string> version = default;
            Optional<string> exactVersion = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("publisher"))
                {
                    publisher = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("offer"))
                {
                    offer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("sku"))
                {
                    sku = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("version"))
                {
                    version = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("exactVersion"))
                {
                    exactVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new ImageReference(id.HasValue ? id.Value : null, publisher.HasValue ? publisher.Value : null, offer.HasValue ? offer.Value : null, sku.HasValue ? sku.Value : null, version.HasValue ? version.Value : null, exactVersion.HasValue ? exactVersion.Value : null);
        }
    }
}
