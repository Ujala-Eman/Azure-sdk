// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class FormatBasicProperties : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("@odata.type");
            writer.WriteStringValue(OdataType);
            writer.WritePropertyName("filenamePattern");
            writer.WriteStringValue(FilenamePattern);
            writer.WriteEndObject();
        }

        internal static FormatBasicProperties DeserializeFormatBasicProperties(JsonElement element)
        {
            if (element.TryGetProperty("@odata.type", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "#Microsoft.Media.ImageFormat": return ImageFormat.DeserializeImageFormat(element);
                    case "#Microsoft.Media.JpgFormat": return JpgFormat.DeserializeJpgFormat(element);
                    case "#Microsoft.Media.Mp4Format": return Mp4Format.DeserializeMp4Format(element);
                    case "#Microsoft.Media.MultiBitrateFormat": return MultiBitrateFormat.DeserializeMultiBitrateFormat(element);
                    case "#Microsoft.Media.PngFormat": return PngFormat.DeserializePngFormat(element);
                    case "#Microsoft.Media.TransportStreamFormat": return TransportStreamFormat.DeserializeTransportStreamFormat(element);
                }
            }
            string odataType = default;
            string filenamePattern = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("@odata.type"))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("filenamePattern"))
                {
                    filenamePattern = property.Value.GetString();
                    continue;
                }
            }
            return new FormatBasicProperties(odataType, filenamePattern);
        }
    }
}
