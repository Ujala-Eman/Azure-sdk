// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Network.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Network;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Parameters that define the retention policy for flow log.
    /// </summary>
    public partial class RetentionPolicyParameters
    {
        /// <summary>
        /// Initializes a new instance of the RetentionPolicyParameters class.
        /// </summary>
        public RetentionPolicyParameters()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RetentionPolicyParameters class.
        /// </summary>
        /// <param name="days">Number of days to retain flow log
        /// records.</param>
        /// <param name="enabled">Flag to enable/disable retention.</param>
        public RetentionPolicyParameters(int? days = default(int?), bool? enabled = default(bool?))
        {
            Days = days;
            Enabled = enabled;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of days to retain flow log records.
        /// </summary>
        [JsonProperty(PropertyName = "days")]
        public int? Days { get; set; }

        /// <summary>
        /// Gets or sets flag to enable/disable retention.
        /// </summary>
        [JsonProperty(PropertyName = "enabled")]
        public bool? Enabled { get; set; }

    }
}
