// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> Navigation for DSC Report Resource. </summary>
    public partial class DscReportResourceNavigation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DscReportResourceNavigation"/>. </summary>
        internal DscReportResourceNavigation()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DscReportResourceNavigation"/>. </summary>
        /// <param name="resourceId"> Gets or sets the ID of the resource to navigate to. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DscReportResourceNavigation(string resourceId, Dictionary<string, BinaryData> rawData)
        {
            ResourceId = resourceId;
            _rawData = rawData;
        }

        /// <summary> Gets or sets the ID of the resource to navigate to. </summary>
        public string ResourceId { get; }
    }
}
