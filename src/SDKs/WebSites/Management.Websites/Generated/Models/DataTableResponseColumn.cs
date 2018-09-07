// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Column definition
    /// </summary>
    public partial class DataTableResponseColumn
    {
        /// <summary>
        /// Initializes a new instance of the DataTableResponseColumn class.
        /// </summary>
        public DataTableResponseColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DataTableResponseColumn class.
        /// </summary>
        /// <param name="columnName">Name of the column</param>
        /// <param name="dataType">Data type which looks like 'String' or
        /// 'Int32'.</param>
        /// <param name="columnType">Column Type</param>
        public DataTableResponseColumn(string columnName = default(string), string dataType = default(string), string columnType = default(string))
        {
            ColumnName = columnName;
            DataType = dataType;
            ColumnType = columnType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name of the column
        /// </summary>
        [JsonProperty(PropertyName = "columnName")]
        public string ColumnName { get; set; }

        /// <summary>
        /// Gets or sets data type which looks like 'String' or 'Int32'.
        /// </summary>
        [JsonProperty(PropertyName = "dataType")]
        public string DataType { get; set; }

        /// <summary>
        /// Gets or sets column Type
        /// </summary>
        [JsonProperty(PropertyName = "columnType")]
        public string ColumnType { get; set; }

    }
}
