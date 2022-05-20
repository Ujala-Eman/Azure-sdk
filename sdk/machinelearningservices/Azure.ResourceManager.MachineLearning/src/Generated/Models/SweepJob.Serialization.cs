// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    public partial class SweepJob : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            if (Optional.IsDefined(EarlyTermination))
            {
                if (EarlyTermination != null)
                {
                    writer.WritePropertyName("earlyTermination");
                    writer.WriteObjectValue(EarlyTermination);
                }
                else
                {
                    writer.WriteNull("earlyTermination");
                }
            }
            if (Optional.IsCollectionDefined(Inputs))
            {
                if (Inputs != null)
                {
                    writer.WritePropertyName("inputs");
                    writer.WriteStartObject();
                    foreach (var item in Inputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("inputs");
                }
            }
            if (Optional.IsDefined(Limits))
            {
                if (Limits != null)
                {
                    writer.WritePropertyName("limits");
                    writer.WriteObjectValue(Limits);
                }
                else
                {
                    writer.WriteNull("limits");
                }
            }
            writer.WritePropertyName("objective");
            writer.WriteObjectValue(Objective);
            if (Optional.IsCollectionDefined(Outputs))
            {
                if (Outputs != null)
                {
                    writer.WritePropertyName("outputs");
                    writer.WriteStartObject();
                    foreach (var item in Outputs)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("outputs");
                }
            }
            writer.WritePropertyName("samplingAlgorithm");
            writer.WriteObjectValue(SamplingAlgorithm);
            writer.WritePropertyName("searchSpace");
#if NET6_0_OR_GREATER
				writer.WriteRawValue(SearchSpace);
#else
            JsonSerializer.Serialize(writer, JsonDocument.Parse(SearchSpace.ToString()).RootElement);
#endif
            writer.WritePropertyName("trial");
            writer.WriteObjectValue(Trial);
            if (Optional.IsDefined(ComputeId))
            {
                if (ComputeId != null)
                {
                    writer.WritePropertyName("computeId");
                    writer.WriteStringValue(ComputeId);
                }
                else
                {
                    writer.WriteNull("computeId");
                }
            }
            if (Optional.IsDefined(DisplayName))
            {
                if (DisplayName != null)
                {
                    writer.WritePropertyName("displayName");
                    writer.WriteStringValue(DisplayName);
                }
                else
                {
                    writer.WriteNull("displayName");
                }
            }
            if (Optional.IsDefined(ExperimentName))
            {
                if (ExperimentName != null)
                {
                    writer.WritePropertyName("experimentName");
                    writer.WriteStringValue(ExperimentName);
                }
                else
                {
                    writer.WriteNull("experimentName");
                }
            }
            if (Optional.IsDefined(Identity))
            {
                if (Identity != null)
                {
                    writer.WritePropertyName("identity");
                    writer.WriteObjectValue(Identity);
                }
                else
                {
                    writer.WriteNull("identity");
                }
            }
            if (Optional.IsDefined(IsArchived))
            {
                writer.WritePropertyName("isArchived");
                writer.WriteBooleanValue(IsArchived.Value);
            }
            writer.WritePropertyName("jobType");
            writer.WriteStringValue(JobType.ToString());
            if (Optional.IsDefined(Schedule))
            {
                if (Schedule != null)
                {
                    writer.WritePropertyName("schedule");
                    writer.WriteObjectValue(Schedule);
                }
                else
                {
                    writer.WriteNull("schedule");
                }
            }
            if (Optional.IsCollectionDefined(Services))
            {
                if (Services != null)
                {
                    writer.WritePropertyName("services");
                    writer.WriteStartObject();
                    foreach (var item in Services)
                    {
                        writer.WritePropertyName(item.Key);
                        writer.WriteObjectValue(item.Value);
                    }
                    writer.WriteEndObject();
                }
                else
                {
                    writer.WriteNull("services");
                }
            }
            if (Optional.IsDefined(Description))
            {
                if (Description != null)
                {
                    writer.WritePropertyName("description");
                    writer.WriteStringValue(Description);
                }
                else
                {
                    writer.WriteNull("description");
                }
            }
            if (Optional.IsCollectionDefined(Properties))
            {
                if (Properties != null)
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
                else
                {
                    writer.WriteNull("properties");
                }
            }
            if (Optional.IsCollectionDefined(Tags))
            {
                if (Tags != null)
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
                else
                {
                    writer.WriteNull("tags");
                }
            }
            writer.WriteEndObject();
        }

        internal static SweepJob DeserializeSweepJob(JsonElement element)
        {
            Optional<EarlyTerminationPolicy> earlyTermination = default;
            Optional<IDictionary<string, JobInput>> inputs = default;
            Optional<SweepJobLimits> limits = default;
            Objective objective = default;
            Optional<IDictionary<string, JobOutput>> outputs = default;
            SamplingAlgorithm samplingAlgorithm = default;
            BinaryData searchSpace = default;
            TrialComponent trial = default;
            Optional<string> computeId = default;
            Optional<string> displayName = default;
            Optional<string> experimentName = default;
            Optional<IdentityConfiguration> identity = default;
            Optional<bool> isArchived = default;
            JobType jobType = default;
            Optional<ScheduleBase> schedule = default;
            Optional<IDictionary<string, JobService>> services = default;
            Optional<JobStatus> status = default;
            Optional<string> description = default;
            Optional<IDictionary<string, string>> properties = default;
            Optional<IDictionary<string, string>> tags = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("earlyTermination"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        earlyTermination = null;
                        continue;
                    }
                    earlyTermination = EarlyTerminationPolicy.DeserializeEarlyTerminationPolicy(property.Value);
                    continue;
                }
                if (property.NameEquals("inputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        inputs = null;
                        continue;
                    }
                    Dictionary<string, JobInput> dictionary = new Dictionary<string, JobInput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, JobInput.DeserializeJobInput(property0.Value));
                        }
                    }
                    inputs = dictionary;
                    continue;
                }
                if (property.NameEquals("limits"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        limits = null;
                        continue;
                    }
                    limits = SweepJobLimits.DeserializeSweepJobLimits(property.Value);
                    continue;
                }
                if (property.NameEquals("objective"))
                {
                    objective = Objective.DeserializeObjective(property.Value);
                    continue;
                }
                if (property.NameEquals("outputs"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        outputs = null;
                        continue;
                    }
                    Dictionary<string, JobOutput> dictionary = new Dictionary<string, JobOutput>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, JobOutput.DeserializeJobOutput(property0.Value));
                        }
                    }
                    outputs = dictionary;
                    continue;
                }
                if (property.NameEquals("samplingAlgorithm"))
                {
                    samplingAlgorithm = SamplingAlgorithm.DeserializeSamplingAlgorithm(property.Value);
                    continue;
                }
                if (property.NameEquals("searchSpace"))
                {
                    searchSpace = BinaryData.FromString(property.Value.GetRawText());
                    continue;
                }
                if (property.NameEquals("trial"))
                {
                    trial = TrialComponent.DeserializeTrialComponent(property.Value);
                    continue;
                }
                if (property.NameEquals("computeId"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        computeId = null;
                        continue;
                    }
                    computeId = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("displayName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        displayName = null;
                        continue;
                    }
                    displayName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("experimentName"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        experimentName = null;
                        continue;
                    }
                    experimentName = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("identity"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        identity = null;
                        continue;
                    }
                    identity = IdentityConfiguration.DeserializeIdentityConfiguration(property.Value);
                    continue;
                }
                if (property.NameEquals("isArchived"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    isArchived = property.Value.GetBoolean();
                    continue;
                }
                if (property.NameEquals("jobType"))
                {
                    jobType = new JobType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("schedule"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        schedule = null;
                        continue;
                    }
                    schedule = ScheduleBase.DeserializeScheduleBase(property.Value);
                    continue;
                }
                if (property.NameEquals("services"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        services = null;
                        continue;
                    }
                    Dictionary<string, JobService> dictionary = new Dictionary<string, JobService>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, JobService.DeserializeJobService(property0.Value));
                        }
                    }
                    services = dictionary;
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
                if (property.NameEquals("description"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        description = null;
                        continue;
                    }
                    description = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("properties"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        properties = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    properties = dictionary;
                    continue;
                }
                if (property.NameEquals("tags"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        tags = null;
                        continue;
                    }
                    Dictionary<string, string> dictionary = new Dictionary<string, string>();
                    foreach (var property0 in property.Value.EnumerateObject())
                    {
                        if (property0.Value.ValueKind == JsonValueKind.Null)
                        {
                            dictionary.Add(property0.Name, null);
                        }
                        else
                        {
                            dictionary.Add(property0.Name, property0.Value.GetString());
                        }
                    }
                    tags = dictionary;
                    continue;
                }
            }
            return new SweepJob(description.Value, Optional.ToDictionary(properties), Optional.ToDictionary(tags), computeId.Value, displayName.Value, experimentName.Value, identity.Value, Optional.ToNullable(isArchived), jobType, schedule.Value, Optional.ToDictionary(services), Optional.ToNullable(status), earlyTermination.Value, Optional.ToDictionary(inputs), limits.Value, objective, Optional.ToDictionary(outputs), samplingAlgorithm, searchSpace, trial);
        }
    }
}
