// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Nginx.Models
{
    /// <summary> The NginxDeploymentPatch. </summary>
    public partial class NginxDeploymentPatch
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

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentPatch"/>. </summary>
        public NginxDeploymentPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="NginxDeploymentPatch"/>. </summary>
        /// <param name="identity"> Gets or sets the identity. </param>
        /// <param name="tags"> Dictionary of &lt;string&gt;. </param>
        /// <param name="sku"></param>
        /// <param name="location"></param>
        /// <param name="properties"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal NginxDeploymentPatch(ManagedServiceIdentity identity, IDictionary<string, string> tags, ResourceSku sku, AzureLocation? location, NginxDeploymentUpdateProperties properties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Identity = identity;
            Tags = tags;
            Sku = sku;
            Location = location;
            Properties = properties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets or sets the identity. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Gets or sets the sku. </summary>
        internal ResourceSku Sku { get; set; }
        /// <summary> Name of the SKU. </summary>
        public string SkuName
        {
            get => Sku is null ? default : Sku.Name;
            set => Sku = new ResourceSku(value);
        }

        /// <summary> Gets or sets the location. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Gets or sets the properties. </summary>
        public NginxDeploymentUpdateProperties Properties { get; set; }
    }
}
