// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.SecurityCenter;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> List of secure scores. </summary>
    internal partial class SecureScoresList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SecureScoresList"/>. </summary>
        internal SecureScoresList()
        {
            Value = new ChangeTrackingList<SecureScoreData>();
        }

        /// <summary> Initializes a new instance of <see cref="SecureScoresList"/>. </summary>
        /// <param name="value"> Collection of secure scores in this page. </param>
        /// <param name="nextLink"> The URI to fetch the next page. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SecureScoresList(IReadOnlyList<SecureScoreData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Collection of secure scores in this page. </summary>
        public IReadOnlyList<SecureScoreData> Value { get; }
        /// <summary> The URI to fetch the next page. </summary>
        public string NextLink { get; }
    }
}
