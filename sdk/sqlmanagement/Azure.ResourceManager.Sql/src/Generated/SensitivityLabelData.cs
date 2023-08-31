// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary>
    /// A class representing the SensitivityLabel data model.
    /// A sensitivity label.
    /// </summary>
    public partial class SensitivityLabelData : ResourceData
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="SensitivityLabelData"/>. </summary>
        public SensitivityLabelData()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SensitivityLabelData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="managedBy"> Resource that manages the sensitivity label. </param>
        /// <param name="schemaName"> The schema name. </param>
        /// <param name="tableName"> The table name. </param>
        /// <param name="columnName"> The column name. </param>
        /// <param name="labelName"> The label name. </param>
        /// <param name="labelId"> The label ID. </param>
        /// <param name="informationType"> The information type. </param>
        /// <param name="informationTypeId"> The information type ID. </param>
        /// <param name="isDisabled"> Is sensitivity recommendation disabled. Applicable for recommended sensitivity label only. Specifies whether the sensitivity recommendation on this column is disabled (dismissed) or not. </param>
        /// <param name="rank"></param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal SensitivityLabelData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string managedBy, string schemaName, string tableName, string columnName, string labelName, string labelId, string informationType, string informationTypeId, bool? isDisabled, SensitivityLabelRank? rank, Dictionary<string, BinaryData> rawData) : base(id, name, resourceType, systemData)
        {
            ManagedBy = managedBy;
            SchemaName = schemaName;
            TableName = tableName;
            ColumnName = columnName;
            LabelName = labelName;
            LabelId = labelId;
            InformationType = informationType;
            InformationTypeId = informationTypeId;
            IsDisabled = isDisabled;
            Rank = rank;
            _rawData = rawData;
        }

        /// <summary> Resource that manages the sensitivity label. </summary>
        public string ManagedBy { get; }
        /// <summary> The schema name. </summary>
        public string SchemaName { get; }
        /// <summary> The table name. </summary>
        public string TableName { get; }
        /// <summary> The column name. </summary>
        public string ColumnName { get; }
        /// <summary> The label name. </summary>
        public string LabelName { get; set; }
        /// <summary> The label ID. </summary>
        public string LabelId { get; set; }
        /// <summary> The information type. </summary>
        public string InformationType { get; set; }
        /// <summary> The information type ID. </summary>
        public string InformationTypeId { get; set; }
        /// <summary> Is sensitivity recommendation disabled. Applicable for recommended sensitivity label only. Specifies whether the sensitivity recommendation on this column is disabled (dismissed) or not. </summary>
        public bool? IsDisabled { get; }
        /// <summary> Gets or sets the rank. </summary>
        public SensitivityLabelRank? Rank { get; set; }
    }
}
