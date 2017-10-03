// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataFactory;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The relational table dataset.
    /// </summary>
    [Newtonsoft.Json.JsonObject("RelationalTable")]
    [Rest.Serialization.JsonTransformation]
    public partial class RelationalTableDataset : Dataset
    {
        /// <summary>
        /// Initializes a new instance of the RelationalTableDataset class.
        /// </summary>
        public RelationalTableDataset()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RelationalTableDataset class.
        /// </summary>
        /// <param name="linkedServiceName">Linked service reference.</param>
        /// <param name="description">Dataset description.</param>
        /// <param name="structure">Columns that define the structure of the
        /// dataset. Type: array (or Expression with resultType array),
        /// itemType: DatasetDataElement.</param>
        /// <param name="parameters">Parameters for dataset.</param>
        /// <param name="tableName">The relational table name. Type: string (or
        /// Expression with resultType string).</param>
        public RelationalTableDataset(LinkedServiceReference linkedServiceName, string description = default(string), object structure = default(object), IDictionary<string, ParameterSpecification> parameters = default(IDictionary<string, ParameterSpecification>), object tableName = default(object))
            : base(linkedServiceName, description, structure, parameters)
        {
            LinkedServiceName = new LinkedServiceReference();
            TableName = tableName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the relational table name. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.tableName")]
        public object TableName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
