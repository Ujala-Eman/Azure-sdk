// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Code asset version details. </summary>
    public partial class CodeVersionProperties : AssetBase
    {
        /// <summary> Initializes a new instance of <see cref="CodeVersionProperties"/>. </summary>
        public CodeVersionProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CodeVersionProperties"/>. </summary>
        /// <param name="description"> The asset description text. </param>
        /// <param name="properties"> The asset property dictionary. </param>
        /// <param name="tags"> Tag dictionary. Tags can be added, removed, and updated. </param>
        /// <param name="isAnonymous"> If the name version are system generated (anonymous registration). </param>
        /// <param name="isArchived"> Is the asset archived?. </param>
        /// <param name="codeUri"> Uri where code is located. </param>
        internal CodeVersionProperties(string description, IDictionary<string, string> properties, IDictionary<string, string> tags, bool? isAnonymous, bool? isArchived, Uri codeUri) : base(description, properties, tags, isAnonymous, isArchived)
        {
            CodeUri = codeUri;
        }

        /// <summary> Uri where code is located. </summary>
        public Uri CodeUri { get; set; }
    }
}
