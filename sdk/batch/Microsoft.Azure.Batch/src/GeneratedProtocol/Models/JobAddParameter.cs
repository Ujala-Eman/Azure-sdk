// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// An Azure Batch Job to add.
    /// </summary>
    public partial class JobAddParameter
    {
        /// <summary>
        /// Initializes a new instance of the JobAddParameter class.
        /// </summary>
        public JobAddParameter()
        {
            PoolInfo = new PoolInformation();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobAddParameter class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the Job within
        /// the Account.</param>
        /// <param name="poolInfo">The Pool on which the Batch service runs the
        /// Job's Tasks.</param>
        /// <param name="displayName">The display name for the Job.</param>
        /// <param name="priority">The priority of the Job.</param>
        /// <param name="maxParallelTasks">The maximum number of tasks that can
        /// be executed in parallel for the job.</param>
        /// <param name="allowTaskPreemption">Whether Tasks in this job can be
        /// preempted by other high priority jobs</param>
        /// <param name="constraints">The execution constraints for the
        /// Job.</param>
        /// <param name="jobManagerTask">Details of a Job Manager Task to be
        /// launched when the Job is started.</param>
        /// <param name="jobPreparationTask">The Job Preparation Task.</param>
        /// <param name="jobReleaseTask">The Job Release Task.</param>
        /// <param name="commonEnvironmentSettings">The list of common
        /// environment variable settings. These environment variables are set
        /// for all Tasks in the Job (including the Job Manager, Job
        /// Preparation and Job Release Tasks).</param>
        /// <param name="onAllTasksComplete">The action the Batch service
        /// should take when all Tasks in the Job are in the completed
        /// state.</param>
        /// <param name="onTaskFailure">The action the Batch service should
        /// take when any Task in the Job fails.</param>
        /// <param name="metadata">A list of name-value pairs associated with
        /// the Job as metadata.</param>
        /// <param name="usesTaskDependencies">Whether Tasks in the Job can
        /// define dependencies on each other. The default is false.</param>
        /// <param name="networkConfiguration">The network configuration for
        /// the Job.</param>
        public JobAddParameter(string id, PoolInformation poolInfo, string displayName = default(string), int? priority = default(int?), int? maxParallelTasks = default(int?), bool? allowTaskPreemption = default(bool?), JobConstraints constraints = default(JobConstraints), JobManagerTask jobManagerTask = default(JobManagerTask), JobPreparationTask jobPreparationTask = default(JobPreparationTask), JobReleaseTask jobReleaseTask = default(JobReleaseTask), IList<EnvironmentSetting> commonEnvironmentSettings = default(IList<EnvironmentSetting>), OnAllTasksComplete? onAllTasksComplete = default(OnAllTasksComplete?), OnTaskFailure? onTaskFailure = default(OnTaskFailure?), IList<MetadataItem> metadata = default(IList<MetadataItem>), bool? usesTaskDependencies = default(bool?), JobNetworkConfiguration networkConfiguration = default(JobNetworkConfiguration))
        {
            Id = id;
            DisplayName = displayName;
            Priority = priority;
            MaxParallelTasks = maxParallelTasks;
            AllowTaskPreemption = allowTaskPreemption;
            Constraints = constraints;
            JobManagerTask = jobManagerTask;
            JobPreparationTask = jobPreparationTask;
            JobReleaseTask = jobReleaseTask;
            CommonEnvironmentSettings = commonEnvironmentSettings;
            PoolInfo = poolInfo;
            OnAllTasksComplete = onAllTasksComplete;
            OnTaskFailure = onTaskFailure;
            Metadata = metadata;
            UsesTaskDependencies = usesTaskDependencies;
            NetworkConfiguration = networkConfiguration;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets a string that uniquely identifies the Job within the
        /// Account.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters. The ID is case-preserving and case-insensitive (that
        /// is, you may not have two IDs within an Account that differ only by
        /// case).
        /// </remarks>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the display name for the Job.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the priority of the Job.
        /// </summary>
        /// <remarks>
        /// Priority values can range from -1000 to 1000, with -1000 being the
        /// lowest priority and 1000 being the highest priority. The default
        /// value is 0.
        /// </remarks>
        [JsonProperty(PropertyName = "priority")]
        public int? Priority { get; set; }

        /// <summary>
        /// Gets or sets the maximum number of tasks that can be executed in
        /// parallel for the job.
        /// </summary>
        /// <remarks>
        /// The value of maxParallelTasks must be -1 or greater than 0 if
        /// specified. If not specified, the default value is -1, which means
        /// there's no limit to the number of tasks that can be run at once.
        /// You can update a job's maxParallelTasks after it has been created
        /// using the update job API.
        /// </remarks>
        [JsonProperty(PropertyName = "maxParallelTasks")]
        public int? MaxParallelTasks { get; set; }

        /// <summary>
        /// Gets or sets whether Tasks in this job can be preempted by other
        /// high priority jobs
        /// </summary>
        /// <remarks>
        /// If the value is set to True, other high priority jobs submitted to
        /// the system will take precedence and will be able requeue tasks from
        /// this job. You can update a job's allowTaskPreemption after it has
        /// been created using the update job API.
        /// </remarks>
        [JsonProperty(PropertyName = "allowTaskPreemption")]
        public bool? AllowTaskPreemption { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints for the Job.
        /// </summary>
        [JsonProperty(PropertyName = "constraints")]
        public JobConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets details of a Job Manager Task to be launched when the
        /// Job is started.
        /// </summary>
        /// <remarks>
        /// If the Job does not specify a Job Manager Task, the user must
        /// explicitly add Tasks to the Job. If the Job does specify a Job
        /// Manager Task, the Batch service creates the Job Manager Task when
        /// the Job is created, and will try to schedule the Job Manager Task
        /// before scheduling other Tasks in the Job. The Job Manager Task's
        /// typical purpose is to control and/or monitor Job execution, for
        /// example by deciding what additional Tasks to run, determining when
        /// the work is complete, etc. (However, a Job Manager Task is not
        /// restricted to these activities - it is a fully-fledged Task in the
        /// system and perform whatever actions are required for the Job.) For
        /// example, a Job Manager Task might download a file specified as a
        /// parameter, analyze the contents of that file and submit additional
        /// Tasks based on those contents.
        /// </remarks>
        [JsonProperty(PropertyName = "jobManagerTask")]
        public JobManagerTask JobManagerTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Preparation Task.
        /// </summary>
        /// <remarks>
        /// If a Job has a Job Preparation Task, the Batch service will run the
        /// Job Preparation Task on a Node before starting any Tasks of that
        /// Job on that Compute Node.
        /// </remarks>
        [JsonProperty(PropertyName = "jobPreparationTask")]
        public JobPreparationTask JobPreparationTask { get; set; }

        /// <summary>
        /// Gets or sets the Job Release Task.
        /// </summary>
        /// <remarks>
        /// A Job Release Task cannot be specified without also specifying a
        /// Job Preparation Task for the Job. The Batch service runs the Job
        /// Release Task on the Nodes that have run the Job Preparation Task.
        /// The primary purpose of the Job Release Task is to undo changes to
        /// Compute Nodes made by the Job Preparation Task. Example activities
        /// include deleting local files, or shutting down services that were
        /// started as part of Job preparation.
        /// </remarks>
        [JsonProperty(PropertyName = "jobReleaseTask")]
        public JobReleaseTask JobReleaseTask { get; set; }

        /// <summary>
        /// Gets or sets the list of common environment variable settings.
        /// These environment variables are set for all Tasks in the Job
        /// (including the Job Manager, Job Preparation and Job Release Tasks).
        /// </summary>
        /// <remarks>
        /// Individual Tasks can override an environment setting specified here
        /// by specifying the same setting name with a different value.
        /// </remarks>
        [JsonProperty(PropertyName = "commonEnvironmentSettings")]
        public IList<EnvironmentSetting> CommonEnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets the Pool on which the Batch service runs the Job's
        /// Tasks.
        /// </summary>
        [JsonProperty(PropertyName = "poolInfo")]
        public PoolInformation PoolInfo { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when all
        /// Tasks in the Job are in the completed state.
        /// </summary>
        /// <remarks>
        /// Note that if a Job contains no Tasks, then all Tasks are considered
        /// complete. This option is therefore most commonly used with a Job
        /// Manager task; if you want to use automatic Job termination without
        /// a Job Manager, you should initially set onAllTasksComplete to
        /// noaction and update the Job properties to set onAllTasksComplete to
        /// terminatejob once you have finished adding Tasks. The default is
        /// noaction. Possible values include: 'noAction', 'terminateJob'
        /// </remarks>
        [JsonProperty(PropertyName = "onAllTasksComplete")]
        public OnAllTasksComplete? OnAllTasksComplete { get; set; }

        /// <summary>
        /// Gets or sets the action the Batch service should take when any Task
        /// in the Job fails.
        /// </summary>
        /// <remarks>
        /// A Task is considered to have failed if has a failureInfo. A
        /// failureInfo is set if the Task completes with a non-zero exit code
        /// after exhausting its retry count, or if there was an error starting
        /// the Task, for example due to a resource file download error. The
        /// default is noaction. Possible values include: 'noAction',
        /// 'performExitOptionsJobAction'
        /// </remarks>
        [JsonProperty(PropertyName = "onTaskFailure")]
        public OnTaskFailure? OnTaskFailure { get; set; }

        /// <summary>
        /// Gets or sets a list of name-value pairs associated with the Job as
        /// metadata.
        /// </summary>
        /// <remarks>
        /// The Batch service does not assign any meaning to metadata; it is
        /// solely for the use of user code.
        /// </remarks>
        [JsonProperty(PropertyName = "metadata")]
        public IList<MetadataItem> Metadata { get; set; }

        /// <summary>
        /// Gets or sets whether Tasks in the Job can define dependencies on
        /// each other. The default is false.
        /// </summary>
        [JsonProperty(PropertyName = "usesTaskDependencies")]
        public bool? UsesTaskDependencies { get; set; }

        /// <summary>
        /// Gets or sets the network configuration for the Job.
        /// </summary>
        [JsonProperty(PropertyName = "networkConfiguration")]
        public JobNetworkConfiguration NetworkConfiguration { get; set; }

    }
}
