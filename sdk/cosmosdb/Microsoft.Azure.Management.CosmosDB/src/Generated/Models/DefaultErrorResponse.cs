// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CosmosDB.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// An error response from the service.
    /// </summary>
    public partial class DefaultErrorResponse
    {
        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponse class.
        /// </summary>
        public DefaultErrorResponse()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DefaultErrorResponse class.
        /// </summary>
        public DefaultErrorResponse(ErrorResponse error = default(ErrorResponse))
        {
            Error = error;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public ErrorResponse Error { get; set; }

    }
}
