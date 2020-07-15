// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Messaging.EventGrid.Models
{
    /// <summary> Schema of the Data property of an EventGridEvent for a Microsoft.ContainerRegistry.ChartDeleted event. </summary>
    internal partial class ContainerRegistryChartDeletedEventData : ContainerRegistryArtifactEventData
    {
        /// <summary> Initializes a new instance of ContainerRegistryChartDeletedEventData. </summary>
        internal ContainerRegistryChartDeletedEventData()
        {
        }

        /// <summary> Initializes a new instance of ContainerRegistryChartDeletedEventData. </summary>
        /// <param name="id"> The event ID. </param>
        /// <param name="timestamp"> The time at which the event occurred. </param>
        /// <param name="action"> The action that encompasses the provided event. </param>
        /// <param name="target"> The target of the event. </param>
        internal ContainerRegistryChartDeletedEventData(string id, DateTimeOffset? timestamp, string action, ContainerRegistryArtifactEventTarget target) : base(id, timestamp, action, target)
        {
        }
    }
}
