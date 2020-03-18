// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.Management.Storage.Models
{
    /// <summary> The FileServiceItems. </summary>
    public partial class FileServiceItems
    {
        /// <summary> Initializes a new instance of FileServiceItems. </summary>
        internal FileServiceItems()
        {
        }

        /// <summary> Initializes a new instance of FileServiceItems. </summary>
        /// <param name="value"> List of file services returned. </param>
        internal FileServiceItems(IList<FileServiceProperties> value)
        {
            Value = value;
        }

        /// <summary> List of file services returned. </summary>
        public IList<FileServiceProperties> Value { get; internal set; }
    }
}
