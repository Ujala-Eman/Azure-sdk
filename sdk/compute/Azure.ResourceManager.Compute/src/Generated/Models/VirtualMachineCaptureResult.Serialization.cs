// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineCaptureResult : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(Schema))
            {
                writer.WritePropertyName("$schema");
                writer.WriteStringValue(Schema);
            }
            if (Optional.IsDefined(ContentVersion))
            {
                writer.WritePropertyName("contentVersion");
                writer.WriteStringValue(ContentVersion);
            }
            if (Optional.IsDefined(Parameters))
            {
                writer.WritePropertyName("parameters");
                writer.WriteObjectValue(Parameters);
            }
            if (Optional.IsDefined(Resources))
            {
                writer.WritePropertyName("resources");
                writer.WriteStartArray();
                foreach (var item in Resources)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WriteEndObject();
        }

        internal static VirtualMachineCaptureResult DeserializeVirtualMachineCaptureResult(JsonElement element)
        {
            Optional<string> schema = default;
            Optional<string> contentVersion = default;
            Optional<object> parameters = default;
            Optional<IList<object>> resources = default;
            Optional<string> id = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("$schema"))
                {
                    schema = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("contentVersion"))
                {
                    contentVersion = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    parameters = property.Value.GetObject();
                    continue;
                }
                if (property.NameEquals("resources"))
                {
                    List<object> array = new List<object>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(item.GetObject());
                        }
                    }
                    resources = array;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
            }
            return new VirtualMachineCaptureResult(id.HasValue ? id.Value : null, schema.HasValue ? schema.Value : null, contentVersion.HasValue ? contentVersion.Value : null, parameters.HasValue ? parameters.Value : null, new ChangeTrackingList<object>(resources));
        }
    }
}
