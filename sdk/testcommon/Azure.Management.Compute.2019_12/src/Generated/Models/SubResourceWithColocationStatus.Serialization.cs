// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    public partial class SubResourceWithColocationStatus : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(ColocationStatus))
            {
                writer.WritePropertyName("colocationStatus");
                writer.WriteObjectValue(ColocationStatus);
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static SubResourceWithColocationStatus DeserializeSubResourceWithColocationStatus(JsonElement element)
        {
            Optional<InstanceViewStatus> colocationStatus = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("colocationStatus"))
                {
                    colocationStatus = InstanceViewStatus.DeserializeInstanceViewStatus(property.Value);
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new SubResourceWithColocationStatus(id.Value, colocationStatus.Value);
        }
    }
}
