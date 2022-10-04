// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    internal partial class FormulaPropertiesFromVm : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LabVmId))
            {
                writer.WritePropertyName("labVmId");
                writer.WriteStringValue(LabVmId);
            }
            writer.WriteEndObject();
        }

        internal static FormulaPropertiesFromVm DeserializeFormulaPropertiesFromVm(JsonElement element)
        {
            Optional<string> labVmId = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("labVmId"))
                {
                    labVmId = property.Value.GetString();
                    continue;
                }
            }
            return new FormulaPropertiesFromVm(labVmId.Value);
        }
    }
}
