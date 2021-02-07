// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> An error response from Azure. </summary>
    public partial class ErrorData
    {
        /// <summary> Initializes a new instance of ErrorData. </summary>
        internal ErrorData()
        {
        }

        /// <summary> Initializes a new instance of ErrorData. </summary>
        /// <param name="code"> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </param>
        /// <param name="message"> A message describing the error, intended to be suitable for displaying in a user interface. </param>
        internal ErrorData(string code, string message)
        {
            Code = code;
            Message = message;
        }

        /// <summary> An identifier for the error. Codes are invariant and are intended to be consumed programmatically. </summary>
        public string Code { get; }
        /// <summary> A message describing the error, intended to be suitable for displaying in a user interface. </summary>
        public string Message { get; }
    }
}
