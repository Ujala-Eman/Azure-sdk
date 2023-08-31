// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Deployment on error behavior. </summary>
    public partial class ErrorDeployment
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ErrorDeployment"/>. </summary>
        public ErrorDeployment()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ErrorDeployment"/>. </summary>
        /// <param name="deploymentType"> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </param>
        /// <param name="deploymentName"> The deployment to be used on error case. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ErrorDeployment(ErrorDeploymentType? deploymentType, string deploymentName, Dictionary<string, BinaryData> rawData)
        {
            DeploymentType = deploymentType;
            DeploymentName = deploymentName;
            _rawData = rawData;
        }

        /// <summary> The deployment on error behavior type. Possible values are LastSuccessful and SpecificDeployment. </summary>
        public ErrorDeploymentType? DeploymentType { get; set; }
        /// <summary> The deployment to be used on error case. </summary>
        public string DeploymentName { get; set; }
    }
}
