// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.AppContainers;

/// <summary>
/// Configuration of application logs.
/// </summary>
public partial class ContainerAppLogsConfiguration : ProvisionableConstruct
{
    /// <summary>
    /// Logs destination, can be &apos;log-analytics&apos;,
    /// &apos;azure-monitor&apos; or &apos;none&apos;.
    /// </summary>
    public BicepValue<string> Destination 
    {
        get { Initialize(); return _destination!; }
        set { Initialize(); _destination!.Assign(value); }
    }
    private BicepValue<string>? _destination;

    /// <summary>
    /// Log Analytics configuration, must only be provided when destination is
    /// configured as &apos;log-analytics&apos;.
    /// </summary>
    public ContainerAppLogAnalyticsConfiguration LogAnalyticsConfiguration 
    {
        get { Initialize(); return _logAnalyticsConfiguration!; }
        set { Initialize(); AssignOrReplace(ref _logAnalyticsConfiguration, value); }
    }
    private ContainerAppLogAnalyticsConfiguration? _logAnalyticsConfiguration;

    /// <summary>
    /// Creates a new ContainerAppLogsConfiguration.
    /// </summary>
    public ContainerAppLogsConfiguration()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerAppLogsConfiguration.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _destination = DefineProperty<string>("Destination", ["destination"]);
        _logAnalyticsConfiguration = DefineModelProperty<ContainerAppLogAnalyticsConfiguration>("LogAnalyticsConfiguration", ["logAnalyticsConfiguration"]);
    }
}
