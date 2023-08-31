// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Elastic.Models
{
    /// <summary> The vm ingestion details to install an agent. </summary>
    public partial class VmIngestionDetailsResponse
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="VmIngestionDetailsResponse"/>. </summary>
        internal VmIngestionDetailsResponse()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VmIngestionDetailsResponse"/>. </summary>
        /// <param name="cloudId"> The cloudId of given Elastic monitor resource. </param>
        /// <param name="ingestionKey"> Ingestion details to install agent on given VM. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal VmIngestionDetailsResponse(string cloudId, string ingestionKey, Dictionary<string, BinaryData> rawData)
        {
            CloudId = cloudId;
            IngestionKey = ingestionKey;
            _rawData = rawData;
        }

        /// <summary> The cloudId of given Elastic monitor resource. </summary>
        public string CloudId { get; }
        /// <summary> Ingestion details to install agent on given VM. </summary>
        public string IngestionKey { get; }
    }
}
