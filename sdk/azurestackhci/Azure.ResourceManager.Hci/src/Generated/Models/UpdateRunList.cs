// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Hci;

namespace Azure.ResourceManager.Hci.Models
{
    /// <summary> List of Update runs. </summary>
    internal partial class UpdateRunList
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UpdateRunList"/>. </summary>
        internal UpdateRunList()
        {
            Value = new ChangeTrackingList<UpdateRunData>();
        }

        /// <summary> Initializes a new instance of <see cref="UpdateRunList"/>. </summary>
        /// <param name="value"> List of Update runs. </param>
        /// <param name="nextLink"> Link to the next set of results. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UpdateRunList(IReadOnlyList<UpdateRunData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> List of Update runs. </summary>
        public IReadOnlyList<UpdateRunData> Value { get; }
        /// <summary> Link to the next set of results. </summary>
        public string NextLink { get; }
    }
}
