// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    public partial class SapConfiguration : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("configurationType");
            writer.WriteStringValue(ConfigurationType.ToString());
            writer.WriteEndObject();
        }

        internal static SapConfiguration DeserializeSapConfiguration(JsonElement element)
        {
            if (element.TryGetProperty("configurationType", out JsonElement discriminator))
            {
                switch (discriminator.GetString())
                {
                    case "Deployment": return DeploymentConfiguration.DeserializeDeploymentConfiguration(element);
                    case "DeploymentWithOSConfig": return DeploymentWithOSConfiguration.DeserializeDeploymentWithOSConfiguration(element);
                    case "Discovery": return DiscoveryConfiguration.DeserializeDiscoveryConfiguration(element);
                }
            }
            SapConfigurationType configurationType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("configurationType"))
                {
                    configurationType = new SapConfigurationType(property.Value.GetString());
                    continue;
                }
            }
            return new UnknownSapConfiguration(configurationType);
        }
    }
}
