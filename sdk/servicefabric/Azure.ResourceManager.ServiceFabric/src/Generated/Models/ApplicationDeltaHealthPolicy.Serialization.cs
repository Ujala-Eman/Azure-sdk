// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ServiceFabric.Models
{
    public partial class ApplicationDeltaHealthPolicy : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(DefaultServiceTypeDeltaHealthPolicy))
            {
                writer.WritePropertyName("defaultServiceTypeDeltaHealthPolicy");
                writer.WriteObjectValue(DefaultServiceTypeDeltaHealthPolicy);
            }
            if (Optional.IsCollectionDefined(ServiceTypeDeltaHealthPolicies))
            {
                writer.WritePropertyName("serviceTypeDeltaHealthPolicies");
                writer.WriteStartObject();
                foreach (var item in ServiceTypeDeltaHealthPolicies)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
        }

        internal static ApplicationDeltaHealthPolicy DeserializeApplicationDeltaHealthPolicy(JsonElement element)
        {
            Optional<ServiceTypeDeltaHealthPolicy> defaultServiceTypeDeltaHealthPolicy = default;
            Optional<IDictionary<string, ServiceTypeDeltaHealthPolicy>> serviceTypeDeltaHealthPolicies = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("defaultServiceTypeDeltaHealthPolicy"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    defaultServiceTypeDeltaHealthPolicy = ServiceTypeDeltaHealthPolicy.DeserializeServiceTypeDeltaHealthPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("serviceTypeDeltaHealthPolicies"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, ServiceTypeDeltaHealthPolicy> dictionary = new Dictionary<string, ServiceTypeDeltaHealthPolicy>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, ServiceTypeDeltaHealthPolicy.DeserializeServiceTypeDeltaHealthPolicy(property0.Value));
                    }
                    serviceTypeDeltaHealthPolicies = dictionary;
                    continue;
                }
            }
            return new ApplicationDeltaHealthPolicy(defaultServiceTypeDeltaHealthPolicy.Value, Optional.ToDictionary(serviceTypeDeltaHealthPolicies));
        }
    }
}
