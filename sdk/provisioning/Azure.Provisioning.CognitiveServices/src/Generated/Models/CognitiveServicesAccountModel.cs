// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.CognitiveServices;

/// <summary>
/// Cognitive Services account Model.
/// </summary>
public partial class CognitiveServicesAccountModel : CognitiveServicesAccountDeploymentModel
{
    /// <summary>
    /// Base Model Identifier.
    /// </summary>
    public CognitiveServicesAccountDeploymentModel BaseModel 
    {
        get { Initialize(); return _baseModel!; }
        set { Initialize(); AssignOrReplace(ref _baseModel, value); }
    }
    private CognitiveServicesAccountDeploymentModel? _baseModel;

    /// <summary>
    /// If the model is default version.
    /// </summary>
    public BicepValue<bool> IsDefaultVersion 
    {
        get { Initialize(); return _isDefaultVersion!; }
        set { Initialize(); _isDefaultVersion!.Assign(value); }
    }
    private BicepValue<bool>? _isDefaultVersion;

    /// <summary>
    /// The list of Model Sku.
    /// </summary>
    public BicepList<CognitiveServicesModelSku> Skus 
    {
        get { Initialize(); return _skus!; }
        set { Initialize(); _skus!.Assign(value); }
    }
    private BicepList<CognitiveServicesModelSku>? _skus;

    /// <summary>
    /// The max capacity.
    /// </summary>
    public BicepValue<int> MaxCapacity 
    {
        get { Initialize(); return _maxCapacity!; }
        set { Initialize(); _maxCapacity!.Assign(value); }
    }
    private BicepValue<int>? _maxCapacity;

    /// <summary>
    /// The capabilities.
    /// </summary>
    public BicepDictionary<string> Capabilities 
    {
        get { Initialize(); return _capabilities!; }
        set { Initialize(); _capabilities!.Assign(value); }
    }
    private BicepDictionary<string>? _capabilities;

    /// <summary>
    /// The capabilities for finetune models.
    /// </summary>
    public BicepDictionary<string> FinetuneCapabilities 
    {
        get { Initialize(); return _finetuneCapabilities!; }
        set { Initialize(); _finetuneCapabilities!.Assign(value); }
    }
    private BicepDictionary<string>? _finetuneCapabilities;

    /// <summary>
    /// Cognitive Services account ModelDeprecationInfo.
    /// </summary>
    public ServiceAccountModelDeprecationInfo Deprecation 
    {
        get { Initialize(); return _deprecation!; }
        set { Initialize(); AssignOrReplace(ref _deprecation, value); }
    }
    private ServiceAccountModelDeprecationInfo? _deprecation;

    /// <summary>
    /// Model lifecycle status.
    /// </summary>
    public BicepValue<ModelLifecycleStatus> LifecycleStatus 
    {
        get { Initialize(); return _lifecycleStatus!; }
        set { Initialize(); _lifecycleStatus!.Assign(value); }
    }
    private BicepValue<ModelLifecycleStatus>? _lifecycleStatus;

    /// <summary>
    /// Metadata pertaining to creation and last modification of the resource.
    /// </summary>
    public SystemData SystemData 
    {
        get { Initialize(); return _systemData!; }
    }
    private SystemData? _systemData;

    /// <summary>
    /// Creates a new CognitiveServicesAccountModel.
    /// </summary>
    public CognitiveServicesAccountModel() : base()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// CognitiveServicesAccountModel.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _baseModel = DefineModelProperty<CognitiveServicesAccountDeploymentModel>("BaseModel", ["baseModel"]);
        _isDefaultVersion = DefineProperty<bool>("IsDefaultVersion", ["isDefaultVersion"]);
        _skus = DefineListProperty<CognitiveServicesModelSku>("Skus", ["skus"]);
        _maxCapacity = DefineProperty<int>("MaxCapacity", ["maxCapacity"]);
        _capabilities = DefineDictionaryProperty<string>("Capabilities", ["capabilities"]);
        _finetuneCapabilities = DefineDictionaryProperty<string>("FinetuneCapabilities", ["finetuneCapabilities"]);
        _deprecation = DefineModelProperty<ServiceAccountModelDeprecationInfo>("Deprecation", ["deprecation"]);
        _lifecycleStatus = DefineProperty<ModelLifecycleStatus>("LifecycleStatus", ["lifecycleStatus"]);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
