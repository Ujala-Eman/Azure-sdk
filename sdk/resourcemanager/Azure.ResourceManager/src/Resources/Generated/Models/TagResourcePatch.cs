// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Resources.Models
{
    /// <summary> Wrapper resource for tags patch API request only. </summary>
    public partial class TagResourcePatch
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="TagResourcePatch"/>. </summary>
        public TagResourcePatch()
        {
        }

        /// <summary> Initializes a new instance of <see cref="TagResourcePatch"/>. </summary>
        /// <param name="patchMode"> The operation type for the patch API. </param>
        /// <param name="properties"> The set of tags. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal TagResourcePatch(TagPatchMode? patchMode, Tag properties, Dictionary<string, BinaryData> rawData)
        {
            PatchMode = patchMode;
            Properties = properties;
            _rawData = rawData;
        }

        /// <summary> The operation type for the patch API. </summary>
        public TagPatchMode? PatchMode { get; set; }
        /// <summary> The set of tags. </summary>
        internal Tag Properties { get; set; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IDictionary<string, string> TagValues
        {
            get
            {
                if (Properties is null)
                    Properties = new Tag();
                return Properties.TagValues;
            }
        }
    }
}
