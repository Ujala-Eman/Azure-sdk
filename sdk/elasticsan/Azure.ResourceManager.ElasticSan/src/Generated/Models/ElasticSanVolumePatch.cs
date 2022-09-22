// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ElasticSan.Models
{
    /// <summary> Response for Volume request. </summary>
    public partial class ElasticSanVolumePatch
    {
        /// <summary> Initializes a new instance of ElasticSanVolumePatch. </summary>
        public ElasticSanVolumePatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> Volume size. </summary>
        public long? SizeGiB { get; set; }
    }
}
