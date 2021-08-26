// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Maintenance windows. </summary>
    public partial class MaintenanceWindows : ProxyResource
    {
        /// <summary> Initializes a new instance of MaintenanceWindows. </summary>
        public MaintenanceWindows()
        {
            TimeRanges = new ChangeTrackingList<MaintenanceWindowTimeRange>();
        }

        /// <summary> Initializes a new instance of MaintenanceWindows. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="timeRanges"> . </param>
        internal MaintenanceWindows(string id, string name, string type, IList<MaintenanceWindowTimeRange> timeRanges) : base(id, name, type)
        {
            TimeRanges = timeRanges;
        }

        public IList<MaintenanceWindowTimeRange> TimeRanges { get; }
    }
}
