// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.VoiceServices.Models
{
    /// <summary> The check availability result. </summary>
    public partial class VoiceServicesCheckNameAvailabilityResult
    {
        /// <summary> Initializes a new instance of <see cref="VoiceServicesCheckNameAvailabilityResult"/>. </summary>
        internal VoiceServicesCheckNameAvailabilityResult()
        {
        }

        /// <summary> Initializes a new instance of <see cref="VoiceServicesCheckNameAvailabilityResult"/>. </summary>
        /// <param name="nameAvailable"> Indicates if the resource name is available. </param>
        /// <param name="reason"> The reason why the given name is not available. </param>
        /// <param name="message"> Detailed reason why the given name is not available. </param>
        internal VoiceServicesCheckNameAvailabilityResult(bool? nameAvailable, VoiceServicesNameUnavailableReason? reason, string message)
        {
            NameAvailable = nameAvailable;
            Reason = reason;
            Message = message;
        }

        /// <summary> Indicates if the resource name is available. </summary>
        public bool? NameAvailable { get; }
        /// <summary> The reason why the given name is not available. </summary>
        public VoiceServicesNameUnavailableReason? Reason { get; }
        /// <summary> Detailed reason why the given name is not available. </summary>
        public string Message { get; }
    }
}
