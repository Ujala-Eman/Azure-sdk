// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Monitor.Models
{
    /// <summary> The log profile resource for patch operations. </summary>
    public partial class LogProfilePatch
    {
        /// <summary> Initializes a new instance of <see cref="LogProfilePatch"/>. </summary>
        public LogProfilePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
            Locations = new ChangeTrackingList<string>();
            Categories = new ChangeTrackingList<string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> the resource id of the storage account to which you would like to send the Activity Log. </summary>
        public string StorageAccountId { get; set; }
        /// <summary> The service bus rule ID of the service bus namespace in which you would like to have Event Hubs created for streaming the Activity Log. The rule ID is of the format: &apos;{service bus resource ID}/authorizationrules/{key name}&apos;. </summary>
        public string ServiceBusRuleId { get; set; }
        /// <summary> List of regions for which Activity Log events should be stored or streamed. It is a comma separated list of valid ARM locations including the &apos;global&apos; location. </summary>
        public IList<string> Locations { get; }
        /// <summary> the categories of the logs. These categories are created as is convenient to the user. Some values are: &apos;Write&apos;, &apos;Delete&apos;, and/or &apos;Action.&apos;. </summary>
        public IList<string> Categories { get; }
        /// <summary> the retention policy for the events in the log. </summary>
        public RetentionPolicy RetentionPolicy { get; set; }
    }
}
