// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DeviceUpdate.Models
{
    /// <summary> Customer-initiated diagnostic log collection storage properties. </summary>
    public partial class DiagnosticStorageProperties
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="DiagnosticStorageProperties"/>. </summary>
        /// <param name="authenticationType"> Authentication Type. </param>
        /// <param name="resourceId"> ResourceId of the diagnostic storage account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="resourceId"/> is null. </exception>
        public DiagnosticStorageProperties(AuthenticationType authenticationType, string resourceId)
        {
            Argument.AssertNotNull(resourceId, nameof(resourceId));

            AuthenticationType = authenticationType;
            ResourceId = resourceId;
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticStorageProperties"/>. </summary>
        /// <param name="authenticationType"> Authentication Type. </param>
        /// <param name="connectionString"> ConnectionString of the diagnostic storage account. </param>
        /// <param name="resourceId"> ResourceId of the diagnostic storage account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticStorageProperties(AuthenticationType authenticationType, string connectionString, string resourceId, Dictionary<string, BinaryData> rawData)
        {
            AuthenticationType = authenticationType;
            ConnectionString = connectionString;
            ResourceId = resourceId;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticStorageProperties"/> for deserialization. </summary>
        internal DiagnosticStorageProperties()
        {
        }

        /// <summary> Authentication Type. </summary>
        public AuthenticationType AuthenticationType { get; set; }
        /// <summary> ConnectionString of the diagnostic storage account. </summary>
        public string ConnectionString { get; set; }
        /// <summary> ResourceId of the diagnostic storage account. </summary>
        public string ResourceId { get; set; }
    }
}
