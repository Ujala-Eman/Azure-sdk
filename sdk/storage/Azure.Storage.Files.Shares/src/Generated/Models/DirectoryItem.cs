// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> A listed directory item. </summary>
    public partial class DirectoryItem
    {
        /// <summary> Initializes a new instance of DirectoryItem. </summary>
        /// <param name="name"> . </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> is null. </exception>
        internal DirectoryItem(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }

            Name = name;
        }

        public string Name { get; }
    }
}
