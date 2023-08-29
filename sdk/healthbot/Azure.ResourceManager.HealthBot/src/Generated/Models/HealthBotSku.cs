// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.HealthBot.Models
{
    /// <summary> The resource model definition representing SKU. </summary>
    public partial class HealthBotSku
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="HealthBotSku"/>. </summary>
        /// <param name="name"> The name of the Azure Health Bot SKU. </param>
        public HealthBotSku(HealthBotSkuName name)
        {
            Name = name;
        }

        /// <summary> Initializes a new instance of <see cref="HealthBotSku"/>. </summary>
        /// <param name="name"> The name of the Azure Health Bot SKU. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal HealthBotSku(HealthBotSkuName name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="HealthBotSku"/> for deserialization. </summary>
        internal HealthBotSku()
        {
        }

        /// <summary> The name of the Azure Health Bot SKU. </summary>
        public HealthBotSkuName Name { get; set; }
    }
}
