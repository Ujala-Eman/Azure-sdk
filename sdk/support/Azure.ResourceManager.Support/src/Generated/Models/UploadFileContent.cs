// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Support.Models
{
    /// <summary> File content associated with the file under a workspace. </summary>
    public partial class UploadFileContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UploadFileContent"/>. </summary>
        public UploadFileContent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="UploadFileContent"/>. </summary>
        /// <param name="content"> File Content in base64 encoded format. </param>
        /// <param name="chunkIndex"> Index of the uploaded chunk (Index starts at 0). </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UploadFileContent(string content, float? chunkIndex, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Content = content;
            ChunkIndex = chunkIndex;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> File Content in base64 encoded format. </summary>
        public string Content { get; set; }
        /// <summary> Index of the uploaded chunk (Index starts at 0). </summary>
        public float? ChunkIndex { get; set; }
    }
}
