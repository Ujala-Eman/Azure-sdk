// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    public partial class CommandJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(CodeId))
            {
                writer.WritePropertyName("codeId");
                writer.WriteStringValue(CodeId);
            }
            writer.WritePropertyName("command");
            writer.WriteStringValue(Command);
            writer.WritePropertyName("compute");
            writer.WriteObjectValue(Compute);
            if (Optional.IsDefined(Distribution))
            {
                writer.WritePropertyName("distribution");
                writer.WriteObjectValue(Distribution);
            }
            if (Optional.IsDefined(EnvironmentId))
            {
                writer.WritePropertyName("environmentId");
                writer.WriteStringValue(EnvironmentId);
            }
            if (Optional.IsCollectionDefined(EnvironmentVariables))
            {
                writer.WritePropertyName("environmentVariables");
                writer.WriteStartObject();
                foreach (var item in EnvironmentVariables)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(ExperimentName))
            {
                writer.WritePropertyName("experimentName");
                writer.WriteStringValue(ExperimentName);
            }
            if (Optional.IsDefined(Identity))
            {
                writer.WritePropertyName("identity");
                writer.WriteObjectValue(Identity);
            }
            if (Optional.IsCollectionDefined(InputDataBindings))
            {
                writer.WritePropertyName("inputDataBindings");
                writer.WriteStartObject();
                foreach (var item in InputDataBindings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsCollectionDefined(OutputDataBindings))
            {
                writer.WritePropertyName("outputDataBindings");
                writer.WriteStartObject();
                foreach (var item in OutputDataBindings)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteObjectValue(item.Value);
                }
                writer.WriteEndObject();
            }
            if (Optional.IsDefined(Priority))
            {
                writer.WritePropertyName("priority");
                writer.WriteNumberValue(Priority.Value);
            }
            if (Optional.IsDefined(Timeout))
            {
                writer.WritePropertyName("timeout");
                writer.WriteStringValue(Timeout.Value, "P");
            }
            if (Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description");
                writer.WriteStringValue(Description);
            }
            writer.WritePropertyName("jobType");
            writer.WriteStringValue(JobType.ToString());
            if (Optional.IsCollectionDefined(Properties))
            {
                writer.WritePropertyName("properties");
                writer.WriteStartObject();
                foreach (var item in Properties)
                {
                    writer.WritePropertyName(item.Key);
                    writer.WriteStringValue(item.Value);
                }
                writer.WriteEndObject();
            }
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
            writer.WriteEndObject();
        }

        internal static CommandJob DeserializeCommandJob(JsonElement element)
        {
            Optional<string> codeId = default;
            string command = default;
            ComputeConfiguration compute = default;
            Optional<DistributionConfiguration> distribution = default;
            Optional<string> environmentId = default;
            Optional<IDictionary<string, string>> environmentVariables = default;
            Optional<string> experimentName = default;
            Optional<IdentityConfiguration> identity = default;
            Optional<IDictionary<string, InputDataBinding>> inputDataBindings = default;
            Optional<JobOutput> output = default;
            Optional<IDictionary<string, OutputDataBinding>> outputDataBindings = default;
            Optional<IReadOnlyDictionary<string, object>> parameters = default;
            Optional<int> priority = default;
            Optional<JobStatus> status = default;
            Optional<TimeSpan> timeout = default;
            Optional<string> description = default;
            Optional<IReadOnlyDictionary<string, JobEndpoint>> interactionEndpoints = default;
            JobType jobType = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<JobProvisioningState> provisioningState = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("codeId"))
                {
                    codeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("command"))
                {
                    command = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("compute"))
                {
                    compute = ComputeConfiguration.DeserializeComputeConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("distribution"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    distribution = DistributionConfiguration.DeserializeDistributionConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("environmentId"))
                {
                    environmentId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("environmentVariables"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    environmentVariables = dictionary;
                    continue;
                }
                if (property.NameEquals("experimentName"))
                {
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    identity = IdentityConfiguration.DeserializeIdentityConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("inputDataBindings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, InputDataBinding> dictionary = new Dictionary<string, InputDataBinding>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, InputDataBinding.DeserializeInputDataBinding(property0.Value));
                    }
                    inputDataBindings = dictionary;
                    continue;
                }
                if (property.NameEquals("output"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    output = JobOutput.DeserializeJobOutput(property.Value);
                    continue;
                }
                if (property.NameEquals("outputDataBindings"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, OutputDataBinding> dictionary = new Dictionary<string, OutputDataBinding>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, OutputDataBinding.DeserializeOutputDataBinding(property0.Value));
                    }
                    outputDataBindings = dictionary;
                    continue;
                }
                if (property.NameEquals("parameters"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, object> dictionary = new Dictionary<string, object>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetObject());
                    }
                    parameters = dictionary;
                    continue;
                }
                if (property.NameEquals("priority"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    priority = property.Value.GetInt32();
                    continue;
                }
                if (property.NameEquals("status"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    status = new JobStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("timeout"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    timeout = property.Value.GetTimeSpan("P");
                    continue;
                }
                if (property.NameEquals("description"))
                {
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("interactionEndpoints"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, JobEndpoint> dictionary = new Dictionary<string, JobEndpoint>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, JobEndpoint.DeserializeJobEndpoint(property0.Value));
                    }
                    interactionEndpoints = dictionary;
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("provisioningState"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    provisioningState = new JobProvisioningState(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        dictionary.Add(property0.Name, property0.Value.GetString());
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new CommandJob(description.Value, Optional.ToDictionary(interactionEndpoints), jobType, Optional.ToDictionary(properties), Optional.ToNullable(provisioningState), Optional.ToDictionary(tags), codeId.Value, command, compute, distribution.Value, environmentId.Value, Optional.ToDictionary(environmentVariables), experimentName.Value, identity.Value, Optional.ToDictionary(inputDataBindings), output.Value, Optional.ToDictionary(outputDataBindings), Optional.ToDictionary(parameters), Optional.ToNullable(priority), Optional.ToNullable(status), Optional.ToNullable(timeout));
        }
    }
}
