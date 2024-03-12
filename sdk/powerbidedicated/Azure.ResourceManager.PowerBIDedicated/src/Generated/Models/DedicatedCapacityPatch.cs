// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.PowerBIDedicated;

namespace Azure.ResourceManager.PowerBIDedicated.Models
{
    /// <summary> Provision request specification. </summary>
    public partial class DedicatedCapacityPatch
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

        /// <summary> Initializes a new instance of <see cref="DedicatedCapacityPatch"/>. </summary>
        public DedicatedCapacityPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="DedicatedCapacityPatch"/>. </summary>
        /// <param name="sku"> The SKU of the Dedicated capacity resource. </param>
        /// <param name="tags"> Key-value pairs of additional provisioning properties. </param>
        /// <param name="administration"> A collection of Dedicated capacity administrators. </param>
        /// <param name="mode"> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value 'Gen2' is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </param>
        /// <param name="tenantId"> Tenant ID for the capacity. Used for creating Pro Plus capacity. </param>
        /// <param name="friendlyName"> Capacity name. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DedicatedCapacityPatch(CapacitySku sku, IDictionary<string, string> tags, DedicatedCapacityAdministrators administration, Mode? mode, Guid? tenantId, string friendlyName, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Sku = sku;
            Tags = tags;
            Administration = administration;
            Mode = mode;
            TenantId = tenantId;
            FriendlyName = friendlyName;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The SKU of the Dedicated capacity resource. </summary>
        public CapacitySku Sku { get; set; }
        /// <summary> Key-value pairs of additional provisioning properties. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> A collection of Dedicated capacity administrators. </summary>
        internal DedicatedCapacityAdministrators Administration { get; set; }
        /// <summary> An array of administrator user identities. </summary>
        public IList<string> AdministrationMembers
        {
            get
            {
                if (Administration is null)
                    Administration = new DedicatedCapacityAdministrators();
                return Administration.Members;
            }
        }

        /// <summary> Specifies the generation of the Power BI Embedded capacity. If no value is specified, the default value 'Gen2' is used. [Learn More](https://docs.microsoft.com/power-bi/developer/embedded/power-bi-embedded-generation-2). </summary>
        public Mode? Mode { get; set; }
        /// <summary> Tenant ID for the capacity. Used for creating Pro Plus capacity. </summary>
        public Guid? TenantId { get; }
        /// <summary> Capacity name. </summary>
        public string FriendlyName { get; }
    }
}
