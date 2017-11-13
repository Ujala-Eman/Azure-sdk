// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Description of a backup schedule. Describes how often should be the
    /// backup performed and what should be the retention policy.
    /// </summary>
    public partial class BackupSchedule
    {
        /// <summary>
        /// Initializes a new instance of the BackupSchedule class.
        /// </summary>
        public BackupSchedule()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the BackupSchedule class.
        /// </summary>
        /// <param name="frequencyInterval">How often the backup should be
        /// executed (e.g. for weekly backup, this should be set to 7 and
        /// FrequencyUnit should be set to Day)</param>
        /// <param name="frequencyUnit">The unit of time for how often the
        /// backup should be executed (e.g. for weekly backup, this should be
        /// set to Day and FrequencyInterval should be set to 7). Possible
        /// values include: 'Day', 'Hour'</param>
        /// <param name="keepAtLeastOneBackup">True if the retention policy
        /// should always keep at least one backup in the storage account,
        /// regardless how old it is; false otherwise.</param>
        /// <param name="retentionPeriodInDays">After how many days backups
        /// should be deleted.</param>
        /// <param name="startTime">When the schedule should start
        /// working.</param>
        /// <param name="lastExecutionTime">Last time when this schedule was
        /// triggered.</param>
        public BackupSchedule(int frequencyInterval, FrequencyUnit frequencyUnit, bool keepAtLeastOneBackup, int retentionPeriodInDays, System.DateTime? startTime = default(System.DateTime?), System.DateTime? lastExecutionTime = default(System.DateTime?))
        {
            FrequencyInterval = frequencyInterval;
            FrequencyUnit = frequencyUnit;
            KeepAtLeastOneBackup = keepAtLeastOneBackup;
            RetentionPeriodInDays = retentionPeriodInDays;
            StartTime = startTime;
            LastExecutionTime = lastExecutionTime;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets how often the backup should be executed (e.g. for
        /// weekly backup, this should be set to 7 and FrequencyUnit should be
        /// set to Day)
        /// </summary>
        [JsonProperty(PropertyName = "frequencyInterval")]
        public int FrequencyInterval { get; set; }

        /// <summary>
        /// Gets or sets the unit of time for how often the backup should be
        /// executed (e.g. for weekly backup, this should be set to Day and
        /// FrequencyInterval should be set to 7). Possible values include:
        /// 'Day', 'Hour'
        /// </summary>
        [JsonProperty(PropertyName = "frequencyUnit")]
        public FrequencyUnit FrequencyUnit { get; set; }

        /// <summary>
        /// Gets or sets true if the retention policy should always keep at
        /// least one backup in the storage account, regardless how old it is;
        /// false otherwise.
        /// </summary>
        [JsonProperty(PropertyName = "keepAtLeastOneBackup")]
        public bool KeepAtLeastOneBackup { get; set; }

        /// <summary>
        /// Gets or sets after how many days backups should be deleted.
        /// </summary>
        [JsonProperty(PropertyName = "retentionPeriodInDays")]
        public int RetentionPeriodInDays { get; set; }

        /// <summary>
        /// Gets or sets when the schedule should start working.
        /// </summary>
        [JsonProperty(PropertyName = "startTime")]
        public System.DateTime? StartTime { get; set; }

        /// <summary>
        /// Gets last time when this schedule was triggered.
        /// </summary>
        [JsonProperty(PropertyName = "lastExecutionTime")]
        public System.DateTime? LastExecutionTime { get; private set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
