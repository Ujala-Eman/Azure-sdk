// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AmazonPostgreSqlProperties. </summary>
    public partial class AmazonPostgreSqlProperties : DataSourceProperties
    {
        /// <summary> Initializes a new instance of AmazonPostgreSqlProperties. </summary>
        public AmazonPostgreSqlProperties()
        {
        }

        /// <summary> Initializes a new instance of AmazonPostgreSqlProperties. </summary>
        /// <param name="createdAt"></param>
        /// <param name="lastModifiedAt"></param>
        /// <param name="collection"></param>
        /// <param name="serverEndpoint"></param>
        /// <param name="port"></param>
        internal AmazonPostgreSqlProperties(DateTimeOffset? createdAt, DateTimeOffset? lastModifiedAt, DataSourcePropertiesCollection collection, string serverEndpoint, string port) : base(createdAt, lastModifiedAt, collection)
        {
            ServerEndpoint = serverEndpoint;
            Port = port;
        }

        /// <summary> Gets or sets the server endpoint. </summary>
        public string ServerEndpoint { get; set; }
        /// <summary> Gets or sets the port. </summary>
        public string Port { get; set; }
    }
}
