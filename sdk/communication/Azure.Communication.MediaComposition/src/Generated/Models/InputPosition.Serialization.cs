// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.MediaComposition.Models
{
    public partial class InputPosition : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("x");
            writer.WriteNumberValue(X);
            writer.WritePropertyName("y");
            writer.WriteNumberValue(Y);
            writer.WritePropertyName("kind");
            writer.WriteStringValue(Kind);
            writer.WriteEndObject();
        }

        internal static InputPosition DeserializeInputPosition(JsonElement element)
        {
            int x = default;
            int y = default;
            string kind = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("x"))
                {
                    x = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("y"))
                {
                    y = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("kind"))
                {
                    kind = property.Value.GetString();
                    continue;
                }
            }
            return new InputPosition(kind, x, y);
        }
    }
}
