// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    public partial class VirtualMachineImage : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("location");
            writer.WriteStringValue(Location);
            if (Optional.IsCollectionDefined(Tags))
            {
                writer.WritePropertyName("tags");
                writer.WriteStartObject();
                foreach (var item in Tags)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Id))
            {
                writer.WritePropertyName("id");
                writer.WriteStringValue(Id);
            }
            writer.WritePropertyName("properties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Plan))
            {
                writer.WritePropertyName("plan");
                writer.WriteObjectValue(Plan);
            }
            if (Optional.IsDefined(OsDiskImage))
            {
                writer.WritePropertyName("osDiskImage");
                writer.WriteObjectValue(OsDiskImage);
            }
            if (Optional.IsCollectionDefined(DataDiskImages))
            {
                writer.WritePropertyName("dataDiskImages");
                writer.WriteStartArray();
                foreach (var item in DataDiskImages)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(AutomaticOSUpgradeProperties))
            {
                writer.WritePropertyName("automaticOSUpgradeProperties");
                writer.WriteObjectValue(AutomaticOSUpgradeProperties);
            }
            if (Optional.IsDefined(HyperVGeneration))
            {
                writer.WritePropertyName("hyperVGeneration");
                writer.WriteStringValue(HyperVGeneration.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }

        internal static VirtualMachineImage DeserializeVirtualMachineImage(JsonElement element)
        {
            string name = default;
            string location = default;
            Optional<IDictionary<string, string>> tags = default;
            Optional<string> id = default;
            Optional<PurchasePlan> plan = default;
            Optional<OSDiskImage> osDiskImage = default;
            Optional<IList<DataDiskImage>> dataDiskImages = default;
            Optional<AutomaticOSUpgradeProperties> automaticOSUpgradeProperties = default;
            Optional<HyperVGenerationTypes> hyperVGeneration = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("location"))
                {
                    location = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
                if (property.NameEquals("id"))
                {
                    id = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("plan"))
                        {
                            plan = PurchasePlan.DeserializePurchasePlan(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("osDiskImage"))
                        {
                            osDiskImage = OSDiskImage.DeserializeOSDiskImage(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataDiskImages"))
                        {
                            List<DataDiskImage> array = new List<DataDiskImage>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                array.Add(DataDiskImage.DeserializeDataDiskImage(item));
                            }
                            dataDiskImages = array;
                            continue;
                        }
                        if (property0.NameEquals("automaticOSUpgradeProperties"))
                        {
                            automaticOSUpgradeProperties = AutomaticOSUpgradeProperties.DeserializeAutomaticOSUpgradeProperties(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("hyperVGeneration"))
                        {
                            hyperVGeneration = new HyperVGenerationTypes(property0.Value.GetString());
                            continue;
                        }
                    }
                    continue;
                }
            }
            return new VirtualMachineImage(id.Value, name, location, Optional.ToDictionary(tags), plan.Value, osDiskImage.Value, Optional.ToList(dataDiskImages), automaticOSUpgradeProperties.Value, Optional.ToNullable(hyperVGeneration));
        }
    }
}
