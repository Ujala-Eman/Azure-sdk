// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary> A workload profile with specific hardware configure to run container apps. </summary>
    public partial class ContainerAppAvailableWorkloadProfile : ResourceData
    {
        /// <summary> Initializes a new instance of ContainerAppAvailableWorkloadProfile. </summary>
        public ContainerAppAvailableWorkloadProfile()
        {
        }

        /// <summary> Initializes a new instance of ContainerAppAvailableWorkloadProfile. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Region of the workload profile. </param>
        /// <param name="properties"> Revision resource specific properties. </param>
        internal ContainerAppAvailableWorkloadProfile(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, AzureLocation? location, ContainerAppAvailableWorkloadProfileProperties properties) : base(id, name, resourceType, systemData)
        {
            Location = location;
            Properties = properties;
        }

        /// <summary> Region of the workload profile. </summary>
        public AzureLocation? Location { get; set; }
        /// <summary> Revision resource specific properties. </summary>
        public ContainerAppAvailableWorkloadProfileProperties Properties { get; set; }
    }
}
