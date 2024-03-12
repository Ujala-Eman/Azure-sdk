// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Search.Documents;

namespace Azure.Search.Documents.Indexes.Models
{
    /// <summary>
    /// Base type for character filters.
    /// Please note <see cref="CharFilter"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="MappingCharFilter"/> and <see cref="PatternReplaceCharFilter"/>.
    /// </summary>
    public partial class CharFilter
    {
        /// <summary> Initializes a new instance of <see cref="CharFilter"/>. </summary>
        /// <param name="oDataType"> A URI fragment specifying the type of char filter. </param>
        /// <param name="name"> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </param>
        internal CharFilter(string oDataType, string name)
        {
            ODataType = oDataType;
            Name = name;
        }

        /// <summary> A URI fragment specifying the type of char filter. </summary>
        internal string ODataType { get; set; }
        /// <summary> The name of the char filter. It must only contain letters, digits, spaces, dashes or underscores, can only start and end with alphanumeric characters, and is limited to 128 characters. </summary>
        public string Name { get; set; }
    }
}
