// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Network.Models
{
    /// <summary> Tags object for patch operations. </summary>
    public partial class TagsObject
    {
        /// <summary> Initializes a new instance of TagsObject. </summary>
        public TagsObject()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of TagsObject. </summary>
        /// <param name="tags"> Resource tags. </param>
        internal TagsObject(IDictionary<string, string> tags)
        {
            Tags = tags;
        }

        /// <summary> Resource tags. </summary>
        public IDictionary<string, string> Tags { get; }
    }
}
