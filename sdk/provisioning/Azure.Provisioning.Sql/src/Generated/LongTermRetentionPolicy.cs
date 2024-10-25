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
/// LongTermRetentionPolicy.
/// </summary>
public partial class LongTermRetentionPolicy : ProvisionableResource
{
    /// <summary>
    /// Gets the Name.
    /// </summary>
    public BicepValue<string> Name { get => _name; }
    private readonly BicepValue<string> _name;

    /// <summary>
    /// The BackupStorageAccessTier for the LTR backups.
    /// </summary>
    public BicepValue<SqlBackupStorageAccessTier> BackupStorageAccessTier { get => _backupStorageAccessTier; set => _backupStorageAccessTier.Assign(value); }
    private readonly BicepValue<SqlBackupStorageAccessTier> _backupStorageAccessTier;

    /// <summary>
    /// The setting whether to make LTR backups immutable.
    /// </summary>
    public BicepValue<bool> MakeBackupsImmutable { get => _makeBackupsImmutable; set => _makeBackupsImmutable.Assign(value); }
    private readonly BicepValue<bool> _makeBackupsImmutable;

    /// <summary>
    /// The monthly retention policy for an LTR backup in an ISO 8601 format.
    /// </summary>
    public BicepValue<string> MonthlyRetention { get => _monthlyRetention; set => _monthlyRetention.Assign(value); }
    private readonly BicepValue<string> _monthlyRetention;

    /// <summary>
    /// The weekly retention policy for an LTR backup in an ISO 8601 format.
    /// </summary>
    public BicepValue<string> WeeklyRetention { get => _weeklyRetention; set => _weeklyRetention.Assign(value); }
    private readonly BicepValue<string> _weeklyRetention;

    /// <summary>
    /// The week of year to take the yearly backup in an ISO 8601 format.
    /// </summary>
    public BicepValue<int> WeekOfYear { get => _weekOfYear; set => _weekOfYear.Assign(value); }
    private readonly BicepValue<int> _weekOfYear;

    /// <summary>
    /// The yearly retention policy for an LTR backup in an ISO 8601 format.
    /// </summary>
    public BicepValue<string> YearlyRetention { get => _yearlyRetention; set => _yearlyRetention.Assign(value); }
    private readonly BicepValue<string> _yearlyRetention;

    /// <summary>
    /// Gets the Id.
    /// </summary>
    public BicepValue<ResourceIdentifier> Id { get => _id; }
    private readonly BicepValue<ResourceIdentifier> _id;

    /// <summary>
    /// Gets the SystemData.
    /// </summary>
    public BicepValue<SystemData> SystemData { get => _systemData; }
    private readonly BicepValue<SystemData> _systemData;

    /// <summary>
    /// Gets or sets a reference to the parent SqlDatabase.
    /// </summary>
    public SqlDatabase? Parent { get => _parent!.Value; set => _parent!.Value = value; }
    private readonly ResourceReference<SqlDatabase> _parent;

    /// <summary>
    /// Creates a new LongTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LongTermRetentionPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LongTermRetentionPolicy.</param>
    public LongTermRetentionPolicy(string bicepIdentifier, string? resourceVersion = default)
        : base(bicepIdentifier, "Microsoft.Sql/servers/databases/backupLongTermRetentionPolicies", resourceVersion ?? "2021-11-01")
    {
        _name = BicepValue<string>.DefineProperty(this, "Name", ["name"], isOutput: true);
        _backupStorageAccessTier = BicepValue<SqlBackupStorageAccessTier>.DefineProperty(this, "BackupStorageAccessTier", ["properties", "backupStorageAccessTier"]);
        _makeBackupsImmutable = BicepValue<bool>.DefineProperty(this, "MakeBackupsImmutable", ["properties", "makeBackupsImmutable"]);
        _monthlyRetention = BicepValue<string>.DefineProperty(this, "MonthlyRetention", ["properties", "monthlyRetention"]);
        _weeklyRetention = BicepValue<string>.DefineProperty(this, "WeeklyRetention", ["properties", "weeklyRetention"]);
        _weekOfYear = BicepValue<int>.DefineProperty(this, "WeekOfYear", ["properties", "weekOfYear"]);
        _yearlyRetention = BicepValue<string>.DefineProperty(this, "YearlyRetention", ["properties", "yearlyRetention"]);
        _id = BicepValue<ResourceIdentifier>.DefineProperty(this, "Id", ["id"], isOutput: true);
        _systemData = BicepValue<SystemData>.DefineProperty(this, "SystemData", ["systemData"], isOutput: true);
        _parent = ResourceReference<SqlDatabase>.DefineResource(this, "Parent", ["parent"], isRequired: true);
    }

    /// <summary>
    /// Supported LongTermRetentionPolicy resource versions.
    /// </summary>
    public static class ResourceVersions
    {
        /// <summary>
        /// 2021-11-01.
        /// </summary>
        public static readonly string V2021_11_01 = "2021-11-01";
    }

    /// <summary>
    /// Creates a reference to an existing LongTermRetentionPolicy.
    /// </summary>
    /// <param name="bicepIdentifier">
    /// The the Bicep identifier name of the LongTermRetentionPolicy resource.
    /// This can be used to refer to the resource in expressions, but is not
    /// the Azure name of the resource.  This value can contain letters,
    /// numbers, and underscores.
    /// </param>
    /// <param name="resourceVersion">Version of the LongTermRetentionPolicy.</param>
    /// <returns>The existing LongTermRetentionPolicy resource.</returns>
    public static LongTermRetentionPolicy FromExisting(string bicepIdentifier, string? resourceVersion = default) =>
        new(bicepIdentifier, resourceVersion) { IsExistingResource = true };
}
