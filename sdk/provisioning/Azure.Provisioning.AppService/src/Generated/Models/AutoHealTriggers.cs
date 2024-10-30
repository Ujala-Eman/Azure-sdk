// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning;
using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Triggers for auto-heal.
/// </summary>
public partial class AutoHealTriggers : ProvisionableConstruct
{
    /// <summary>
    /// A rule based on total requests.
    /// </summary>
    public RequestsBasedTrigger Requests 
    {
        get { Initialize(); return _requests!; }
        set { Initialize(); AssignOrReplace(ref _requests, value); }
    }
    private RequestsBasedTrigger? _requests;

    /// <summary>
    /// A rule based on private bytes.
    /// </summary>
    public BicepValue<int> PrivateBytesInKB 
    {
        get { Initialize(); return _privateBytesInKB!; }
        set { Initialize(); _privateBytesInKB!.Assign(value); }
    }
    private BicepValue<int>? _privateBytesInKB;

    /// <summary>
    /// A rule based on status codes.
    /// </summary>
    public BicepList<StatusCodesBasedTrigger> StatusCodes 
    {
        get { Initialize(); return _statusCodes!; }
        set { Initialize(); _statusCodes!.Assign(value); }
    }
    private BicepList<StatusCodesBasedTrigger>? _statusCodes;

    /// <summary>
    /// A rule based on request execution time.
    /// </summary>
    public SlowRequestsBasedTrigger SlowRequests 
    {
        get { Initialize(); return _slowRequests!; }
        set { Initialize(); AssignOrReplace(ref _slowRequests, value); }
    }
    private SlowRequestsBasedTrigger? _slowRequests;

    /// <summary>
    /// A rule based on multiple Slow Requests Rule with path.
    /// </summary>
    public BicepList<SlowRequestsBasedTrigger> SlowRequestsWithPath 
    {
        get { Initialize(); return _slowRequestsWithPath!; }
        set { Initialize(); _slowRequestsWithPath!.Assign(value); }
    }
    private BicepList<SlowRequestsBasedTrigger>? _slowRequestsWithPath;

    /// <summary>
    /// A rule based on status codes ranges.
    /// </summary>
    public BicepList<StatusCodesRangeBasedTrigger> StatusCodesRange 
    {
        get { Initialize(); return _statusCodesRange!; }
        set { Initialize(); _statusCodesRange!.Assign(value); }
    }
    private BicepList<StatusCodesRangeBasedTrigger>? _statusCodesRange;

    /// <summary>
    /// Creates a new AutoHealTriggers.
    /// </summary>
    public AutoHealTriggers()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of AutoHealTriggers.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _requests = DefineModelProperty<RequestsBasedTrigger>("Requests", ["requests"]);
        _privateBytesInKB = DefineProperty<int>("PrivateBytesInKB", ["privateBytesInKB"]);
        _statusCodes = DefineListProperty<StatusCodesBasedTrigger>("StatusCodes", ["statusCodes"]);
        _slowRequests = DefineModelProperty<SlowRequestsBasedTrigger>("SlowRequests", ["slowRequests"]);
        _slowRequestsWithPath = DefineListProperty<SlowRequestsBasedTrigger>("SlowRequestsWithPath", ["slowRequestsWithPath"]);
        _statusCodesRange = DefineListProperty<StatusCodesRangeBasedTrigger>("StatusCodesRange", ["statusCodesRange"]);
    }
}
