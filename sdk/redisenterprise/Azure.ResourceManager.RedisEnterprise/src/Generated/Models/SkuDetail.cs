// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.RedisEnterprise.Models
{
    /// <summary> Information about Sku. </summary>
    internal partial class SkuDetail
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SkuDetail"/>. </summary>
        internal SkuDetail()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SkuDetail"/>. </summary>
        /// <param name="name"> The type of RedisEnterprise cluster to deploy. Possible values: (Enterprise_E10, EnterpriseFlash_F300 etc.). </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SkuDetail(RedisEnterpriseSkuName? name, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            _rawData = rawData;
        }

        /// <summary> The type of RedisEnterprise cluster to deploy. Possible values: (Enterprise_E10, EnterpriseFlash_F300 etc.). </summary>
        public RedisEnterpriseSkuName? Name { get; }
    }
}
