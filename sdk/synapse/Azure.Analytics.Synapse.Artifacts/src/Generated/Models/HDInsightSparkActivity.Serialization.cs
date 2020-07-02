// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    public partial class HDInsightSparkActivity : IUtf8JsonSerializable
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
            writer.WritePropertyName("rootPath");
            writer.WriteObjectValue(RootPath);
            writer.WritePropertyName("entryFilePath");
            writer.WriteObjectValue(EntryFilePath);
            if (Optional.IsDefined(Arguments))
            {
                writer.WritePropertyName("arguments");
                writer.WriteStartArray();
                foreach (var item in Arguments)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(GetDebugInfo))
            {
                writer.WritePropertyName("getDebugInfo");
                writer.WriteStringValue(GetDebugInfo.Value.ToString());
            }
            if (Optional.IsDefined(SparkJobLinkedService))
            {
                writer.WritePropertyName("sparkJobLinkedService");
                writer.WriteObjectValue(SparkJobLinkedService);
            }
            if (Optional.IsDefined(ClassName))
            {
                writer.WritePropertyName("className");
                writer.WriteStringValue(ClassName);
            }
            if (Optional.IsDefined(ProxyUser))
            {
                writer.WritePropertyName("proxyUser");
                writer.WriteObjectValue(ProxyUser);
            }
            if (Optional.IsDefined(SparkConfig))
            {
                writer.WritePropertyName("sparkConfig");
                writer.WriteStartObject();
                foreach (var item in SparkConfig)
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

        internal static HDInsightSparkActivity DeserializeHDInsightSparkActivity(JsonElement element)
        {
            Optional<LinkedServiceReference> linkedServiceName = default;
            Optional<ActivityPolicy> policy = default;
            string name = default;
            string type = default;
            Optional<string> description = default;
            Optional<IList<ActivityDependency>> dependsOn = default;
            Optional<IList<UserProperty>> userProperties = default;
            object rootPath = default;
            object entryFilePath = default;
            Optional<IList<object>> arguments = default;
            Optional<HDInsightActivityDebugInfoOption> getDebugInfo = default;
            Optional<LinkedServiceReference> sparkJobLinkedService = default;
            Optional<string> className = default;
            Optional<object> proxyUser = default;
            Optional<IDictionary<string, object>> sparkConfig = default;
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
                        if (property0.NameEquals("rootPath"))
                        {
                            rootPath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("entryFilePath"))
                        {
                            entryFilePath = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("arguments"))
                        {
                            List<object> array = new List<object>();
                            foreach (var item in property0.Value.EnumerateArray())
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
                            arguments = array;
                            continue;
                        }
                        if (property0.NameEquals("getDebugInfo"))
                        {
                            getDebugInfo = new HDInsightActivityDebugInfoOption(property0.Value.GetString());
                            continue;
                        }
                        if (property0.NameEquals("sparkJobLinkedService"))
                        {
                            sparkJobLinkedService = LinkedServiceReference.DeserializeLinkedServiceReference(property0.Value);
                            continue;
                        }
                        if (property0.NameEquals("className"))
                        {
                            className = property0.Value.GetString();
                            continue;
                        }
                        if (property0.NameEquals("proxyUser"))
                        {
                            proxyUser = property0.Value.GetObject();
                            continue;
                        }
                        if (property0.NameEquals("sparkConfig"))
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
                            sparkConfig = dictionary;
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
            return new HDInsightSparkActivity(name, type, description.HasValue ? description.Value : null, new ChangeTrackingList<ActivityDependency>(dependsOn), new ChangeTrackingList<UserProperty>(userProperties), additionalProperties, linkedServiceName.HasValue ? linkedServiceName.Value : null, policy.HasValue ? policy.Value : null, rootPath, entryFilePath, new ChangeTrackingList<object>(arguments), getDebugInfo.HasValue ? getDebugInfo.Value : (HDInsightActivityDebugInfoOption?)null, sparkJobLinkedService.HasValue ? sparkJobLinkedService.Value : null, className.HasValue ? className.Value : null, proxyUser.HasValue ? proxyUser.Value : null, new ChangeTrackingDictionary<string, object>(sparkConfig));
        }
    }
}
