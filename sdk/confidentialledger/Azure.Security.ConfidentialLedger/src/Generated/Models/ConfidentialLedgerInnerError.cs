// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.ConfidentialLedger.Models
{
    /// <summary> An inner error response from Confidential Ledger. </summary>
    internal partial class ConfidentialLedgerInnerError
    {
        /// <summary> Initializes a new instance of ConfidentialLedgerInnerError. </summary>
        internal ConfidentialLedgerInnerError()
        {
        }

        /// <summary> The error code. </summary>
        public string Code { get; }
        /// <summary> An error response from Confidential Ledger. </summary>
        public ConfidentialLedgerErrorBody InnerError { get; }
    }
}
