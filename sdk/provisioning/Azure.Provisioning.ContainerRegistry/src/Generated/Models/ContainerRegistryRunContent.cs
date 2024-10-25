// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

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
    public BicepValue<bool> IsArchiveEnabled { get => _isArchiveEnabled; set => _isArchiveEnabled.Assign(value); }
    private readonly BicepValue<bool> _isArchiveEnabled;

    /// <summary>
    /// The dedicated agent pool for the run.
    /// </summary>
    public BicepValue<string> AgentPoolName { get => _agentPoolName; set => _agentPoolName.Assign(value); }
    private readonly BicepValue<string> _agentPoolName;

    /// <summary>
    /// The template that describes the repository and tag information for run
    /// log artifact.
    /// </summary>
    public BicepValue<string> LogTemplate { get => _logTemplate; set => _logTemplate.Assign(value); }
    private readonly BicepValue<string> _logTemplate;

    /// <summary>
    /// Creates a new ContainerRegistryRunContent.
    /// </summary>
    public ContainerRegistryRunContent()
    {
        _isArchiveEnabled = BicepValue<bool>.DefineProperty(this, "IsArchiveEnabled", ["isArchiveEnabled"]);
        _agentPoolName = BicepValue<string>.DefineProperty(this, "AgentPoolName", ["agentPoolName"]);
        _logTemplate = BicepValue<string>.DefineProperty(this, "LogTemplate", ["logTemplate"]);
    }
}
