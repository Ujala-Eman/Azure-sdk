// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Synapse;

namespace Azure.ResourceManager.Synapse.Models
{
    /// <summary> A list of sql pool extended auditing settings. </summary>
    internal partial class SynapseExtendedSqlPoolBlobAuditingPolicyListResult
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SynapseExtendedSqlPoolBlobAuditingPolicyListResult"/>. </summary>
        internal SynapseExtendedSqlPoolBlobAuditingPolicyListResult()
        {
            Value = new ChangeTrackingList<SynapseExtendedSqlPoolBlobAuditingPolicyData>();
        }

        /// <summary> Initializes a new instance of <see cref="SynapseExtendedSqlPoolBlobAuditingPolicyListResult"/>. </summary>
        /// <param name="value"> Array of results. </param>
        /// <param name="nextLink"> Link to retrieve next page of results. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SynapseExtendedSqlPoolBlobAuditingPolicyListResult(IReadOnlyList<SynapseExtendedSqlPoolBlobAuditingPolicyData> value, string nextLink, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Value = value;
            NextLink = nextLink;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Array of results. </summary>
        public IReadOnlyList<SynapseExtendedSqlPoolBlobAuditingPolicyData> Value { get; }
        /// <summary> Link to retrieve next page of results. </summary>
        public string NextLink { get; }
    }
}
