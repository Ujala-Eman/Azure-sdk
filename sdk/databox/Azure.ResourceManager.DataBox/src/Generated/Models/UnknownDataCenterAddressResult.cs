// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The UnknownDataCenterAddressResult. </summary>
    internal partial class UnknownDataCenterAddressResult : DataCenterAddressResult
    {
        /// <summary> Initializes a new instance of UnknownDataCenterAddressResult. </summary>
        /// <param name="dataCenterAddressType"> Data center address type. </param>
        /// <param name="supportedCarriersForReturnShipment"> List of supported carriers for return shipment. </param>
        /// <param name="dataCenterAzureLocation"> Azure Location where the Data Center serves primarily. </param>
        internal UnknownDataCenterAddressResult(DataCenterAddressType dataCenterAddressType, IReadOnlyList<string> supportedCarriersForReturnShipment, AzureLocation? dataCenterAzureLocation) : base(dataCenterAddressType, supportedCarriersForReturnShipment, dataCenterAzureLocation)
        {
            DataCenterAddressType = dataCenterAddressType;
        }
    }
}
