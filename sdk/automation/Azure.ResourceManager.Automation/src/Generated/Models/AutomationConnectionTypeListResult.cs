// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Automation;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The response model for the list connection type operation. </summary>
    internal partial class AutomationConnectionTypeListResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionTypeListResult"/>. </summary>
        internal AutomationConnectionTypeListResult()
        {
            Value = new ChangeTrackingList<AutomationConnectionTypeData>();
        }

        /// <summary> Initializes a new instance of <see cref="AutomationConnectionTypeListResult"/>. </summary>
        /// <param name="value"> Gets or sets a list of connection types. </param>
        /// <param name="nextLink"> Gets or sets the next link. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal AutomationConnectionTypeListResult(IReadOnlyList<AutomationConnectionTypeData> value, string nextLink, Dictionary<string, BinaryData> rawData)
        {
            Value = value;
            NextLink = nextLink;
            _rawData = rawData;
        }

        /// <summary> Gets or sets a list of connection types. </summary>
        public IReadOnlyList<AutomationConnectionTypeData> Value { get; }
        /// <summary> Gets or sets the next link. </summary>
        public string NextLink { get; }
    }
}
