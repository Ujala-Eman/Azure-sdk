// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.NetApp.Models
{
    /// <summary> Volume patch resource. </summary>
    public partial class NetAppVolumePatch : TrackedResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="NetAppVolumePatch"/>. </summary>
        /// <param name="location"> The location. </param>
        public NetAppVolumePatch(AzureLocation location) : base(location)
        {
            ProtocolTypes = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumePatch"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="serviceLevel"> The service level of the file system. </param>
        /// <param name="usageThreshold"> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. For regular volumes, valid values are in the range 50GiB to 100TiB. For large volumes, valid values are in the range 100TiB to 500TiB, and on an exceptional basis, from to 2400GiB to 2400TiB. Values expressed in bytes as multiples of 1 GiB. </param>
        /// <param name="exportPolicy"> Set of export policy rules. </param>
        /// <param name="protocolTypes"> Set of protocol types, default NFSv3, CIFS for SMB protocol. </param>
        /// <param name="throughputMibps"> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </param>
        /// <param name="dataProtection"> DataProtection type volumes include an object containing details of the replication. </param>
        /// <param name="isDefaultQuotaEnabled"> Specifies if default quota is enabled for the volume. </param>
        /// <param name="defaultUserQuotaInKiBs"> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </param>
        /// <param name="defaultGroupQuotaInKiBs"> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </param>
        /// <param name="unixPermissions"> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users. </param>
        /// <param name="isCoolAccessEnabled"> Specifies whether Cool Access(tiering) is enabled for the volume. </param>
        /// <param name="coolnessPeriod"> Specifies the number of days after which data that is not accessed by clients will be tiered. </param>
        /// <param name="coolAccessRetrievalPolicy">
        /// coolAccessRetrievalPolicy determines the data retrieval behavior from the cool tier to standard storage based on the read pattern for cool access enabled volumes. The possible values for this field are:
        ///  Default - Data will be pulled from cool tier to standard storage on random reads. This policy is the default.
        ///  OnRead - All client-driven data read is pulled from cool tier to standard storage on both sequential and random reads.
        ///  Never - No client-driven data is pulled from cool tier to standard storage.
        /// </param>
        /// <param name="isSnapshotDirectoryVisible"> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots. </param>
        /// <param name="smbAccessBasedEnumeration"> Enables access-based enumeration share property for SMB Shares. Only applicable for SMB/DualProtocol volume. </param>
        /// <param name="smbNonBrowsable"> Enables non-browsable property for SMB Shares. Only applicable for SMB/DualProtocol volume. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NetAppVolumePatch(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, NetAppFileServiceLevel? serviceLevel, long? usageThreshold, VolumePatchPropertiesExportPolicy exportPolicy, IList<string> protocolTypes, float? throughputMibps, NetAppVolumePatchDataProtection dataProtection, bool? isDefaultQuotaEnabled, long? defaultUserQuotaInKiBs, long? defaultGroupQuotaInKiBs, string unixPermissions, bool? isCoolAccessEnabled, int? coolnessPeriod, CoolAccessRetrievalPolicy? coolAccessRetrievalPolicy, bool? isSnapshotDirectoryVisible, SmbAccessBasedEnumeration? smbAccessBasedEnumeration, SmbNonBrowsable? smbNonBrowsable, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData, tags, location)
        {
            ServiceLevel = serviceLevel;
            UsageThreshold = usageThreshold;
            ExportPolicy = exportPolicy;
            ProtocolTypes = protocolTypes;
            ThroughputMibps = throughputMibps;
            DataProtection = dataProtection;
            IsDefaultQuotaEnabled = isDefaultQuotaEnabled;
            DefaultUserQuotaInKiBs = defaultUserQuotaInKiBs;
            DefaultGroupQuotaInKiBs = defaultGroupQuotaInKiBs;
            UnixPermissions = unixPermissions;
            IsCoolAccessEnabled = isCoolAccessEnabled;
            CoolnessPeriod = coolnessPeriod;
            CoolAccessRetrievalPolicy = coolAccessRetrievalPolicy;
            IsSnapshotDirectoryVisible = isSnapshotDirectoryVisible;
            SmbAccessBasedEnumeration = smbAccessBasedEnumeration;
            SmbNonBrowsable = smbNonBrowsable;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="NetAppVolumePatch"/> for deserialization. </summary>
        internal NetAppVolumePatch()
        {
        }

        /// <summary> The service level of the file system. </summary>
        public NetAppFileServiceLevel? ServiceLevel { get; set; }
        /// <summary> Maximum storage quota allowed for a file system in bytes. This is a soft quota used for alerting only. For regular volumes, valid values are in the range 50GiB to 100TiB. For large volumes, valid values are in the range 100TiB to 500TiB, and on an exceptional basis, from to 2400GiB to 2400TiB. Values expressed in bytes as multiples of 1 GiB. </summary>
        public long? UsageThreshold { get; set; }
        /// <summary> Set of export policy rules. </summary>
        internal VolumePatchPropertiesExportPolicy ExportPolicy { get; set; }
        /// <summary> Export policy rule. </summary>
        public IList<NetAppVolumeExportPolicyRule> ExportRules
        {
            get
            {
                if (ExportPolicy is null)
                    ExportPolicy = new VolumePatchPropertiesExportPolicy();
                return ExportPolicy.Rules;
            }
        }

        /// <summary> Set of protocol types, default NFSv3, CIFS for SMB protocol. </summary>
        public IList<string> ProtocolTypes { get; }
        /// <summary> Maximum throughput in MiB/s that can be achieved by this volume and this will be accepted as input only for manual qosType volume. </summary>
        public float? ThroughputMibps { get; set; }
        /// <summary> DataProtection type volumes include an object containing details of the replication. </summary>
        public NetAppVolumePatchDataProtection DataProtection { get; set; }
        /// <summary> Specifies if default quota is enabled for the volume. </summary>
        public bool? IsDefaultQuotaEnabled { get; set; }
        /// <summary> Default user quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies . </summary>
        public long? DefaultUserQuotaInKiBs { get; set; }
        /// <summary> Default group quota for volume in KiBs. If isDefaultQuotaEnabled is set, the minimum value of 4 KiBs applies. </summary>
        public long? DefaultGroupQuotaInKiBs { get; set; }
        /// <summary> UNIX permissions for NFS volume accepted in octal 4 digit format. First digit selects the set user ID(4), set group ID (2) and sticky (1) attributes. Second digit selects permission for the owner of the file: read (4), write (2) and execute (1). Third selects permissions for other users in the same group. the fourth for other users not in the group. 0755 - gives read/write/execute permissions to owner and read/execute to group and other users. </summary>
        public string UnixPermissions { get; set; }
        /// <summary> Specifies whether Cool Access(tiering) is enabled for the volume. </summary>
        public bool? IsCoolAccessEnabled { get; set; }
        /// <summary> Specifies the number of days after which data that is not accessed by clients will be tiered. </summary>
        public int? CoolnessPeriod { get; set; }
        /// <summary>
        /// coolAccessRetrievalPolicy determines the data retrieval behavior from the cool tier to standard storage based on the read pattern for cool access enabled volumes. The possible values for this field are:
        ///  Default - Data will be pulled from cool tier to standard storage on random reads. This policy is the default.
        ///  OnRead - All client-driven data read is pulled from cool tier to standard storage on both sequential and random reads.
        ///  Never - No client-driven data is pulled from cool tier to standard storage.
        /// </summary>
        public CoolAccessRetrievalPolicy? CoolAccessRetrievalPolicy { get; set; }
        /// <summary> If enabled (true) the volume will contain a read-only snapshot directory which provides access to each of the volume's snapshots. </summary>
        public bool? IsSnapshotDirectoryVisible { get; set; }
        /// <summary> Enables access-based enumeration share property for SMB Shares. Only applicable for SMB/DualProtocol volume. </summary>
        public SmbAccessBasedEnumeration? SmbAccessBasedEnumeration { get; set; }
        /// <summary> Enables non-browsable property for SMB Shares. Only applicable for SMB/DualProtocol volume. </summary>
        public SmbNonBrowsable? SmbNonBrowsable { get; set; }
    }
}
