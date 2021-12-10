// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The ScanDiagnostics. </summary>
    public partial class ScanDiagnostics
    {
        /// <summary> Initializes a new instance of ScanDiagnostics. </summary>
        internal ScanDiagnostics()
        {
            Notifications = new ChangeTrackingList<Notification>();
            ExceptionCountMap = new ChangeTrackingDictionary<string, int>();
        }

        /// <summary> Initializes a new instance of ScanDiagnostics. </summary>
        /// <param name="notifications"></param>
        /// <param name="exceptionCountMap"> Dictionary of &lt;integer&gt;. </param>
        internal ScanDiagnostics(IReadOnlyList<Notification> notifications, IReadOnlyDictionary<string, int> exceptionCountMap)
        {
            Notifications = notifications;
            ExceptionCountMap = exceptionCountMap;
        }

        /// <summary> Gets the notifications. </summary>
        public IReadOnlyList<Notification> Notifications { get; }
        /// <summary> Dictionary of &lt;integer&gt;. </summary>
        public IReadOnlyDictionary<string, int> ExceptionCountMap { get; }
    }
}
