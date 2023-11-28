// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> Azure ML Execute Pipeline activity. </summary>
    public partial class AzureMLExecutePipelineActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of <see cref="AzureMLExecutePipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="mlPipelineId"> ID of the published Azure ML pipeline. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="mlPipelineId"/> is null. </exception>
        public AzureMLExecutePipelineActivity(string name, object mlPipelineId) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(mlPipelineId, nameof(mlPipelineId));

            MlPipelineId = mlPipelineId;
            Type = "AzureMLExecutePipeline";
        }

        /// <summary> Initializes a new instance of <see cref="AzureMLExecutePipelineActivity"/>. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="type"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="state"> Activity state. This is an optional property and if not provided, the state will be Active by default. </param>
        /// <param name="onInactiveMarkAs"> Status result of the activity when the state is set to Inactive. This is an optional property and if not provided when the activity is inactive, the status will be Succeeded by default. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="mlPipelineId"> ID of the published Azure ML pipeline. Type: string (or Expression with resultType string). </param>
        /// <param name="experimentName"> Run history experiment name of the pipeline run. This information will be passed in the ExperimentName property of the published pipeline execution request. Type: string (or Expression with resultType string). </param>
        /// <param name="mlPipelineParameters"> Key,Value pairs to be passed to the published Azure ML pipeline endpoint. Keys must match the names of pipeline parameters defined in the published pipeline. Values will be passed in the ParameterAssignments property of the published pipeline execution request. Type: object with key value pairs (or Expression with resultType object). </param>
        /// <param name="mlParentRunId"> The parent Azure ML Service pipeline run id. This information will be passed in the ParentRunId property of the published pipeline execution request. Type: string (or Expression with resultType string). </param>
        /// <param name="continueOnStepFailure"> Whether to continue execution of other steps in the PipelineRun if a step fails. This information will be passed in the continueOnStepFailure property of the published pipeline execution request. Type: boolean (or Expression with resultType boolean). </param>
        internal AzureMLExecutePipelineActivity(string name, string type, string description, ActivityState? state, ActivityOnInactiveMarkAs? onInactiveMarkAs, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, object> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, object mlPipelineId, object experimentName, object mlPipelineParameters, object mlParentRunId, object continueOnStepFailure) : base(name, type, description, state, onInactiveMarkAs, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            MlPipelineId = mlPipelineId;
            ExperimentName = experimentName;
            MlPipelineParameters = mlPipelineParameters;
            MlParentRunId = mlParentRunId;
            ContinueOnStepFailure = continueOnStepFailure;
            Type = type ?? "AzureMLExecutePipeline";
        }

        /// <summary> ID of the published Azure ML pipeline. Type: string (or Expression with resultType string). </summary>
        public object MlPipelineId { get; set; }
        /// <summary> Run history experiment name of the pipeline run. This information will be passed in the ExperimentName property of the published pipeline execution request. Type: string (or Expression with resultType string). </summary>
        public object ExperimentName { get; set; }
        /// <summary> Key,Value pairs to be passed to the published Azure ML pipeline endpoint. Keys must match the names of pipeline parameters defined in the published pipeline. Values will be passed in the ParameterAssignments property of the published pipeline execution request. Type: object with key value pairs (or Expression with resultType object). </summary>
        public object MlPipelineParameters { get; set; }
        /// <summary> The parent Azure ML Service pipeline run id. This information will be passed in the ParentRunId property of the published pipeline execution request. Type: string (or Expression with resultType string). </summary>
        public object MlParentRunId { get; set; }
        /// <summary> Whether to continue execution of other steps in the PipelineRun if a step fails. This information will be passed in the continueOnStepFailure property of the published pipeline execution request. Type: boolean (or Expression with resultType boolean). </summary>
        public object ContinueOnStepFailure { get; set; }
    }
}
