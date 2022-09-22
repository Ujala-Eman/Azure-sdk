// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> NumberNotIn Advanced Filter. </summary>
    public partial class NumberNotInAdvancedFilter : AdvancedFilter
    {
        /// <summary> Initializes a new instance of NumberNotInAdvancedFilter. </summary>
        public NumberNotInAdvancedFilter()
        {
            Values = new ChangeTrackingList<double>();
            OperatorType = AdvancedFilterOperatorType.NumberNotIn;
        }

        /// <summary> Initializes a new instance of NumberNotInAdvancedFilter. </summary>
        /// <param name="operatorType"> The operator type used for filtering, e.g., NumberIn, StringContains, BoolEquals and others. </param>
        /// <param name="key"> The field/property in the event based on which you want to filter. </param>
        /// <param name="values"> The set of filter values. </param>
        internal NumberNotInAdvancedFilter(AdvancedFilterOperatorType operatorType, string key, IList<double> values) : base(operatorType, key)
        {
            Values = values;
            OperatorType = operatorType;
        }

        /// <summary> The set of filter values. </summary>
        public IList<double> Values { get; }
    }
}
