// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    public partial class ParameterValuesValue : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value");
                writer.WriteObjectValue(Value);
            }
            writer.WriteEndObject();
        }

        internal static ParameterValuesValue DeserializeParameterValuesValue(JsonElement element)
        {
            Optional<object> value = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("value"))
                {
                    value = property.Value.GetObject();
                    continue;
                }
            }
            return new ParameterValuesValue(value.HasValue ? value.Value : null);
        }
    }
}
