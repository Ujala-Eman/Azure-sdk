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
/// WorkloadClassifier.
/// </summary>
public partial class WorkloadClassifier : ProvisionableResource
{
    /// <summary>
    /// The name of the workload classifier to create/update.
    /// </summary>
    public BicepValue<string> Name 
    {
        get { Initialize(); return _name!; }
        set { Initialize(); _name!.Assign(value); }
    }
    private BicepValue<string>? _name;

    /// <summary>
    /// The workload classifier context.
    /// </summary>
    public BicepValue<string> Context 
    {
        get { Initialize(); return _context!; }
        set { Initialize(); _context!.Assign(value); }
    }
    private BicepValue<string>? _context;

    /// <summary>
    /// The workload classifier end time for classification.
    /// </summary>
    public BicepValue<string> EndTime 
    {
        get { Initialize(); return _endTime!; }
        set { Initialize(); _endTime!.Assign(value); }
    }
    private BicepValue<string>? _endTime;

    /// <summary>
    /// The workload classifier importance.
    /// </summary>
    public BicepValue<string> Importance 
    {
        get { Initialize(); return _importance!; }
        set { Initialize(); _importance!.Assign(value); }
    }
    private BicepValue<string>? _importance;

    /// <summary>
    /// The workload classifier label.
    /// </summary>
    public BicepValue<string> Label 
    {
        get { Initialize(); return _label!; }
        set { Initialize(); _label!.Assign(value); }
    }
    private BicepValue<string>? _label;

    /// <summary>
    /// The workload classifier member name.
    /// </summary>
    public BicepValue<string> MemberName 
    {
        get { Initialize(); return _memberName!; }
        set { Initialize(); _memberName!.Assign(value); }
    }
    private BicepValue<string>? _memberName;

    /// <summary>
    /// The workload classifier start time for classification.
    /// </summary>
    public BicepValue<string> StartTime 
    {
        get { Initialize(); return _startTime!; }
        set { Initialize(); _startTime!.Assign(value); }
    }
    private BicepValue<string>? _startTime;

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
    /// Gets or sets a reference to the parent WorkloadGroup.
    /// </summary>
    public WorkloadGroup? Parent
    {
        get { Initialize(); return _parent!.Value; }
        set { Initialize(); _parent!.Value = value; }
    }
    private ResourceReference<WorkloadGroup>? _parent;

    /// <summary>
    /// Creates a new WorkloadClassifier.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadClassifier resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadClassifier.</param>
    public WorkloadClassifier(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/workloadGroups/workloadClassifiers", resourceVersion ?? "2021-11-01")
    {
    }

    /// <summary>
    /// Define all the provisionable properties of WorkloadClassifier.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        _name = DefineProperty<string>("Name", ["name"], isRequired: true);
        _context = DefineProperty<string>("Context", ["properties", "context"]);
        _endTime = DefineProperty<string>("EndTime", ["properties", "endTime"]);
        _importance = DefineProperty<string>("Importance", ["properties", "importance"]);
        _label = DefineProperty<string>("Label", ["properties", "label"]);
        _memberName = DefineProperty<string>("MemberName", ["properties", "memberName"]);
        _startTime = DefineProperty<string>("StartTime", ["properties", "startTime"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
        _parent = DefineResource<WorkloadGroup>("Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported WorkloadClassifier resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing WorkloadClassifier.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the WorkloadClassifier resource.  This
    /// can be used to refer to the resource in expressions, but is not the
    /// Azure name of the resource.  This value can contain letters, numbers,
    /// and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the WorkloadClassifier.</param>
    /// <returns>The existing WorkloadClassifier resource.</returns>
    public static WorkloadClassifier FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
