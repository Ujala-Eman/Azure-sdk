// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.DataLake.Analytics.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.DataLake;
    using Microsoft.Azure.Management.DataLake.Analytics;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A Data Lake Analytics catalog U-SQL table valued function item.
    /// </summary>
    public partial class USqlTableValuedFunction : CatalogItem
    {
        /// <summary>
        /// Initializes a new instance of the USqlTableValuedFunction class.
        /// </summary>
        public USqlTableValuedFunction()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the USqlTableValuedFunction class.
        /// </summary>
        /// <param name="computeAccountName">the name of the Data Lake
        /// Analytics account.</param>
        /// <param name="version">the version of the catalog item.</param>
        /// <param name="databaseName">the name of the database.</param>
        /// <param name="schemaName">the name of the schema associated with
        /// this database.</param>
        /// <param name="name">the name of the table valued function.</param>
        /// <param name="definition">the definition of the table valued
        /// function.</param>
        public USqlTableValuedFunction(string computeAccountName = default(string), System.Guid? version = default(System.Guid?), string databaseName = default(string), string schemaName = default(string), string name = default(string), string definition = default(string))
            : base(computeAccountName, version)
        {
            DatabaseName = databaseName;
            SchemaName = schemaName;
            Name = name;
            Definition = definition;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the database.
        /// </summary>
        [JsonProperty(PropertyName = "databaseName")]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Gets or sets the name of the schema associated with this database.
        /// </summary>
        [JsonProperty(PropertyName = "schemaName")]
        public string SchemaName { get; set; }

        /// <summary>
        /// Gets or sets the name of the table valued function.
        /// </summary>
        [JsonProperty(PropertyName = "tvfName")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the definition of the table valued function.
        /// </summary>
        [JsonProperty(PropertyName = "definition")]
        public string Definition { get; set; }

    }
}
