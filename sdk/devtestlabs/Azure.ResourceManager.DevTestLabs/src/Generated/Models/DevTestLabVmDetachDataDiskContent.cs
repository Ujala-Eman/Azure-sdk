// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DevTestLabs.Models
{
    /// <summary> Request body for detaching data disk from a virtual machine. </summary>
    public partial class DevTestLabVmDetachDataDiskContent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmDetachDataDiskContent"/>. </summary>
        public DevTestLabVmDetachDataDiskContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DevTestLabVmDetachDataDiskContent"/>. </summary>
        /// <param name="existingLabDiskId"> Specifies the disk resource ID to detach from virtual machine. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DevTestLabVmDetachDataDiskContent(ResourceIdentifier existingLabDiskId, Dictionary<string, BinaryData> rawData)
        {
            ExistingLabDiskId = existingLabDiskId;
            _rawData = rawData;
        }

        /// <summary> Specifies the disk resource ID to detach from virtual machine. </summary>
        public ResourceIdentifier ExistingLabDiskId { get; set; }
    }
}
