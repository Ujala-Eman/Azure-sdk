// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> The CheckNameAvailability operation response. </summary>
    public partial class BatchNameAvailabilityResult
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchNameAvailabilityResult"/>. </summary>
        internal BatchNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="BatchNameAvailabilityResult"/>. </summary>
        /// <param name="isNameAvailable"> Gets a boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or invalid and cannot be used. </param>
        /// <param name="reason"> Gets the reason that a Batch account name could not be used. The Reason element is only returned if NameAvailable is false. </param>
        /// <param name="message"> Gets an error message explaining the Reason value in more detail. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchNameAvailabilityResult(bool? isNameAvailable, BatchNameUnavailableReason? reason, string message, Dictionary<string, BinaryData> rawData)
        {
            IsNameAvailable = isNameAvailable;
            Reason = reason;
            Message = message;
            _rawData = rawData;
        }

        /// <summary> Gets a boolean value that indicates whether the name is available for you to use. If true, the name is available. If false, the name has already been taken or invalid and cannot be used. </summary>
        public bool? IsNameAvailable { get; }
        /// <summary> Gets the reason that a Batch account name could not be used. The Reason element is only returned if NameAvailable is false. </summary>
        public BatchNameUnavailableReason? Reason { get; }
        /// <summary> Gets an error message explaining the Reason value in more detail. </summary>
        public string Message { get; }
    }
}
