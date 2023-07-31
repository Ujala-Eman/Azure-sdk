// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppContainers.Models
{
    /// <summary>
    /// Container App versioned application definition.
    /// Defines the desired state of an immutable revision.
    /// Any changes to this section Will result in a new revision being created
    /// </summary>
    public partial class ContainerAppTemplate
    {
        /// <summary> Initializes a new instance of ContainerAppTemplate. </summary>
        public ContainerAppTemplate()
        {
            InitContainers = new ChangeTrackingList<ContainerAppInitContainer>();
            Containers = new ChangeTrackingList<ContainerAppContainer>();
            Volumes = new ChangeTrackingList<ContainerAppVolume>();
            ServiceBinds = new ChangeTrackingList<ServiceBind>();
        }

        /// <summary> Initializes a new instance of ContainerAppTemplate. </summary>
        /// <param name="revisionSuffix"> User friendly suffix that is appended to the revision name. </param>
        /// <param name="terminationGracePeriodSeconds"> Optional duration in seconds the Container App Instance needs to terminate gracefully. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds. </param>
        /// <param name="initContainers"> List of specialized containers that run before app containers. </param>
        /// <param name="containers"> List of container definitions for the Container App. </param>
        /// <param name="scale"> Scaling properties for the Container App. </param>
        /// <param name="volumes"> List of volume definitions for the Container App. </param>
        /// <param name="serviceBinds"> List of container app services bound to the app. </param>
        internal ContainerAppTemplate(string revisionSuffix, long? terminationGracePeriodSeconds, IList<ContainerAppInitContainer> initContainers, IList<ContainerAppContainer> containers, ContainerAppScale scale, IList<ContainerAppVolume> volumes, IList<ServiceBind> serviceBinds)
        {
            RevisionSuffix = revisionSuffix;
            TerminationGracePeriodSeconds = terminationGracePeriodSeconds;
            InitContainers = initContainers;
            Containers = containers;
            Scale = scale;
            Volumes = volumes;
            ServiceBinds = serviceBinds;
        }

        /// <summary> User friendly suffix that is appended to the revision name. </summary>
        public string RevisionSuffix { get; set; }
        /// <summary> Optional duration in seconds the Container App Instance needs to terminate gracefully. Value must be non-negative integer. The value zero indicates stop immediately via the kill signal (no opportunity to shut down). If this value is nil, the default grace period will be used instead. Set this value longer than the expected cleanup time for your process. Defaults to 30 seconds. </summary>
        public long? TerminationGracePeriodSeconds { get; set; }
        /// <summary> List of specialized containers that run before app containers. </summary>
        public IList<ContainerAppInitContainer> InitContainers { get; }
        /// <summary> List of container definitions for the Container App. </summary>
        public IList<ContainerAppContainer> Containers { get; }
        /// <summary> Scaling properties for the Container App. </summary>
        public ContainerAppScale Scale { get; set; }
        /// <summary> List of volume definitions for the Container App. </summary>
        public IList<ContainerAppVolume> Volumes { get; }
        /// <summary> List of container app services bound to the app. </summary>
        public IList<ServiceBind> ServiceBinds { get; }
    }
}
