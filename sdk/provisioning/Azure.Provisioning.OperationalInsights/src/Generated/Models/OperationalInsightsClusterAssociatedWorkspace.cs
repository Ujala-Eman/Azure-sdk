// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.OperationalInsights;

/// <summary>
/// The list of Log Analytics workspaces associated with the cluster.
/// </summary>
public partial class OperationalInsightsClusterAssociatedWorkspace : ProvisionableConstruct
{
    /// <summary>
    /// The id of the assigned workspace.
    /// </summary>
    public BicepValue<Guid> WorkspaceId 
    {
        get { Initialize(); return _workspaceId!; }
    }
    private BicepValue<Guid>? _workspaceId;

    /// <summary>
    /// The name id the assigned workspace.
    /// </summary>
    public BicepValue<string> WorkspaceName 
    {
        get { Initialize(); return _workspaceName!; }
    }
    private BicepValue<string>? _workspaceName;

    /// <summary>
    /// The ResourceId id the assigned workspace.
    /// </summary>
    public BicepValue<ResourceIdentifier> ResourceId 
    {
        get { Initialize(); return _resourceId!; }
    }
    private BicepValue<ResourceIdentifier>? _resourceId;

    /// <summary>
    /// The time of workspace association.
    /// </summary>
    public BicepValue<DateTimeOffset> AssociatedOn 
    {
        get { Initialize(); return _associatedOn!; }
    }
    private BicepValue<DateTimeOffset>? _associatedOn;

    /// <summary>
    /// Creates a new OperationalInsightsClusterAssociatedWorkspace.
    /// </summary>
    public OperationalInsightsClusterAssociatedWorkspace()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// OperationalInsightsClusterAssociatedWorkspace.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _workspaceId = DefineProperty<Guid>("WorkspaceId", ["workspaceId"], isOutput: true);
        _workspaceName = DefineProperty<string>("WorkspaceName", ["workspaceName"], isOutput: true);
        _resourceId = DefineProperty<ResourceIdentifier>("ResourceId", ["resourceId"], isOutput: true);
        _associatedOn = DefineProperty<DateTimeOffset>("AssociatedOn", ["associateDate"], isOutput: true);
    }
}
