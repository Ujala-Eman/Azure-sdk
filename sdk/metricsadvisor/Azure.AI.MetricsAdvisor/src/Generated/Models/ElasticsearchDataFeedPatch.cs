// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The ElasticsearchDataFeedPatch. </summary>
    public partial class ElasticsearchDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of ElasticsearchDataFeedPatch. </summary>
        public ElasticsearchDataFeedPatch()
        {
            DataSourceType = DataFeedDetailPatchDataSourceType.Elasticsearch;
        }

        public ElasticsearchParameter DataSourceParameter { get; set; }
    }
}
