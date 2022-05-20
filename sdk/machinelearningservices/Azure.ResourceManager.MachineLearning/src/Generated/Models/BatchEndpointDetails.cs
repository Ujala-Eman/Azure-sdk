// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Batch endpoint configuration. </summary>
    public partial class BatchEndpointDetails : EndpointPropertiesBase
    {
        /// <summary> Initializes a new instance of BatchEndpointDetails. </summary>
        /// <param name="authMode"> [Required] Use &apos;Key&apos; for key based authentication and &apos;AMLToken&apos; for Azure Machine Learning token-based authentication. &apos;Key&apos; doesn&apos;t expire but &apos;AMLToken&apos; does. </param>
        public BatchEndpointDetails(EndpointAuthMode authMode) : base(authMode)
        {
        }

        /// <summary> Initializes a new instance of BatchEndpointDetails. </summary>
        /// <param name="authMode"> [Required] Use &apos;Key&apos; for key based authentication and &apos;AMLToken&apos; for Azure Machine Learning token-based authentication. &apos;Key&apos; doesn&apos;t expire but &apos;AMLToken&apos; does. </param>
        /// <param name="description"> Description of the inference endpoint. </param>
        /// <param name="keys">
        /// EndpointAuthKeys to set initially on an Endpoint.
        /// This property will always be returned as null. AuthKey values must be retrieved using the ListKeys API.
        /// </param>
        /// <param name="properties"> Property dictionary. Properties can be added, but not removed or altered. </param>
        /// <param name="scoringUri"> Endpoint URI. </param>
        /// <param name="swaggerUri"> Endpoint Swagger URI. </param>
        /// <param name="defaults"> Default values for Batch Endpoint. </param>
        /// <param name="provisioningState"> Provisioning state for the endpoint. </param>
        internal BatchEndpointDetails(EndpointAuthMode authMode, string description, EndpointAuthKeys keys, IDictionary<string, string> properties, Uri scoringUri, Uri swaggerUri, BatchEndpointDefaults defaults, EndpointProvisioningState? provisioningState) : base(authMode, description, keys, properties, scoringUri, swaggerUri)
        {
            Defaults = defaults;
            ProvisioningState = provisioningState;
        }

        /// <summary> Default values for Batch Endpoint. </summary>
        internal BatchEndpointDefaults Defaults { get; set; }
        /// <summary>
        /// Name of the deployment that will be default for the endpoint.
        /// This deployment will end up getting 100% traffic when the endpoint scoring URL is invoked.
        /// </summary>
        public string DefaultsDeploymentName
        {
            get => Defaults is null ? default : Defaults.DeploymentName;
            set
            {
                if (Defaults is null)
                    Defaults = new BatchEndpointDefaults();
                Defaults.DeploymentName = value;
            }
        }

        /// <summary> Provisioning state for the endpoint. </summary>
        public EndpointProvisioningState? ProvisioningState { get; }
    }
}
