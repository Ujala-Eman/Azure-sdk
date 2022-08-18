// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Request body to get the configuration for the region. </summary>
    public partial class RegionConfigurationRequest
    {
        /// <summary> Initializes a new instance of RegionConfigurationRequest. </summary>
        public RegionConfigurationRequest()
        {
        }

        /// <summary>
        /// Request body to get the availability for scheduling orders.
        /// Please note <see cref="ScheduleAvailabilityRequest"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DataBoxScheduleAvailabilityRequest"/>, <see cref="DiskScheduleAvailabilityRequest"/> and <see cref="HeavyScheduleAvailabilityRequest"/>.
        /// </summary>
        public ScheduleAvailabilityRequest ScheduleAvailabilityRequest { get; set; }
        /// <summary> Request body to get the transport availability for given sku. </summary>
        internal TransportAvailabilityRequest TransportAvailabilityRequest { get; set; }
        /// <summary> Type of the device. </summary>
        public DataBoxSkuName? TransportAvailabilityRequestSkuName
        {
            get => TransportAvailabilityRequest is null ? default : TransportAvailabilityRequest.SkuName;
            set
            {
                if (TransportAvailabilityRequest is null)
                    TransportAvailabilityRequest = new TransportAvailabilityRequest();
                TransportAvailabilityRequest.SkuName = value;
            }
        }

        /// <summary> Request body to get the datacenter address for given sku. </summary>
        public DatacenterAddressRequest DatacenterAddressRequest { get; set; }
    }
}
