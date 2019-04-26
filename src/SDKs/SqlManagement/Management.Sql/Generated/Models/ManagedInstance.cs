// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure SQL managed instance.
    /// </summary>
    [Rest.Serialization.JsonTransformation]
    public partial class ManagedInstance : TrackedResource
    {
        /// <summary>
        /// Initializes a new instance of the ManagedInstance class.
        /// </summary>
        public ManagedInstance()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagedInstance class.
        /// </summary>
        /// <param name="location">Resource location.</param>
        /// <param name="id">Resource ID.</param>
        /// <param name="name">Resource name.</param>
        /// <param name="type">Resource type.</param>
        /// <param name="tags">Resource tags.</param>
        /// <param name="identity">The Azure Active Directory identity of the
        /// managed instance.</param>
        /// <param name="sku">Managed instance SKU. Allowed values for
        /// sku.name: GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5</param>
        /// <param name="managedInstanceCreateMode">Specifies the mode of
        /// database creation.
        ///
        /// Default: Regular instance creation.
        ///
        /// Restore: Creates an instance by restoring a set of backups to
        /// specific point in time. RestorePointInTime and
        /// SourceManagedInstanceId must be specified. Possible values include:
        /// 'Default', 'PointInTimeRestore'</param>
        /// <param name="fullyQualifiedDomainName">The fully qualified domain
        /// name of the managed instance.</param>
        /// <param name="administratorLogin">Administrator username for the
        /// managed instance. Can only be specified when the managed instance
        /// is being created (and is required for creation).</param>
        /// <param name="administratorLoginPassword">The administrator login
        /// password (required for managed instance creation).</param>
        /// <param name="subnetId">Subnet resource ID for the managed
        /// instance.</param>
        /// <param name="state">The state of the managed instance.</param>
        /// <param name="licenseType">The license type. Possible values are
        /// 'LicenseIncluded' (regular price inclusive of a new SQL license)
        /// and 'BasePrice' (discounted AHB price for bringing your own SQL
        /// licenses). Possible values include: 'LicenseIncluded',
        /// 'BasePrice'</param>
        /// <param name="vCores">The number of vCores. Allowed values: 8, 16,
        /// 24, 32, 40, 64, 80.</param>
        /// <param name="storageSizeInGB">Storage size in GB. Minimum value:
        /// 32. Maximum value: 8192. Increments of 32 GB allowed only.</param>
        /// <param name="collation">Collation of the managed instance.</param>
        /// <param name="dnsZone">The Dns Zone that the managed instance is
        /// in.</param>
        /// <param name="dnsZonePartner">The resource id of another managed
        /// instance whose DNS zone this managed instance will share after
        /// creation.</param>
        /// <param name="publicDataEndpointEnabled">Whether or not the public
        /// data endpoint is enabled.</param>
        /// <param name="sourceManagedInstanceId">The resource identifier of
        /// the source managed instance associated with create operation of
        /// this instance.</param>
        /// <param name="restorePointInTime">Specifies the point in time
        /// (ISO8601 format) of the source database that will be restored to
        /// create the new database.</param>
        /// <param name="proxyOverride">Connection type used for connecting to
        /// the instance. Possible values include: 'Proxy', 'Redirect',
        /// 'Default'</param>
        /// <param name="timezoneId">Id of the timezone. Allowed values are
        /// timezones supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in
        /// registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time
        /// Zones.
        /// You can get those registry values via SQL Server by querying SELECT
        /// name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing
        /// [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W.
        /// Europe Standard Time".</param>
        /// <param name="instancePoolId">The Id of the instance pool this
        /// managed server belongs to.</param>
        public ManagedInstance(string location, string id = default(string), string name = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), ResourceIdentity identity = default(ResourceIdentity), Sku sku = default(Sku), string managedInstanceCreateMode = default(string), string fullyQualifiedDomainName = default(string), string administratorLogin = default(string), string administratorLoginPassword = default(string), string subnetId = default(string), string state = default(string), string licenseType = default(string), int? vCores = default(int?), int? storageSizeInGB = default(int?), string collation = default(string), string dnsZone = default(string), string dnsZonePartner = default(string), bool? publicDataEndpointEnabled = default(bool?), string sourceManagedInstanceId = default(string), System.DateTime? restorePointInTime = default(System.DateTime?), string proxyOverride = default(string), string timezoneId = default(string), string instancePoolId = default(string))
            : base(location, id, name, type, tags)
        {
            Identity = identity;
            Sku = sku;
            ManagedInstanceCreateMode = managedInstanceCreateMode;
            FullyQualifiedDomainName = fullyQualifiedDomainName;
            AdministratorLogin = administratorLogin;
            AdministratorLoginPassword = administratorLoginPassword;
            SubnetId = subnetId;
            State = state;
            LicenseType = licenseType;
            VCores = vCores;
            StorageSizeInGB = storageSizeInGB;
            Collation = collation;
            DnsZone = dnsZone;
            DnsZonePartner = dnsZonePartner;
            PublicDataEndpointEnabled = publicDataEndpointEnabled;
            SourceManagedInstanceId = sourceManagedInstanceId;
            RestorePointInTime = restorePointInTime;
            ProxyOverride = proxyOverride;
            TimezoneId = timezoneId;
            InstancePoolId = instancePoolId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the Azure Active Directory identity of the managed
        /// instance.
        /// </summary>
        [JsonProperty(PropertyName = "identity")]
        public ResourceIdentity Identity { get; set; }

        /// <summary>
        /// Gets or sets managed instance SKU. Allowed values for sku.name:
        /// GP_Gen4, GP_Gen5, BC_Gen4, BC_Gen5
        /// </summary>
        [JsonProperty(PropertyName = "sku")]
        public Sku Sku { get; set; }

        /// <summary>
        /// Gets or sets specifies the mode of database creation.
        ///
        /// Default: Regular instance creation.
        ///
        /// Restore: Creates an instance by restoring a set of backups to
        /// specific point in time. RestorePointInTime and
        /// SourceManagedInstanceId must be specified. Possible values include:
        /// 'Default', 'PointInTimeRestore'
        /// </summary>
        [JsonProperty(PropertyName = "properties.managedInstanceCreateMode")]
        public string ManagedInstanceCreateMode { get; set; }

        /// <summary>
        /// Gets the fully qualified domain name of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fullyQualifiedDomainName")]
        public string FullyQualifiedDomainName { get; private set; }

        /// <summary>
        /// Gets or sets administrator username for the managed instance. Can
        /// only be specified when the managed instance is being created (and
        /// is required for creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLogin")]
        public string AdministratorLogin { get; set; }

        /// <summary>
        /// Gets or sets the administrator login password (required for managed
        /// instance creation).
        /// </summary>
        [JsonProperty(PropertyName = "properties.administratorLoginPassword")]
        public string AdministratorLoginPassword { get; set; }

        /// <summary>
        /// Gets or sets subnet resource ID for the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.subnetId")]
        public string SubnetId { get; set; }

        /// <summary>
        /// Gets the state of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; private set; }

        /// <summary>
        /// Gets or sets the license type. Possible values are
        /// 'LicenseIncluded' (regular price inclusive of a new SQL license)
        /// and 'BasePrice' (discounted AHB price for bringing your own SQL
        /// licenses). Possible values include: 'LicenseIncluded', 'BasePrice'
        /// </summary>
        [JsonProperty(PropertyName = "properties.licenseType")]
        public string LicenseType { get; set; }

        /// <summary>
        /// Gets or sets the number of vCores. Allowed values: 8, 16, 24, 32,
        /// 40, 64, 80.
        /// </summary>
        [JsonProperty(PropertyName = "properties.vCores")]
        public int? VCores { get; set; }

        /// <summary>
        /// Gets or sets storage size in GB. Minimum value: 32. Maximum value:
        /// 8192. Increments of 32 GB allowed only.
        /// </summary>
        [JsonProperty(PropertyName = "properties.storageSizeInGB")]
        public int? StorageSizeInGB { get; set; }

        /// <summary>
        /// Gets or sets collation of the managed instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.collation")]
        public string Collation { get; set; }

        /// <summary>
        /// Gets the Dns Zone that the managed instance is in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsZone")]
        public string DnsZone { get; private set; }

        /// <summary>
        /// Gets or sets the resource id of another managed instance whose DNS
        /// zone this managed instance will share after creation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.dnsZonePartner")]
        public string DnsZonePartner { get; set; }

        /// <summary>
        /// Gets or sets whether or not the public data endpoint is enabled.
        /// </summary>
        [JsonProperty(PropertyName = "properties.publicDataEndpointEnabled")]
        public bool? PublicDataEndpointEnabled { get; set; }

        /// <summary>
        /// Gets or sets the resource identifier of the source managed instance
        /// associated with create operation of this instance.
        /// </summary>
        [JsonProperty(PropertyName = "properties.sourceManagedInstanceId")]
        public string SourceManagedInstanceId { get; set; }

        /// <summary>
        /// Gets or sets specifies the point in time (ISO8601 format) of the
        /// source database that will be restored to create the new database.
        /// </summary>
        [JsonProperty(PropertyName = "properties.restorePointInTime")]
        public System.DateTime? RestorePointInTime { get; set; }

        /// <summary>
        /// Gets or sets connection type used for connecting to the instance.
        /// Possible values include: 'Proxy', 'Redirect', 'Default'
        /// </summary>
        [JsonProperty(PropertyName = "properties.proxyOverride")]
        public string ProxyOverride { get; set; }

        /// <summary>
        /// Gets or sets id of the timezone. Allowed values are timezones
        /// supported by Windows.
        /// Windows keeps details on supported timezones, including the id, in
        /// registry under
        /// KEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\Time
        /// Zones.
        /// You can get those registry values via SQL Server by querying SELECT
        /// name AS timezone_id FROM sys.time_zone_info.
        /// List of Ids can also be obtained by executing
        /// [System.TimeZoneInfo]::GetSystemTimeZones() in PowerShell.
        /// An example of valid timezone id is "Pacific Standard Time" or "W.
        /// Europe Standard Time".
        /// </summary>
        [JsonProperty(PropertyName = "properties.timezoneId")]
        public string TimezoneId { get; set; }

        /// <summary>
        /// Gets or sets the Id of the instance pool this managed server
        /// belongs to.
        /// </summary>
        [JsonProperty(PropertyName = "properties.instancePoolId")]
        public string InstancePoolId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Sku != null)
            {
                Sku.Validate();
            }
        }
    }
}
