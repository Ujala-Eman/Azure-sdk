// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Container for data asset versions. </summary>
    public partial class DataContainerProperties : AssetContainer
    {
        /// <summary> Initializes a new instance of <see cref="DataContainerProperties"/>. </summary>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        public DataContainerProperties(DataType dataType)
        {
            DataType = dataType;
        }

        /// <summary> Initializes a new instance of <see cref="DataContainerProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="latestVersion"> The latest version inside this container. </param>
        /// <param name="nextVersion"> The next auto incremental version. </param>
        /// <param name="dataType"> [Required] Specifies the type of data. </param>
        internal DataContainerProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isArchived, string latestVersion, string nextVersion, DataType dataType) : base(description, properties, tags, isArchived, latestVersion, nextVersion)
        {
            DataType = dataType;
        }

        /// <summary> [Required] Specifies the type of data. </summary>
        public DataType DataType { get; set; }
    }
}
