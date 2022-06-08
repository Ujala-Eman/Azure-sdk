// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Applications.Containers.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Applications.Containers
{
    /// <summary> A class representing the ManagedEnvironmentStorage data model. </summary>
    public partial class ManagedEnvironmentStorageData : ResourceData
    {
        /// <summary> Initializes a new instance of <see cref="ManagedEnvironmentStorageData"/>. </summary>
        public ManagedEnvironmentStorageData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ManagedEnvironmentStorageData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Storage properties. </param>
        internal ManagedEnvironmentStorageData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ManagedEnvironmentStorageProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Storage properties. </summary>
        internal ManagedEnvironmentStorageProperties Properties { get; set; }
        /// <summary> Azure file properties. </summary>
        public AzureFileProperties ManagedEnvironmentStorageAzureFile
        {
            get => Properties is null ? default : Properties.AzureFile;
            set
            {
                if (Properties is null)
                    Properties = new ManagedEnvironmentStorageProperties();
                Properties.AzureFile = value;
            }
        }
    }
}
