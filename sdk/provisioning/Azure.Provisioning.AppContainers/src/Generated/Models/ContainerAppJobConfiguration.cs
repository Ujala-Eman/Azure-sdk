// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Non versioned Container Apps Job configuration properties.
/// </summary>
public partial class ContainerAppJobConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Collection of secrets used by a Container Apps Job.
    /// </summary>
    public BicepList<ContainerAppWritableSecret> Secrets { get => _secrets; set => _secrets.Assign(value); }
    private readonly BicepList<ContainerAppWritableSecret> _secrets;

    /// <summary>
    /// Trigger type of the job.
    /// </summary>
    public BicepValue<ContainerAppJobTriggerType> TriggerType { get => _triggerType; set => _triggerType.Assign(value); }
    private readonly BicepValue<ContainerAppJobTriggerType> _triggerType;

    /// <summary>
    /// Maximum number of seconds a replica is allowed to run.
    /// </summary>
    public BicepValue<int> ReplicaTimeout { get => _replicaTimeout; set => _replicaTimeout.Assign(value); }
    private readonly BicepValue<int> _replicaTimeout;

    /// <summary>
    /// Maximum number of retries before failing the job.
    /// </summary>
    public BicepValue<int> ReplicaRetryLimit { get => _replicaRetryLimit; set => _replicaRetryLimit.Assign(value); }
    private readonly BicepValue<int> _replicaRetryLimit;

    /// <summary>
    /// Manual trigger configuration for a single execution job. Properties
    /// replicaCompletionCount and parallelism would be set to 1 by default.
    /// </summary>
    public BicepValue<JobConfigurationManualTriggerConfig> ManualTriggerConfig { get => _manualTriggerConfig; set => _manualTriggerConfig.Assign(value); }
    private readonly BicepValue<JobConfigurationManualTriggerConfig> _manualTriggerConfig;

    /// <summary>
    /// Cron formatted repeating trigger schedule (&quot;* * * * *&quot;) for
    /// cronjobs. Properties completions and parallelism would be set to 1 by
    /// default.
    /// </summary>
    public BicepValue<JobConfigurationScheduleTriggerConfig> ScheduleTriggerConfig { get => _scheduleTriggerConfig; set => _scheduleTriggerConfig.Assign(value); }
    private readonly BicepValue<JobConfigurationScheduleTriggerConfig> _scheduleTriggerConfig;

    /// <summary>
    /// Trigger configuration of an event driven job.
    /// </summary>
    public BicepValue<EventTriggerConfiguration> EventTriggerConfig { get => _eventTriggerConfig; set => _eventTriggerConfig.Assign(value); }
    private readonly BicepValue<EventTriggerConfiguration> _eventTriggerConfig;

    /// <summary>
    /// Collection of private container registry credentials used by a
    /// Container apps job.
    /// </summary>
    public BicepList<ContainerAppRegistryCredentials> Registries { get => _registries; set => _registries.Assign(value); }
    private readonly BicepList<ContainerAppRegistryCredentials> _registries;

    /// <summary>
    /// Creates a new ContainerAppJobConfiguration.
    /// </summary>
    public ContainerAppJobConfiguration()
    {
        _secrets = BicepList<ContainerAppWritableSecret>.DefineProperty(this, "Secrets", ["secrets"]);
        _triggerType = BicepValue<ContainerAppJobTriggerType>.DefineProperty(this, "TriggerType", ["triggerType"]);
        _replicaTimeout = BicepValue<int>.DefineProperty(this, "ReplicaTimeout", ["replicaTimeout"]);
        _replicaRetryLimit = BicepValue<int>.DefineProperty(this, "ReplicaRetryLimit", ["replicaRetryLimit"]);
        _manualTriggerConfig = BicepValue<JobConfigurationManualTriggerConfig>.DefineProperty(this, "ManualTriggerConfig", ["manualTriggerConfig"]);
        _scheduleTriggerConfig = BicepValue<JobConfigurationScheduleTriggerConfig>.DefineProperty(this, "ScheduleTriggerConfig", ["scheduleTriggerConfig"]);
        _eventTriggerConfig = BicepValue<EventTriggerConfiguration>.DefineProperty(this, "EventTriggerConfig", ["eventTriggerConfig"]);
        _registries = BicepList<ContainerAppRegistryCredentials>.DefineProperty(this, "Registries", ["registries"]);
    }
}
