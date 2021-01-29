// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.Storage.Blobs.Models
{
    /// <summary> An Azure Storage blob. </summary>
    internal partial class BlobItemInternal
    {
        /// <summary> Initializes a new instance of BlobItemInternal. </summary>
        /// <param name="name"> . </param>
        /// <param name="deleted"> . </param>
        /// <param name="snapshot"> . </param>
        /// <param name="properties"> Properties of a blob. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="snapshot"/>, or <paramref name="properties"/> is null. </exception>
        internal BlobItemInternal(string name, bool deleted, string snapshot, BlobPropertiesInternal properties)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (snapshot == null)
            {
                throw new ArgumentNullException(nameof(snapshot));
            }
            if (properties == null)
            {
                throw new ArgumentNullException(nameof(properties));
            }

            Name = name;
            Deleted = deleted;
            Snapshot = snapshot;
            Properties = properties;
            ObjectReplicationMetadata = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of BlobItemInternal. </summary>
        /// <param name="name"> . </param>
        /// <param name="deleted"> . </param>
        /// <param name="snapshot"> . </param>
        /// <param name="versionId"> . </param>
        /// <param name="isCurrentVersion"> . </param>
        /// <param name="properties"> Properties of a blob. </param>
        /// <param name="metadata"> . </param>
        /// <param name="blobTags"> Blob tags. </param>
        /// <param name="objectReplicationMetadata"> Dictionary of &lt;string&gt;. </param>
        internal BlobItemInternal(string name, bool deleted, string snapshot, string versionId, bool? isCurrentVersion, BlobPropertiesInternal properties, BlobMetadata metadata, BlobTags blobTags, IReadOnlyDictionary<string, string> objectReplicationMetadata)
        {
            Name = name;
            Deleted = deleted;
            Snapshot = snapshot;
            VersionId = versionId;
            IsCurrentVersion = isCurrentVersion;
            Properties = properties;
            Metadata = metadata;
            BlobTags = blobTags;
            ObjectReplicationMetadata = objectReplicationMetadata;
        }

        public string Name { get; }
        public bool Deleted { get; }
        public string Snapshot { get; }
        public string VersionId { get; }
        public bool? IsCurrentVersion { get; }
        /// <summary> Properties of a blob. </summary>
        public BlobPropertiesInternal Properties { get; }
        public BlobMetadata Metadata { get; }
        /// <summary> Blob tags. </summary>
        public BlobTags BlobTags { get; }
        /// <summary> Dictionary of &lt;string&gt;. </summary>
        public IReadOnlyDictionary<string, string> ObjectReplicationMetadata { get; }
    }
}
