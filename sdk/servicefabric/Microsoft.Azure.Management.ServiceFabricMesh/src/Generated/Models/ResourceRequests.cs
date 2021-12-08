// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabricMesh.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// This type describes the requested resources for a given container. It
    /// describes the least amount of resources required for the container. A
    /// container can consume more than requested resources up to the specified
    /// limits before being restarted. Currently, the requested resources are
    /// treated as limits.
    /// </summary>
    public partial class ResourceRequests
    {
        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        public ResourceRequests()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ResourceRequests class.
        /// </summary>
        /// <param name="memoryInGB">The memory request in GB for this
        /// container.</param>
        /// <param name="cpu">Requested number of CPU cores. At present, only
        /// full cores are supported.</param>
        public ResourceRequests(double memoryInGB, double cpu)
        {
            MemoryInGB = memoryInGB;
            Cpu = cpu;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the memory request in GB for this container.
        /// </summary>
        [JsonProperty(PropertyName = "memoryInGB")]
        public double MemoryInGB { get; set; }

        /// <summary>
        /// Gets or sets requested number of CPU cores. At present, only full
        /// cores are supported.
        /// </summary>
        [JsonProperty(PropertyName = "cpu")]
        public double Cpu { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
