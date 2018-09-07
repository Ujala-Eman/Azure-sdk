// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.RecoveryServices.Backup.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Mab container-specific backup policy.
    /// </summary>
    [Newtonsoft.Json.JsonObject("MAB")]
    public partial class MabProtectionPolicy : ProtectionPolicy
    {
        /// <summary>
        /// Initializes a new instance of the MabProtectionPolicy class.
        /// </summary>
        public MabProtectionPolicy()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MabProtectionPolicy class.
        /// </summary>
        /// <param name="protectedItemsCount">Number of items associated with
        /// this policy.</param>
        /// <param name="schedulePolicy">Backup schedule of backup
        /// policy.</param>
        /// <param name="retentionPolicy">Retention policy details.</param>
        public MabProtectionPolicy(int? protectedItemsCount = default(int?), SchedulePolicy schedulePolicy = default(SchedulePolicy), RetentionPolicy retentionPolicy = default(RetentionPolicy))
            : base(protectedItemsCount)
        {
            SchedulePolicy = schedulePolicy;
            RetentionPolicy = retentionPolicy;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets backup schedule of backup policy.
        /// </summary>
        [JsonProperty(PropertyName = "schedulePolicy")]
        public SchedulePolicy SchedulePolicy { get; set; }

        /// <summary>
        /// Gets or sets retention policy details.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPolicy")]
        public RetentionPolicy RetentionPolicy { get; set; }

    }
}
