// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Group of the gallery sharing profile
    /// </summary>
    public partial class SharingProfileGroup
    {
        /// <summary>
        /// Initializes a new instance of the SharingProfileGroup class.
        /// </summary>
        public SharingProfileGroup()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SharingProfileGroup class.
        /// </summary>
        /// <param name="type">This property allows you to specify the type of
        /// sharing group. &lt;br&gt;&lt;br&gt; Possible values are:
        /// &lt;br&gt;&lt;br&gt; **Subscriptions** &lt;br&gt;&lt;br&gt;
        /// **AADTenants**. Possible values include: 'Subscriptions',
        /// 'AADTenants'</param>
        /// <param name="ids">A list of subscription/tenant ids the gallery is
        /// aimed to be shared to.</param>
        public SharingProfileGroup(string type = default(string), IList<string> ids = default(IList<string>))
        {
            Type = type;
            Ids = ids;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets this property allows you to specify the type of
        /// sharing group. &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; Possible values
        /// are: &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **Subscriptions**
        /// &amp;lt;br&amp;gt;&amp;lt;br&amp;gt; **AADTenants**. Possible
        /// values include: 'Subscriptions', 'AADTenants'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// Gets or sets a list of subscription/tenant ids the gallery is aimed
        /// to be shared to.
        /// </summary>
        [JsonProperty(PropertyName = "ids")]
        public IList<string> Ids { get; set; }

    }
}
