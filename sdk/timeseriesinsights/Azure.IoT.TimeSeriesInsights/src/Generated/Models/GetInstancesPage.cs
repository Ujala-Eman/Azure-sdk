// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.IoT.TimeSeriesInsights
{
    /// <summary> Partial list of time series instances returned in a single request. </summary>
    internal partial class GetInstancesPage : PagedResponse
    {
        /// <summary> Initializes a new instance of <see cref="GetInstancesPage"/>. </summary>
        internal GetInstancesPage()
        {
            Instances = new ChangeTrackingList<TimeSeriesInstance>();
        }

        /// <summary> Initializes a new instance of <see cref="GetInstancesPage"/>. </summary>
        /// <param name="continuationToken"> If returned, this means that current results represent a partial result. Continuation token allows to get the next page of results. To get the next page of query results, send the same request with continuation token parameter in "x-ms-continuation" HTTP header. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="instances"> Partial list of time series instances returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null. </param>
        internal GetInstancesPage(string continuationToken, IDictionary<string, BinaryData> serializedAdditionalRawData, IReadOnlyList<TimeSeriesInstance> instances) : base(continuationToken, serializedAdditionalRawData)
        {
            Instances = instances;
        }

        /// <summary> Partial list of time series instances returned in a single request. Can be empty if server was unable to fill the page in this request, or there is no more objects when continuation token is null. </summary>
        public IReadOnlyList<TimeSeriesInstance> Instances { get; }
    }
}
