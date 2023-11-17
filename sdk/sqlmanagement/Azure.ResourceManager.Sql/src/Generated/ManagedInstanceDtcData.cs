// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the ManagedInstanceDtc data model.
    /// SQL Managed Instance DTC
    /// </summary>
    public partial class ManagedInstanceDtcData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcData"/>. </summary>
        public ManagedInstanceDtcData()
        {
            ExternalDnsSuffixSearchList = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ManagedInstanceDtcData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="dtcEnabled"> Active status of managed instance DTC. </param>
        /// <param name="securitySettings"> Security settings of managed instance DTC. </param>
        /// <param name="externalDnsSuffixSearchList"> External dns suffix search list of managed instance DTC. </param>
        /// <param name="dtcHostNameDnsSuffix"> Host name dns suffix of managed instance DTC. </param>
        /// <param name="provisioningState"> Provisioning state of managed instance DTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedInstanceDtcData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, bool? dtcEnabled, ManagedInstanceDtcSecuritySettings securitySettings, IList<string> externalDnsSuffixSearchList, string dtcHostNameDnsSuffix, JobExecutionProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            DtcEnabled = dtcEnabled;
            SecuritySettings = securitySettings;
            ExternalDnsSuffixSearchList = externalDnsSuffixSearchList;
            DtcHostNameDnsSuffix = dtcHostNameDnsSuffix;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Active status of managed instance DTC. </summary>
        public bool? DtcEnabled { get; set; }
        /// <summary> Security settings of managed instance DTC. </summary>
        public ManagedInstanceDtcSecuritySettings SecuritySettings { get; set; }
        /// <summary> External dns suffix search list of managed instance DTC. </summary>
        public IList<string> ExternalDnsSuffixSearchList { get; }
        /// <summary> Host name dns suffix of managed instance DTC. </summary>
        public string DtcHostNameDnsSuffix { get; }
        /// <summary> Provisioning state of managed instance DTC. </summary>
        public JobExecutionProvisioningState? ProvisioningState { get; }
    }
}
