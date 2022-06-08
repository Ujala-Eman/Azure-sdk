// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Applications.Containers.Models
{
    /// <summary> Container object under Container App Revision Replica. </summary>
    public partial class ReplicaContainer
    {
        /// <summary> Initializes a new instance of <see cref="ReplicaContainer"/>. </summary>
        public ReplicaContainer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ReplicaContainer"/>. </summary>
        /// <param name="name"> The Name of the Container. </param>
        /// <param name="containerId"> The Id of the Container. </param>
        /// <param name="ready"> The container ready status. </param>
        /// <param name="started"> The container start status. </param>
        /// <param name="restartCount"> The container restart count. </param>
        internal ReplicaContainer(string name, string containerId, bool? ready, bool? started, int? restartCount)
        {
            Name = name;
            ContainerId = containerId;
            Ready = ready;
            Started = started;
            RestartCount = restartCount;
        }

        /// <summary> The Name of the Container. </summary>
        public string Name { get; set; }
        /// <summary> The Id of the Container. </summary>
        public string ContainerId { get; set; }
        /// <summary> The container ready status. </summary>
        public bool? Ready { get; set; }
        /// <summary> The container start status. </summary>
        public bool? Started { get; set; }
        /// <summary> The container restart count. </summary>
        public int? RestartCount { get; set; }
    }
}
