// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class HDInsightPigActivity : IUtf8JsonSerializable
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
            if (Optional.IsDefined(StorageLinkedServices))
            {
                writer.WritePropertyName("storageLinkedServices");
                writer.WriteStartArray();
                foreach (var item in StorageLinkedServices)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteObjectValue(Arguments);
            }
            if (Optional.IsDefined(GetDebugInfo))
            {
                writer.WritePropertyName("getDebugInfo");
                writer.WriteStringValue(GetDebugInfo.Value.ToString());
            }
            if (Optional.IsDefined(ScriptPath))
            {
                writer.WritePropertyName("scriptPath");
                writer.WriteObjectValue(ScriptPath);
            }
            if (Optional.IsDefined(ScriptLinkedService))
            {
                writer.WritePropertyName("scriptLinkedService");
                writer.WriteObjectValue(ScriptLinkedService);
            }
            if (Optional.IsDefined(Defines))
            {
                writer.WritePropertyName("defines");
                writer.WriteStartObject();
                foreach (var item in Defines)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            writer.WriteEndObject();
            foreach (var item in AdditionalProperties)
            {
                writer.WritePropertyName(item.Key);
                writer.WriteObjectValue(item.Value);
            }
            writer.WriteEndObject();
        }

        internal static HDInsightPigActivity DeserializeHDInsightPigActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            Optional<IList<LinkedServiceReference>> storageLinkedServices = default;
            Optional<object> arguments = default;
            Optional<HDInsightActivityDebugInfoOption> getDebugInfo = default;
            Optional<object> scriptPath = default;
            Optional<LinkedServiceReference> scriptLinkedService = default;
            Optional<IDictionary<string, object>> defines = default;
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
                        if (property0.NameEquals("storageLinkedServices"))
                        {
                            List<LinkedServiceReference> array = new List<LinkedServiceReference>();
                            foreach (var item in property0.Value.EnumerateArray())
                            {
                                if (item.ValueKind == JsonValueKind.Null)
                                {
                                    array.Add(null);
                                }
                                else
                                {
                                    array.Add(LinkedServiceReference.DeserializeLinkedServiceReference(item));
                                }
                            }
                            storageLinkedServices = array;
                            continue;
                        }
                        if (property0.NameEquals("arguments"))
                        {
                            arguments = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("getDebugInfo"))
                        {
                            getDebugInfo = new HDInsightActivityDebugInfoOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("scriptPath"))
                        {
                            scriptPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("scriptLinkedService"))
                        {
                            scriptLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("defines"))
                        {
                            Dictionary<string, object> dictionary = new Dictionary<string, object>();
                            foreach (var property1 in property0.Value.EnumerateObject())
                            {
                                if (property1.Value.ValueKind == JsonValueKind.Null)
                                {
                                    dictionary.Add(property1.Name, null);
                                }
                                else
                                {
                                    dictionary.Add(property1.Name, property1.Value.GetObject());
                                }
                            }
                            defines = dictionary;
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
            return new HDInsightPigActivity(name, type, description.HasValue ? description.Value : null, new ChangeTrackingList<ActivityDependency>(dependsOn), new ChangeTrackingList<UserProperty>(userProperties), additionalProperties, linkedServiceName.HasValue ? linkedServiceName.Value : null, policy.HasValue ? policy.Value : null, new ChangeTrackingList<LinkedServiceReference>(storageLinkedServices), arguments.HasValue ? arguments.Value : null, getDebugInfo.HasValue ? getDebugInfo.Value : (HDInsightActivityDebugInfoOption?)null, scriptPath.HasValue ? scriptPath.Value : null, scriptLinkedService.HasValue ? scriptLinkedService.Value : null, new ChangeTrackingDictionary<string, object>(defines));
        }
    }
}
