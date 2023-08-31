// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Identifies the Azure key vault associated with a Batch account. </summary>
    public partial class BatchKeyVaultReference
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="BatchKeyVaultReference"/>. </summary>
        /// <param name="id"> The resource ID of the Azure key vault associated with the Batch account. </param>
        /// <param name="uri"> The URL of the Azure key vault associated with the Batch account. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="id"/> or <paramref name="uri"/> is null. </exception>
        public BatchKeyVaultReference(ResourceIdentifier id, Uri uri)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(uri, nameof(uri));

            Id = id;
            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="BatchKeyVaultReference"/>. </summary>
        /// <param name="id"> The resource ID of the Azure key vault associated with the Batch account. </param>
        /// <param name="uri"> The URL of the Azure key vault associated with the Batch account. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal BatchKeyVaultReference(ResourceIdentifier id, Uri uri, Dictionary<string, BinaryData> rawData)
        {
            Id = id;
            Uri = uri;
            _rawData = rawData;
        }

        /// <summary> Initializes a new instance of <see cref="BatchKeyVaultReference"/> for deserialization. </summary>
        internal BatchKeyVaultReference()
        {
        }

        /// <summary> The resource ID of the Azure key vault associated with the Batch account. </summary>
        public ResourceIdentifier Id { get; set; }
        /// <summary> The URL of the Azure key vault associated with the Batch account. </summary>
        public Uri Uri { get; set; }
    }
}
