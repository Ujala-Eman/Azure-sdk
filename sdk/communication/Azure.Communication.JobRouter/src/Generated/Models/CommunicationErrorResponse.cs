// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Communication.JobRouter
{
    /// <summary> The Communication Services error. </summary>
    internal partial class CommunicationErrorResponse
    {
        /// <summary> Initializes a new instance of CommunicationErrorResponse. </summary>
        /// <param name="error"> The Communication Services error. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="error"/> is null. </exception>
        internal CommunicationErrorResponse(JobRouterError error)
        {
            if (error == null)
            {
                throw new ArgumentNullException(nameof(error));
            }

            Error = error;
        }

        /// <summary> The Communication Services error. </summary>
        public JobRouterError Error { get; }
    }
}
