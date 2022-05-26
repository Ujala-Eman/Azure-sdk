// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Batch endpoint default values. </summary>
    internal partial class BatchEndpointDefaults
    {
        /// <summary> Initializes a new instance of BatchEndpointDefaults. </summary>
        public BatchEndpointDefaults()
        {
        }

        /// <summary> Initializes a new instance of BatchEndpointDefaults. </summary>
        /// <param name="deploymentName">
        /// Name of the deployment that will be default for the endpoint.
        /// This deployment will end up getting 100% traffic when the endpoint scoring URL is invoked.
        /// </param>
        internal BatchEndpointDefaults(string deploymentName)
        {
            DeploymentName = deploymentName;
        }

        /// <summary>
        /// Name of the deployment that will be default for the endpoint.
        /// This deployment will end up getting 100% traffic when the endpoint scoring URL is invoked.
        /// </summary>
        public string DeploymentName { get; set; }
    }
}
