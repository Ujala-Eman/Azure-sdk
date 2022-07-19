// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Static site zip deployment ARM resource. </summary>
    public partial class StaticSiteZipDeploymentARM : ResourceData
    {
        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARM. </summary>
        public StaticSiteZipDeploymentARM()
        {
        }

        /// <summary> Initializes a new instance of StaticSiteZipDeploymentARM. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="appZipUri"> URL for the zipped app content. </param>
        /// <param name="apiZipUri"> URL for the zipped api content. </param>
        /// <param name="deploymentTitle"> A title to label the deployment. </param>
        /// <param name="provider"> The provider submitting this deployment. </param>
        /// <param name="functionLanguage"> The language of the api content, if it exists. </param>
        /// <param name="kind"> Kind of resource. </param>
        internal StaticSiteZipDeploymentARM(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Uri appZipUri, Uri apiZipUri, string deploymentTitle, string provider, string functionLanguage, string kind) : base(id, name, resourceType, systemData)
        {
            AppZipUri = appZipUri;
            ApiZipUri = apiZipUri;
            DeploymentTitle = deploymentTitle;
            Provider = provider;
            FunctionLanguage = functionLanguage;
            Kind = kind;
        }

        /// <summary> URL for the zipped app content. </summary>
        public Uri AppZipUri { get; set; }
        /// <summary> URL for the zipped api content. </summary>
        public Uri ApiZipUri { get; set; }
        /// <summary> A title to label the deployment. </summary>
        public string DeploymentTitle { get; set; }
        /// <summary> The provider submitting this deployment. </summary>
        public string Provider { get; set; }
        /// <summary> The language of the api content, if it exists. </summary>
        public string FunctionLanguage { get; set; }
        /// <summary> Kind of resource. </summary>
        public string Kind { get; set; }
    }
}
