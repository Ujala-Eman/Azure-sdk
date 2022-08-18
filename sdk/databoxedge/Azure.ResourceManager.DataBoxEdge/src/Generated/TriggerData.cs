// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the Trigger data model.
    /// Please note <see cref="TriggerData"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="FileEventTrigger"/> and <see cref="PeriodicTimerEventTrigger"/>.
    /// </summary>
    public partial class TriggerData : ResourceData
    {
        /// <summary> Initializes a new instance of TriggerData. </summary>
        public TriggerData()
        {
        }

        /// <summary> Initializes a new instance of TriggerData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="kind"> Trigger Kind. </param>
        internal TriggerData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, TriggerEventType kind) : base(id, name, resourceType, systemData)
        {
            Kind = kind;
        }

        /// <summary> Trigger Kind. </summary>
        internal TriggerEventType Kind { get; set; }
    }
}
