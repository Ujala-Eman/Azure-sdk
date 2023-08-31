// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppComplianceAutomation.Models
{
    /// <summary> The overview of the compliance result for one report. </summary>
    public partial class OverviewStatus
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="OverviewStatus"/>. </summary>
        internal OverviewStatus()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OverviewStatus"/>. </summary>
        /// <param name="passedCount"> The count of all passed full automation control. </param>
        /// <param name="failedCount"> The count of all failed full automation control. </param>
        /// <param name="manualCount"> The count of all manual control. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OverviewStatus(int? passedCount, int? failedCount, int? manualCount, Dictionary<string, BinaryData> rawData)
        {
            PassedCount = passedCount;
            FailedCount = failedCount;
            ManualCount = manualCount;
            _rawData = rawData;
        }

        /// <summary> The count of all passed full automation control. </summary>
        public int? PassedCount { get; }
        /// <summary> The count of all failed full automation control. </summary>
        public int? FailedCount { get; }
        /// <summary> The count of all manual control. </summary>
        public int? ManualCount { get; }
    }
}
