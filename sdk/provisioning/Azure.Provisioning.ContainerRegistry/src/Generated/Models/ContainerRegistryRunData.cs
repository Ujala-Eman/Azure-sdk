// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// A class representing the ContainerRegistryRun data model.             Run
/// resource properties
/// </summary>
public partial class ContainerRegistryRunData : ProvisionableConstruct
{
    /// <summary>
    /// The unique identifier for the run.
    /// </summary>
    public BicepValue<string> RunId 
    {
        get { Initialize(); return _runId!; }
        set { Initialize(); _runId!.Assign(value); }
    }
    private BicepValue<string>? _runId;

    /// <summary>
    /// The current status of the run.
    /// </summary>
    public BicepValue<ContainerRegistryRunStatus> Status 
    {
        get { Initialize(); return _status!; }
        set { Initialize(); _status!.Assign(value); }
    }
    private BicepValue<ContainerRegistryRunStatus>? _status;

    /// <summary>
    /// The last updated time for the run.
    /// </summary>
    public BicepValue<DateTimeOffset> LastUpdatedOn 
    {
        get { Initialize(); return _lastUpdatedOn!; }
        set { Initialize(); _lastUpdatedOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _lastUpdatedOn;

    /// <summary>
    /// The type of run.
    /// </summary>
    public BicepValue<ContainerRegistryRunType> RunType 
    {
        get { Initialize(); return _runType!; }
        set { Initialize(); _runType!.Assign(value); }
    }
    private BicepValue<ContainerRegistryRunType>? _runType;

    /// <summary>
    /// The dedicated agent pool for the run.
    /// </summary>
    public BicepValue<string> AgentPoolName 
    {
        get { Initialize(); return _agentPoolName!; }
        set { Initialize(); _agentPoolName!.Assign(value); }
    }
    private BicepValue<string>? _agentPoolName;

    /// <summary>
    /// The time the run was scheduled.
    /// </summary>
    public BicepValue<DateTimeOffset> CreatedOn 
    {
        get { Initialize(); return _createdOn!; }
        set { Initialize(); _createdOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _createdOn;

    /// <summary>
    /// The time the run started.
    /// </summary>
    public BicepValue<DateTimeOffset> StartOn 
    {
        get { Initialize(); return _startOn!; }
        set { Initialize(); _startOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _startOn;

    /// <summary>
    /// The time the run finished.
    /// </summary>
    public BicepValue<DateTimeOffset> FinishOn 
    {
        get { Initialize(); return _finishOn!; }
        set { Initialize(); _finishOn!.Assign(value); }
    }
    private BicepValue<DateTimeOffset>? _finishOn;

    /// <summary>
    /// The list of all images that were generated from the run. This is
    /// applicable if the run generates base image dependencies.
    /// </summary>
    public BicepList<ContainerRegistryImageDescriptor> OutputImages 
    {
        get { Initialize(); return _outputImages!; }
        set { Initialize(); _outputImages!.Assign(value); }
    }
    private BicepList<ContainerRegistryImageDescriptor>? _outputImages;

    /// <summary>
    /// The task against which run was scheduled.
    /// </summary>
    public BicepValue<string> Task 
    {
        get { Initialize(); return _task!; }
        set { Initialize(); _task!.Assign(value); }
    }
    private BicepValue<string>? _task;

    /// <summary>
    /// The image update trigger that caused the run. This is applicable if the
    /// task has base image trigger configured.
    /// </summary>
    public ContainerRegistryImageUpdateTrigger ImageUpdateTrigger 
    {
        get { Initialize(); return _imageUpdateTrigger!; }
        set { Initialize(); AssignOrReplace(ref _imageUpdateTrigger, value); }
    }
    private ContainerRegistryImageUpdateTrigger? _imageUpdateTrigger;

    /// <summary>
    /// The source trigger that caused the run.
    /// </summary>
    public ContainerRegistrySourceTriggerDescriptor SourceTrigger 
    {
        get { Initialize(); return _sourceTrigger!; }
        set { Initialize(); AssignOrReplace(ref _sourceTrigger, value); }
    }
    private ContainerRegistrySourceTriggerDescriptor? _sourceTrigger;

    /// <summary>
    /// The timer trigger that caused the run.
    /// </summary>
    public ContainerRegistryTimerTriggerDescriptor TimerTrigger 
    {
        get { Initialize(); return _timerTrigger!; }
        set { Initialize(); AssignOrReplace(ref _timerTrigger, value); }
    }
    private ContainerRegistryTimerTriggerDescriptor? _timerTrigger;

    /// <summary>
    /// The platform properties against which the run will happen.
    /// </summary>
    public ContainerRegistryPlatformProperties Platform 
    {
        get { Initialize(); return _platform!; }
        set { Initialize(); AssignOrReplace(ref _platform, value); }
    }
    private ContainerRegistryPlatformProperties? _platform;

    /// <summary>
    /// The CPU configuration in terms of number of cores required for the run.
    /// </summary>
    public BicepValue<int> AgentCpu 
    {
        get { Initialize(); return _agentCpu!; }
        set { Initialize(); _agentCpu!.Assign(value); }
    }
    private BicepValue<int>? _agentCpu;

    /// <summary>
    /// The scope of the credentials that were used to login to the source
    /// registry during this run.
    /// </summary>
    public BicepValue<string> SourceRegistryAuth 
    {
        get { Initialize(); return _sourceRegistryAuth!; }
        set { Initialize(); _sourceRegistryAuth!.Assign(value); }
    }
    private BicepValue<string>? _sourceRegistryAuth;

    /// <summary>
    /// The list of custom registries that were logged in during this run.
    /// </summary>
    public BicepList<string> CustomRegistries 
    {
        get { Initialize(); return _customRegistries!; }
        set { Initialize(); _customRegistries!.Assign(value); }
    }
    private BicepList<string>? _customRegistries;

    /// <summary>
    /// The error message received from backend systems after the run is
    /// scheduled.
    /// </summary>
    public BicepValue<string> RunErrorMessage 
    {
        get { Initialize(); return _runErrorMessage!; }
    }
    private BicepValue<string>? _runErrorMessage;

    /// <summary>
    /// The update trigger token passed for the Run.
    /// </summary>
    public BicepValue<string> UpdateTriggerToken 
    {
        get { Initialize(); return _updateTriggerToken!; }
        set { Initialize(); _updateTriggerToken!.Assign(value); }
    }
    private BicepValue<string>? _updateTriggerToken;

    /// <summary>
    /// The image description for the log artifact.
    /// </summary>
    public ContainerRegistryImageDescriptor LogArtifact 
    {
        get { Initialize(); return _logArtifact!; }
    }
    private ContainerRegistryImageDescriptor? _logArtifact;

    /// <summary>
    /// The provisioning state of a run.
    /// </summary>
    public BicepValue<ContainerRegistryProvisioningState> ProvisioningState 
    {
        get { Initialize(); return _provisioningState!; }
        set { Initialize(); _provisioningState!.Assign(value); }
    }
    private BicepValue<ContainerRegistryProvisioningState>? _provisioningState;

    /// <summary>
    /// The value that indicates whether archiving is enabled or not.
    /// </summary>
    public BicepValue<bool> IsArchiveEnabled 
    {
        get { Initialize(); return _isArchiveEnabled!; }
        set { Initialize(); _isArchiveEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isArchiveEnabled;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new ContainerRegistryRunData.
    /// </summary>
    public ContainerRegistryRunData()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryRunData.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _runId = DefineProperty<string>("RunId", ["properties", "runId"]);
        _status = DefineProperty<ContainerRegistryRunStatus>("Status", ["properties", "status"]);
        _lastUpdatedOn = DefineProperty<DateTimeOffset>("LastUpdatedOn", ["properties", "lastUpdatedTime"]);
        _runType = DefineProperty<ContainerRegistryRunType>("RunType", ["properties", "runType"]);
        _agentPoolName = DefineProperty<string>("AgentPoolName", ["properties", "agentPoolName"]);
        _createdOn = DefineProperty<DateTimeOffset>("CreatedOn", ["properties", "createTime"]);
        _startOn = DefineProperty<DateTimeOffset>("StartOn", ["properties", "startTime"]);
        _finishOn = DefineProperty<DateTimeOffset>("FinishOn", ["properties", "finishTime"]);
        _outputImages = DefineListProperty<ContainerRegistryImageDescriptor>("OutputImages", ["properties", "outputImages"]);
        _task = DefineProperty<string>("Task", ["properties", "task"]);
        _imageUpdateTrigger = DefineModelProperty<ContainerRegistryImageUpdateTrigger>("ImageUpdateTrigger", ["properties", "imageUpdateTrigger"]);
        _sourceTrigger = DefineModelProperty<ContainerRegistrySourceTriggerDescriptor>("SourceTrigger", ["properties", "sourceTrigger"]);
        _timerTrigger = DefineModelProperty<ContainerRegistryTimerTriggerDescriptor>("TimerTrigger", ["properties", "timerTrigger"]);
        _platform = DefineModelProperty<ContainerRegistryPlatformProperties>("Platform", ["properties", "platform"]);
        _agentCpu = DefineProperty<int>("AgentCpu", ["properties", "agentConfiguration", "cpu"]);
        _sourceRegistryAuth = DefineProperty<string>("SourceRegistryAuth", ["properties", "sourceRegistryAuth"]);
        _customRegistries = DefineListProperty<string>("CustomRegistries", ["properties", "customRegistries"]);
        _runErrorMessage = DefineProperty<string>("RunErrorMessage", ["properties", "runErrorMessage"], isOutput: true);
        _updateTriggerToken = DefineProperty<string>("UpdateTriggerToken", ["properties", "updateTriggerToken"]);
        _logArtifact = DefineModelProperty<ContainerRegistryImageDescriptor>("LogArtifact", ["properties", "logArtifact"], isOutput: true);
        _provisioningState = DefineProperty<ContainerRegistryProvisioningState>("ProvisioningState", ["properties", "provisioningState"]);
        _isArchiveEnabled = DefineProperty<bool>("IsArchiveEnabled", ["properties", "isArchiveEnabled"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
