// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Properties of the disk to detach. </summary>
    public partial class DevTestLabDiskDetachContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabDiskDetachContent"/>. </summary>
        public DevTestLabDiskDetachContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabDiskDetachContent"/>. </summary>
        /// <param name="leasedByLabVmId"> The resource ID of the Lab VM to which the disk is attached. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabDiskDetachContent(ResourceIdentifier leasedByLabVmId, Dictionary<string, BinaryData> rawData)
        {
            LeasedByLabVmId = leasedByLabVmId;
            _rawData = rawData;
        }

        /// <summary> The resource ID of the Lab VM to which the disk is attached. </summary>
        public ResourceIdentifier LeasedByLabVmId { get; set; }
    }
}
