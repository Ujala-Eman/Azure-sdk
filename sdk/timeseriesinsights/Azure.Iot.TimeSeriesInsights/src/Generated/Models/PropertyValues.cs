// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Iot.TimeSeriesInsights
{
    /// <summary> Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property. </summary>
    public partial class PropertyValues : EventProperty
    {
        /// <summary> Initializes a new instance of PropertyValues. </summary>
        public PropertyValues()
        {
            Values = new ChangeTrackingList<object>();
        }

        /// <summary> Initializes a new instance of PropertyValues. </summary>
        /// <param name="name"> The name of the property. </param>
        /// <param name="type"> The type of the property. </param>
        /// <param name="values"> Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property. </param>
        internal PropertyValues(string name, PropertyTypes? type, IList<object> values) : base(name, type)
        {
            Values = values;
        }

        /// <summary> Values of a single property corresponding to the timestamps. May contain nulls. Type of values matches the type of property. </summary>
        public IList<object> Values { get; }
    }
}
