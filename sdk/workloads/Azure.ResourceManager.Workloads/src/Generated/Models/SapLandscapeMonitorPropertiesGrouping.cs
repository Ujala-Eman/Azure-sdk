// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Workloads.Models
{
    /// <summary> Gets or sets the SID groupings by landscape and Environment. </summary>
    public partial class SapLandscapeMonitorPropertiesGrouping
    {
        /// <summary> Initializes a new instance of <see cref="SapLandscapeMonitorPropertiesGrouping"/>. </summary>
        public SapLandscapeMonitorPropertiesGrouping()
        {
            Landscape = new ChangeTrackingList<SapLandscapeMonitorSidMapping>();
            SapApplication = new ChangeTrackingList<SapLandscapeMonitorSidMapping>();
        }

        /// <summary> Initializes a new instance of <see cref="SapLandscapeMonitorPropertiesGrouping"/>. </summary>
        /// <param name="landscape"> Gets or sets the list of landscape to SID mappings. </param>
        /// <param name="sapApplication"> Gets or sets the list of Sap Applications to SID mappings. </param>
        internal SapLandscapeMonitorPropertiesGrouping(IList<SapLandscapeMonitorSidMapping> landscape, IList<SapLandscapeMonitorSidMapping> sapApplication)
        {
            Landscape = landscape;
            SapApplication = sapApplication;
        }

        /// <summary> Gets or sets the list of landscape to SID mappings. </summary>
        public IList<SapLandscapeMonitorSidMapping> Landscape { get; }
        /// <summary> Gets or sets the list of Sap Applications to SID mappings. </summary>
        public IList<SapLandscapeMonitorSidMapping> SapApplication { get; }
    }
}
