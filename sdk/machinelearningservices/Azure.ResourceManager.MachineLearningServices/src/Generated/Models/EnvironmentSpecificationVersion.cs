// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearningServices
{
    /// <summary>
    /// Environment specification version details.
    /// 
    /// &lt;see href=&quot;https://repo2docker.readthedocs.io/en/latest/specification.html&quot; /&gt;.
    /// </summary>
    public partial class EnvironmentSpecificationVersion
    {
        /// <summary> Initializes a new instance of EnvironmentSpecificationVersion. </summary>
        public EnvironmentSpecificationVersion()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of EnvironmentSpecificationVersion. </summary>
        /// <param name="condaFile">
        /// Standard configuration file used by Conda that lets you install any kind of package, including Python, R, and C/C++ packages.
        /// 
        /// &lt;see href=&quot;https://repo2docker.readthedocs.io/en/latest/config_files.html#environment-yml-install-a-conda-environment&quot; /&gt;.
        /// </param>
        /// <param name="description"> The asset description text. </param>
        /// <param name="docker"> Configuration settings for Docker. </param>
        /// <param name="environmentSpecificationType">
        /// Environment specification is either user managed or curated by the Azure ML service
        /// 
        /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/resource-curated-environments&quot; /&gt;.
        /// </param>
        /// <param name="inferenceContainerProperties"> Defines configuration specific to inference. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        internal EnvironmentSpecificationVersion(string condaFile, string description, DockerSpecification docker, EnvironmentSpecificationType? environmentSpecificationType, InferenceContainerProperties inferenceContainerProperties, bool? isAnonymous, IDictionary<string, string> properties, IDictionary<string, string> tags)
        {
            CondaFile = condaFile;
            Description = description;
            Docker = docker;
            EnvironmentSpecificationType = environmentSpecificationType;
            InferenceContainerProperties = inferenceContainerProperties;
            IsAnonymous = isAnonymous;
            Properties = properties;
            Tags = tags;
        }

        /// <summary>
        /// Standard configuration file used by Conda that lets you install any kind of package, including Python, R, and C/C++ packages.
        /// 
        /// &lt;see href=&quot;https://repo2docker.readthedocs.io/en/latest/config_files.html#environment-yml-install-a-conda-environment&quot; /&gt;.
        /// </summary>
        public string CondaFile { get; set; }
        /// <summary> The asset description text. </summary>
        public string Description { get; set; }
        /// <summary> Configuration settings for Docker. </summary>
        public DockerSpecification Docker { get; set; }
        /// <summary>
        /// Environment specification is either user managed or curated by the Azure ML service
        /// 
        /// &lt;see href=&quot;https://docs.microsoft.com/en-us/azure/machine-learning/resource-curated-environments&quot; /&gt;.
        /// </summary>
        public EnvironmentSpecificationType? EnvironmentSpecificationType { get; }
        /// <summary> Defines configuration specific to inference. </summary>
        public InferenceContainerProperties InferenceContainerProperties { get; set; }
        /// <summary> If the name version are system generated (anonymous registration). </summary>
        public bool? IsAnonymous { get; set; }
        /// <summary> The asset property dictionary. </summary>
        public IDictionary<string, string> Properties { get; }
        /// <summary> Tag dictionary. Tags can be added, removed, and updated. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
