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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Runtime information of a container instance.
    /// </summary>
    public partial class ContainerInstanceView
    {
        /// <summary>
        /// Initializes a new instance of the ContainerInstanceView class.
        /// </summary>
        public ContainerInstanceView()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ContainerInstanceView class.
        /// </summary>
        /// <param name="restartCount">The number of times the container has
        /// been restarted.</param>
        /// <param name="currentState">Current container instance
        /// state.</param>
        /// <param name="previousState">Previous container instance
        /// state.</param>
        /// <param name="events">The events of this container instance.</param>
        public ContainerInstanceView(int? restartCount = default(int?), ContainerState currentState = default(ContainerState), ContainerState previousState = default(ContainerState), IList<ContainerEvent> events = default(IList<ContainerEvent>))
        {
            RestartCount = restartCount;
            CurrentState = currentState;
            PreviousState = previousState;
            Events = events;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the number of times the container has been restarted.
        /// </summary>
        [JsonProperty(PropertyName = "restartCount")]
        public int? RestartCount { get; set; }

        /// <summary>
        /// Gets or sets current container instance state.
        /// </summary>
        [JsonProperty(PropertyName = "currentState")]
        public ContainerState CurrentState { get; set; }

        /// <summary>
        /// Gets or sets previous container instance state.
        /// </summary>
        [JsonProperty(PropertyName = "previousState")]
        public ContainerState PreviousState { get; set; }

        /// <summary>
        /// Gets or sets the events of this container instance.
        /// </summary>
        [JsonProperty(PropertyName = "events")]
        public IList<ContainerEvent> Events { get; set; }

    }
}
