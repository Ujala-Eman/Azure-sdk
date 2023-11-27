// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The configuration that services will be excluded when creating cluster. </summary>
    public partial class ExcludedServicesConfig
    {
        /// <summary> Initializes a new instance of <see cref="ExcludedServicesConfig"/>. </summary>
        public ExcludedServicesConfig()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ExcludedServicesConfig"/>. </summary>
        /// <param name="excludedServicesConfigId"> The config id of excluded services. </param>
        /// <param name="excludedServicesList"> The list of excluded services. </param>
        internal ExcludedServicesConfig(string excludedServicesConfigId, string excludedServicesList)
        {
            ExcludedServicesConfigId = excludedServicesConfigId;
            ExcludedServicesList = excludedServicesList;
        }

        /// <summary> The config id of excluded services. </summary>
        public string ExcludedServicesConfigId { get; set; }
        /// <summary> The list of excluded services. </summary>
        public string ExcludedServicesList { get; set; }
    }
}
