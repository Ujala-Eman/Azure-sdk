// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.Sql;

/// <summary>
/// WorkloadGroup.
/// </summary>
public partial class WorkloadGroup : ProvisionableResource
{
    /// <summary>
    /// The name of the workload group.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The workload group importance level.
    /// </summary>
    public BicepValue<string> Importance 
    {
        get { Initialize(); return _importance!; }
        set { Initialize(); _importance!.Assign(value); }
    }
    private BicepValue<string>? _importance;

    /// <summary>
    /// The workload group cap percentage resource.
    /// </summary>
    public BicepValue<int> MaxResourcePercent 
    {
        get { Initialize(); return _maxResourcePercent!; }
        set { Initialize(); _maxResourcePercent!.Assign(value); }
    }
    private BicepValue<int>? _maxResourcePercent;

    /// <summary>
    /// The workload group request maximum grant percentage.
    /// </summary>
    public BicepValue<double> MaxResourcePercentPerRequest 
    {
        get { Initialize(); return _maxResourcePercentPerRequest!; }
        set { Initialize(); _maxResourcePercentPerRequest!.Assign(value); }
    }
    private BicepValue<double>? _maxResourcePercentPerRequest;

    /// <summary>
    /// The workload group minimum percentage resource.
    /// </summary>
    public BicepValue<int> MinResourcePercent 
    {
        get { Initialize(); return _minResourcePercent!; }
        set { Initialize(); _minResourcePercent!.Assign(value); }
    }
    private BicepValue<int>? _minResourcePercent;

    /// <summary>
    /// The workload group request minimum grant percentage.
    /// </summary>
    public BicepValue<double> MinResourcePercentPerRequest 
    {
        get { Initialize(); return _minResourcePercentPerRequest!; }
        set { Initialize(); _minResourcePercentPerRequest!.Assign(value); }
    }
    private BicepValue<double>? _minResourcePercentPerRequest;

    /// <summary>
    /// The workload group query execution timeout.
    /// </summary>
    public BicepValue<int> QueryExecutionTimeout 
    {
        get { Initialize(); return _queryExecutionTimeout!; }
        set { Initialize(); _queryExecutionTimeout!.Assign(value); }
    }
    private BicepValue<int>? _queryExecutionTimeout;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id 
    {
        get { Initialize(); return _id!; }
    }
    private BicepValue<ResourceIdentifier>? _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<SqlDatabase>? _parent;

    /// <summary>
    /// Creates a new WorkloadGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadGroup.</param>
    public WorkloadGroup(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/workloadGroups", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WorkloadGroup.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _importance = DefineProperty<string>("Importance", ["properties", "importance"]);
        _maxResourcePercent = DefineProperty<int>("MaxResourcePercent", ["properties", "maxResourcePercent"]);
        _maxResourcePercentPerRequest = DefineProperty<double>("MaxResourcePercentPerRequest", ["properties", "maxResourcePercentPerRequest"]);
        _minResourcePercent = DefineProperty<int>("MinResourcePercent", ["properties", "minResourcePercent"]);
        _minResourcePercentPerRequest = DefineProperty<double>("MinResourcePercentPerRequest", ["properties", "minResourcePercentPerRequest"]);
        _queryExecutionTimeout = DefineProperty<int>("QueryExecutionTimeout", ["properties", "queryExecutionTimeout"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<SqlDatabase>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WorkloadGroup resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing WorkloadGroup.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadGroup resource.  This can
    /// be used to refer to the resource in expressions, but is not the Azure
    /// name of the resource.  This value can contain letters, numbers, and
    /// underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadGroup.</param>
    /// <returns>The existing WorkloadGroup resource.</returns>
    public static WorkloadGroup FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
