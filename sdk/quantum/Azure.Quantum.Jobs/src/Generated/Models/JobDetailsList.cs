// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Azure.Quantum.Jobs.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of job details.
    /// </summary>
    public partial class JobDetailsList
    {
        /// <summary>
        /// Initializes a new instance of the JobDetailsList class.
        /// </summary>
        public JobDetailsList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the JobDetailsList class.
        /// </summary>
        /// <param name="count">Total records count number.</param>
        /// <param name="nextLink">Link to the next page of results.</param>
        public JobDetailsList(IList<JobDetails> value = default(IList<JobDetails>), long? count = default(long?), string nextLink = default(string))
        {
            Value = value;
            Count = count;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<JobDetails> Value { get; private set; }

        /// <summary>
        /// Gets or sets total records count number.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public long? Count { get; set; }

        /// <summary>
        /// Gets link to the next page of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; private set; }

    }
}
