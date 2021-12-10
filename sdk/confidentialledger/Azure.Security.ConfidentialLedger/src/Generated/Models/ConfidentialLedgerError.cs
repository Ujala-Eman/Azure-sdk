// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Security.ConfidentialLedger.Models
{
    /// <summary> An error response from Confidential Ledger. </summary>
    internal partial class ConfidentialLedgerError
    {
        /// <summary> Initializes a new instance of ConfidentialLedgerError. </summary>
        internal ConfidentialLedgerError()
        {
        }

        /// <summary> Initializes a new instance of ConfidentialLedgerError. </summary>
        /// <param name="error"> An error response from Confidential Ledger. </param>
        internal ConfidentialLedgerError(ConfidentialLedgerErrorBody error)
        {
            Error = error;
        }

        /// <summary> An error response from Confidential Ledger. </summary>
        public ConfidentialLedgerErrorBody Error { get; }
    }
}
