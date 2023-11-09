// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Storage.Files.Shares.Models
{
    /// <summary> File properties. </summary>
    internal partial class FileProperty
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="FileProperty"/>. </summary>
        /// <param name="contentLength"> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </param>
        internal FileProperty(long contentLength)
        {
            ContentLength = contentLength;
        }

        /// <summary> Initializes a new instance of <see cref="FileProperty"/>. </summary>
        /// <param name="contentLength"> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </param>
        /// <param name="creationTime"></param>
        /// <param name="lastAccessTime"></param>
        /// <param name="lastWriteTime"></param>
        /// <param name="changeTime"></param>
        /// <param name="lastModified"></param>
        /// <param name="etag"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal FileProperty(long contentLength, DateTimeOffset? creationTime, DateTimeOffset? lastAccessTime, DateTimeOffset? lastWriteTime, DateTimeOffset? changeTime, DateTimeOffset? lastModified, string etag, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ContentLength = contentLength;
            CreationTime = creationTime;
            LastAccessTime = lastAccessTime;
            LastWriteTime = lastWriteTime;
            ChangeTime = changeTime;
            LastModified = lastModified;
            Etag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="FileProperty"/> for deserialization. </summary>
        internal FileProperty()
        {
        }

        /// <summary> Content length of the file. This value may not be up-to-date since an SMB client may have modified the file locally. The value of Content-Length may not reflect that fact until the handle is closed or the op-lock is broken. To retrieve current property values, call Get File Properties. </summary>
        public long ContentLength { get; }
        /// <summary> Gets the creation time. </summary>
        public DateTimeOffset? CreationTime { get; }
        /// <summary> Gets the last access time. </summary>
        public DateTimeOffset? LastAccessTime { get; }
        /// <summary> Gets the last write time. </summary>
        public DateTimeOffset? LastWriteTime { get; }
        /// <summary> Gets the change time. </summary>
        public DateTimeOffset? ChangeTime { get; }
        /// <summary> Gets the last modified. </summary>
        public DateTimeOffset? LastModified { get; }
        /// <summary> Gets the etag. </summary>
        public string Etag { get; }
    }
}
