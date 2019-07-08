// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ManagedServices.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// List of the operations.
    /// </summary>
    public partial class OperationList
    {
        /// <summary>
        /// Initializes a new instance of the OperationList class.
        /// </summary>
        public OperationList()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationList class.
        /// </summary>
        /// <param name="value">List of Microsoft.ManagedServices
        /// operations.</param>
        public OperationList(IList<Operation> value = default(IList<Operation>))
        {
            Value = value;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets list of Microsoft.ManagedServices operations.
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public IList<Operation> Value { get; private set; }

    }
}
