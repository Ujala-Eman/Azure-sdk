// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.SecurityInsights.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Connector Availability Status
    /// </summary>
    public partial class Availability
    {
        /// <summary>
        /// Initializes a new instance of the Availability class.
        /// </summary>
        public Availability()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Availability class.
        /// </summary>
        /// <param name="status">The connector Availability Status</param>
        /// <param name="isPreview">Set connector as preview</param>
        public Availability(int? status = default(int?), bool? isPreview = default(bool?))
        {
            Status = status;
            IsPreview = isPreview;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the connector Availability Status
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public int? Status { get; set; }

        /// <summary>
        /// Gets or sets set connector as preview
        /// </summary>
        [JsonProperty(PropertyName = "isPreview")]
        public bool? IsPreview { get; set; }

    }
}
