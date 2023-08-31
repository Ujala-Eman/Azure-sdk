// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataProtectionBackup.Models
{
    /// <summary> Base for all lists of V2 resources. </summary>
    internal partial class DppBaseResourceList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DppBaseResourceList"/>. </summary>
        internal DppBaseResourceList()
        {
            Value = new ChangeTrackingList<ResourceGuardProtectedObjectData>();
        }

        /// <summary> Initializes a new instance of <see cref="DppBaseResourceList"/>. </summary>
        /// <param name="value"> List of Dpp resources. </param>
        /// <param name="nextLink"> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DppBaseResourceList(IReadOnlyList<ResourceGuardProtectedObjectData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Dpp resources. </summary>
        public IReadOnlyList<ResourceGuardProtectedObjectData> Value { get; }
        /// <summary> The uri to fetch the next page of resources. Call ListNext() fetches next page of resources. </summary>
        public string NextLink { get; }
    }
}
