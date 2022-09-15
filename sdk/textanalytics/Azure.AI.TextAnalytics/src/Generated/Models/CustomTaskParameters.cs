// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.TextAnalytics.Models
{
    /// <summary> Parameters object for a text analysis task using custom models. </summary>
    internal partial class CustomTaskParameters : TaskParameters
    {
        /// <summary> Initializes a new instance of CustomTaskParameters. </summary>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="deploymentName"/> is null. </exception>
        public CustomTaskParameters(string projectName, string deploymentName)
        {
            if (projectName == null)
            {
                throw new ArgumentNullException(nameof(projectName));
            }
            if (deploymentName == null)
            {
                throw new ArgumentNullException(nameof(deploymentName));
            }

            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> Initializes a new instance of CustomTaskParameters. </summary>
        /// <param name="loggingOptOut"></param>
        /// <param name="projectName"> This field indicates the project name for the model. </param>
        /// <param name="deploymentName"> This field indicates the deployment name for the model. </param>
        internal CustomTaskParameters(bool? loggingOptOut, string projectName, string deploymentName) : base(loggingOptOut)
        {
            ProjectName = projectName;
            DeploymentName = deploymentName;
        }

        /// <summary> This field indicates the project name for the model. </summary>
        public string ProjectName { get; set; }
        /// <summary> This field indicates the deployment name for the model. </summary>
        public string DeploymentName { get; set; }
    }
}
