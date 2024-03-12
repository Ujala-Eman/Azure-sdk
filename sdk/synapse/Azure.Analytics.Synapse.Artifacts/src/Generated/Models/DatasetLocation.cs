// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Analytics.Synapse.Artifacts;

namespace Azure.Analytics.Synapse.Artifacts.Models
{
    /// <summary>
    /// Dataset location.
    /// Please note <see cref="DatasetLocation"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AmazonS3Location"/>, <see cref="AzureBlobFSLocation"/>, <see cref="AzureBlobStorageLocation"/>, <see cref="AzureDataLakeStoreLocation"/>, <see cref="AzureFileStorageLocation"/>, <see cref="FileServerLocation"/>, <see cref="FtpServerLocation"/>, <see cref="GoogleCloudStorageLocation"/>, <see cref="HdfsLocation"/>, <see cref="HttpServerLocation"/> and <see cref="SftpLocation"/>.
    /// </summary>
    public abstract partial class DatasetLocation
    {
        /// <summary> Initializes a new instance of <see cref="DatasetLocation"/>. </summary>
        protected DatasetLocation()
        {
            AdditionalProperties = new ChangeTrackingDictionary<string, object>();
        }

        /// <summary> Initializes a new instance of <see cref="DatasetLocation"/>. </summary>
        /// <param name="type"> Type of dataset storage location. </param>
        /// <param name="folderPath"> Specify the folder path of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="fileName"> Specify the file name of dataset. Type: string (or Expression with resultType string). </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal DatasetLocation(string type, object folderPath, object fileName, IDictionary<string, object> additionalProperties)
        {
            Type = type;
            FolderPath = folderPath;
            FileName = fileName;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> Type of dataset storage location. </summary>
        internal string Type { get; set; }
        /// <summary> Specify the folder path of dataset. Type: string (or Expression with resultType string). </summary>
        public object FolderPath { get; set; }
        /// <summary> Specify the file name of dataset. Type: string (or Expression with resultType string). </summary>
        public object FileName { get; set; }
        /// <summary> Additional Properties. </summary>
        public IDictionary<string, object> AdditionalProperties { get; }
    }
}
