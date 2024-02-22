// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The EnrichmentStatus. </summary>
    public partial class EnrichmentStatus
    {
        /// <summary> Initializes a new instance of <see cref="EnrichmentStatus"/>. </summary>
        /// <param name="timestamp"> data slice timestamp. </param>
        /// <param name="status"> latest enrichment status for this data slice. </param>
        /// <param name="message"> the trimmed message describes details of the enrichment status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="status"/> or <paramref name="message"/> is null. </exception>
        internal EnrichmentStatus(DateTimeOffset timestamp, string status, string message)
        {
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }

            Timestamp = timestamp;
            Status = status;
            Message = message;
        }
    }
}
