// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberLessThanOrEquals Filter. </summary>
    public partial class NumberLessThanOrEqualsFilter : EventGridFilter
    {
        /// <summary> Initializes a new instance of <see cref="NumberLessThanOrEqualsFilter"/>. </summary>
        public NumberLessThanOrEqualsFilter()
        {
            OperatorType = FilterOperatorType.NumberLessThanOrEquals;
        }

        /// <summary> Initializes a new instance of <see cref="NumberLessThanOrEqualsFilter"/>. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="value"> The filter value. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal NumberLessThanOrEqualsFilter(FilterOperatorType operatorType, string key, double? value, Dictionary<string, BinaryData> rawData) : base(operatorType, key, rawData)
        {
            Value = value;
            OperatorType = operatorType;
        }

        /// <summary> The filter value. </summary>
        public double? Value { get; set; }
    }
}
