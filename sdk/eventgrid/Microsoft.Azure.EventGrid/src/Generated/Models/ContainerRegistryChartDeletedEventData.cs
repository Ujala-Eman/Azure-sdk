// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.EventGrid.Models
{
    using System.Linq;

    /// <summary>
    /// Schema of the Data property of an EventGridEvent for a
    /// Microsoft.ContainerRegistry.ChartDeleted event.
    /// </summary>
    public partial class ContainerRegistryChartDeletedEventData : ContainerRegistryArtifactEventData
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ContainerRegistryChartDeletedEventData class.
        /// </summary>
        public ContainerRegistryChartDeletedEventData()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ContainerRegistryChartDeletedEventData class.
        /// </summary>
        /// <param name="id">The event ID.</param>
        /// <param name="timestamp">The time at which the event
        /// occurred.</param>
        /// <param name="action">The action that encompasses the provided
        /// event.</param>
        /// <param name="target">The target of the event.</param>
        public ContainerRegistryChartDeletedEventData(string id = default(string), System.DateTime? timestamp = default(System.DateTime?), string action = default(string), ContainerRegistryArtifactEventTarget target = default(ContainerRegistryArtifactEventTarget))
            : base(id, timestamp, action, target)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
