// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Analytics.Purview.Scanning.Models
{
    /// <summary> The AdlsGen1DataSource. </summary>
    public partial class AdlsGen1DataSource : DataSource
    {
        /// <summary> Initializes a new instance of AdlsGen1DataSource. </summary>
        public AdlsGen1DataSource()
        {
            Kind = DataSourceType.AdlsGen1;
        }

        /// <summary> Initializes a new instance of AdlsGen1DataSource. </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="scans"></param>
        /// <param name="properties"></param>
        internal AdlsGen1DataSource(string id, string name, DataSourceType kind, IReadOnlyList<Scan> scans, AdlsGen1DataSourceProperties properties) : base(id, name, kind, scans)
        {
            Properties = properties;
            Kind = kind;
        }

        /// <summary> Gets or sets the properties. </summary>
        public AdlsGen1DataSourceProperties Properties { get; set; }
    }
}
