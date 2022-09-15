// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Reservations.Models;

namespace Azure.ResourceManager.Reservations
{
    /// <summary> A class representing the ReservationQuotum data model. </summary>
    public partial class ReservationQuotumData : ResourceData
    {
        /// <summary> Initializes a new instance of ReservationQuotumData. </summary>
        public ReservationQuotumData()
        {
        }

        /// <summary> Initializes a new instance of ReservationQuotumData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="properties"> Quota properties for the resource. </param>
        internal ReservationQuotumData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, QuotaProperties properties) : base(id, name, resourceType, systemData)
        {
            Properties = properties;
        }

        /// <summary> Quota properties for the resource. </summary>
        public QuotaProperties Properties { get; set; }
    }
}
