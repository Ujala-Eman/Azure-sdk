// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Azure.Communication.JobRouter.Models
{
    /// <summary> Describes a condition that must be met against a set of labels for queue selection. </summary>
    public partial class RouterQueueSelector
    {
        /// <summary> Initializes a new instance of RouterQueueSelector. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the label selector. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> is null. </exception>
        public RouterQueueSelector(string key, LabelOperator labelOperator)
        {
            Argument.AssertNotNull(key, nameof(key));

            Key = key;
            LabelOperator = labelOperator;
        }

        /// <summary> Initializes a new instance of RouterQueueSelector. </summary>
        /// <param name="key"> The label key to query against. </param>
        /// <param name="labelOperator"> Describes how the value of the label is compared to the value defined on the label selector. </param>
        /// <param name="value"> The value to compare against the actual label value with the given operator. </param>
        internal RouterQueueSelector(string key, LabelOperator labelOperator, object value)
        {
            Key = key;
            LabelOperator = labelOperator;
            Value = value;
        }

        /// <summary> The label key to query against. </summary>
        public string Key { get; set; }
        /// <summary> Describes how the value of the label is compared to the value defined on the label selector. </summary>
        public LabelOperator LabelOperator { get; set; }
        /// <summary> The value to compare against the actual label value with the given operator. </summary>
        public object Value { get; set; }
    }
}
