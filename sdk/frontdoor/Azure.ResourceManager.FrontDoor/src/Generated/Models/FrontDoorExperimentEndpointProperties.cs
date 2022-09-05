// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.FrontDoor.Models
{
    /// <summary> Defines the endpoint properties. </summary>
    public partial class FrontDoorExperimentEndpointProperties
    {
        /// <summary> Initializes a new instance of FrontDoorExperimentEndpointProperties. </summary>
        public FrontDoorExperimentEndpointProperties()
        {
        }

        /// <summary> Initializes a new instance of FrontDoorExperimentEndpointProperties. </summary>
        /// <param name="name"> The name of the endpoint. </param>
        /// <param name="endpoint"> The endpoint URL. </param>
        internal FrontDoorExperimentEndpointProperties(string name, string endpoint)
        {
            Name = name;
            Endpoint = endpoint;
        }

        /// <summary> The name of the endpoint. </summary>
        public string Name { get; set; }
        /// <summary> The endpoint URL. </summary>
        public string Endpoint { get; set; }
    }
}
