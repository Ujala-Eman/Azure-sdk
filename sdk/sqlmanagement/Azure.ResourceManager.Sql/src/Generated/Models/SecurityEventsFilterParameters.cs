// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace SqlManagementClient.Models
{
    /// <summary> The properties that are supported in the $filter operation. </summary>
    internal partial class SecurityEventsFilterParameters
    {
        /// <summary> Initializes a new instance of SecurityEventsFilterParameters. </summary>
        internal SecurityEventsFilterParameters()
        {
        }

        /// <summary> Filter on the event time. </summary>
        public DateTimeOffset? EventTime { get; }
        /// <summary> Whether to show server records or not. </summary>
        public bool? ShowServerRecords { get; }
    }
}
