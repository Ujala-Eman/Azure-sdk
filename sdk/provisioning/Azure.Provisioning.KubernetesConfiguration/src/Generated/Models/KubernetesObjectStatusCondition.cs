// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.KubernetesConfiguration;

/// <summary>
/// Status condition of Kubernetes object.
/// </summary>
public partial class KubernetesObjectStatusCondition : ProvisionableConstruct
{
    /// <summary>
    /// Last time this status condition has changed.
    /// </summary>
    public BicepValue<DateTimeOffset> LastTransitionOn 
    {
        get { Initialize(); return _lastTransitionOn!; }
    }
    private BicepValue<DateTimeOffset>? _lastTransitionOn;

    /// <summary>
    /// A more verbose description of the object status condition.
    /// </summary>
    public BicepValue<string> Message 
    {
        get { Initialize(); return _message!; }
    }
    private BicepValue<string>? _message;

    /// <summary>
    /// Reason for the specified status condition type status.
    /// </summary>
    public BicepValue<string> Reason 
    {
        get { Initialize(); return _reason!; }
    }
    private BicepValue<string>? _reason;

    /// <summary>
    /// Status of the Kubernetes object condition type.
    /// </summary>
    public BicepValue<string> Status 
    {
        get { Initialize(); return _status!; }
    }
    private BicepValue<string>? _status;

    /// <summary>
    /// Object status condition type for this object.
    /// </summary>
    public BicepValue<string> ObjectStatusConditionDefinitionType 
    {
        get { Initialize(); return _objectStatusConditionDefinitionType!; }
    }
    private BicepValue<string>? _objectStatusConditionDefinitionType;

    /// <summary>
    /// Creates a new KubernetesObjectStatusCondition.
    /// </summary>
    public KubernetesObjectStatusCondition()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// KubernetesObjectStatusCondition.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _lastTransitionOn = DefineProperty<DateTimeOffset>("LastTransitionOn", ["lastTransitionTime"], isOutput: true);
        _message = DefineProperty<string>("Message", ["message"], isOutput: true);
        _reason = DefineProperty<string>("Reason", ["reason"], isOutput: true);
        _status = DefineProperty<string>("Status", ["status"], isOutput: true);
        _objectStatusConditionDefinitionType = DefineProperty<string>("ObjectStatusConditionDefinitionType", ["type"], isOutput: true);
    }
}
