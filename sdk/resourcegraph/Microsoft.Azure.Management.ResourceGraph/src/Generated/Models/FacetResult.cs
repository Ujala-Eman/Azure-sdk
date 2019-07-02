// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ResourceGraph.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Successfully executed facet containing additional statistics on the
    /// response of a query.
    /// </summary>
    public partial class FacetResult : Facet
    {
        /// <summary>
        /// Initializes a new instance of the FacetResult class.
        /// </summary>
        public FacetResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FacetResult class.
        /// </summary>
        /// <param name="expression">Facet expression, same as in the
        /// corresponding facet request.</param>
        /// <param name="totalRecords">Number of total records in the facet
        /// results.</param>
        /// <param name="count">Number of records returned in the facet
        /// response.</param>
        /// <param name="data">A table containing the desired facets. Only
        /// present if the facet is valid.</param>
        public FacetResult(string expression, long totalRecords, int count, object data)
            : base(expression)
        {
            TotalRecords = totalRecords;
            Count = count;
            Data = data;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets number of total records in the facet results.
        /// </summary>
        [JsonProperty(PropertyName = "totalRecords")]
        public long TotalRecords { get; set; }

        /// <summary>
        /// Gets or sets number of records returned in the facet response.
        /// </summary>
        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        /// <summary>
        /// Gets or sets a table containing the desired facets. Only present if
        /// the facet is valid.
        /// </summary>
        [JsonProperty(PropertyName = "data")]
        public object Data { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Data == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Data");
            }
        }
    }
}
