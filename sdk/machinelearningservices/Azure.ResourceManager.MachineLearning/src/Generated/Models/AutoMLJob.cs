// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// AutoMLJob class.
    /// Use this class for executing AutoML tasks like Classification/Regression etc.
    /// See TaskType enum for all the tasks supported.
    /// </summary>
    public partial class AutoMLJob : MachineLearningJobProperties
    {
        /// <summary> Initializes a new instance of <see cref="AutoMLJob"/>. </summary>
        /// <param name="taskDetails">
        /// [Required] This represents scenario which can be one of Tables/NLP/Image
        /// Please note <see cref="AutoMLVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ClassificationTask"/>, <see cref="MachineLearningForecasting"/>, <see cref="ImageClassification"/>, <see cref="ImageClassificationMultilabel"/>, <see cref="ImageInstanceSegmentation"/>, <see cref="ImageObjectDetection"/>, <see cref="AutoMLVerticalRegression"/>, <see cref="TextClassification"/>, <see cref="TextClassificationMultilabel"/> and <see cref="TextNer"/>.
        /// </param>
        /// <exception cref="ArgumentNullException"> <paramref name="taskDetails"/> is null. </exception>
        public AutoMLJob(AutoMLVertical taskDetails)
        {
            if (taskDetails == null)
            {
                throw new ArgumentNullException(nameof(taskDetails));
            }

            EnvironmentVariables = new ChangeTrackingDictionary<string, string>();
            Outputs = new ChangeTrackingDictionary<string, MachineLearningJobOutput>();
            TaskDetails = taskDetails;
            JobType = JobType.AutoML;
        }

        /// <summary> Initializes a new instance of <see cref="AutoMLJob"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="componentId"> ARM resource ID of the component resource. </param>
        /// <param name="computeId"> ARM resource ID of the compute resource. </param>
        /// <param name="displayName"> Display name of job. </param>
        /// <param name="experimentName"> The name of the experiment the job belongs to. If not set, the job is placed in the "Default" experiment. </param>
        /// <param name="identity">
        /// Identity configuration. If set, this should be one of AmlToken, ManagedIdentity, UserIdentity or null.
        /// Defaults to AmlToken if null.
        /// Please note <see cref="MachineLearningIdentityConfiguration"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmlToken"/>, <see cref="MachineLearningManagedIdentity"/> and <see cref="MachineLearningUserIdentity"/>.
        /// </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="jobType"> [Required] Specifies the type of job. </param>
        /// <param name="notificationSetting"> Notification setting for the job. </param>
        /// <param name="secretsConfiguration"> Configuration for secrets to be made available during runtime. </param>
        /// <param name="services">
        /// List of JobEndpoints.
        /// For local jobs, a job endpoint will have an endpoint value of FileStreamObject.
        /// </param>
        /// <param name="status"> Status of the job. </param>
        /// <param name="environmentId">
        /// The ARM resource ID of the Environment specification for the job.
        /// This is optional value to provide, if not provided, AutoML will default this to Production AutoML curated environment version when running the job.
        /// </param>
        /// <param name="environmentVariables"> Environment variables included in the job. </param>
        /// <param name="outputs">
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </param>
        /// <param name="queueSettings"> Queue settings for the job. </param>
        /// <param name="resources"> Compute Resource configuration for the job. </param>
        /// <param name="taskDetails">
        /// [Required] This represents scenario which can be one of Tables/NLP/Image
        /// Please note <see cref="AutoMLVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ClassificationTask"/>, <see cref="MachineLearningForecasting"/>, <see cref="ImageClassification"/>, <see cref="ImageClassificationMultilabel"/>, <see cref="ImageInstanceSegmentation"/>, <see cref="ImageObjectDetection"/>, <see cref="AutoMLVerticalRegression"/>, <see cref="TextClassification"/>, <see cref="TextClassificationMultilabel"/> and <see cref="TextNer"/>.
        /// </param>
        internal AutoMLJob(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData, ResourceIdentifier componentId, ResourceIdentifier computeId, string displayName, string experimentName, MachineLearningIdentityConfiguration identity, bool? isArchived, JobType jobType, NotificationSetting notificationSetting, IDictionary<string, SecretConfiguration> secretsConfiguration, IDictionary<string, MachineLearningJobService> services, MachineLearningJobStatus? status, string environmentId, IDictionary<string, string> environmentVariables, IDictionary<string, MachineLearningJobOutput> outputs, JobQueueSettings queueSettings, MachineLearningJobResourceConfiguration resources, AutoMLVertical taskDetails) : base(description, properties, tags, serializedAdditionalRawData, componentId, computeId, displayName, experimentName, identity, isArchived, jobType, notificationSetting, secretsConfiguration, services, status)
        {
            EnvironmentId = environmentId;
            EnvironmentVariables = environmentVariables;
            Outputs = outputs;
            QueueSettings = queueSettings;
            Resources = resources;
            TaskDetails = taskDetails;
            JobType = jobType;
        }

        /// <summary> Initializes a new instance of <see cref="AutoMLJob"/> for deserialization. </summary>
        internal AutoMLJob()
        {
        }

        /// <summary>
        /// The ARM resource ID of the Environment specification for the job.
        /// This is optional value to provide, if not provided, AutoML will default this to Production AutoML curated environment version when running the job.
        /// </summary>
        public string EnvironmentId { get; set; }
        /// <summary> Environment variables included in the job. </summary>
        public IDictionary<string, string> EnvironmentVariables { get; set; }
        /// <summary>
        /// Mapping of output data bindings used in the job.
        /// Please note <see cref="MachineLearningJobOutput"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MachineLearningCustomModelJobOutput"/>, <see cref="MachineLearningFlowModelJobOutput"/>, <see cref="MachineLearningTableJobOutput"/>, <see cref="MachineLearningTritonModelJobOutput"/>, <see cref="MachineLearningUriFileJobOutput"/> and <see cref="MachineLearningUriFolderJobOutput"/>.
        /// </summary>
        public IDictionary<string, MachineLearningJobOutput> Outputs { get; set; }
        /// <summary> Queue settings for the job. </summary>
        public JobQueueSettings QueueSettings { get; set; }
        /// <summary> Compute Resource configuration for the job. </summary>
        public MachineLearningJobResourceConfiguration Resources { get; set; }
        /// <summary>
        /// [Required] This represents scenario which can be one of Tables/NLP/Image
        /// Please note <see cref="AutoMLVertical"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="ClassificationTask"/>, <see cref="MachineLearningForecasting"/>, <see cref="ImageClassification"/>, <see cref="ImageClassificationMultilabel"/>, <see cref="ImageInstanceSegmentation"/>, <see cref="ImageObjectDetection"/>, <see cref="AutoMLVerticalRegression"/>, <see cref="TextClassification"/>, <see cref="TextClassificationMultilabel"/> and <see cref="TextNer"/>.
        /// </summary>
        public AutoMLVertical TaskDetails { get; set; }
    }
}
