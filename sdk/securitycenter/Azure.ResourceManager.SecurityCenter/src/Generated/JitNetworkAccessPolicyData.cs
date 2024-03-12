// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityCenter.Models;

namespace Azure.ResourceManager.SecurityCenter
{
    /// <summary> A class representing the JitNetworkAccessPolicy data model. </summary>
    public partial class JitNetworkAccessPolicyData : ResourceData
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

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyData"/>. </summary>
        /// <param name="virtualMachines"> Configurations for Microsoft.Compute/virtualMachines resource type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="virtualMachines"/> is null. </exception>
        public JitNetworkAccessPolicyData(IEnumerable<JitNetworkAccessPolicyVirtualMachine> virtualMachines)
        {
            Argument.AssertNotNull(virtualMachines, nameof(virtualMachines));

            VirtualMachines = virtualMachines.ToList();
            Requests = new ChangeTrackingList<JitNetworkAccessRequestInfo>();
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="virtualMachines"> Configurations for Microsoft.Compute/virtualMachines resource type. </param>
        /// <param name="requests"></param>
        /// <param name="provisioningState"> Gets the provisioning state of the Just-in-Time policy. </param>
        /// <param name="kind"> Kind of the resource. </param>
        /// <param name="location"> Location where the resource is stored. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal JitNetworkAccessPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IList<JitNetworkAccessPolicyVirtualMachine> virtualMachines, IList<JitNetworkAccessRequestInfo> requests, string provisioningState, string kind, AzureLocation? location, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            VirtualMachines = virtualMachines;
            Requests = requests;
            ProvisioningState = provisioningState;
            Kind = kind;
            Location = location;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="JitNetworkAccessPolicyData"/> for deserialization. </summary>
        internal JitNetworkAccessPolicyData()
        {
        }

        /// <summary> Configurations for Microsoft.Compute/virtualMachines resource type. </summary>
        public IList<JitNetworkAccessPolicyVirtualMachine> VirtualMachines { get; }
        /// <summary> Gets the requests. </summary>
        public IList<JitNetworkAccessRequestInfo> Requests { get; }
        /// <summary> Gets the provisioning state of the Just-in-Time policy. </summary>
        public string ProvisioningState { get; }
        /// <summary> Kind of the resource. </summary>
        public string Kind { get; set; }
        /// <summary> Location where the resource is stored. </summary>
        public AzureLocation? Location { get; }
    }
}
