// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary> Represents a function that transforms a value from a data source before indexing. </summary>
    public partial class FieldMappingFunction
    {
        /// <summary> Initializes a new instance of FieldMappingFunction. </summary>
        /// <param name="name"> The name of the field mapping function. </param>
        public FieldMappingFunction(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
            Parameters = new Dictionary<string, object>();
        }

        /// <summary> Initializes a new instance of FieldMappingFunction. </summary>
        /// <param name="name"> The name of the field mapping function. </param>
        /// <param name="parameters"> A dictionary of parameter name/value pairs to pass to the function. Each value must be of a primitive type. </param>
        internal FieldMappingFunction(string name, IDictionary<string, object> parameters)
        {
            Name = name;
            Parameters = parameters ?? new Dictionary<string, object>();
        }

        /// <summary> The name of the field mapping function. </summary>
        public string Name { get; set; }
    }
}
