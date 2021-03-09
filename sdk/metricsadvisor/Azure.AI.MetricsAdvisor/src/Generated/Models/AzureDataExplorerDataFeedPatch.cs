// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureDataExplorerDataFeedPatch. </summary>
    public partial class AzureDataExplorerDataFeedPatch : DataFeedDetailPatch
    {
        /// <summary> Initializes a new instance of AzureDataExplorerDataFeedPatch. </summary>
        public AzureDataExplorerDataFeedPatch()
        {
            DataSourceType = DataFeedDetailPatchDataSourceType.AzureDataExplorer;
        }

        public SqlSourceParameter DataSourceParameter { get; set; }
    }
}
