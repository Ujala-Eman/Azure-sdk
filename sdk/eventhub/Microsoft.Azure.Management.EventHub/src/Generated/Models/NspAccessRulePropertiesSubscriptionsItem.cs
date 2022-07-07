// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EventHub.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Subscription for inbound rule
    /// </summary>
    public partial class NspAccessRulePropertiesSubscriptionsItem
    {
        /// <summary>
        /// Initializes a new instance of the
        /// NspAccessRulePropertiesSubscriptionsItem class.
        /// </summary>
        public NspAccessRulePropertiesSubscriptionsItem()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// NspAccessRulePropertiesSubscriptionsItem class.
        /// </summary>
        /// <param name="id">Fully qualified identifier of subscription</param>
        public NspAccessRulePropertiesSubscriptionsItem(string id = default(string))
        {
            Id = id;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets fully qualified identifier of subscription
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

    }
}
