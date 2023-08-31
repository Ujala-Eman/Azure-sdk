// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Quantum.Jobs.Models
{
    /// <summary> Usage event details. </summary>
    public partial class UsageEvent
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="UsageEvent"/>. </summary>
        internal UsageEvent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UsageEvent"/>. </summary>
        /// <param name="dimensionId"> The dimension id. </param>
        /// <param name="dimensionName"> The dimension name. </param>
        /// <param name="measureUnit"> The unit of measure. </param>
        /// <param name="amountBilled"> The amount billed. </param>
        /// <param name="amountConsumed"> The amount consumed. </param>
        /// <param name="unitPrice"> The unit price. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal UsageEvent(string dimensionId, string dimensionName, string measureUnit, float? amountBilled, float? amountConsumed, float? unitPrice, Dictionary<string, BinaryData> rawData)
        {
            DimensionId = dimensionId;
            DimensionName = dimensionName;
            MeasureUnit = measureUnit;
            AmountBilled = amountBilled;
            AmountConsumed = amountConsumed;
            UnitPrice = unitPrice;
            _rawData = rawData;
        }

        /// <summary> The dimension id. </summary>
        public string DimensionId { get; }
        /// <summary> The dimension name. </summary>
        public string DimensionName { get; }
        /// <summary> The unit of measure. </summary>
        public string MeasureUnit { get; }
        /// <summary> The amount billed. </summary>
        public float? AmountBilled { get; }
        /// <summary> The amount consumed. </summary>
        public float? AmountConsumed { get; }
        /// <summary> The unit price. </summary>
        public float? UnitPrice { get; }
    }
}
