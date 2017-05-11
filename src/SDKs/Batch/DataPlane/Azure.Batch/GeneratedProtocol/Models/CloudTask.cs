// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// An Azure Batch task.
    /// </summary>
    public partial class CloudTask
    {
        /// <summary>
        /// Initializes a new instance of the CloudTask class.
        /// </summary>
        public CloudTask() { }

        /// <summary>
        /// Initializes a new instance of the CloudTask class.
        /// </summary>
        /// <param name="id">A string that uniquely identifies the task within
        /// the job.</param>
        /// <param name="displayName">A display name for the task.</param>
        /// <param name="url">The URL of the task.</param>
        /// <param name="eTag">The ETag of the task.</param>
        /// <param name="lastModified">The last modified time of the
        /// task.</param>
        /// <param name="creationTime">The creation time of the task.</param>
        /// <param name="exitConditions">How the Batch service should respond
        /// when the task completes.</param>
        /// <param name="state">The current state of the task.</param>
        /// <param name="stateTransitionTime">The time at which the task
        /// entered its current state.</param>
        /// <param name="previousState">The previous state of the task.</param>
        /// <param name="previousStateTransitionTime">The time at which the
        /// task entered its previous state.</param>
        /// <param name="commandLine">The command line of the task.</param>
        /// <param name="resourceFiles">A list of files that the Batch service
        /// will download to the compute node before running the command
        /// line.</param>
        /// <param name="outputFiles">A list of files that the Batch service
        /// will upload from the compute node after running the command
        /// line.</param>
        /// <param name="environmentSettings">A list of environment variable
        /// settings for the task.</param>
        /// <param name="affinityInfo">A locality hint that can be used by the
        /// Batch service to select a compute node on which to start the new
        /// task.</param>
        /// <param name="constraints">The execution constraints that apply to
        /// this task.</param>
        /// <param name="userIdentity">The user identity under which the task
        /// runs.</param>
        /// <param name="executionInfo">Information about the execution of the
        /// task.</param>
        /// <param name="nodeInfo">Information about the compute node on which
        /// the task ran.</param>
        /// <param name="multiInstanceSettings">An object that indicates that
        /// the task is a multi-instance task, and contains information about
        /// how to run the multi-instance task.</param>
        /// <param name="stats">Resource usage statistics for the task.</param>
        /// <param name="dependsOn">The tasks that this task depends
        /// on.</param>
        /// <param name="applicationPackageReferences">A list of application
        /// packages that the Batch service will deploy to the compute node
        /// before running the command line.</param>
        /// <param name="authenticationTokenSettings">The settings for an
        /// authentication token that the task can use to perform Batch service
        /// operations.</param>
        public CloudTask(string id = default(string), string displayName = default(string), string url = default(string), string eTag = default(string), System.DateTime? lastModified = default(System.DateTime?), System.DateTime? creationTime = default(System.DateTime?), ExitConditions exitConditions = default(ExitConditions), TaskState? state = default(TaskState?), System.DateTime? stateTransitionTime = default(System.DateTime?), TaskState? previousState = default(TaskState?), System.DateTime? previousStateTransitionTime = default(System.DateTime?), string commandLine = default(string), System.Collections.Generic.IList<ResourceFile> resourceFiles = default(System.Collections.Generic.IList<ResourceFile>), System.Collections.Generic.IList<OutputFile> outputFiles = default(System.Collections.Generic.IList<OutputFile>), System.Collections.Generic.IList<EnvironmentSetting> environmentSettings = default(System.Collections.Generic.IList<EnvironmentSetting>), AffinityInformation affinityInfo = default(AffinityInformation), TaskConstraints constraints = default(TaskConstraints), UserIdentity userIdentity = default(UserIdentity), TaskExecutionInformation executionInfo = default(TaskExecutionInformation), ComputeNodeInformation nodeInfo = default(ComputeNodeInformation), MultiInstanceSettings multiInstanceSettings = default(MultiInstanceSettings), TaskStatistics stats = default(TaskStatistics), TaskDependencies dependsOn = default(TaskDependencies), System.Collections.Generic.IList<ApplicationPackageReference> applicationPackageReferences = default(System.Collections.Generic.IList<ApplicationPackageReference>), AuthenticationTokenSettings authenticationTokenSettings = default(AuthenticationTokenSettings))
        {
            Id = id;
            DisplayName = displayName;
            Url = url;
            ETag = eTag;
            LastModified = lastModified;
            CreationTime = creationTime;
            ExitConditions = exitConditions;
            State = state;
            StateTransitionTime = stateTransitionTime;
            PreviousState = previousState;
            PreviousStateTransitionTime = previousStateTransitionTime;
            CommandLine = commandLine;
            ResourceFiles = resourceFiles;
            OutputFiles = outputFiles;
            EnvironmentSettings = environmentSettings;
            AffinityInfo = affinityInfo;
            Constraints = constraints;
            UserIdentity = userIdentity;
            ExecutionInfo = executionInfo;
            NodeInfo = nodeInfo;
            MultiInstanceSettings = multiInstanceSettings;
            Stats = stats;
            DependsOn = dependsOn;
            ApplicationPackageReferences = applicationPackageReferences;
            AuthenticationTokenSettings = authenticationTokenSettings;
        }

        /// <summary>
        /// Gets or sets a string that uniquely identifies the task within the
        /// job.
        /// </summary>
        /// <remarks>
        /// The ID can contain any combination of alphanumeric characters
        /// including hyphens and underscores, and cannot contain more than 64
        /// characters.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets a display name for the task.
        /// </summary>
        /// <remarks>
        /// The display name need not be unique and can contain any Unicode
        /// characters up to a maximum length of 1024.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets the URL of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets the ETag of the task.
        /// </summary>
        /// <remarks>
        /// This is an opaque string. You can use it to detect whether the task
        /// has changed between requests. In particular, you can be pass the
        /// ETag when updating a task to specify that your changes should take
        /// effect only if nobody else has modified the task in the meantime.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "eTag")]
        public string ETag { get; set; }

        /// <summary>
        /// Gets or sets the last modified time of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "lastModified")]
        public System.DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets or sets the creation time of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "creationTime")]
        public System.DateTime? CreationTime { get; set; }

        /// <summary>
        /// Gets or sets how the Batch service should respond when the task
        /// completes.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "exitConditions")]
        public ExitConditions ExitConditions { get; set; }

        /// <summary>
        /// Gets or sets the current state of the task.
        /// </summary>
        /// <remarks>
        /// Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "state")]
        public TaskState? State { get; set; }

        /// <summary>
        /// Gets or sets the time at which the task entered its current state.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stateTransitionTime")]
        public System.DateTime? StateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the previous state of the task.
        /// </summary>
        /// <remarks>
        /// This property is not set if the task is in its initial Active
        /// state. Possible values include: 'active', 'preparing', 'running',
        /// 'completed'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousState")]
        public TaskState? PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the time at which the task entered its previous state.
        /// </summary>
        /// <remarks>
        /// This property is not set if the task is in its initial Active
        /// state.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "previousStateTransitionTime")]
        public System.DateTime? PreviousStateTransitionTime { get; set; }

        /// <summary>
        /// Gets or sets the command line of the task.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the command line is executed as the
        /// primary task, after the primary task and all subtasks have finished
        /// executing the coordination command line. The command line does not
        /// run under a shell, and therefore cannot take advantage of shell
        /// features such as environment variable expansion. If you want to
        /// take advantage of such features, you should invoke the shell in the
        /// command line, for example using "cmd /c MyCommand" in Windows or
        /// "/bin/sh -c MyCommand" in Linux.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "commandLine")]
        public string CommandLine { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will download
        /// to the compute node before running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the resource files will only be
        /// downloaded to the compute node on which the primary task is
        /// executed.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "resourceFiles")]
        public System.Collections.Generic.IList<ResourceFile> ResourceFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of files that the Batch service will upload
        /// from the compute node after running the command line.
        /// </summary>
        /// <remarks>
        /// For multi-instance tasks, the files will only be uploaded from the
        /// compute node on which the primary task is executed.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "outputFiles")]
        public System.Collections.Generic.IList<OutputFile> OutputFiles { get; set; }

        /// <summary>
        /// Gets or sets a list of environment variable settings for the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "environmentSettings")]
        public System.Collections.Generic.IList<EnvironmentSetting> EnvironmentSettings { get; set; }

        /// <summary>
        /// Gets or sets a locality hint that can be used by the Batch service
        /// to select a compute node on which to start the new task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "affinityInfo")]
        public AffinityInformation AffinityInfo { get; set; }

        /// <summary>
        /// Gets or sets the execution constraints that apply to this task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "constraints")]
        public TaskConstraints Constraints { get; set; }

        /// <summary>
        /// Gets or sets the user identity under which the task runs.
        /// </summary>
        /// <remarks>
        /// If omitted, the task runs as a non-administrative user unique to
        /// the task.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "userIdentity")]
        public UserIdentity UserIdentity { get; set; }

        /// <summary>
        /// Gets or sets information about the execution of the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "executionInfo")]
        public TaskExecutionInformation ExecutionInfo { get; set; }

        /// <summary>
        /// Gets or sets information about the compute node on which the task
        /// ran.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "nodeInfo")]
        public ComputeNodeInformation NodeInfo { get; set; }

        /// <summary>
        /// Gets or sets an object that indicates that the task is a
        /// multi-instance task, and contains information about how to run the
        /// multi-instance task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "multiInstanceSettings")]
        public MultiInstanceSettings MultiInstanceSettings { get; set; }

        /// <summary>
        /// Gets or sets resource usage statistics for the task.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "stats")]
        public TaskStatistics Stats { get; set; }

        /// <summary>
        /// Gets or sets the tasks that this task depends on.
        /// </summary>
        /// <remarks>
        /// This task will not be scheduled until all tasks that it depends on
        /// have completed successfully. If any of those tasks fail and exhaust
        /// their retry counts, this task will never be scheduled.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "dependsOn")]
        public TaskDependencies DependsOn { get; set; }

        /// <summary>
        /// Gets or sets a list of application packages that the Batch service
        /// will deploy to the compute node before running the command line.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "applicationPackageReferences")]
        public System.Collections.Generic.IList<ApplicationPackageReference> ApplicationPackageReferences { get; set; }

        /// <summary>
        /// Gets or sets the settings for an authentication token that the task
        /// can use to perform Batch service operations.
        /// </summary>
        /// <remarks>
        /// If this property is set, the Batch service provides the task with
        /// an authentication token which can be used to authenticate Batch
        /// service operations without requiring an account access key. The
        /// token is provided via the AZ_BATCH_AUTHENTICATION_TOKEN environment
        /// variable. The operations that the task can carry out using the
        /// token depend on the settings. For example, a task can request job
        /// permissions in order to add other tasks to the job, or check the
        /// status of the job or of other tasks under the job.
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "authenticationTokenSettings")]
        public AuthenticationTokenSettings AuthenticationTokenSettings { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (this.ResourceFiles != null)
            {
                foreach (var element in this.ResourceFiles)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.OutputFiles != null)
            {
                foreach (var element1 in this.OutputFiles)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.EnvironmentSettings != null)
            {
                foreach (var element2 in this.EnvironmentSettings)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
            if (this.AffinityInfo != null)
            {
                this.AffinityInfo.Validate();
            }
            if (this.ExecutionInfo != null)
            {
                this.ExecutionInfo.Validate();
            }
            if (this.MultiInstanceSettings != null)
            {
                this.MultiInstanceSettings.Validate();
            }
            if (this.Stats != null)
            {
                this.Stats.Validate();
            }
            if (this.ApplicationPackageReferences != null)
            {
                foreach (var element3 in this.ApplicationPackageReferences)
                {
                    if (element3 != null)
                    {
                        element3.Validate();
                    }
                }
            }
        }
    }
}
