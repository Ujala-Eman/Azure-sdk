// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Compute.Models
{
    /// <summary> List of supported capabilities (like accelerated networking) persisted on the disk resource for VM use. </summary>
    internal partial class SupportedCapabilities
    {
        /// <summary> Initializes a new instance of <see cref="SupportedCapabilities"/>. </summary>
        public SupportedCapabilities()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SupportedCapabilities"/>. </summary>
        /// <param name="acceleratedNetwork"> True if the image from which the OS disk is created supports accelerated networking. </param>
        internal SupportedCapabilities(bool? acceleratedNetwork)
        {
            AcceleratedNetwork = acceleratedNetwork;
        }

        /// <summary> True if the image from which the OS disk is created supports accelerated networking. </summary>
        public bool? AcceleratedNetwork { get; set; }
    }
}
