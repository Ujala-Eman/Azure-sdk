// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Azure.ResourceManager.DataBoxEdge.Models
{
    /// <summary> The metric counter set. </summary>
    public partial class DataBoxEdgeMetricCounterSet
    {
        /// <summary> Initializes a new instance of DataBoxEdgeMetricCounterSet. </summary>
        /// <param name="counters"> The counters that should be collected in this set. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="counters"/> is null. </exception>
        public DataBoxEdgeMetricCounterSet(IEnumerable<DataBoxEdgeMetricCounter> counters)
        {
            if (counters == null)
            {
                throw new ArgumentNullException(nameof(counters));
            }

            Counters = counters.ToList();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeMetricCounterSet. </summary>
        /// <param name="counters"> The counters that should be collected in this set. </param>
        internal DataBoxEdgeMetricCounterSet(IList<DataBoxEdgeMetricCounter> counters)
        {
            Counters = counters;
        }

        /// <summary> The counters that should be collected in this set. </summary>
        public IList<DataBoxEdgeMetricCounter> Counters { get; }
    }
}
