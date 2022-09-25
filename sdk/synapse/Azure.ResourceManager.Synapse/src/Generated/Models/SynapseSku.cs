// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> SQL pool SKU. </summary>
    public partial class SynapseSku
    {
        /// <summary> Initializes a new instance of SynapseSku. </summary>
        public SynapseSku()
        {
        }

        /// <summary> Initializes a new instance of SynapseSku. </summary>
        /// <param name="tier"> The service tier. </param>
        /// <param name="name"> The SKU name. </param>
        /// <param name="capacity"> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </param>
        internal SynapseSku(string tier, string name, int? capacity)
        {
            Tier = tier;
            Name = name;
            Capacity = capacity;
        }

        /// <summary> The service tier. </summary>
        public string Tier { get; set; }
        /// <summary> The SKU name. </summary>
        public string Name { get; set; }
        /// <summary> If the SKU supports scale out/in then the capacity integer should be included. If scale out/in is not possible for the resource this may be omitted. </summary>
        public int? Capacity { get; set; }
    }
}
