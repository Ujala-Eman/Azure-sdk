// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> Describes the storage profile. </summary>
    public partial class RestorePointSourceVmStorageProfile
    {
        /// <summary> Initializes a new instance of <see cref="RestorePointSourceVmStorageProfile"/>. </summary>
        internal RestorePointSourceVmStorageProfile()
        {
            DataDisks = new ChangeTrackingList<RestorePointSourceVmDataDisk>();
        }

        /// <summary> Initializes a new instance of <see cref="RestorePointSourceVmStorageProfile"/>. </summary>
        /// <param name="osDisk"> Gets the OS disk of the VM captured at the time of the restore point creation. </param>
        /// <param name="dataDisks"> Gets the data disks of the VM captured at the time of the restore point creation. </param>
        internal RestorePointSourceVmStorageProfile(RestorePointSourceVmOSDisk osDisk, IReadOnlyList<RestorePointSourceVmDataDisk> dataDisks)
        {
            OSDisk = osDisk;
            DataDisks = dataDisks;
        }

        /// <summary> Gets the OS disk of the VM captured at the time of the restore point creation. </summary>
        public RestorePointSourceVmOSDisk OSDisk { get; }
        /// <summary> Gets the data disks of the VM captured at the time of the restore point creation. </summary>
        public IReadOnlyList<RestorePointSourceVmDataDisk> DataDisks { get; }
    }
}
