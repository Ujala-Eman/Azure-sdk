// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Insights.Models
{
    /// <summary> The autoscale setting object for patch operations. </summary>
    public partial class AutoscaleSettingResourcePatch
    {
        /// <summary> Initializes a new instance of AutoscaleSettingResourcePatch. </summary>
        public AutoscaleSettingResourcePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Profiles = new ChangeTrackingList<AutoscaleProfile>();
            Notifications = new ChangeTrackingList<AutoscaleNotification>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> the collection of automatic scaling profiles that specify different scaling parameters for different time periods. A maximum of 20 profiles can be specified. </summary>
        public IList<AutoscaleProfile> Profiles { get; }
        /// <summary> the collection of notifications. </summary>
        public IList<AutoscaleNotification> Notifications { get; }
        /// <summary> the enabled flag. Specifies whether automatic scaling is enabled for the resource. The default value is &apos;true&apos;. </summary>
        public bool? Enabled { get; set; }
        /// <summary> the name of the autoscale setting. </summary>
        public string Name { get; set; }
        /// <summary> the resource identifier of the resource that the autoscale setting should be added to. </summary>
        public string TargetResourceUri { get; set; }
    }
}
