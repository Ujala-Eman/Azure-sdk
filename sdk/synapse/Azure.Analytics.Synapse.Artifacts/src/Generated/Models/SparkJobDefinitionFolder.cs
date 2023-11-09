// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary> The folder that this Spark job definition is in. If not specified, this Spark job definition will appear at the root level. </summary>
    public partial class SparkJobDefinitionFolder
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SparkJobDefinitionFolder"/>. </summary>
        public SparkJobDefinitionFolder()
        {
        }

        /// <summary> Initializes a new instance of <see cref="SparkJobDefinitionFolder"/>. </summary>
        /// <param name="name"> The name of the folder that this Spark job definition is in. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SparkJobDefinitionFolder(string name, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the folder that this Spark job definition is in. </summary>
        public string Name { get; set; }
    }
}
