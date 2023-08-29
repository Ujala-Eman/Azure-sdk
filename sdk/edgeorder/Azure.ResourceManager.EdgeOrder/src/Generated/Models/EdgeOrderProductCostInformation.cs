// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EdgeOrder.Models
{
    /// <summary> Cost information for the product system. </summary>
    public partial class EdgeOrderProductCostInformation
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductCostInformation"/>. </summary>
        internal EdgeOrderProductCostInformation()
        {
            BillingMeterDetails = new ChangeTrackingList<EdgeOrderProductBillingMeterDetails>();
        }

        /// <summary> Initializes a new instance of <see cref="EdgeOrderProductCostInformation"/>. </summary>
        /// <param name="billingMeterDetails"> Details on the various billing aspects for the product system. </param>
        /// <param name="billingInfoUri"> Default url to display billing information. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal EdgeOrderProductCostInformation(IReadOnlyList<EdgeOrderProductBillingMeterDetails> billingMeterDetails, Uri billingInfoUri, Dictionary<string, BinaryData> rawData)
        {
            BillingMeterDetails = billingMeterDetails;
            BillingInfoUri = billingInfoUri;
            _rawData = rawData;
        }

        /// <summary> Details on the various billing aspects for the product system. </summary>
        public IReadOnlyList<EdgeOrderProductBillingMeterDetails> BillingMeterDetails { get; }
        /// <summary> Default url to display billing information. </summary>
        public Uri BillingInfoUri { get; }
    }
}
