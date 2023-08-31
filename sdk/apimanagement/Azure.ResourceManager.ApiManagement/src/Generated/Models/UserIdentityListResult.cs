// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> List of Users Identity list representation. </summary>
    internal partial class UserIdentityListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UserIdentityListResult"/>. </summary>
        internal UserIdentityListResult()
        {
            Value = new ChangeTrackingList<UserIdentityContract>();
        }

        /// <summary> Initializes a new instance of <see cref="UserIdentityListResult"/>. </summary>
        /// <param name="value"> User Identity values. </param>
        /// <param name="count"> Total record count number across all pages. </param>
        /// <param name="nextLink"> Next page link if any. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UserIdentityListResult(IReadOnlyList<UserIdentityContract> value, long? count, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> User Identity values. </summary>
        public IReadOnlyList<UserIdentityContract> Value { get; }
        /// <summary> Total record count number across all pages. </summary>
        public long? Count { get; }
        /// <summary> Next page link if any. </summary>
        public string NextLink { get; }
    }
}
