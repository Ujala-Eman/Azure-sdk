// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Automation.Models
{
    /// <summary> The parameters supplied to the create or update connection type operation. </summary>
    public partial class ConnectionTypeCreateOrUpdateContent
    {
        /// <summary> Initializes a new instance of ConnectionTypeCreateOrUpdateContent. </summary>
        /// <param name="name"> Gets or sets the name of the connection type. </param>
        /// <param name="fieldDefinitions"> Gets or sets the field definitions of the connection type. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="fieldDefinitions"/> is null. </exception>
        public ConnectionTypeCreateOrUpdateContent(string name, IDictionary<string, FieldDefinition> fieldDefinitions)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (fieldDefinitions == null)
            {
                throw new ArgumentNullException(nameof(fieldDefinitions));
            }

            Name = name;
            FieldDefinitions = fieldDefinitions;
        }

        /// <summary> Gets or sets the name of the connection type. </summary>
        public string Name { get; }
        /// <summary> Gets or sets a Boolean value to indicate if the connection type is global. </summary>
        public bool? IsGlobal { get; set; }
        /// <summary> Gets or sets the field definitions of the connection type. </summary>
        public IDictionary<string, FieldDefinition> FieldDefinitions { get; }
    }
}
