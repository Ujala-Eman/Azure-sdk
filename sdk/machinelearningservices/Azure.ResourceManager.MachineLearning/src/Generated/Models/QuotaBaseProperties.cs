// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The properties for Quota update or retrieval. </summary>
    public partial class QuotaBaseProperties
    {
        /// <summary> Initializes a new instance of <see cref="QuotaBaseProperties"/>. </summary>
        public QuotaBaseProperties()
        {
        }

        /// <summary> Specifies the resource ID. </summary>
        public string Id { get; set; }
        /// <summary> Specifies the resource type. </summary>
        public string QuotaBasePropertiesType { get; set; }
        /// <summary> The maximum permitted quota of the resource. </summary>
        public long? Limit { get; set; }
        /// <summary> An enum describing the unit of quota measurement. </summary>
        public QuotaUnit? Unit { get; set; }
    }
}
