// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the GeoBackupPolicy data model.
    /// A database geo backup policy.
    /// </summary>
    public partial class GeoBackupPolicyData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="GeoBackupPolicyData"/>. </summary>
        /// <param name="state"> The state of the geo backup policy. </param>
        public GeoBackupPolicyData(GeoBackupPolicyState state)
        {
            State = state;
        }

        /// <summary> Initializes a new instance of <see cref="GeoBackupPolicyData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Kind of geo backup policy.  This is metadata used for the Azure portal experience. </param>
        /// <param name="location"> Backup policy location. </param>
        /// <param name="state"> The state of the geo backup policy. </param>
        /// <param name="storageType"> The storage type of the geo backup policy. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal GeoBackupPolicyData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string kind, AzureLocation? location, GeoBackupPolicyState state, string storageType, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
            Location = location;
            State = state;
            StorageType = storageType;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="GeoBackupPolicyData"/> for deserialization. </summary>
        internal GeoBackupPolicyData()
        {
        }

        /// <summary> Kind of geo backup policy.  This is metadata used for the Azure portal experience. </summary>
        public string Kind { get; }
        /// <summary> Backup policy location. </summary>
        public AzureLocation? Location { get; }
        /// <summary> The state of the geo backup policy. </summary>
        public GeoBackupPolicyState State { get; set; }
        /// <summary> The storage type of the geo backup policy. </summary>
        public string StorageType { get; }
    }
}
