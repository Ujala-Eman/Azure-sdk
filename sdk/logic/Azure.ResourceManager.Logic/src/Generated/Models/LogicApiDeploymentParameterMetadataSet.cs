// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Logic.Models
{
    /// <summary> The API deployment parameters metadata. </summary>
    public partial class LogicApiDeploymentParameterMetadataSet
    {
        /// <summary> Initializes a new instance of LogicApiDeploymentParameterMetadataSet. </summary>
        internal LogicApiDeploymentParameterMetadataSet()
        {
        }

        /// <summary> Initializes a new instance of LogicApiDeploymentParameterMetadataSet. </summary>
        /// <param name="packageContentLink"> The package content link parameter. </param>
        /// <param name="redisCacheConnectionString"> The package content link parameter. </param>
        internal LogicApiDeploymentParameterMetadataSet(LogicApiDeploymentParameterMetadata packageContentLink, LogicApiDeploymentParameterMetadata redisCacheConnectionString)
        {
            PackageContentLink = packageContentLink;
            RedisCacheConnectionString = redisCacheConnectionString;
        }

        /// <summary> The package content link parameter. </summary>
        public LogicApiDeploymentParameterMetadata PackageContentLink { get; }
        /// <summary> The package content link parameter. </summary>
        public LogicApiDeploymentParameterMetadata RedisCacheConnectionString { get; }
    }
}
