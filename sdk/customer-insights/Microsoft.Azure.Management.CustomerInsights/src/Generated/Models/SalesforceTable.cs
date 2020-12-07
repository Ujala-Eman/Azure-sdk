// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Salesforce table.
    /// </summary>
    public partial class SalesforceTable
    {
        /// <summary>
        /// Initializes a new instance of the SalesforceTable class.
        /// </summary>
        public SalesforceTable()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the SalesforceTable class.
        /// </summary>
        /// <param name="tableCategory">The table category.</param>
        /// <param name="tableName">The name of the table.</param>
        /// <param name="tableSchema">The table schema.</param>
        /// <param name="isProfile">Indicating whether this instance is
        /// profile.</param>
        /// <param name="tableRemarks">The table remarks.</param>
        public SalesforceTable(string tableCategory, string tableName, string tableSchema, string isProfile = default(string), string tableRemarks = default(string))
        {
            IsProfile = isProfile;
            TableCategory = tableCategory;
            TableName = tableName;
            TableRemarks = tableRemarks;
            TableSchema = tableSchema;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets indicating whether this instance is profile.
        /// </summary>
        [JsonProperty(PropertyName = "isProfile")]
        public string IsProfile { get; set; }

        /// <summary>
        /// Gets or sets the table category.
        /// </summary>
        [JsonProperty(PropertyName = "tableCategory")]
        public string TableCategory { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        [JsonProperty(PropertyName = "tableName")]
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the table remarks.
        /// </summary>
        [JsonProperty(PropertyName = "tableRemarks")]
        public string TableRemarks { get; set; }

        /// <summary>
        /// Gets or sets the table schema.
        /// </summary>
        [JsonProperty(PropertyName = "tableSchema")]
        public string TableSchema { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (TableCategory == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableCategory");
            }
            if (TableName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableName");
            }
            if (TableSchema == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "TableSchema");
            }
        }
    }
}
