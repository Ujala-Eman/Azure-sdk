// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Build properties for the static site. </summary>
    public partial class StaticSiteBuildProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StaticSiteBuildProperties"/>. </summary>
        public StaticSiteBuildProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StaticSiteBuildProperties"/>. </summary>
        /// <param name="appLocation"> The path to the app code within the repository. </param>
        /// <param name="apiLocation"> The path to the api code within the repository. </param>
        /// <param name="appArtifactLocation"> Deprecated: The path of the app artifacts after building (deprecated in favor of OutputLocation). </param>
        /// <param name="outputLocation"> The output path of the app after building. </param>
        /// <param name="appBuildCommand"> A custom command to run during deployment of the static content application. </param>
        /// <param name="apiBuildCommand"> A custom command to run during deployment of the Azure Functions API application. </param>
        /// <param name="skipGithubActionWorkflowGeneration"> Skip Github Action workflow generation. </param>
        /// <param name="githubActionSecretNameOverride"> Github Action secret name override. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StaticSiteBuildProperties(string appLocation, string apiLocation, string appArtifactLocation, string outputLocation, string appBuildCommand, string apiBuildCommand, bool? skipGithubActionWorkflowGeneration, string githubActionSecretNameOverride, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            AppLocation = appLocation;
            ApiLocation = apiLocation;
            AppArtifactLocation = appArtifactLocation;
            OutputLocation = outputLocation;
            AppBuildCommand = appBuildCommand;
            ApiBuildCommand = apiBuildCommand;
            SkipGithubActionWorkflowGeneration = skipGithubActionWorkflowGeneration;
            GithubActionSecretNameOverride = githubActionSecretNameOverride;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The path to the app code within the repository. </summary>
        public string AppLocation { get; set; }
        /// <summary> The path to the api code within the repository. </summary>
        public string ApiLocation { get; set; }
        /// <summary> Deprecated: The path of the app artifacts after building (deprecated in favor of OutputLocation). </summary>
        public string AppArtifactLocation { get; set; }
        /// <summary> The output path of the app after building. </summary>
        public string OutputLocation { get; set; }
        /// <summary> A custom command to run during deployment of the static content application. </summary>
        public string AppBuildCommand { get; set; }
        /// <summary> A custom command to run during deployment of the Azure Functions API application. </summary>
        public string ApiBuildCommand { get; set; }
        /// <summary> Skip Github Action workflow generation. </summary>
        public bool? SkipGithubActionWorkflowGeneration { get; set; }
        /// <summary> Github Action secret name override. </summary>
        public string GithubActionSecretNameOverride { get; set; }
    }
}
