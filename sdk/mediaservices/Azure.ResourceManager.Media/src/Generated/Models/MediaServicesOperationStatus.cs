// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Status of media service operation. </summary>
    public partial class MediaServicesOperationStatus
    {
        /// <summary> Initializes a new instance of MediaServicesOperationStatus. </summary>
        /// <param name="name"> Operation identifier. </param>
        /// <param name="status"> Operation status. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="status"/> is null. </exception>
        internal MediaServicesOperationStatus(string name, string status)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (status == null)
            {
                throw new ArgumentNullException(nameof(status));
            }

            Name = name;
            Status = status;
        }

        /// <summary> Initializes a new instance of MediaServicesOperationStatus. </summary>
        /// <param name="name"> Operation identifier. </param>
        /// <param name="id"> Operation resource ID. </param>
        /// <param name="startsOn"> Operation start time. </param>
        /// <param name="endsOn"> Operation end time. </param>
        /// <param name="status"> Operation status. </param>
        /// <param name="error"> The error detail. </param>
        internal MediaServicesOperationStatus(string name, ResourceIdentifier id, DateTimeOffset? startsOn, DateTimeOffset? endsOn, string status, ResponseError error)
        {
            Name = name;
            Id = id;
            StartsOn = startsOn;
            EndsOn = endsOn;
            Status = status;
            Error = error;
        }

        /// <summary> Operation identifier. </summary>
        public string Name { get; }
        /// <summary> Operation resource ID. </summary>
        public ResourceIdentifier Id { get; }
        /// <summary> Operation start time. </summary>
        public DateTimeOffset? StartsOn { get; }
        /// <summary> Operation end time. </summary>
        public DateTimeOffset? EndsOn { get; }
        /// <summary> Operation status. </summary>
        public string Status { get; }
        /// <summary> The error detail. </summary>
        public ResponseError Error { get; }
    }
}
