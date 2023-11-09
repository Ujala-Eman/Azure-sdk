// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.AppService.Models
{
    /// <summary> Set of data with rendering instructions. </summary>
    public partial class DiagnosticDataset
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DiagnosticDataset"/>. </summary>
        public DiagnosticDataset()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DiagnosticDataset"/>. </summary>
        /// <param name="table"> Data in table form. </param>
        /// <param name="renderingProperties"> Properties that describe how the table should be rendered. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DiagnosticDataset(DataTableResponseObject table, DiagnosticDataRendering renderingProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Table = table;
            RenderingProperties = renderingProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Data in table form. </summary>
        public DataTableResponseObject Table { get; set; }
        /// <summary> Properties that describe how the table should be rendered. </summary>
        public DiagnosticDataRendering RenderingProperties { get; set; }
    }
}
