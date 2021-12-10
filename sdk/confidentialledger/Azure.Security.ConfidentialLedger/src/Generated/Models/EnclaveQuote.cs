// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Security.ConfidentialLedger.Models
{
    /// <summary> Contains the enclave quote. </summary>
    public partial class EnclaveQuote
    {
        /// <summary> Initializes a new instance of EnclaveQuote. </summary>
        /// <param name="nodeId"> ID assigned to this node. </param>
        /// <param name="quoteVersion"> Version of the quote presented. </param>
        /// <param name="raw"> Raw SGX quote, parsable by tools like Open Enclave&apos;s oeverify. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="nodeId"/>, <paramref name="quoteVersion"/>, or <paramref name="raw"/> is null. </exception>
        internal EnclaveQuote(string nodeId, string quoteVersion, string raw)
        {
            if (nodeId == null)
            {
                throw new ArgumentNullException(nameof(nodeId));
            }
            if (quoteVersion == null)
            {
                throw new ArgumentNullException(nameof(quoteVersion));
            }
            if (raw == null)
            {
                throw new ArgumentNullException(nameof(raw));
            }

            NodeId = nodeId;
            QuoteVersion = quoteVersion;
            Raw = raw;
        }

        /// <summary> Initializes a new instance of EnclaveQuote. </summary>
        /// <param name="nodeId"> ID assigned to this node. </param>
        /// <param name="mrenclave"> MRENCLAVE value of the code running in the enclave. </param>
        /// <param name="quoteVersion"> Version of the quote presented. </param>
        /// <param name="raw"> Raw SGX quote, parsable by tools like Open Enclave&apos;s oeverify. </param>
        internal EnclaveQuote(string nodeId, string mrenclave, string quoteVersion, string raw)
        {
            NodeId = nodeId;
            Mrenclave = mrenclave;
            QuoteVersion = quoteVersion;
            Raw = raw;
        }

        /// <summary> ID assigned to this node. </summary>
        public string NodeId { get; }
        /// <summary> MRENCLAVE value of the code running in the enclave. </summary>
        public string Mrenclave { get; }
        /// <summary> Version of the quote presented. </summary>
        public string QuoteVersion { get; }
        /// <summary> Raw SGX quote, parsable by tools like Open Enclave&apos;s oeverify. </summary>
        public string Raw { get; }
    }
}
