// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Storage.Models
{
    /// <summary> The URIs that are used to perform a retrieval of a public blob, queue, table, web or dfs object via a microsoft routing endpoint. </summary>
    public partial class StorageAccountMicrosoftEndpoints
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="StorageAccountMicrosoftEndpoints"/>. </summary>
        internal StorageAccountMicrosoftEndpoints()
        {
        }

        /// <summary> Initializes a new instance of <see cref="StorageAccountMicrosoftEndpoints"/>. </summary>
        /// <param name="blobUri"> Gets the blob endpoint. </param>
        /// <param name="queueUri"> Gets the queue endpoint. </param>
        /// <param name="tableUri"> Gets the table endpoint. </param>
        /// <param name="fileUri"> Gets the file endpoint. </param>
        /// <param name="webUri"> Gets the web endpoint. </param>
        /// <param name="dfsUri"> Gets the dfs endpoint. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal StorageAccountMicrosoftEndpoints(Uri blobUri, Uri queueUri, Uri tableUri, Uri fileUri, Uri webUri, Uri dfsUri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            BlobUri = blobUri;
            QueueUri = queueUri;
            TableUri = tableUri;
            FileUri = fileUri;
            WebUri = webUri;
            DfsUri = dfsUri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Gets the blob endpoint. </summary>
        public Uri BlobUri { get; }
        /// <summary> Gets the queue endpoint. </summary>
        public Uri QueueUri { get; }
        /// <summary> Gets the table endpoint. </summary>
        public Uri TableUri { get; }
        /// <summary> Gets the file endpoint. </summary>
        public Uri FileUri { get; }
        /// <summary> Gets the web endpoint. </summary>
        public Uri WebUri { get; }
        /// <summary> Gets the dfs endpoint. </summary>
        public Uri DfsUri { get; }
    }
}
