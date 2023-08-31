// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.SecurityCenter.Models
{
    /// <summary> The ETA (estimated time of arrival) for remediation. </summary>
    public partial class RemediationEta
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/>. </summary>
        /// <param name="eta"> ETA for remediation. </param>
        /// <param name="justification"> Justification for change of Eta. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="justification"/> is null. </exception>
        public RemediationEta(DateTimeOffset eta, string justification)
        {
            Argument.AssertNotNull(justification, nameof(justification));

            Eta = eta;
            Justification = justification;
        }

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/>. </summary>
        /// <param name="eta"> ETA for remediation. </param>
        /// <param name="justification"> Justification for change of Eta. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal RemediationEta(DateTimeOffset eta, string justification, Dictionary<string, BinaryData> rawData)
        {
            Eta = eta;
            Justification = justification;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="RemediationEta"/> for deserialization. </summary>
        internal RemediationEta()
        {
        }

        /// <summary> ETA for remediation. </summary>
        public DateTimeOffset Eta { get; set; }
        /// <summary> Justification for change of Eta. </summary>
        public string Justification { get; set; }
    }
}
