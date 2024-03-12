// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.AI.MetricsAdvisor;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The AzureLogAnalyticsParameter. </summary>
    internal partial class AzureLogAnalyticsParameter
    {
        /// <summary> Initializes a new instance of <see cref="AzureLogAnalyticsParameter"/>. </summary>
        /// <param name="workspaceId"> The workspace id of this Log Analytics. </param>
        /// <param name="query"> The KQL (Kusto Query Language) query to fetch data from this Log Analytics. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="workspaceId"/> or <paramref name="query"/> is null. </exception>
        public AzureLogAnalyticsParameter(string workspaceId, string query)
        {
            Argument.AssertNotNull(workspaceId, nameof(workspaceId));
            Argument.AssertNotNull(query, nameof(query));

            WorkspaceId = workspaceId;
            Query = query;
        }

        /// <summary> Initializes a new instance of <see cref="AzureLogAnalyticsParameter"/>. </summary>
        /// <param name="tenantId"> The tenant id of service principal that have access to this Log Analytics. </param>
        /// <param name="clientId"> The client id of service principal that have access to this Log Analytics. </param>
        /// <param name="clientSecret"> The client secret of service principal that have access to this Log Analytics. </param>
        /// <param name="workspaceId"> The workspace id of this Log Analytics. </param>
        /// <param name="query"> The KQL (Kusto Query Language) query to fetch data from this Log Analytics. </param>
        internal AzureLogAnalyticsParameter(string tenantId, string clientId, string clientSecret, string workspaceId, string query)
        {
            TenantId = tenantId;
            ClientId = clientId;
            ClientSecret = clientSecret;
            WorkspaceId = workspaceId;
            Query = query;
        }

        /// <summary> The tenant id of service principal that have access to this Log Analytics. </summary>
        public string TenantId { get; set; }
        /// <summary> The client id of service principal that have access to this Log Analytics. </summary>
        public string ClientId { get; set; }
        /// <summary> The client secret of service principal that have access to this Log Analytics. </summary>
        public string ClientSecret { get; set; }
        /// <summary> The workspace id of this Log Analytics. </summary>
        public string WorkspaceId { get; set; }
        /// <summary> The KQL (Kusto Query Language) query to fetch data from this Log Analytics. </summary>
        public string Query { get; set; }
    }
}
