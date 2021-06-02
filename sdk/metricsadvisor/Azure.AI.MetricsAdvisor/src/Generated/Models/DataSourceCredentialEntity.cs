// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataSourceCredential. </summary>
    public partial class DatasourceCredential
    {

        /// <summary> Initializes a new instance of DataSourceCredentialEntity. </summary>
        /// <param name="dataSourceCredentialType"> Type of data source credential. </param>
        /// <param name="id"> Unique id of data source credential. </param>
        /// <param name="name"> Name of data source credential. </param>
        /// <param name="description"> Description of data source credential. </param>
        internal DatasourceCredential(DataSourceCredentialType dataSourceCredentialType, string id, string name, string description)
        {
            DataSourceCredentialType = dataSourceCredentialType;
            Id = id;
            Name = name;
            Description = description;
        }

        /// <summary> Type of data source credential. </summary>
        internal DataSourceCredentialType DataSourceCredentialType { get; set; }
    }
}
