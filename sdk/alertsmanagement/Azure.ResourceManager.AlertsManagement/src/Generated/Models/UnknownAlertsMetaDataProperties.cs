// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AlertsManagement.Models
{
    /// <summary> The UnknownAlertsMetaDataProperties. </summary>
    internal partial class UnknownAlertsMetaDataProperties : ServiceAlertMetadataProperties
    {
        /// <summary> Initializes a new instance of <see cref="UnknownAlertsMetaDataProperties"/>. </summary>
        /// <param name="metadataIdentifier"> Identification of the information to be retrieved by API call. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UnknownAlertsMetaDataProperties(ServiceAlertMetadataIdentifier metadataIdentifier, Dictionary<string, BinaryData> rawData) : base(metadataIdentifier, rawData)
        {
            MetadataIdentifier = metadataIdentifier;
        }

        /// <summary> Initializes a new instance of <see cref="UnknownAlertsMetaDataProperties"/> for deserialization. </summary>
        internal UnknownAlertsMetaDataProperties()
        {
        }
    }
}
