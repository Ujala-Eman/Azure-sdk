// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.HDInsight.Models
{
    /// <summary> The cluster create request specification. </summary>
    public partial class HDInsightClusterCreationValidateContent : HDInsightClusterCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of HDInsightClusterCreationValidateContent. </summary>
        public HDInsightClusterCreationValidateContent()
        {
        }

        /// <summary> The cluster name. </summary>
        public string Name { get; set; }
        /// <summary> The resource type. </summary>
        public string ClusterCreateRequestValidationParametersType { get; set; }
        /// <summary> The tenant id. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> This indicates whether fetch Aadds resource or not. </summary>
        public bool? FetchAaddsResource { get; set; }
    }
}
