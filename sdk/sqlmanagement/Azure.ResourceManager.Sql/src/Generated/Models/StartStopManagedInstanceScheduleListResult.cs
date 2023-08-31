// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Sql;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Managed instance's Start/Stop schedule list result. </summary>
    internal partial class StartStopManagedInstanceScheduleListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="StartStopManagedInstanceScheduleListResult"/>. </summary>
        internal StartStopManagedInstanceScheduleListResult()
        {
            Value = new ChangeTrackingList<ManagedInstanceStartStopScheduleData>();
        }

        /// <summary> Initializes a new instance of <see cref="StartStopManagedInstanceScheduleListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal StartStopManagedInstanceScheduleListResult(IReadOnlyList<ManagedInstanceStartStopScheduleData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<ManagedInstanceStartStopScheduleData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
