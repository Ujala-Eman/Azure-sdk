// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Core;
using Azure.Provisioning.Primitives;
using Azure.Provisioning.Resources;
using System;

namespace Azure.Provisioning.AppService;

/// <summary>
/// Virtual Network route contract used to pass routing information for a
/// Virtual Network.
/// </summary>
public partial class AppServiceVirtualNetworkRoute : ProvisionableConstruct
{
    /// <summary>
    /// The starting address for this route. This may also include a CIDR
    /// notation, in which case the end address must not be specified.
    /// </summary>
    public BicepValue<string> StartAddress 
    {
        get { Initialize(); return _startAddress!; }
        set { Initialize(); _startAddress!.Assign(value); }
    }
    private BicepValue<string>? _startAddress;

    /// <summary>
    /// The ending address for this route. If the start address is specified in
    /// CIDR notation, this must be omitted.
    /// </summary>
    public BicepValue<string> EndAddress 
    {
        get { Initialize(); return _endAddress!; }
        set { Initialize(); _endAddress!.Assign(value); }
    }
    private BicepValue<string>? _endAddress;

    /// <summary>
    /// The type of route this is:              DEFAULT - By default, every app
    /// has routes to the local address ranges specified by RFC1918
    /// INHERITED - Routes inherited from the real Virtual
    /// Network routes              STATIC - Static route set on the app only
    /// These values will be used for syncing an
    /// app&apos;s routes with those from a Virtual Network.
    /// </summary>
    public BicepValue<AppServiceVirtualNetworkRouteType> RouteType 
    {
        get { Initialize(); return _routeType!; }
        set { Initialize(); _routeType!.Assign(value); }
    }
    private BicepValue<AppServiceVirtualNetworkRouteType>? _routeType;

    /// <summary>
    /// Kind of resource.
    /// </summary>
    public BicepValue<string> Kind 
    {
        get { Initialize(); return _kind!; }
        set { Initialize(); _kind!.Assign(value); }
    }
    private BicepValue<string>? _kind;

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
    /// Creates a new AppServiceVirtualNetworkRoute.
    /// </summary>
    public AppServiceVirtualNetworkRoute()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// AppServiceVirtualNetworkRoute.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _startAddress = DefineProperty<string>("StartAddress", ["properties", "startAddress"]);
        _endAddress = DefineProperty<string>("EndAddress", ["properties", "endAddress"]);
        _routeType = DefineProperty<AppServiceVirtualNetworkRouteType>("RouteType", ["properties", "routeType"]);
        _kind = DefineProperty<string>("Kind", ["kind"]);
        _id = DefineProperty<ResourceIdentifier>("Id", ["id"], isOutput: true);
        _name = DefineProperty<string>("Name", ["name"], isOutput: true);
        _systemData = DefineModelProperty<SystemData>("SystemData", ["systemData"], isOutput: true);
    }
}
