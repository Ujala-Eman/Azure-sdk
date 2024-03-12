// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Storage.Common;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlobPrefix. </summary>
    internal partial class BlobPrefix
    {
        /// <summary> Initializes a new instance of <see cref="BlobPrefix"/>. </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal BlobPrefix(BlobName name)
        {
            Argument.AssertNotNull(name, nameof(name));

            Name = name;
        }

        /// <summary> Gets the name. </summary>
        public BlobName Name { get; }
    }
}
