// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Storage.Common;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> The BlobTag. </summary>
    internal partial class BlobTag
    {
        /// <summary> Initializes a new instance of <see cref="BlobTag"/>. </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="key"/> or <paramref name="value"/> is null. </exception>
        public BlobTag(string key, string value)
        {
            Argument.AssertNotNull(key, nameof(key));
            Argument.AssertNotNull(value, nameof(value));

            Key = key;
            Value = value;
        }

        /// <summary> Gets or sets the key. </summary>
        public string Key { get; set; }
        /// <summary> Gets or sets the value. </summary>
        public string Value { get; set; }
    }
}
