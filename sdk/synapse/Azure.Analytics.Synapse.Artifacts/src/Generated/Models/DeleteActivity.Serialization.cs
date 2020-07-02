// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class DeleteActivity : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(LinkedServiceName))
            {
                writer.WritePropertyName("linkedServiceName");
                writer.WriteObjectValue(LinkedServiceName);
            }
            if (Optional.IsDefined(Policy))
            {
                writer.WritePropertyName("policy");
                writer.WriteObjectValue(Policy);
            }
            writer.WritePropertyName("name");
            writer.WriteStringValue(Name);
            writer.WritePropertyName("type");
            writer.WriteStringValue(Type);
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            if (Optional.IsDefined(DependsOn))
            {
                writer.WritePropertyName("dependsOn");
                writer.WriteStartArray();
                foreach (var item in DependsOn)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(UserProperties))
            {
                writer.WritePropertyName("userProperties");
                writer.WriteStartArray();
                foreach (var item in UserProperties)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("typeProperties");
            writer.WriteStartObject();
            if (Optional.IsDefined(Recursive))
            {
                writer.WritePropertyName("recursive");
                writer.WriteObjectValue(Recursive);
            }
            if (Optional.IsDefined(MaxConcurrentConnections))
            {
                writer.WritePropertyName("maxConcurrentConnections");
                writer.WriteNumberValue(MaxConcurrentConnections.Value);
            }
            if (Optional.IsDefined(EnableLogging))
            {
                writer.WritePropertyName("enableLogging");
                writer.WriteObjectValue(EnableLogging);
            }
            if (Optional.IsDefined(LogStorageSettings))
            {
                writer.WritePropertyName("logStorageSettings");
                writer.WriteObjectValue(LogStorageSettings);
            }
            writer.WritePropertyName("dataset");
            writer.WriteObjectValue(Dataset);
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static DeleteActivity DeserializeDeleteActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            Optional<object> recursive = default;
            Optional<int> maxConcurrentConnections = default;
            Optional<object> enableLogging = default;
            Optional<LogStorageSettings> logStorageSettings = default;
            DatasetReference dataset = default;
            IDictionary<string, object> additionalProperties = default;
            Dictionary<string, object> additionalPropertiesDictionary = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("linkedServiceName"))
                {
                    linkedServiceName = LinkedServiceReference.DeserializeLinkedServiceReference(property.Value);
                    continue;
                }
                if (property.NameEquals("policy"))
                {
                    policy = ActivityPolicy.DeserializeActivityPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("name"))
                {
                    name = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("type"))
                {
                    type = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("dependsOn"))
                {
                    List<ActivityDependency> array = new List<ActivityDependency>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(ActivityDependency.DeserializeActivityDependency(item));
                        }
                    }
                    dependsOn = array;
                    continue;
                }
                if (property.NameEquals("userProperties"))
                {
                    List<UserProperty> array = new List<UserProperty>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        if (item.ValueKind == JsonValueKind.Null)
                        {
                            array.Add(null);
                        }
                        else
                        {
                            array.Add(UserProperty.DeserializeUserProperty(item));
                        }
                    }
                    userProperties = array;
                    continue;
                }
                if (property.NameEquals("typeProperties"))
                {
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.NameEquals("recursive"))
                        {
                            recursive = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("maxConcurrentConnections"))
                        {
                            maxConcurrentConnections = property0.Value.GetInt32();
                            continue;
                        }
                        if (property0.NameEquals("enableLogging"))
                        {
                            enableLogging = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("logStorageSettings"))
                        {
                            logStorageSettings = LogStorageSettings.DeserializeLogStorageSettings(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("dataset"))
                        {
                            dataset = DatasetReference.DeserializeDatasetReference(property0.Value);
                            continue;
                        }
                    }
                    continue;
                }
                additionalPropertiesDictionary ??= new Dictionary<string, object>();
                if (property.Value.ValueKind == JsonValueKind.Null)
                {
                    additionalPropertiesDictionary.Add(property.Name, null);
                }
                else
                {
                    additionalPropertiesDictionary.Add(property.Name, property.Value.GetObject());
                }
            }
            additionalProperties = additionalPropertiesDictionary;
            return new DeleteActivity(name, type, description.HasValue ? description.Value : null, new ChangeTrackingList<ActivityDependency>(dependsOn), new ChangeTrackingList<UserProperty>(userProperties), additionalProperties, linkedServiceName.HasValue ? linkedServiceName.Value : null, policy.HasValue ? policy.Value : null, recursive.HasValue ? recursive.Value : null, maxConcurrentConnections.HasValue ? maxConcurrentConnections.Value : (int?)null, enableLogging.HasValue ? enableLogging.Value : null, logStorageSettings.HasValue ? logStorageSettings.Value : null, dataset);
        }
    }
}
