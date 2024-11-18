// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable enable

using Azure.Provisioning.Primitives;
using System;

namespace Azure.Provisioning.ContainerService;

/// <summary>
/// One and only one of the schedule types should be specified. Choose either
/// &apos;daily&apos;, &apos;weekly&apos;, &apos;absoluteMonthly&apos; or
/// &apos;relativeMonthly&apos; for your maintenance schedule.
/// </summary>
public partial class ContainerServiceMaintenanceSchedule : ProvisionableConstruct
{
    /// <summary>
    /// Specifies the number of days between each set of occurrences.
    /// </summary>
    public BicepValue<int> DailyIntervalDays 
    {
        get { Initialize(); return _dailyIntervalDays!; }
        set { Initialize(); _dailyIntervalDays!.Assign(value); }
    }
    private BicepValue<int>? _dailyIntervalDays;

    /// <summary>
    /// For schedules like: &apos;recur every Monday&apos; or &apos;recur every
    /// 3 weeks on Wednesday&apos;.
    /// </summary>
    public ContainerServiceMaintenanceWeeklySchedule Weekly 
    {
        get { Initialize(); return _weekly!; }
        set { Initialize(); AssignOrReplace(ref _weekly, value); }
    }
    private ContainerServiceMaintenanceWeeklySchedule? _weekly;

    /// <summary>
    /// For schedules like: &apos;recur every month on the 15th&apos; or
    /// &apos;recur every 3 months on the 20th&apos;.
    /// </summary>
    public ContainerServiceMaintenanceAbsoluteMonthlySchedule AbsoluteMonthly 
    {
        get { Initialize(); return _absoluteMonthly!; }
        set { Initialize(); AssignOrReplace(ref _absoluteMonthly, value); }
    }
    private ContainerServiceMaintenanceAbsoluteMonthlySchedule? _absoluteMonthly;

    /// <summary>
    /// For schedules like: &apos;recur every month on the first Monday&apos;
    /// or &apos;recur every 3 months on last Friday&apos;.
    /// </summary>
    public ContainerServiceMaintenanceRelativeMonthlySchedule RelativeMonthly 
    {
        get { Initialize(); return _relativeMonthly!; }
        set { Initialize(); AssignOrReplace(ref _relativeMonthly, value); }
    }
    private ContainerServiceMaintenanceRelativeMonthlySchedule? _relativeMonthly;

    /// <summary>
    /// Creates a new ContainerServiceMaintenanceSchedule.
    /// </summary>
    public ContainerServiceMaintenanceSchedule()
    {
    }

    /// <summary>
    /// Define all the provisionable properties of
    /// ContainerServiceMaintenanceSchedule.
    /// </summary>
    protected override void DefineProvisionableProperties()
    {
        base.DefineProvisionableProperties();
        _dailyIntervalDays = DefineProperty<int>("DailyIntervalDays", ["daily", "intervalDays"]);
        _weekly = DefineModelProperty<ContainerServiceMaintenanceWeeklySchedule>("Weekly", ["weekly"]);
        _absoluteMonthly = DefineModelProperty<ContainerServiceMaintenanceAbsoluteMonthlySchedule>("AbsoluteMonthly", ["absoluteMonthly"]);
        _relativeMonthly = DefineModelProperty<ContainerServiceMaintenanceRelativeMonthlySchedule>("RelativeMonthly", ["relativeMonthly"]);
    }
}
