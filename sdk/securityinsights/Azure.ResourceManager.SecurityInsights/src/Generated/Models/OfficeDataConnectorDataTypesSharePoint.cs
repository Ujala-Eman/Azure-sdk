// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.SecurityInsights.Models
{
    /// <summary> SharePoint data type connection. </summary>
    internal partial class OfficeDataConnectorDataTypesSharePoint : DataConnectorDataTypeCommon
    {
        /// <summary> Initializes a new instance of <see cref="OfficeDataConnectorDataTypesSharePoint"/>. </summary>
        public OfficeDataConnectorDataTypesSharePoint()
        {
        }

        /// <summary> Initializes a new instance of <see cref="OfficeDataConnectorDataTypesSharePoint"/>. </summary>
        /// <param name="state"> Describe whether this data type connection is enabled or not. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal OfficeDataConnectorDataTypesSharePoint(SecurityInsightsDataTypeConnectionState? state, Dictionary<string, BinaryData> rawData) : base(state, rawData)
        {
        }
    }
}
