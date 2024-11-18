// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerRegistry;

/// <summary>
/// The request parameters for scheduling a run.             Please note
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryRunContent
/// is the base class. According to the scenario, a derived class of the base
/// class might need to be assigned here, or this property needs to be casted
/// to one of the possible derived classes.             The available derived
/// classes include
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryDockerBuildContent,
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryEncodedTaskRunContent,
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryFileTaskRunContent
/// and
/// Azure.ResourceManager.ContainerRegistry.Models.ContainerRegistryTaskRunContent.
/// </summary>
public partial class ContainerRegistryRunContent : ProvisionableConstruct
{
    /// <summary>
    /// The value that indicates whether archiving is enabled for the run or
    /// not.
    /// </summary>
    public BicepValue<bool> IsArchiveEnabled 
    {
        get { Initialize(); return _isArchiveEnabled!; }
        set { Initialize(); _isArchiveEnabled!.Assign(value); }
    }
    private BicepValue<bool>? _isArchiveEnabled;

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
    /// The template that describes the repository and tag information for run
    /// log artifact.
    /// </summary>
    public BicepValue<string> LogTemplate 
    {
        get { Initialize(); return _logTemplate!; }
        set { Initialize(); _logTemplate!.Assign(value); }
    }
    private BicepValue<string>? _logTemplate;

    /// <summary>
    /// Creates a new ContainerRegistryRunContent.
    /// </summary>
    public ContainerRegistryRunContent()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of ContainerRegistryRunContent.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _isArchiveEnabled = DefineProperty<bool>("IsArchiveEnabled", ["isArchiveEnabled"]);
        _agentPoolName = DefineProperty<string>("AgentPoolName", ["agentPoolName"]);
        _logTemplate = DefineProperty<string>("LogTemplate", ["logTemplate"]);
    }
}
