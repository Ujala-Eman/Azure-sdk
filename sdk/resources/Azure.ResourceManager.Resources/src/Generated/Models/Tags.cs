// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> A dictionary of name and value pairs. </summary>
    public partial class Tags
    {
        /// <summary> Initializes a new instance of Tags. </summary>
        public Tags()
        {
            TagsValue = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of Tags. </summary>
        /// <param name="tagsValue"> Dictionary of &lt;string&gt;. </param>
        internal Tags(IDictionary<string, string> tagsValue)
        {
            TagsValue = tagsValue;
        }

        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> TagsValue { get; }
    }
}
