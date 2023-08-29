// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeploymentManager.Models
{
    /// <summary> The regular expressions to match the response content with. </summary>
    public partial class RestResponseRegex
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RestResponseRegex"/>. </summary>
        public RestResponseRegex()
        {
            Matches = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="RestResponseRegex"/>. </summary>
        /// <param name="matches"> The list of regular expressions. </param>
        /// <param name="matchQuantifier"> Indicates whether any or all of the expressions should match with the response content. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RestResponseRegex(IList<string> matches, RestMatchQuantifier? matchQuantifier, Dictionary<string, BinaryData> rawData)
        {
            Matches = matches;
            MatchQuantifier = matchQuantifier;
            _rawData = rawData;
        }

        /// <summary> The list of regular expressions. </summary>
        public IList<string> Matches { get; }
        /// <summary> Indicates whether any or all of the expressions should match with the response content. </summary>
        public RestMatchQuantifier? MatchQuantifier { get; set; }
    }
}
