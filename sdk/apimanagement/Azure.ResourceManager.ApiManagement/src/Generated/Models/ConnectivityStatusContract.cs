// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Details about connectivity to a resource. </summary>
    public partial class ConnectivityStatusContract
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="ConnectivityStatusContract"/>. </summary>
        /// <param name="name"> The hostname of the resource which the service depends on. This can be the database, storage or any other azure resource on which the service depends upon. </param>
        /// <param name="status"> Resource Connectivity Status Type identifier. </param>
        /// <param name="lastUpdatedOn">
        /// The date when the resource connectivity status was last updated. This status should be updated every 15 minutes. If this status has not been updated, then it means that the service has lost network connectivity to the resource, from inside the Virtual Network.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="lastStatusChangedOn">
        /// The date when the resource connectivity status last Changed from success to failure or vice-versa. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="resourceType"> Resource Type. </param>
        /// <param name="isOptional"> Whether this is optional. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="resourceType"/> is null. </exception>
        internal ConnectivityStatusContract(string name, ConnectivityStatusType status, DateTimeOffset lastUpdatedOn, DateTimeOffset lastStatusChangedOn, string resourceType, bool isOptional)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(resourceType, nameof(resourceType));

            Name = name;
            Status = status;
            LastUpdatedOn = lastUpdatedOn;
            LastStatusChangedOn = lastStatusChangedOn;
            ResourceType = resourceType;
            IsOptional = isOptional;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityStatusContract"/>. </summary>
        /// <param name="name"> The hostname of the resource which the service depends on. This can be the database, storage or any other azure resource on which the service depends upon. </param>
        /// <param name="status"> Resource Connectivity Status Type identifier. </param>
        /// <param name="error"> Error details of the connectivity to the resource. </param>
        /// <param name="lastUpdatedOn">
        /// The date when the resource connectivity status was last updated. This status should be updated every 15 minutes. If this status has not been updated, then it means that the service has lost network connectivity to the resource, from inside the Virtual Network.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="lastStatusChangedOn">
        /// The date when the resource connectivity status last Changed from success to failure or vice-versa. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </param>
        /// <param name="resourceType"> Resource Type. </param>
        /// <param name="isOptional"> Whether this is optional. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal ConnectivityStatusContract(string name, ConnectivityStatusType status, string error, DateTimeOffset lastUpdatedOn, DateTimeOffset lastStatusChangedOn, string resourceType, bool isOptional, Dictionary<string, BinaryData> rawData)
        {
            Name = name;
            Status = status;
            Error = error;
            LastUpdatedOn = lastUpdatedOn;
            LastStatusChangedOn = lastStatusChangedOn;
            ResourceType = resourceType;
            IsOptional = isOptional;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConnectivityStatusContract"/> for deserialization. </summary>
        internal ConnectivityStatusContract()
        {
        }

        /// <summary> The hostname of the resource which the service depends on. This can be the database, storage or any other azure resource on which the service depends upon. </summary>
        public string Name { get; }
        /// <summary> Resource Connectivity Status Type identifier. </summary>
        public ConnectivityStatusType Status { get; }
        /// <summary> Error details of the connectivity to the resource. </summary>
        public string Error { get; }
        /// <summary>
        /// The date when the resource connectivity status was last updated. This status should be updated every 15 minutes. If this status has not been updated, then it means that the service has lost network connectivity to the resource, from inside the Virtual Network.The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset LastUpdatedOn { get; }
        /// <summary>
        /// The date when the resource connectivity status last Changed from success to failure or vice-versa. The date conforms to the following format: `yyyy-MM-ddTHH:mm:ssZ` as specified by the ISO 8601 standard.
        ///
        /// </summary>
        public DateTimeOffset LastStatusChangedOn { get; }
        /// <summary> Resource Type. </summary>
        public string ResourceType { get; }
        /// <summary> Whether this is optional. </summary>
        public bool IsOptional { get; }
    }
}
