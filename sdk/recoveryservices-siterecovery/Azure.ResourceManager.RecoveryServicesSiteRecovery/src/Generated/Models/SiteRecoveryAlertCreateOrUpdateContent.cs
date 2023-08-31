// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RecoveryServicesSiteRecovery.Models
{
    /// <summary> Request to configure alerts for the system. </summary>
    public partial class SiteRecoveryAlertCreateOrUpdateContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAlertCreateOrUpdateContent"/>. </summary>
        public SiteRecoveryAlertCreateOrUpdateContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SiteRecoveryAlertCreateOrUpdateContent"/>. </summary>
        /// <param name="properties"> The properties of a configure alert request. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SiteRecoveryAlertCreateOrUpdateContent(SiteRecoveryConfigureAlertProperties properties, Dictionary<string, BinaryData> rawData)
        {
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The properties of a configure alert request. </summary>
        public SiteRecoveryConfigureAlertProperties Properties { get; set; }
    }
}
