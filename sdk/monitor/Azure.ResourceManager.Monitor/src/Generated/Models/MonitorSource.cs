// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> Specifies the log search query. </summary>
    public partial class MonitorSource
    {
        /// <summary> Initializes a new instance of <see cref="MonitorSource"/>. </summary>
        /// <param name="dataSourceId"> The resource uri over which log search query is to be run. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataSourceId"/> is null. </exception>
        public MonitorSource(string dataSourceId)
        {
            if (dataSourceId == null)
            {
                throw new ArgumentNullException(nameof(dataSourceId));
            }

            AuthorizedResources = new ChangeTrackingList<string>();
            DataSourceId = dataSourceId;
        }

        /// <summary> Initializes a new instance of <see cref="MonitorSource"/>. </summary>
        /// <param name="query"> Log search query. Required for action type - AlertingAction. </param>
        /// <param name="authorizedResources"> List of  Resource referred into query. </param>
        /// <param name="dataSourceId"> The resource uri over which log search query is to be run. </param>
        /// <param name="queryType"> Set value to &apos;ResultCount&apos; . </param>
        internal MonitorSource(string query, IList<string> authorizedResources, string dataSourceId, QueryType? queryType)
        {
            Query = query;
            AuthorizedResources = authorizedResources;
            DataSourceId = dataSourceId;
            QueryType = queryType;
        }

        /// <summary> Log search query. Required for action type - AlertingAction. </summary>
        public string Query { get; set; }
        /// <summary> List of  Resource referred into query. </summary>
        public IList<string> AuthorizedResources { get; }
        /// <summary> The resource uri over which log search query is to be run. </summary>
        public string DataSourceId { get; set; }
        /// <summary> Set value to &apos;ResultCount&apos; . </summary>
        public QueryType? QueryType { get; set; }
    }
}
